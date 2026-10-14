using System.Text.RegularExpressions;
using LearnWeb.Api.Content;
using LearnWeb.Api.Data;
using Microsoft.EntityFrameworkCore;

namespace LearnWeb.Api.Llm;

public sealed record TopicDraftRequest(string SubjectSlug, string TopicSlug, int CardCount = 15, string? Notes = null);

public sealed record TopicDraftResult(string FileName, string Markdown, IReadOnlyList<ContentIssue> Issues, bool IsValid);

/// <summary>
/// Návrh obsahu tématu pomocí LLM. Výsledek se NIKDY neukládá automaticky — vrací se jako MD
/// k revizi; do DB se dostane jen standardním importem, který jej zvaliduje.
/// </summary>
public sealed partial class ContentDraftService(LearnWebDbContext db, LlmClient llm)
{
    private static readonly Lazy<string> Template = new(() =>
    {
        using var s = typeof(ContentDraftService).Assembly
            .GetManifestResourceStream("LearnWeb.Api.Llm.Prompts.topic-draft.md")!;
        return new StreamReader(s).ReadToEnd();
    });

    [GeneratedRegex(@"^\s*```[a-zA-Z]*\s*\n(?<body>.*?)\n\s*```\s*$", RegexOptions.Singleline)]
    private static partial Regex CodeFenceRegex();

    public async Task<TopicDraftResult?> DraftTopicAsync(TopicDraftRequest req, CancellationToken ct)
    {
        var topic = await db.Topics.AsNoTracking()
            .Include(t => t.Subject)
            .Include(t => t.Cards.Where(c => !c.IsArchived)).ThenInclude(c => c.Questions.Where(q => !q.IsArchived))
            .SingleOrDefaultAsync(t => t.Subject.Slug == req.SubjectSlug && t.Slug == req.TopicSlug, ct);
        if (topic is null) return null;

        var existing = topic.Cards.Count == 0
            ? ""
            : "\nTéma už obsahuje níže uvedené karty. Zachovej jejich klíče a obsah zpřesni/doplň, nic nemaž bez důvodu:\n\n"
              + MarkdownContentWriter.Write(ContentExporter.ToDocument(topic.Subject, topic)) + "\n";
        var notes = string.IsNullOrWhiteSpace(req.Notes) ? "" : $"\nDoplňující podklady od studenta (mají přednost):\n{req.Notes}\n";

        var prompt = Template.Value
            .Replace("{{subjectSlug}}", topic.Subject.Slug)
            .Replace("{{subjectName}}", topic.Subject.Name)
            .Replace("{{subjectGoal}}", topic.Subject.Goal)
            .Replace("{{topicSlug}}", topic.Slug)
            .Replace("{{topicName}}", topic.Name.Replace("\"", "\\\""))
            .Replace("{{topicOrder}}", topic.Order.ToString())
            .Replace("{{topicDescription}}", topic.Description)
            .Replace("{{cardCount}}", Math.Clamp(req.CardCount, 3, 40).ToString())
            .Replace("{{existingContent}}", existing)
            .Replace("{{notes}}", notes);

        var answer = await llm.CompleteAsync(
            "Odpovídáš výhradně obsahem požadovaného Markdown souboru.", prompt, ct);

        var fence = CodeFenceRegex().Match(answer);
        var markdown = (fence.Success ? fence.Groups["body"].Value : answer).Trim() + "\n";

        var fileName = MarkdownContentWriter.TopicFileName(topic.Order, topic.Slug);
        var parsed = MarkdownContentParser.Parse(fileName, markdown);
        var issues = parsed.Issues.ToList();
        if (parsed.Document is TopicDocument d && (d.SubjectSlug != topic.Subject.Slug || d.Slug != topic.Slug))
            issues.Add(new ContentIssue(fileName, 1, "Model změnil hlavičku (subject/slug) — návrh by se naimportoval jinam."));

        return new TopicDraftResult(fileName, markdown, issues, parsed.IsValid && issues.All(i => !i.IsError));
    }
}
