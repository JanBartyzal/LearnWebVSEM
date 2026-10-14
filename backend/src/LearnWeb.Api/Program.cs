using System.Text.Json.Serialization;
using LearnWeb.Api.Content;
using LearnWeb.Api.Data;
using LearnWeb.Api.Endpoints;
using LearnWeb.Api.Engine;
using LearnWeb.Api.Llm;
using LearnWeb.Api.Study;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<LearnWebDbContext>(o => o
    .UseNpgsql(builder.Configuration.GetConnectionString("LearnWeb"),
        npgsql => npgsql.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery))
    .UseSnakeCaseNamingConvention());

builder.Services.AddSingleton(TimeProvider.System);
builder.Services.AddSingleton<IRepetitionStrategy, LeitnerStrategy>();
builder.Services.AddScoped<StudyService>();
builder.Services.AddScoped<ContentImporter>();
builder.Services.AddScoped<ContentExporter>();
builder.Services.AddScoped<ContentDraftService>();
builder.Services.Configure<ContentOptions>(builder.Configuration.GetSection(ContentOptions.Section));
builder.Services.Configure<LlmOptions>(builder.Configuration.GetSection(LlmOptions.Section));
builder.Services.AddHttpClient<LlmClient>((sp, http) =>
    http.Timeout = TimeSpan.FromSeconds(sp.GetRequiredService<IOptions<LlmOptions>>().Value.TimeoutSeconds));

builder.Services.ConfigureHttpJsonOptions(o => o.SerializerOptions.Converters.Add(new JsonStringEnumConverter()));
builder.Services.AddProblemDetails();

var app = builder.Build();

app.UseExceptionHandler();

await MigrateAndSeedAsync(app);

app.MapGet("/api/health", () => Results.Ok(new { status = "ok" }));
app.MapStudyEndpoints();
app.MapContentEndpoints();

app.Run();

static async Task MigrateAndSeedAsync(WebApplication app)
{
    using var scope = app.Services.CreateScope();
    var db = scope.ServiceProvider.GetRequiredService<LearnWebDbContext>();
    var log = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();

    await db.Database.MigrateAsync();

    var options = scope.ServiceProvider.GetRequiredService<IOptions<ContentOptions>>().Value;
    if (!options.SeedOnEmptyDatabase || await db.Subjects.AnyAsync() || !Directory.Exists(options.Directory)) return;

    var files = ContentImporter.ReadDirectory(options.Directory).ToList();
    var report = await scope.ServiceProvider.GetRequiredService<ContentImporter>()
        .ImportAsync(files, $"seed:{options.Directory}", dryRun: false);

    if (report.Applied) log.LogInformation("Prázdná DB naplněna z {Dir}: {Counts}", options.Directory, report.Counts);
    else foreach (var issue in report.Issues.Where(i => i.IsError)) log.LogError("Seed obsahu selhal: {Issue}", issue);
}
