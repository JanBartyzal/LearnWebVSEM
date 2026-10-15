using LearnWeb.Api.Data;
using LearnWeb.Api.Engine;
using LearnWeb.Api.Study;
using Microsoft.EntityFrameworkCore;

namespace LearnWeb.Api.Endpoints;

public sealed record AreaSummary(int Id, string Slug, string Name, string Description, int Order, int SubjectCount);

public sealed record SubjectSummary(int Id, string Slug, string Name, int Order, int TopicCount, int CardCount, double Mastery,
    string AreaSlug);

/// <summary>Formát zkoušky nanečisto podle certifikace (null u předmětů s výchozím formátem).</summary>
public sealed record ExamFormatDto(int Questions, int Minutes, int PassPercent);

public sealed record TopicSummary(int Id, string Slug, string Name, string Description, int Order, int CardCount, int SeenCount,
    double Mastery);

public sealed record SubjectDetail(int Id, string Slug, string Name, string Goal, double Mastery, IReadOnlyList<TopicSummary> Topics,
    string AreaSlug, string AreaName, ExamFormatDto? Exam);

public sealed record CardDto(int Id, string Key, string Type, string Front, string Back, int Order, int QuestionCount, bool Seen);

public sealed record TopicDetail(int Id, string Slug, string Name, string Description, string SubjectSlug, string SubjectName,
    IReadOnlyList<CardDto> Cards, string AreaSlug, string AreaName);

public static class StudyEndpoints
{
    private const int UserId = StudyService.UserId;

    public static void MapStudyEndpoints(this IEndpointRouteBuilder app)
    {
        var api = app.MapGroup("/api");

        api.MapGet("/areas", async (LearnWebDbContext db, CancellationToken ct) =>
            await db.Areas.AsNoTracking().OrderBy(a => a.Order)
                .Select(a => new AreaSummary(a.Id, a.Slug, a.Name, a.Description, a.Order, a.Subjects.Count))
                .ToListAsync(ct));

        api.MapGet("/subjects", async (LearnWebDbContext db, CancellationToken ct) =>
        {
            var topics = await TopicStatsAsync(db, null, ct);
            var subjects = await db.Subjects.AsNoTracking().Include(s => s.Area)
                .OrderBy(s => s.Area.Order).ThenBy(s => s.Order).ToListAsync(ct);
            return subjects.Select(s =>
            {
                var ts = topics.Where(t => t.SubjectId == s.Id).ToList();
                return new SubjectSummary(s.Id, s.Slug, s.Name, s.Order, ts.Count, ts.Sum(t => t.CardCount),
                    Mastery.ForSubject(ts.Select(t => (t.CardCount, t.Mastery))), s.Area.Slug);
            });
        });

        api.MapGet("/subjects/{slug}", async (string slug, LearnWebDbContext db, CancellationToken ct) =>
        {
            var s = await db.Subjects.AsNoTracking().Include(x => x.Area).SingleOrDefaultAsync(x => x.Slug == slug, ct);
            if (s is null) return Results.NotFound();

            var ts = await TopicStatsAsync(db, s.Id, ct);
            return Results.Ok(new SubjectDetail(s.Id, s.Slug, s.Name, s.Goal,
                Mastery.ForSubject(ts.Select(t => (t.CardCount, t.Mastery))),
                ts.OrderBy(t => t.Order)
                    .Select(t => new TopicSummary(t.Id, t.Slug, t.Name, t.Description, t.Order, t.CardCount, t.Boxes.Count, t.Mastery))
                    .ToList(),
                s.Area.Slug, s.Area.Name,
                s is { ExamQuestions: { } q, ExamMinutes: { } m, ExamPassPercent: { } p } ? new ExamFormatDto(q, m, p) : null));
        });

        api.MapGet("/topics/{id:int}", async (int id, LearnWebDbContext db, CancellationToken ct) =>
        {
            var t = await db.Topics.AsNoTracking()
                .Include(x => x.Subject).ThenInclude(s => s.Area)
                .Include(x => x.Cards.Where(c => !c.IsArchived).OrderBy(c => c.Order))
                .ThenInclude(c => c.Questions.Where(q => !q.IsArchived))
                .SingleOrDefaultAsync(x => x.Id == id, ct);
            if (t is null) return Results.NotFound();

            var seen = await db.CardProgress
                .Where(p => p.UserId == UserId && p.Card.TopicId == id && p.SeenAt != null)
                .Select(p => p.CardId).ToListAsync(ct);

            return Results.Ok(new TopicDetail(t.Id, t.Slug, t.Name, t.Description, t.Subject.Slug, t.Subject.Name,
                t.Cards.Select(c => new CardDto(c.Id, c.Key, c.Type.ToString().ToLowerInvariant(), c.Front, c.Back, c.Order,
                    c.Questions.Count, seen.Contains(c.Id))).ToList(), t.Subject.Area.Slug, t.Subject.Area.Name));
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

        // --- Denní opakování a „pokračovat kde jsi skončil" (fáze 3) ---

        api.MapGet("/review/summary", (StudyService study, CancellationToken ct) => study.ReviewSummaryAsync(ct));

        api.MapPost("/review", async (ReviewRequest req, StudyService study, CancellationToken ct) =>
            Results.Ok(await study.BuildReviewAsync(req, ct)));

        // Bez dosavadní aktivity vrací JSON `null` (ne 204), aby klient nemusel řešit prázdné tělo.
        api.MapGet("/continue", async (StudyService study, CancellationToken ct) =>
            Results.Json(await study.ContinueAsync(ct)));

        // --- Simulace zkoušky, dokončené seance, statistiky (fáze 4) ---

        api.MapPost("/exams", async (ExamComposeRequest req, StudyService study, CancellationToken ct) =>
            await study.ComposeExamAsync(req, ct) is { } paper ? Results.Ok(paper) : Results.NotFound());

        api.MapPost("/exams/submit", async (ExamSubmitRequest req, StudyService study, CancellationToken ct) =>
            await study.SubmitExamAsync(req, ct) is { } outcome
                ? Results.Ok(outcome)
                : Results.BadRequest(new { error = "Zkoušku se nepodařilo vyhodnotit — chybí předmět nebo otázky." }));

        api.MapPost("/sessions", async (SessionCompleteRequest req, StudyService study, CancellationToken ct) =>
            req.Mode is StudyMode.Exam
                ? Results.BadRequest(new { error = "Zkouška se zaznamenává při odevzdání." })
                : Results.Ok(await study.CompleteSessionAsync(req, ct)));

        api.MapGet("/stats/overview", (StatsService stats, CancellationToken ct) => stats.OverviewAsync(ct));

        api.MapGet("/stats/subjects/{slug}", async (string slug, StatsService stats, CancellationToken ct) =>
            await stats.SubjectAsync(slug, ct) is { } result ? Results.Ok(result) : Results.NotFound());
    }

    private static Task<List<TopicStats>> TopicStatsAsync(LearnWebDbContext db, int? subjectId, CancellationToken ct) =>
        ProgressQueries.TopicStatsAsync(db, UserId, subjectId, ct);
}
