using System.Text.Json;
using LearnWeb.Api.Data;
using LearnWeb.Api.Engine;
using Microsoft.EntityFrameworkCore;

namespace LearnWeb.Api.Study;

public sealed record ExamComposeRequest(string SubjectSlug, int Count = ExamComposer.DefaultCount);

/// <summary>
/// Zadání zkoušky — bez správných odpovědí. `TimeLimitMinutes` je limit (u certifikací podle skutečné zkoušky),
/// `CertificationFormat` = počet otázek, čas i hranice úspěchu jsou převzaté z certifikace.
/// </summary>
public sealed record ExamPaper(string SubjectSlug, string SubjectName, int TimeLimitMinutes, int PassPercent,
    bool CertificationFormat, IReadOnlyList<QuizQuestion> Questions);

/// <summary>`SelectedIndex` = původní index možnosti; null = bez odpovědi (počítá se jako chyba).</summary>
public sealed record ExamSubmitAnswer(int QuestionId, int? SelectedIndex);

public sealed record ExamSubmitRequest(string SubjectSlug, DateTime StartedAt, IReadOnlyList<ExamSubmitAnswer> Answers);

/// <summary>Vyhodnocená otázka — `Options` v původním pořadí (index = pozice).</summary>
public sealed record ExamItemResult(int QuestionId, int CardId, string CardFront, int TopicId, string TopicName, string Text,
    IReadOnlyList<string> Options, int? SelectedIndex, int CorrectIndex, bool IsCorrect, string Explanation);

public sealed record ExamTopicResult(int TopicId, string TopicName, int Correct, int Total);

public sealed record BadgeDto(string Code, string Name, string Description);

public sealed record ExamOutcome(long ExamId, int Correct, int Total, int Percent, int PassPercent, bool Passed, int XpGained,
    int TotalXp,
    IReadOnlyList<ExamTopicResult> Topics, IReadOnlyList<ExamItemResult> Items, StreakInfo Streak,
    IReadOnlyList<BadgeDto> NewBadges);

public sealed record SessionCompleteRequest(StudyMode Mode, string? SubjectSlug = null, int? TopicId = null,
    int Answered = 0, int Correct = 0, int Learned = 0);

public sealed record SessionOutcome(StreakInfo Streak, IReadOnlyList<BadgeDto> NewBadges);

/// <summary>Simulace zkoušky, dokončené seance, série dní a odznaky (fáze 4). Pravidla jsou v Engine/.</summary>
public sealed partial class StudyService
{
    private static readonly JsonSerializerOptions BreakdownJson = new(JsonSerializerDefaults.Web);

    public async Task<ExamPaper?> ComposeExamAsync(ExamComposeRequest req, CancellationToken ct)
    {
        var subject = await db.Subjects.AsNoTracking().SingleOrDefaultAsync(s => s.Slug == req.SubjectSlug, ct);
        if (subject is null) return null;

        var candidates = await db.Cards.AsNoTracking()
            .Where(c => c.Topic.SubjectId == subject.Id && !c.IsArchived && c.Questions.Any(q => !q.IsArchived))
            .Select(c => new ExamCandidate(c.Id, c.TopicId))
            .ToListAsync(ct);

        var certification = subject.ExamQuestions is not null;
        var count = subject.ExamQuestions ?? Math.Clamp(req.Count, ExamComposer.MinCount, ExamComposer.MaxCount);
        var selected = ExamComposer.SelectCards(candidates, count, Random.Shared);
        var questions = await QuestionsForCardsAsync(selected, null, ct);
        var minutes = subject.ExamMinutes ?? questions.Count * ExamComposer.MinutesPerQuestion;
        return new ExamPaper(subject.Slug, subject.Name, minutes, PassPercent(subject), certification, questions);
    }

    /// <summary>
    /// Vyhodnocení zkoušky naráz (bez průběžné zpětné vazby). Každá odpověď jde do AttemptLog (bez odpovědi = −1)
    /// a do Leitnera jako chyba/správně v režimu Zkouška — chybované karty se tím zařadí do opakování.
    /// </summary>
    public async Task<ExamOutcome?> SubmitExamAsync(ExamSubmitRequest req, CancellationToken ct)
    {
        var subject = await db.Subjects.AsNoTracking().SingleOrDefaultAsync(s => s.Slug == req.SubjectSlug, ct);
        if (subject is null) return null;

        var answers = req.Answers.GroupBy(a => a.QuestionId).Select(g => g.Last())
            .Take(subject.ExamQuestions ?? ExamComposer.MaxCount).ToList();
        var ids = answers.Select(a => a.QuestionId).ToList();
        var questions = await db.Questions.AsNoTracking()
            .Where(q => ids.Contains(q.Id) && q.Card.Topic.SubjectId == subject.Id)
            .Select(q => new
            {
                q.Id, q.CardId, q.Text, q.Options, q.CorrectIndex, q.Explanation,
                CardFront = q.Card.Front, q.Card.TopicId, TopicName = q.Card.Topic.Name,
            })
            .ToDictionaryAsync(q => q.Id, ct);
        if (questions.Count == 0) return null;

        var cardIds = questions.Values.Select(q => q.CardId).Distinct().ToList();
        var progress = await db.CardProgress.Where(p => p.UserId == UserId && cardIds.Contains(p.CardId))
            .ToDictionaryAsync(p => p.CardId, ct);

        var items = new List<ExamItemResult>();
        var xp = 0;
        foreach (var a in answers.Where(a => questions.ContainsKey(a.QuestionId)))
        {
            var q = questions[a.QuestionId];
            var selected = a.SelectedIndex is { } i && i >= 0 && i < q.Options.Count ? i : (int?)null;
            var isCorrect = selected == q.CorrectIndex;

            if (!progress.TryGetValue(q.CardId, out var p))
            {
                p = new CardProgress { CardId = q.CardId, UserId = UserId, Box = LeitnerStrategy.MinBox, DueDate = Today };
                db.CardProgress.Add(p);
                progress[q.CardId] = p;
            }
            strategy.OnAnswered(p, StudyMode.Exam, isCorrect, Today, Now);

            db.AttemptLogs.Add(new AttemptLog
            {
                QuestionId = q.Id, UserId = UserId, Mode = StudyMode.Exam,
                SelectedIndex = selected ?? -1, IsCorrect = isCorrect, AnsweredAt = Now,
            });
            xp += Gamification.XpForAnswer(StudyMode.Exam, isCorrect);
            items.Add(new ExamItemResult(q.Id, q.CardId, q.CardFront, q.TopicId, q.TopicName, q.Text, q.Options, selected,
                q.CorrectIndex, isCorrect, q.Explanation));
        }

        var score = ExamScoring.Evaluate(items.Select(i => new ExamAnswer(i.TopicId, i.IsCorrect)));
        var topicNames = items.GroupBy(i => i.TopicId).ToDictionary(g => g.Key, g => g.First().TopicName);
        var topics = score.Topics.Select(t => new ExamTopicResult(t.TopicId, topicNames[t.TopicId], t.Correct, t.Total)).ToList();
        var pass = PassPercent(subject);
        xp += Gamification.XpForExam(score.Percent, pass);

        var started = req.StartedAt.ToUniversalTime();
        var exam = new ExamResult
        {
            SubjectId = subject.Id, UserId = UserId, Score = score.Correct, Total = score.Total,
            Breakdown = JsonSerializer.Serialize(topics, BreakdownJson),
            StartedAt = started > Now || started < Now.AddHours(-6) ? Now : started,
            FinishedAt = Now,
        };
        db.ExamResults.Add(exam);
        db.StudySessions.Add(new StudySession
        {
            UserId = UserId, Mode = StudyMode.Exam, SubjectId = subject.Id,
            Answered = items.Count(i => i.SelectedIndex is not null), Correct = score.Correct, FinishedAt = Now,
        });

        var stats = await GetOrCreateStatsAsync(ct);
        stats.Xp += xp;
        await db.SaveChangesAsync(ct);

        var (streak, badges) = await RefreshStreakAndBadgesAsync(stats, ct);
        return new ExamOutcome(exam.Id, score.Correct, score.Total, score.Percent, pass, score.Percent >= pass, xp, stats.Xp,
            topics, items, streak, badges);
    }

    /// <summary>Hranice úspěchu zkoušky: u certifikačního kurzu podle certifikace, jinak výchozí (BA: 85 %).</summary>
    public static int PassPercent(Subject subject) => subject.ExamPassPercent ?? Gamification.ExamPassPercent;

    /// <summary>Dokončená seance Učení / Procvičování / Opakování — počítá se do série dní a kalendáře.</summary>
    public async Task<SessionOutcome> CompleteSessionAsync(SessionCompleteRequest req, CancellationToken ct)
    {
        int? subjectId = req.SubjectSlug is null
            ? null
            : await db.Subjects.Where(s => s.Slug == req.SubjectSlug).Select(s => (int?)s.Id).SingleOrDefaultAsync(ct);
        if (subjectId is null && req.TopicId is { } topicId)
            subjectId = await db.Topics.Where(t => t.Id == topicId).Select(t => (int?)t.SubjectId).SingleOrDefaultAsync(ct);

        db.StudySessions.Add(new StudySession
        {
            UserId = UserId, Mode = req.Mode, SubjectId = subjectId, TopicId = req.TopicId,
            Answered = Math.Max(0, req.Answered), Correct = Math.Max(0, req.Correct), Learned = Math.Max(0, req.Learned),
            FinishedAt = Now,
        });
        var stats = await GetOrCreateStatsAsync(ct);
        await db.SaveChangesAsync(ct);

        var (streak, badges) = await RefreshStreakAndBadgesAsync(stats, ct);
        return new SessionOutcome(streak, badges);
    }

    /// <summary>Přepočítá sérii dní (materializuje ji do UserStats) a udělí nově splněné odznaky.</summary>
    private async Task<(StreakInfo Streak, IReadOnlyList<BadgeDto> NewBadges)> RefreshStreakAndBadgesAsync(UserStats stats,
        CancellationToken ct)
    {
        var tz = clock.LocalTimeZone;
        var streak = Engine.Streak.Compute(await ProgressQueries.ActiveDaysAsync(db, UserId, tz, ct), Today);
        stats.StreakDays = streak.Current;
        stats.LastActiveDate = streak.ActiveToday ? Today : stats.LastActiveDate;

        var topics = await ProgressQueries.TopicStatsAsync(db, UserId, null, ct);
        var mastery = ProgressQueries.SubjectMastery(topics);
        var bestExam = await db.ExamResults.Where(e => e.UserId == UserId && e.Total > 0)
            .Select(e => (int?)(100 * e.Score / e.Total)).MaxAsync(ct) ?? 0;

        var dayStart = ProgressQueries.DayStartUtc(Today, tz);
        var answeredCards = await db.AttemptLogs.Where(a => a.UserId == UserId && a.AnsweredAt >= dayStart)
            .Select(a => a.Question.CardId).Distinct().ToListAsync(ct);
        var learnedCards = await db.CardProgress.Where(p => p.UserId == UserId && p.SeenAt >= dayStart)
            .Select(p => p.CardId).ToListAsync(ct);

        var context = new BadgeContext(
            CompletedTopics: topics.Count(t => t.IsCompleted),
            CurrentStreak: streak.Current,
            BestSubjectMastery: mastery.Count == 0 ? 0 : mastery.Values.Max(),
            BestExamPercent: bestExam,
            CardsToday: answeredCards.Union(learnedCards).Count());

        var fresh = Engine.Badges.NewlyEarned(context, stats.Badges);
        if (fresh.Count > 0) stats.Badges = [.. stats.Badges, .. fresh];
        await db.SaveChangesAsync(ct);

        return (streak, fresh.Select(code => Engine.Badges.Find(code)!).Select(b => new BadgeDto(b.Code, b.Name, b.Description)).ToList());
    }
}
