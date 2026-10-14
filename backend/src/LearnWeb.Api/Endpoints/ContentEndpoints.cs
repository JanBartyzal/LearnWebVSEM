using LearnWeb.Api.Content;
using LearnWeb.Api.Data;
using LearnWeb.Api.Llm;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace LearnWeb.Api.Endpoints;

public sealed class ContentOptions
{
    public const string Section = "Content";

    /// <summary>Složka s MD zálohou obsahu (v kontejneru bind-mount /content).</summary>
    public string Directory { get; set; } = "";

    /// <summary>Při startu s prázdnou DB naimportovat obsah ze složky.</summary>
    public bool SeedOnEmptyDatabase { get; set; } = true;
}

public sealed record ImportTextRequest(string FileName, string Markdown, bool DryRun = true);

public sealed record ImportHistoryItem(long Id, DateTime ImportedAt, string Source, int FileCount, string Summary);

public static class ContentEndpoints
{
    public static void MapContentEndpoints(this IEndpointRouteBuilder app)
    {
        var api = app.MapGroup("/api/content");

        // Nahrání .md souborů nebo .zip (export) z UI. dryRun=true jen validuje.
        api.MapPost("/import", async (IFormFileCollection files, [FromQuery] bool? dryRun, ContentImporter importer,
            CancellationToken ct) =>
        {
            if (files.Count == 0) return Results.BadRequest(new { error = "Nebyl nahrán žádný soubor." });

            var contents = new List<ContentFile>();
            foreach (var f in files)
            {
                await using var s = f.OpenReadStream();
                contents.AddRange(ContentImporter.ReadUpload(f.FileName, s));
            }
            return Results.Ok(await importer.ImportAsync(contents, "upload", dryRun ?? false, ct));
        }).DisableAntiforgery();

        // Import jednoho MD z textu (např. návrh z LLM upravený v UI).
        api.MapPost("/import-text", async (ImportTextRequest req, ContentImporter importer, CancellationToken ct) =>
            Results.Ok(await importer.ImportAsync([new ContentFile(req.FileName, req.Markdown)], "editor", req.DryRun, ct)));

        // Znovunačtení celé MD zálohy z připojené složky content/.
        api.MapPost("/import-directory", async ([FromQuery] bool? dryRun, ContentImporter importer,
            IOptions<ContentOptions> options, CancellationToken ct) =>
        {
            var dir = options.Value.Directory;
            if (string.IsNullOrEmpty(dir) || !Directory.Exists(dir))
                return Results.BadRequest(new { error = $"Složka s obsahem '{dir}' neexistuje." });

            var files = ContentImporter.ReadDirectory(dir).ToList();
            return Results.Ok(await importer.ImportAsync(files, $"directory:{dir}", dryRun ?? false, ct));
        });

        // Záloha DB → ZIP s MD soubory (stejná struktura jako content/).
        api.MapGet("/export", async ([FromQuery] string? subject, ContentExporter exporter, TimeProvider clock,
            CancellationToken ct) =>
        {
            var files = await exporter.ExportAsync(subject, ct);
            var stamp = clock.GetLocalNow().ToString("yyyyMMdd-HHmm");
            return Results.File(ContentExporter.Zip(files), "application/zip", $"learnweb-obsah-{stamp}.zip");
        });

        api.MapGet("/imports", async (LearnWebDbContext db, CancellationToken ct) =>
            await db.ContentImports.AsNoTracking()
                .OrderByDescending(i => i.ImportedAt).Take(50)
                .Select(i => new ImportHistoryItem(i.Id, i.ImportedAt, i.Source, i.Files.Count, i.Summary))
                .ToListAsync(ct));

        // --- LLM (volitelné; jen pro přípravu návrhů obsahu) ---

        api.MapGet("/llm/status", async (LlmClient llm, CancellationToken ct) =>
            new { configured = llm.IsConfigured, reachable = await llm.PingAsync(ct) });

        api.MapPost("/llm/draft-topic", async (TopicDraftRequest req, LlmClient llm, ContentDraftService drafts,
            CancellationToken ct) =>
        {
            if (!llm.IsConfigured)
                return Results.Problem("LLM brána není nakonfigurována.", statusCode: StatusCodes.Status503ServiceUnavailable);
            try
            {
                var draft = await drafts.DraftTopicAsync(req, ct);
                return draft is null ? Results.NotFound() : Results.Ok(draft);
            }
            catch (HttpRequestException ex)
            {
                return Results.Problem(ex.Message, statusCode: StatusCodes.Status502BadGateway);
            }
        });
    }
}
