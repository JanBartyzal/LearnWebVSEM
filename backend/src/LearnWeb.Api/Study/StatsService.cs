using LearnWeb.Api.Data;
using LearnWeb.Api.Engine;
using Microsoft.EntityFrameworkCore;

namespace LearnWeb.Api.Study;

public sealed record ActivityDay(DateOnly Date, int Sessions, int Answers, int Learned);

public sealed record BadgeStatus(string Code, string Name, string Description, bool Earned);

public sealed record StatsOverview(int Xp, int Level, int LevelStartXp, int NextLevelXp, StreakInfo Streak,
    IReadOnlyList<ActivityDay> Calendar, IReadOnlyList<BadgeStatus> Badges, int CardsSeen, int CardsTotal,
    int Answers, int CorrectAnswers, int Exams);

public sealed record TopicStat(int TopicId, string Name, int Order, int CardCount, int SeenCount, double Mastery);

public sealed record DailySuccess(DateOnly Date, int Answered, int Correct);

public sealed record MissedCard(int CardId, string Front, int TopicId, string TopicName, int Wrong, int Attempts, int Box);

public sealed record ExamSummary(long Id, DateTime FinishedAt, int Score, int Total, int Percent);

public sealed record SubjectStats(int SubjectId, string Slug, string Name, double Mastery, IReadOnlyList<TopicStat> Topics,
    IReadOnlyList<DailySuccess> Daily, IReadOnlyList<MissedCard> MostMissed, IReadOnlyList<ExamSummary> Exams, int ExamPassPercent);

/// <summary>Statistiky a pokrok (BA §2.2 F) — jen čtení, zdrojem pravdy je AttemptLog a StudySession.</summary>
public sealed class StatsService(LearnWebDbContext db, TimeProvider clock)
{
    private const int UserId = StudyService.UserId;
    public const int CalendarDays = 84;
    public const int DailyDays = 30;
    public const int MostMissedCount = 10;

    private DateOnly Today => DateOnly.FromDateTime(clock.GetLocalNow().DateTime);
    private TimeZoneInfo Tz => clock.LocalTimeZone;

    public async Task<StatsOverview> OverviewAsync(CancellationToken ct)
    {
        var stats = await db.UserStats.AsNoTracking().SingleOrDefaultAsync(s => s.UserId == UserId, ct);
        var xp = stats?.Xp ?? 0;
        var level = Gamification.Level(xp);
        var owned = stats?.Badges.ToHashSet() ?? [];

        var streak = Streak.Compute(await ProgressQueries.ActiveDaysAsync(db, UserId, Tz, ct), Today);

        var from = Today.AddDays(-(CalendarDays - 1));
        var fromUtc = ProgressQueries.DayStartUtc(from, Tz);
        var sessions = await db.StudySessions.AsNoTracking()
            .Where(s => s.UserId == UserId && s.FinishedAt >= fromUtc).Select(s => s.FinishedAt).ToListAsync(ct);
        var answers = await db.AttemptLogs.AsNoTracking()
            .Where(a => a.UserId == UserId && a.AnsweredAt >= fromUtc).Select(a => a.AnsweredAt).ToListAsync(ct);
        var learned = await db.CardProgress.AsNoTracking()
            .Where(p => p.UserId == UserId && p.SeenAt >= fromUtc).Select(p => p.SeenAt!.Value).ToListAsync(ct);

        Dictionary<DateOnly, int> ByDay(IEnumerable<DateTime> xs) =>
            xs.GroupBy(x => ProgressQueries.LocalDate(x, Tz)).ToDictionary(g => g.Key, g => g.Count());
        var s = ByDay(sessions);
        var a = ByDay(answers);
        var l = ByDay(learned);
        var calendar = Enumerable.Range(0, CalendarDays).Select(i => from.AddDays(i))
            .Select(d => new ActivityDay(d, s.GetValueOrDefault(d), a.GetValueOrDefault(d), l.GetValueOrDefault(d)))
            .ToList();

        var totalAnswers = await db.AttemptLogs.CountAsync(x => x.UserId == UserId, ct);
        var correctAnswers = await db.AttemptLogs.CountAsync(x => x.UserId == UserId && x.IsCorrect, ct);
        var cardsSeen = await db.CardProgress.CountAsync(p => p.UserId == UserId && p.SeenAt != null && !p.Card.IsArchived, ct);
        var cardsTotal = await db.Cards.CountAsync(c => !c.IsArchived, ct);
        var exams = await db.ExamResults.CountAsync(e => e.UserId == UserId, ct);

        return new StatsOverview(xp, level, Gamification.XpForLevel(level), Gamification.XpForLevel(level + 1), streak,
            calendar, Badges.All.Select(b => new BadgeStatus(b.Code, b.Name, b.Description, owned.Contains(b.Code))).ToList(),
            cardsSeen, cardsTotal, totalAnswers, correctAnswers, exams);
    }

    public async Task<SubjectStats?> SubjectAsync(string slug, CancellationToken ct)
    {
        var subject = await db.Subjects.AsNoTracking().SingleOrDefaultAsync(x => x.Slug == slug, ct);
        if (subject is null) return null;

        var topics = await ProgressQueries.TopicStatsAsync(db, UserId, subject.Id, ct);
        var mastery = Mastery.ForSubject(topics.Select(t => (t.CardCount, t.Mastery)));

        var from = Today.AddDays(-(DailyDays - 1));
        var fromUtc = ProgressQueries.DayStartUtc(from, Tz);
        var recent = await db.AttemptLogs.AsNoTracking()
            .Where(x => x.UserId == UserId && x.AnsweredAt >= fromUtc && x.Question.Card.Topic.SubjectId == subject.Id)
            .Select(x => new { x.AnsweredAt, x.IsCorrect }).ToListAsync(ct);
        var byDay = recent.GroupBy(x => ProgressQueries.LocalDate(x.AnsweredAt, Tz))
            .ToDictionary(g => g.Key, g => (Answered: g.Count(), Correct: g.Count(x => x.IsCorrect)));
        var daily = Enumerable.Range(0, DailyDays).Select(i => from.AddDays(i))
            .Select(d => byDay.TryGetValue(d, out var v) ? new DailySuccess(d, v.Answered, v.Correct) : new DailySuccess(d, 0, 0))
            .ToList();

        // Nejčastěji chybované karty (celá historie), u stejného počtu chyb vyšší chybovost dřív.
        var missed = await db.AttemptLogs.AsNoTracking()
            .Where(x => x.UserId == UserId && x.Question.Card.Topic.SubjectId == subject.Id && !x.Question.Card.IsArchived)
            .GroupBy(x => x.Question.CardId)
            .Select(g => new { CardId = g.Key, Wrong = g.Count(x => !x.IsCorrect), Attempts = g.Count() })
            .Where(g => g.Wrong > 0)
            .OrderByDescending(g => g.Wrong).ThenByDescending(g => (double)g.Wrong / g.Attempts)
            .Take(MostMissedCount)
            .ToListAsync(ct);
        var missedIds = missed.Select(m => m.CardId).ToList();
        var cards = await db.Cards.AsNoTracking().Where(c => missedIds.Contains(c.Id))
            .Select(c => new
            {
                c.Id, c.Front, c.TopicId, TopicName = c.Topic.Name,
                Box = db.CardProgress.Where(p => p.CardId == c.Id && p.UserId == UserId).Select(p => p.Box).FirstOrDefault(),
            })
            .ToDictionaryAsync(c => c.Id, ct);
        var mostMissed = missed.Select(m =>
        {
            var c = cards[m.CardId];
            return new MissedCard(m.CardId, c.Front, c.TopicId, c.TopicName, m.Wrong, m.Attempts, c.Box);
        }).ToList();

        var exams = await db.ExamResults.AsNoTracking()
            .Where(e => e.UserId == UserId && e.SubjectId == subject.Id)
            .OrderByDescending(e => e.FinishedAt).Take(10)
            .Select(e => new ExamSummary(e.Id, e.FinishedAt, e.Score, e.Total, e.Total == 0 ? 0 : 100 * e.Score / e.Total))
            .ToListAsync(ct);

        return new SubjectStats(subject.Id, subject.Slug, subject.Name, mastery,
            topics.OrderBy(t => t.Order)
                .Select(t => new TopicStat(t.Id, t.Name, t.Order, t.CardCount, t.SeenCount, t.Mastery)).ToList(),
            daily, mostMissed, exams, StudyService.PassPercent(subject));
    }
}
