using LearnWeb.Api.Data;

namespace LearnWeb.Api.Content;

// Výsledek parsování jednoho MD souboru. Formát je popsán v content/README.md.

public abstract record ContentDocument(string FileName);

public sealed record SubjectDocument(string FileName, string Slug, string Name, int Order, string Goal)
    : ContentDocument(FileName);

public sealed record TopicDocument(
    string FileName, string SubjectSlug, string Slug, string Name, int Order, string Description,
    IReadOnlyList<CardDocument> Cards) : ContentDocument(FileName);

public sealed record CardDocument(
    string Key, CardType Type, string Front, string Back, IReadOnlyList<QuestionDocument> Questions, int Line);

public sealed record QuestionDocument(string Text, IReadOnlyList<string> Options, int CorrectIndex, string Explanation, int Line);

public sealed record ContentIssue(string File, int Line, string Message, bool IsError = true)
{
    public override string ToString() => $"{File}:{Line}: {(IsError ? "chyba" : "varování")}: {Message}";
}

public sealed record ParseResult(ContentDocument? Document, IReadOnlyList<ContentIssue> Issues)
{
    public bool IsValid => Document is not null && Issues.All(i => !i.IsError);
}
