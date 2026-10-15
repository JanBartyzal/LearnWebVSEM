using System.Text.RegularExpressions;
using LearnWeb.Api.Data;
using YamlDotNet.Serialization;

namespace LearnWeb.Api.Content;

/// <summary>
/// Deterministický parser obsahových MD souborů (formát viz content/README.md).
/// Řádkový průchod kvůli srozumitelným chybám „soubor:řádek: zpráva".
/// </summary>
public static partial class MarkdownContentParser
{
    [GeneratedRegex(@"^##\s+(?<title>.+?)\s*\{#(?<key>[a-z0-9][a-z0-9-]*)\s+\.(?<type>term|explain|compare)\}\s*$")]
    private static partial Regex CardHeadingRegex();

    [GeneratedRegex(@"^###\s+\?\s*(?<text>.*)$")]
    private static partial Regex QuestionHeadingRegex();

    [GeneratedRegex(@"^[-*]\s+\[(?<mark>[ xX])\]\s+(?<text>.+)$")]
    private static partial Regex OptionRegex();

    [GeneratedRegex(@"^[a-z0-9][a-z0-9-]*$")]
    private static partial Regex SlugRegex();

    // Otázka se v kvízu zobrazuje bez rubu karty a bez ostatních otázek — nesmí na ně odkazovat.
    [GeneratedRegex(@"předchozí otázk|na kartě|z karty|z příkladu|v příkladu|příkladu na|podle příkladu|výše uveden|z tabulky|v tabulce|parametry z|karty o ",
        RegexOptions.IgnoreCase)]
    private static partial Regex ContextReferenceRegex();

    public const int MinOptions = 2;
    public const int MaxOptions = 6;
    public const int RecommendedOptions = 4;

    public static ParseResult Parse(string fileName, string text)
    {
        var issues = new List<ContentIssue>();
        void Error(int line, string msg) => issues.Add(new ContentIssue(fileName, line, msg));
        void Warn(int line, string msg) => issues.Add(new ContentIssue(fileName, line, msg, IsError: false));

        var lines = text.TrimStart('﻿').Replace("\r\n", "\n").Replace('\r', '\n').Split('\n');

        // --- frontmatter ---
        var start = Array.FindIndex(lines, l => l.Trim().Length > 0);
        if (start < 0 || lines[start].Trim() != "---")
        {
            Error(1, "Soubor musí začínat YAML hlavičkou ohraničenou řádky '---'.");
            return new ParseResult(null, issues);
        }
        var end = Array.FindIndex(lines, start + 1, l => l.Trim() == "---");
        if (end < 0)
        {
            Error(start + 1, "Chybí ukončovací '---' YAML hlavičky.");
            return new ParseResult(null, issues);
        }

        Dictionary<string, object?> meta;
        try
        {
            meta = new DeserializerBuilder().Build()
                .Deserialize<Dictionary<string, object?>>(string.Join('\n', lines[(start + 1)..end])) ?? [];
        }
        catch (Exception ex)
        {
            Error(start + 1, $"Neplatná YAML hlavička: {ex.Message}");
            return new ParseResult(null, issues);
        }

        string? Str(string key) => meta.TryGetValue(key, out var v) ? v?.ToString()?.Trim() : null;
        string Required(string key)
        {
            var v = Str(key);
            if (string.IsNullOrEmpty(v)) Error(start + 1, $"V hlavičce chybí pole '{key}'.");
            return v ?? "";
        }
        string RequiredSlug(string key)
        {
            var v = Required(key);
            if (v.Length > 0 && !SlugRegex().IsMatch(v))
                Error(start + 1, $"Pole '{key}' musí obsahovat jen malá písmena bez diakritiky, číslice a pomlčky (je '{v}').");
            return v;
        }
        int RequiredOrder()
        {
            var v = Required("order");
            if (v.Length > 0 && (!int.TryParse(v, out var n) || n < 1))
                Error(start + 1, $"Pole 'order' musí být kladné celé číslo (je '{v}').");
            return int.TryParse(v, out var o) ? o : 0;
        }

        var bodyStart = end + 1;
        var kind = Required("kind");

        ContentDocument? doc = kind switch
        {
            "area" => ParseArea(),
            "subject" => ParseSubject(),
            "topic" => ParseTopic(),
            "" => null,
            _ => Fail($"Neznámý 'kind: {kind}' — povoleno je 'area', 'subject' nebo 'topic'."),
        };

        return new ParseResult(issues.Any(i => i.IsError) ? null : doc, issues);

        ContentDocument? Fail(string msg)
        {
            Error(start + 1, msg);
            return null;
        }

        AreaDocument ParseArea()
        {
            var slug = RequiredSlug("slug");
            var name = Required("name");
            var order = RequiredOrder();
            for (var i = bodyStart; i < lines.Length; i++)
                if (lines[i].StartsWith("## "))
                    Error(i + 1, "Soubor oblasti nesmí obsahovat karty — patří do souborů témat.");
            return new AreaDocument(fileName, slug, name, order, string.Join('\n', lines[bodyStart..]).Trim());
        }

        SubjectDocument ParseSubject()
        {
            var slug = RequiredSlug("slug");
            var name = Required("name");
            var order = RequiredOrder();
            var area = Str("area");
            if (string.IsNullOrEmpty(area)) area = SubjectDocument.DefaultArea;
            else if (!SlugRegex().IsMatch(area))
                Error(start + 1, $"Pole 'area' musí obsahovat jen malá písmena bez diakritiky, číslice a pomlčky (je '{area}').");
            var exam = ParseExam();
            for (var i = bodyStart; i < lines.Length; i++)
                if (lines[i].StartsWith("## "))
                    Error(i + 1, "Soubor předmětu nesmí obsahovat karty — patří do souborů témat.");
            var goal = string.Join('\n', lines[bodyStart..]).Trim();
            if (goal.Length == 0) Warn(bodyStart, "Předmět nemá popsaný cíl.");
            return new SubjectDocument(fileName, slug, name, order, goal, area, exam);
        }

        // exam_questions / exam_minutes / exam_pass — buď všechna tři, nebo žádné.
        ExamFormat? ParseExam()
        {
            var raw = new[] { "exam_questions", "exam_minutes", "exam_pass" }.Select(k => (Key: k, Value: Str(k))).ToList();
            if (raw.All(r => string.IsNullOrEmpty(r.Value))) return null;
            if (raw.Any(r => string.IsNullOrEmpty(r.Value)))
            {
                Error(start + 1, "Formát zkoušky vyžaduje všechna pole 'exam_questions', 'exam_minutes' a 'exam_pass'.");
                return null;
            }
            int Range(string key, string value, int min, int max)
            {
                if (int.TryParse(value, out var n) && n >= min && n <= max) return n;
                Error(start + 1, $"Pole '{key}' musí být celé číslo {min}–{max} (je '{value}').");
                return 0;
            }
            return new ExamFormat(Range("exam_questions", raw[0].Value!, 5, 100), Range("exam_minutes", raw[1].Value!, 5, 300),
                Range("exam_pass", raw[2].Value!, 1, 100));
        }

        TopicDocument ParseTopic()
        {
            var subject = RequiredSlug("subject");
            var slug = RequiredSlug("slug");
            var name = Required("name");
            var order = RequiredOrder();

            var description = new List<string>();
            var cards = new List<CardDocument>();
            var keys = new HashSet<string>();

            var i = bodyStart;
            while (i < lines.Length && !lines[i].StartsWith("## ")) description.Add(lines[i++]);

            while (i < lines.Length)
            {
                var headingLine = i + 1;
                var m = CardHeadingRegex().Match(lines[i].TrimEnd());
                i++;
                var back = new List<string>();
                var questions = new List<QuestionDocument>();

                while (i < lines.Length && !lines[i].StartsWith("## ") && !QuestionHeadingRegex().IsMatch(lines[i]))
                    back.Add(lines[i++]);

                while (i < lines.Length && QuestionHeadingRegex().IsMatch(lines[i]))
                    questions.Add(ParseQuestion(ref i));

                if (!m.Success)
                {
                    Error(headingLine, "Nadpis karty musí mít tvar '## Název {#klic .term|.explain|.compare}'.");
                    continue;
                }

                var key = m.Groups["key"].Value;
                if (!keys.Add(key)) Error(headingLine, $"Duplicitní klíč karty '{key}' v tématu.");

                var backText = string.Join('\n', back).Trim();
                if (backText.Length == 0) Error(headingLine, $"Karta '{key}' nemá obsah (rub).");

                cards.Add(new CardDocument(key, ParseCardType(m.Groups["type"].Value), m.Groups["title"].Value.Trim(),
                    backText, questions, headingLine));
            }

            return new TopicDocument(fileName, subject, slug, name, order, string.Join('\n', description).Trim(), cards);
        }

        QuestionDocument ParseQuestion(ref int i)
        {
            var line = i + 1;
            var text = new List<string> { QuestionHeadingRegex().Match(lines[i]).Groups["text"].Value.Trim() };
            var options = new List<string>();
            var correct = new List<int>();
            var explanation = new List<string>();
            i++;

            for (; i < lines.Length; i++)
            {
                var l = lines[i];
                if (l.StartsWith("## ") || QuestionHeadingRegex().IsMatch(l)) break;
                if (l.Trim().Length == 0) continue;

                var opt = OptionRegex().Match(l.Trim());
                if (opt.Success)
                {
                    if (explanation.Count > 0) Error(i + 1, "Možnosti odpovědí musí předcházet vysvětlení.");
                    if (opt.Groups["mark"].Value != " ") correct.Add(options.Count);
                    options.Add(opt.Groups["text"].Value.Trim());
                }
                else if (l.TrimStart().StartsWith('>'))
                {
                    var t = l.TrimStart()[1..];
                    explanation.Add(t.StartsWith(' ') ? t[1..] : t);
                }
                else if (options.Count == 0 && explanation.Count == 0)
                {
                    text.Add(l.Trim());
                }
                else
                {
                    Error(i + 1, "Neočekávaný řádek v otázce — povoleny jsou jen možnosti '- [ ]' / '- [x]' a vysvětlení '> '.");
                }
            }

            var questionText = string.Join('\n', text).Trim();
            if (questionText.Length == 0) Error(line, "Otázka nemá text.");
            if (ContextReferenceRegex().IsMatch(questionText))
                Warn(line, "Otázka odkazuje na kartu, příklad nebo předchozí otázku — v kvízu se zobrazuje samostatně, doplň data do zadání.");
            if (options.Count is < MinOptions or > MaxOptions)
                Error(line, $"Otázka musí mít {MinOptions}–{MaxOptions} možností (má {options.Count}).");
            else if (options.Count != RecommendedOptions)
                Warn(line, $"Doporučený počet možností je {RecommendedOptions} (má {options.Count}).");
            if (correct.Count != 1)
                Error(line, $"Otázka musí mít právě jednu správnou možnost '- [x]' (má {correct.Count}).");
            if (options.Distinct(StringComparer.OrdinalIgnoreCase).Count() != options.Count)
                Error(line, "Možnosti odpovědí se nesmí opakovat.");
            var explanationText = string.Join('\n', explanation).Trim();
            if (explanationText.Length == 0) Error(line, "Otázka musí mít vysvětlení správné odpovědi ('> ...').");

            return new QuestionDocument(questionText, options, correct.FirstOrDefault(), explanationText, line);
        }
    }

    public static CardType ParseCardType(string s) => s switch
    {
        "term" => CardType.Term,
        "explain" => CardType.Explain,
        "compare" => CardType.Compare,
        _ => throw new ArgumentOutOfRangeException(nameof(s), s, null),
    };

    public static string FormatCardType(CardType t) => t switch
    {
        CardType.Term => "term",
        CardType.Explain => "explain",
        CardType.Compare => "compare",
        _ => throw new ArgumentOutOfRangeException(nameof(t), t, null),
    };
}
