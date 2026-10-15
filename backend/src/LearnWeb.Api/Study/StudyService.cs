using LearnWeb.Api.Data;
using LearnWeb.Api.Engine;
using Microsoft.EntityFrameworkCore;

namespace LearnWeb.Api.Study;

/// <summary>`ExcludeQuestionIds` — u horké fronty se ke kartě přednostně vybere jiná otázka než ta, na kterou student chyboval.</summary>
public sealed record QuizRequest(int? TopicId = null, string? SubjectSlug = null, IReadOnlyList<int>? CardIds = null,
    StudyMode Mode = StudyMode.Quiz, int Count = 10, IReadOnlyList<int>? ExcludeQuestionIds = null);

public sealed record ReviewRequest(string? SubjectSlug = null, bool IgnoreDailyLimit = false);

/// <summary>`Due` = splatné karty, `Available` = kolik z nich zbývá dnes v rámci denního limitu.</summary>
public sealed record SubjectReview(int SubjectId, string Slug, string Name, int Due, int ReviewedToday, int Available);

public sealed record ReviewSummary(int Total, int DailyLimitPerSubject, IReadOnlyList<SubjectReview> Subjects);

public sealed record ContinueInfo(string Kind, int TopicId, string TopicName, string SubjectSlug, string SubjectName,
    int SeenCount, int CardCount);

public sealed record QuizOption(int Index, string Text);

/// <summary>Otázka bez prozrazení správné odpovědi; možnosti jsou zamíchané, `Index` je původní pořadí.</summary>
public sealed record QuizQuestion(int QuestionId, int CardId, string CardFront, string TopicName, string Text,
    IReadOnlyList<QuizOption> Options);

/// <summary>`Repeat` = kolikrát se karta v téže seanci už vrátila z horké fronty (0 = první pokus).</summary>
public sealed record AnswerRequest(int QuestionId, int SelectedIndex, StudyMode Mode, int Repeat = 0);

public sealed record AnsweredCard(int Id, string Type, string Front, string Back);

/// <summary>`Requeue` = vrátit kartu na konec seance (horká fronta).</summary>
public sealed record AnswerResult(bool IsCorrect, int CorrectIndex, string Explanation, int XpGained, int TotalXp,
    bool Reteach, int Box, AnsweredCard Card, bool Requeue);

public sealed record LearnedResult(int XpGained, int TotalXp, bool TopicCompleted);

public sealed record StatsSummary(int Xp, int Level, int LevelStartXp, int NextLevelXp, StreakInfo Streak);

/// <summary>
/// Jediné místo, které mění stav studenta (CardProgress, AttemptLog, UserStats).
/// Pravidla jsou v Engine/ — tady je jen načtení dat, volání pravidel a uložení.
/// </summary>
public sealed partial class StudyService(LearnWebDbContext db, IRepetitionStrategy strategy, TimeProvider clock)
{
    // MVP: jeden uživatel. Až přibude autentizace, přijde z identity requestu.
    public const int UserId = 1;

    public const int RepeatedMistakesForReteach = 3;
    public const int MaxQuizCount = 50;

    private DateTime Now => clock.GetUtcNow().UtcDateTime;
    private DateOnly Today => DateOnly.FromDateTime(clock.GetLocalNow().DateTime);

    public async Task<IReadOnlyList<QuizQuestion>> BuildQuizAsync(QuizRequest req, CancellationToken ct)
    {
        var query = db.Cards.AsNoTracking().Where(c => !c.IsArchived && c.Questions.Any(q => !q.IsArchived));
        if (req.CardIds is { Count: > 0 }) query = query.Where(c => req.CardIds.Contains(c.Id));
        if (req.TopicId is { } topicId) query = query.Where(c => c.TopicId == topicId);
        if (req.SubjectSlug is { } slug) query = query.Where(c => c.Topic.Subject.Slug == slug);

        var candidates = await query
            .Select(c => new
            {
                c.Id,
                Progress = db.CardProgress.Where(p => p.CardId == c.Id && p.UserId == UserId).FirstOrDefault(),
            })
            .ToListAsync(ct);

        var cards = candidates.Select(c => c.Progress is { } p
                ? new CandidateCard(c.Id, ReviewQueue.InPool(p), p.Box, p.DueDate, p.WrongCount, p.LastResult)
                : new CandidateCard(c.Id, false, LeitnerStrategy.MinBox, null, 0, null))
            .ToList();

        var selected = QuestionSelector.SelectCards(cards, Math.Clamp(req.Count, 1, MaxQuizCount), Today, Random.Shared);
        return await QuestionsForCardsAsync(selected, req.ExcludeQuestionIds, ct);
    }

    /// <summary>Jedna seance denního opakování (BA §2.2 D) — výběr karet řídí `ReviewQueue`.</summary>
    public async Task<IReadOnlyList<QuizQuestion>> BuildReviewAsync(ReviewRequest req, CancellationToken ct)
    {
        var candidates = await ReviewCandidatesAsync(req.SubjectSlug, ct);
        var reviewed = await ReviewedTodayBySubjectAsync(ct);
        var selected = ReviewQueue.BuildSession(candidates, Today, reviewed, req.IgnoreDailyLimit);
        return await QuestionsForCardsAsync(selected, null, ct);
    }

    public async Task<ReviewSummary> ReviewSummaryAsync(CancellationToken ct)
    {
        var candidates = await ReviewCandidatesAsync(null, ct);
        var reviewed = await ReviewedTodayBySubjectAsync(ct);
        var dueBySubject = candidates.Where(c => ReviewQueue.IsDue(c, Today))
            .GroupBy(c => c.SubjectId).ToDictionary(g => g.Key, g => g.Count());

        var subjects = await db.Subjects.AsNoTracking().OrderBy(s => s.Order)
            .Select(s => new { s.Id, s.Slug, s.Name }).ToListAsync(ct);
        var rows = subjects.Select(s =>
        {
            var due = dueBySubject.GetValueOrDefault(s.Id);
            var done = reviewed.GetValueOrDefault(s.Id);
            return new SubjectReview(s.Id, s.Slug, s.Name, due, done, ReviewQueue.Available(due, done));
        }).ToList();

        return new ReviewSummary(rows.Sum(r => r.Available), ReviewQueue.DailyLimitPerSubject, rows);
    }

    /// <summary>
    /// „Pokračovat tam, kde jsi skončil": téma poslední učební aktivity (probrání karty, kvíz, mini-kvíz).
    /// Opakování a zkouška se nepočítají — skáčou napříč tématy. Bez aktivity vrací null.
    /// </summary>
    public async Task<ContinueInfo?> ContinueAsync(CancellationToken ct)
    {
        var lastSeen = await db.CardProgress.AsNoTracking()
            .Where(p => p.UserId == UserId && p.SeenAt != null && !p.Card.IsArchived)
            .OrderByDescending(p => p.SeenAt)
            .Select(p => new { At = p.SeenAt!.Value, p.Card.TopicId })
            .FirstOrDefaultAsync(ct);
        var lastAnswer = await db.AttemptLogs.AsNoTracking()
            .Where(a => a.UserId == UserId && (a.Mode == StudyMode.Learn || a.Mode == StudyMode.Quiz))
            .OrderByDescending(a => a.AnsweredAt)
            .Select(a => new { At = a.AnsweredAt, a.Question.Card.TopicId })
            .FirstOrDefaultAsync(ct);

        var last = (lastSeen, lastAnswer) switch
        {
            (null, null) => null,
            ({ } s, null) => s,
            (null, { } a) => a,
            ({ } s, { } a) => a.At > s.At ? a : s,
        };
        if (last is null) return null;

        var subjectId = await db.Topics.Where(t => t.Id == last.TopicId).Select(t => t.SubjectId).SingleAsync(ct);
        var topics = await db.Topics.AsNoTracking()
            .Where(t => t.SubjectId == subjectId)
            .Select(t => new
            {
                t.Id, t.Order, t.Name,
                SubjectSlug = t.Subject.Slug,
                SubjectName = t.Subject.Name,
                CardCount = t.Cards.Count(c => !c.IsArchived),
                SeenCount = t.Cards.Count(c => !c.IsArchived
                    && db.CardProgress.Any(p => p.CardId == c.Id && p.UserId == UserId && p.SeenAt != null)),
            })
            .ToListAsync(ct);

        var target = ContinueRule.Next(last.TopicId,
            topics.Select(t => new TopicProgress(t.Id, t.Order, t.CardCount, t.SeenCount)).ToList());
        var topic = topics.Single(t => t.Id == target.TopicId);
        return new ContinueInfo(target.Kind == ContinueKind.Learn ? "learn" : "practice", topic.Id, topic.Name,
            topic.SubjectSlug, topic.SubjectName, topic.SeenCount, topic.CardCount);
    }

    /// <summary>Ke každé kartě náhodná otázka (přednostně mimo `exclude`) se zamíchanými možnostmi; pořadí karet zůstává.</summary>
    private async Task<IReadOnlyList<QuizQuestion>> QuestionsForCardsAsync(IReadOnlyList<int> cardIds,
        IReadOnlyList<int>? exclude, CancellationToken ct)
    {
        var rng = Random.Shared;
        var details = await db.Cards.AsNoTracking()
            .Where(c => cardIds.Contains(c.Id))
            .Select(c => new
            {
                c.Id,
                c.Front,
                TopicName = c.Topic.Name,
                Questions = c.Questions.Where(q => !q.IsArchived)
                    .Select(q => new { q.Id, q.Text, q.Options }).ToList(),
            })
            .ToDictionaryAsync(c => c.Id, ct);

        return cardIds.Where(details.ContainsKey).Select(id =>
        {
            var c = details[id];
            var pool = c.Questions.Where(q => exclude?.Contains(q.Id) != true).ToList();
            if (pool.Count == 0) pool = c.Questions;
            var q = pool[rng.Next(pool.Count)];
            var options = q.Options.Select((text, i) => new QuizOption(i, text)).ToArray();
            rng.Shuffle(options);
            return new QuizQuestion(q.Id, c.Id, c.Front, c.TopicName, q.Text, options);
        }).ToList();
    }

    private async Task<List<ReviewCandidate>> ReviewCandidatesAsync(string? subjectSlug, CancellationToken ct)
    {
        var query = db.CardProgress.AsNoTracking()
            .Where(ReviewQueue.InPoolExpression)
            .Where(p => p.UserId == UserId && !p.Card.IsArchived && p.Card.Questions.Any(q => !q.IsArchived));
        if (subjectSlug is not null) query = query.Where(p => p.Card.Topic.Subject.Slug == subjectSlug);

        return await query
            .Select(p => new ReviewCandidate(p.CardId, p.Card.Topic.SubjectId, p.Box, p.DueDate, p.LastResult,
                p.Card.Topic.Order, p.Card.Order))
            .ToListAsync(ct);
    }

    /// <summary>Počet různých karet zopakovaných dnes (místní čas) v režimu Opakování, po předmětech.</summary>
    private async Task<Dictionary<int, int>> ReviewedTodayBySubjectAsync(CancellationToken ct)
    {
        var dayStartUtc = TimeZoneInfo.ConvertTimeToUtc(Today.ToDateTime(TimeOnly.MinValue), clock.LocalTimeZone);
        var rows = await db.AttemptLogs.AsNoTracking()
            .Where(a => a.UserId == UserId && a.Mode == StudyMode.Review && a.AnsweredAt >= dayStartUtc)
            .Select(a => new { a.Question.Card.Topic.SubjectId, a.Question.CardId })
            .Distinct()
            .ToListAsync(ct);
        return rows.GroupBy(r => r.SubjectId).ToDictionary(g => g.Key, g => g.Count());
    }

    public async Task<AnswerResult?> AnswerAsync(AnswerRequest req, CancellationToken ct)
    {
        var question = await db.Questions.Include(q => q.Card)
            .SingleOrDefaultAsync(q => q.Id == req.QuestionId, ct);
        if (question is null || req.SelectedIndex < 0 || req.SelectedIndex >= question.Options.Count) return null;

        var isCorrect = req.SelectedIndex == question.CorrectIndex;
        var repeat = Math.Max(0, req.Repeat);
        var effectiveMode = HotQueue.EffectiveMode(req.Mode, repeat);
        var progress = await GetOrCreateProgressAsync(question.CardId, ct);
        strategy.OnAnswered(progress, effectiveMode, isCorrect, Today, Now);

        db.AttemptLogs.Add(new AttemptLog
        {
            QuestionId = question.Id,
            UserId = UserId,
            Mode = req.Mode,
            SelectedIndex = req.SelectedIndex,
            IsCorrect = isCorrect,
            AnsweredAt = Now,
        });

        var stats = await GetOrCreateStatsAsync(ct);
        var xp = Gamification.XpForAnswer(effectiveMode, isCorrect);
        stats.Xp += xp;

        await db.SaveChangesAsync(ct);

        var c = question.Card;
        return new AnswerResult(isCorrect, question.CorrectIndex, question.Explanation, xp, stats.Xp,
            Reteach: !isCorrect && progress.WrongCount >= RepeatedMistakesForReteach, progress.Box,
            new AnsweredCard(c.Id, c.Type.ToString().ToLowerInvariant(), c.Front, c.Back),
            Requeue: HotQueue.ShouldRequeue(req.Mode, isCorrect, repeat));
    }

    /// <summary>Karta probrána v režimu Učení. Opakované označení je bez efektu (XP jen poprvé).</summary>
    public async Task<LearnedResult?> MarkLearnedAsync(int cardId, CancellationToken ct)
    {
        var card = await db.Cards.SingleOrDefaultAsync(c => c.Id == cardId && !c.IsArchived, ct);
        if (card is null) return null;

        var progress = await GetOrCreateProgressAsync(cardId, ct);
        var stats = await GetOrCreateStatsAsync(ct);
        if (progress.SeenAt is not null) return new LearnedResult(0, stats.Xp, false);

        strategy.OnLearned(progress, Today, Now);
        var xp = Gamification.XpCardLearned;
        await db.SaveChangesAsync(ct);

        // Téma je dokončené ve chvíli, kdy je probrána poslední jeho karta.
        var unseenInTopic = await db.Cards.CountAsync(c => c.TopicId == card.TopicId && !c.IsArchived
            && !db.CardProgress.Any(p => p.CardId == c.Id && p.UserId == UserId && p.SeenAt != null), ct);
        var topicCompleted = unseenInTopic == 0;
        if (topicCompleted) xp += Gamification.XpTopicCompleted;

        stats.Xp += xp;
        await db.SaveChangesAsync(ct);
        return new LearnedResult(xp, stats.Xp, topicCompleted);
    }

    public async Task<StatsSummary> SummaryAsync(CancellationToken ct)
    {
        var xp = await db.UserStats.Where(s => s.UserId == UserId).Select(s => s.Xp).FirstOrDefaultAsync(ct);
        var level = Gamification.Level(xp);
        var streak = Streak.Compute(await ProgressQueries.ActiveDaysAsync(db, UserId, clock.LocalTimeZone, ct), Today);
        return new StatsSummary(xp, level, Gamification.XpForLevel(level), Gamification.XpForLevel(level + 1), streak);
    }

    private async Task<CardProgress> GetOrCreateProgressAsync(int cardId, CancellationToken ct)
    {
        var p = await db.CardProgress.SingleOrDefaultAsync(x => x.CardId == cardId && x.UserId == UserId, ct);
        if (p is not null) return p;

        p = new CardProgress { CardId = cardId, UserId = UserId, Box = LeitnerStrategy.MinBox, DueDate = Today };
        db.CardProgress.Add(p);
        return p;
    }

    private async Task<UserStats> GetOrCreateStatsAsync(CancellationToken ct)
    {
        var s = await db.UserStats.SingleOrDefaultAsync(x => x.UserId == UserId, ct);
        if (s is not null) return s;

        s = new UserStats { UserId = UserId };
        db.UserStats.Add(s);
        return s;
    }
}
