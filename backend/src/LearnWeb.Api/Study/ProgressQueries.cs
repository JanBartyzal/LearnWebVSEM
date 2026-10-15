using LearnWeb.Api.Data;
using LearnWeb.Api.Engine;
using Microsoft.EntityFrameworkCore;

namespace LearnWeb.Api.Study;

/// <summary>Boxes = krabice probraných karet tématu (jejich počet = počet probraných karet).</summary>
public sealed record TopicStats(int Id, int SubjectId, string Slug, string Name, string Description, int Order, int CardCount,
    IReadOnlyList<int> Boxes, double Mastery)
{
    public int SeenCount => Boxes.Count;
    public bool IsCompleted => CardCount > 0 && SeenCount >= CardCount;
}

/// <summary>Sdílené dotazy na stav studenta (jen čtení) — pro výpis předmětů, statistiky i vyhodnocení odznaků.</summary>
public static class ProgressQueries
{
    public static async Task<List<TopicStats>> TopicStatsAsync(LearnWebDbContext db, int userId, int? subjectId,
        CancellationToken ct)
    {
        var rows = await db.Topics.AsNoTracking()
            .Where(t => subjectId == null || t.SubjectId == subjectId)
            .Select(t => new
            {
                t.Id, t.SubjectId, t.Slug, t.Name, t.Description, t.Order,
                CardCount = t.Cards.Count(c => !c.IsArchived),
                Boxes = db.CardProgress
                    .Where(p => p.UserId == userId && p.Card.TopicId == t.Id && !p.Card.IsArchived && p.SeenAt != null)
                    .Select(p => p.Box).ToList(),
            })
            .ToListAsync(ct);

        return rows.Select(r => new TopicStats(r.Id, r.SubjectId, r.Slug, r.Name, r.Description, r.Order, r.CardCount,
            r.Boxes, Mastery.ForTopic(r.CardCount, r.Boxes))).ToList();
    }

    /// <summary>Zvládnutí jednotlivých předmětů (průměr témat, BA §2.3 pravidlo 4).</summary>
    public static Dictionary<int, double> SubjectMastery(IEnumerable<TopicStats> topics) =>
        topics.GroupBy(t => t.SubjectId)
            .ToDictionary(g => g.Key, g => Mastery.ForSubject(g.Select(t => (t.CardCount, t.Mastery))));

    /// <summary>Dny (místní čas), ve kterých student dokončil aspoň jednu seanci.</summary>
    public static async Task<List<DateOnly>> ActiveDaysAsync(LearnWebDbContext db, int userId, TimeZoneInfo tz,
        CancellationToken ct)
    {
        var finished = await db.StudySessions.AsNoTracking()
            .Where(s => s.UserId == userId).Select(s => s.FinishedAt).ToListAsync(ct);
        return finished.Select(f => LocalDate(f, tz)).Distinct().ToList();
    }

    public static DateOnly LocalDate(DateTime utc, TimeZoneInfo tz) =>
        DateOnly.FromDateTime(TimeZoneInfo.ConvertTimeFromUtc(DateTime.SpecifyKind(utc, DateTimeKind.Utc), tz));

    public static DateTime DayStartUtc(DateOnly day, TimeZoneInfo tz) =>
        TimeZoneInfo.ConvertTimeToUtc(day.ToDateTime(TimeOnly.MinValue), tz);
}
