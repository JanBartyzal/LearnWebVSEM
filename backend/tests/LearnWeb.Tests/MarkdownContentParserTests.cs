using LearnWeb.Api.Content;
using LearnWeb.Api.Data;

namespace LearnWeb.Tests;

public class MarkdownContentParserTests
{
    private const string ValidTopic = """
        ---
        kind: topic
        subject: projektovy-management
        slug: uvod
        name: "Úvod: základní pojmy"
        order: 1
        ---

        Popis tématu z osnovy.

        ## Projekt {#projekt .term}

        Projekt je jedinečný, časově ohraničený soubor činností.

        ### ? Co NENÍ atributem projektu?

        - [ ] Jedinečnost
        - [ ] Časová ohraničenost
        - [x] Opakovatelnost
        - [ ] Definovaný cíl

        > Opakovatelnost je znakem rutinních procesů.
        > Projekt je jedinečný.

        ## CPM vs. PERT {#cpm-vs-pert .compare}

        | | CPM | PERT |
        |---|---|---|
        | Doby | deterministické | pravděpodobnostní |
        """;

    [Fact]
    public void Parses_valid_topic()
    {
        var r = MarkdownContentParser.Parse("01-uvod.md", ValidTopic);

        Assert.True(r.IsValid, string.Join('\n', r.Issues));
        var t = Assert.IsType<TopicDocument>(r.Document);
        Assert.Equal("projektovy-management", t.SubjectSlug);
        Assert.Equal("Úvod: základní pojmy", t.Name);
        Assert.Equal("Popis tématu z osnovy.", t.Description);
        Assert.Equal(2, t.Cards.Count);

        var card = t.Cards[0];
        Assert.Equal(("projekt", CardType.Term, "Projekt"), (card.Key, card.Type, card.Front));
        var q = Assert.Single(card.Questions);
        Assert.Equal(4, q.Options.Count);
        Assert.Equal(2, q.CorrectIndex);
        Assert.Equal("Opakovatelnost je znakem rutinních procesů.\nProjekt je jedinečný.", q.Explanation);

        Assert.Equal(CardType.Compare, t.Cards[1].Type);
        Assert.Contains("| Doby |", t.Cards[1].Back);
        Assert.Empty(t.Cards[1].Questions);
    }

    [Fact]
    public void Parses_subject()
    {
        var r = MarkdownContentParser.Parse("_predmet.md", """
            ---
            kind: subject
            slug: pravo
            name: Právo
            order: 5
            ---

            Cíl předmětu.
            """);

        var s = Assert.IsType<SubjectDocument>(r.Document);
        Assert.Equal(("pravo", "Právo", 5, "Cíl předmětu."), (s.Slug, s.Name, s.Order, s.Goal));
    }

    [Theory]
    [InlineData("- [x] A\n- [x] B\n- [ ] C\n- [ ] D\n\n> V", "právě jednu správnou", 13)]
    [InlineData("- [ ] A\n- [ ] B\n- [ ] C\n- [ ] D\n\n> V", "právě jednu správnou", 13)]
    [InlineData("- [x] A\n\n> V", "2–6 možností", 13)]
    [InlineData("- [x] A\n- [ ] B\n- [ ] C\n- [ ] D", "vysvětlení", 13)]
    [InlineData("- [x] A\n- [ ] A\n- [ ] C\n- [ ] D\n\n> V", "nesmí opakovat", 13)]
    [InlineData("- [x] A\n- [ ] B\n\n> V\n\nvolný text", "Neočekávaný řádek", 20)]
    public void Reports_invalid_question(string body, string expectedMessage, int expectedLine)
    {
        var md = $"---\nkind: topic\nsubject: s\nslug: t\nname: T\norder: 1\n---\n\n## K {{#k .term}}\n\nRub\n\n### ? Otázka\n\n{body}\n";

        var r = MarkdownContentParser.Parse("t.md", md);

        Assert.False(r.IsValid);
        var issue = Assert.Single(r.Issues, i => i.IsError);
        Assert.Contains(expectedMessage, issue.Message);
        Assert.Equal(expectedLine, issue.Line);
    }

    [Fact]
    public void Warns_when_question_depends_on_card_context()
    {
        var md = "---\nkind: topic\nsubject: s\nslug: t\nname: T\norder: 1\n---\n\n## K {#k .term}\n\nRub\n\n" +
                 "### ? Podle příkladu na kartě: jaký je zisk?\n\n- [x] A\n- [ ] B\n- [ ] C\n- [ ] D\n\n> V\n";

        var r = MarkdownContentParser.Parse("t.md", md);

        Assert.True(r.IsValid);
        Assert.Contains(r.Issues, i => !i.IsError && i.Message.Contains("samostatně"));
    }

    [Fact]
    public void Reports_bad_card_heading_and_duplicate_key_with_line()
    {
        var md = "---\nkind: topic\nsubject: s\nslug: t\nname: T\norder: 1\n---\n\n## Bez klíče\n\nRub\n\n## A {#a .term}\n\nRub\n\n## B {#a .explain}\n\nRub\n";

        var r = MarkdownContentParser.Parse("t.md", md);

        Assert.Null(r.Document);
        Assert.Contains(r.Issues, i => i.Line == 9 && i.Message.Contains("Nadpis karty"));
        Assert.Contains(r.Issues, i => i.Line == 17 && i.Message.Contains("Duplicitní klíč"));
    }

    [Theory]
    [InlineData("Žádná hlavička", "YAML hlavičkou")]
    [InlineData("---\nkind: topic\nslug: t\nname: T\norder: 1\n---\n", "'subject'")]
    [InlineData("---\nkind: topic\nsubject: S s\nslug: t\nname: T\norder: 1\n---\n", "malá písmena")]
    [InlineData("---\nkind: topic\nsubject: s\nslug: t\nname: T\norder: nula\n---\n", "kladné celé číslo")]
    [InlineData("---\nkind: chapter\n---\n", "Neznámý")]
    public void Reports_invalid_frontmatter(string md, string expectedMessage)
    {
        var r = MarkdownContentParser.Parse("x.md", md);

        Assert.Null(r.Document);
        Assert.Contains(r.Issues, i => i.IsError && i.Message.Contains(expectedMessage));
    }

    [Fact]
    public void Writer_output_round_trips()
    {
        var original = Assert.IsType<TopicDocument>(MarkdownContentParser.Parse("01-uvod.md", ValidTopic).Document);

        var written = MarkdownContentWriter.Write(original);
        var reparsed = Assert.IsType<TopicDocument>(MarkdownContentParser.Parse("01-uvod.md", written).Document);

        Assert.Equal(MarkdownContentWriter.Write(reparsed), written);
        Assert.Equal(original.Name, reparsed.Name);
        Assert.Equal(original.Cards.Select(c => (c.Key, c.Type, c.Front, c.Back)), reparsed.Cards.Select(c => (c.Key, c.Type, c.Front, c.Back)));
        Assert.Equal(original.Cards[0].Questions[0].Options, reparsed.Cards[0].Questions[0].Options);
        Assert.Equal(original.Cards[0].Questions[0].Explanation, reparsed.Cards[0].Questions[0].Explanation);
    }

    [Fact]
    public void Repository_content_is_valid()
    {
        var root = FindContentDirectory();
        var issues = ContentImporter.ReadDirectory(root)
            .SelectMany(f => MarkdownContentParser.Parse(f.Name, f.Text).Issues)
            .Where(i => i.IsError)
            .ToList();

        Assert.True(issues.Count == 0, string.Join('\n', issues));
    }

    private static string FindContentDirectory()
    {
        for (var dir = new DirectoryInfo(AppContext.BaseDirectory); dir is not null; dir = dir.Parent)
        {
            var candidate = Path.Combine(dir.FullName, "content");
            if (Directory.Exists(candidate) && File.Exists(Path.Combine(candidate, "README.md"))) return candidate;
        }
        throw new DirectoryNotFoundException("Složka content/ nenalezena (spouštěj testy z repozitáře).");
    }
}
