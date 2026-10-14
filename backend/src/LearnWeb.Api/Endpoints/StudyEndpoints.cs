using LearnWeb.Api.Data;
using LearnWeb.Api.Engine;
using LearnWeb.Api.Study;
using Microsoft.EntityFrameworkCore;

namespace LearnWeb.Api.Endpoints;

public sealed record SubjectSummary(int Id, string Slug, string Name, int Order, int TopicCount, int CardCount, double Mastery);

public sealed record TopicSummary(int Id, string Slug, string Name, string Description, int Order, int CardCount, int SeenCount,
    double Mastery);

public sealed record SubjectDetail(int Id, string Slug, string Name, string Goal, double Mastery, IReadOnlyList<TopicSummary> Topics);

public sealed record CardDto(int Id, string Key, string Type, string Front, string Back, int Order, int QuestionCount, bool Seen);

public sealed record TopicDetail(int Id, string Slug, string Name, string Description, string SubjectSlug, string SubjectName,
    IReadOnlyList<CardDto> Cards);

public static class StudyEndpoints
{
    private const int UserId = StudyService.UserId;

    public static void MapStudyEndpoints(this IEndpointRouteBuilder app)
    {
        var api = app.MapGroup("/api");

        api.MapGet("/subjects", async (LearnWebDbContext db, CancellationToken ct) =>
        {
            var topics = await TopicStatsAsync(db, null, ct);
            var subjects = await db.Subjects.AsNoTracking().OrderBy(s => s.Order).ToListAsync(ct);
            return subjects.Select(s =>
            {
                var ts = topics.Where(t => t.SubjectId == s.Id).ToList();
                return new SubjectSummary(s.Id, s.Slug, s.Name, s.Order, ts.Count, ts.Sum(t => t.CardCount),
                    Mastery.ForSubject(ts.Select(t => (t.CardCount, t.Mastery))));
            });
        });

        api.MapGet("/subjects/{slug}", async (string slug, LearnWebDbContext db, CancellationToken ct) =>
        {
            var s = await db.Subjects.AsNoTracking().SingleOrDefaultAsync(x => x.Slug == slug, ct);
            if (s is null) return Results.NotFound();

            var ts = await TopicStatsAsync(db, s.Id, ct);
            return Results.Ok(new SubjectDetail(s.Id, s.Slug, s.Name, s.Goal,
                Mastery.ForSubject(ts.Select(t => (t.CardCount, t.Mastery))),
                ts.OrderBy(t => t.Order)
                    .Select(t => new TopicSummary(t.Id, t.Slug, t.Name, t.Description, t.Order, t.CardCount, t.Boxes.Count, t.Mastery))
                    .ToList()));
        });

        api.MapGet("/topics/{id:int}", async (int id, LearnWebDbContext db, CancellationToken ct) =>
        {
            var t = await db.Topics.AsNoTracking()
                .Include(x => x.Subject)
                .Include(x => x.Cards.Where(c => !c.IsArchived).OrderBy(c => c.Order))
                .ThenInclude(c => c.Questions.Where(q => !q.IsArchived))
                .SingleOrDefaultAsync(x => x.Id == id, ct);
            if (t is null) return Results.NotFound();

            var seen = await db.CardProgress
                .Where(p => p.UserId == UserId && p.Card.TopicId == id && p.SeenAt != null)
                .Select(p => p.CardId).ToListAsync(ct);

            return Results.Ok(new TopicDetail(t.Id, t.Slug, t.Name, t.Description, t.Subject.Slug, t.Subject.Name,
                t.Cards.Select(c => new CardDto(c.Id, c.Key, c.Type.ToString().ToLowerInvariant(), c.Front, c.Back, c.Order,
                    c.Questions.Count, seen.Contains(c.Id))).ToList()));
        });

        // --- Učení, kvízy, odpovědi (mění stav studenta jen přes StudyService) ---

        api.MapPost("/quiz", async (QuizRequest req, StudyService study, CancellationToken ct) =>
            req.TopicId is null && req.SubjectSlug is null && req.CardIds is not { Count: > 0 }
                ? Results.BadRequest(new { error = "Zadej téma, předmět nebo karty." })
                : Results.Ok(await study.BuildQuizAsync(req, ct)));

        api.MapPost("/answers", async (AnswerRequest req, StudyService study, CancellationToken ct) =>
            await study.AnswerAsync(req, ct) is { } result ? Results.Ok(result) : Results.NotFound());

        api.MapPost("/cards/{id:int}/learned", async (int id, StudyService study, CancellationToken ct) =>
            await study.MarkLearnedAsync(id, ct) is { } result ? Results.Ok(result) : Results.NotFound());

        api.MapGet("/stats/summary", (StudyService study, CancellationToken ct) => study.SummaryAsync(ct));
    }

    /// <summary>Boxes = krabice probraných karet tématu (jejich počet = počet probraných karet).</summary>
    private sealed record TopicStats(int Id, int SubjectId, string Slug, string Name, string Description, int Order, int CardCount,
        IReadOnlyList<int> Boxes, double Mastery);

    private static async Task<List<TopicStats>> TopicStatsAsync(LearnWebDbContext db, int? subjectId, CancellationToken ct)
    {
        var rows = await db.Topics.AsNoTracking()
            .Where(t => subjectId == null || t.SubjectId == subjectId)
            .Select(t => new
            {
                t.Id, t.SubjectId, t.Slug, t.Name, t.Description, t.Order,
                CardCount = t.Cards.Count(c => !c.IsArchived),
                Boxes = db.CardProgress
                    .Where(p => p.UserId == UserId && p.Card.TopicId == t.Id && !p.Card.IsArchived && p.SeenAt != null)
                    .Select(p => p.Box).ToList(),
            })
            .ToListAsync(ct);

        return rows.Select(r => new TopicStats(r.Id, r.SubjectId, r.Slug, r.Name, r.Description, r.Order, r.CardCount,
            r.Boxes, Mastery.ForTopic(r.CardCount, r.Boxes))).ToList();
    }
}
