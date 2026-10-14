using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace LearnWeb.Api.Content;

/// <summary>
/// Kanonický zápis obsahu do MD (export/záloha z DB). Výstup musí jít zpět načíst
/// přes <see cref="MarkdownContentParser"/> beze ztráty (hlídá test round-tripu).
/// </summary>
public static class MarkdownContentWriter
{
    private static readonly JsonSerializerOptions YamlString = new() { Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping };

    public const string SubjectFileName = "_predmet.md";

    public static string TopicFileName(int order, string slug) => $"{order:00}-{slug}.md";

    public static string Write(SubjectDocument s)
    {
        var sb = new StringBuilder();
        Frontmatter(sb, ("kind", "subject"), ("slug", s.Slug), ("name", Quote(s.Name)), ("order", s.Order.ToString()));
        if (s.Goal.Length > 0) sb.Append('\n').Append(s.Goal).Append('\n');
        return sb.ToString();
    }

    public static string Write(TopicDocument t)
    {
        var sb = new StringBuilder();
        Frontmatter(sb, ("kind", "topic"), ("subject", t.SubjectSlug), ("slug", t.Slug), ("name", Quote(t.Name)),
            ("order", t.Order.ToString()));
        if (t.Description.Length > 0) sb.Append('\n').Append(t.Description).Append('\n');

        foreach (var c in t.Cards)
        {
            sb.Append($"\n## {c.Front} {{#{c.Key} .{MarkdownContentParser.FormatCardType(c.Type)}}}\n\n");
            sb.Append(c.Back).Append('\n');

            foreach (var q in c.Questions)
            {
                sb.Append($"\n### ? {q.Text}\n\n");
                for (var i = 0; i < q.Options.Count; i++)
                    sb.Append(i == q.CorrectIndex ? "- [x] " : "- [ ] ").Append(q.Options[i]).Append('\n');
                sb.Append('\n');
                foreach (var line in q.Explanation.Split('\n'))
                    sb.Append(line.Length == 0 ? ">" : "> " + line).Append('\n');
            }
        }

        return sb.ToString();
    }

    private static void Frontmatter(StringBuilder sb, params (string Key, string Value)[] fields)
    {
        sb.Append("---\n");
        foreach (var (k, v) in fields) sb.Append(k).Append(": ").Append(v).Append('\n');
        sb.Append("---\n");
    }

    // JSON řetězec je platný YAML skalár a bezpečně escapuje dvojtečky, uvozovky apod.
    private static string Quote(string s) => JsonSerializer.Serialize(s, YamlString);
}
