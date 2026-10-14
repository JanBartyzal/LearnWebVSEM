namespace LearnWeb.Api.Data;

// ---------- Obsah (importovaný z MD) ----------

public class Subject
{
    public int Id { get; set; }
    public required string Slug { get; set; }
    public required string Name { get; set; }
    public string Goal { get; set; } = "";
    public int Order { get; set; }
    public DateTime UpdatedAt { get; set; }
    public List<Topic> Topics { get; set; } = [];
}

public class Topic
{
    public int Id { get; set; }
    public int SubjectId { get; set; }
    public Subject Subject { get; set; } = null!;
    public required string Slug { get; set; }
    public required string Name { get; set; }
    public string Description { get; set; } = "";
    public int Order { get; set; }
    public DateTime UpdatedAt { get; set; }
    public List<Card> Cards { get; set; } = [];
}

public enum CardType { Term, Explain, Compare }

public class Card
{
    public int Id { get; set; }
    public int TopicId { get; set; }
    public Topic Topic { get; set; } = null!;

    /// <summary>Stabilní klíč karty v rámci tématu (z MD `{#klic}`) — na něj se váže progress.</summary>
    public required string Key { get; set; }
    public CardType Type { get; set; }
    public required string Front { get; set; }
    public required string Back { get; set; }
    public int Order { get; set; }

    /// <summary>Karta zmizela z importovaného souboru — skrývá se, ale progress a historie zůstávají.</summary>
    public bool IsArchived { get; set; }
    public List<Question> Questions { get; set; } = [];
}

public class Question
{
    public int Id { get; set; }
    public int CardId { get; set; }
    public Card Card { get; set; } = null!;
    public int Order { get; set; }
    public required string Text { get; set; }
    public List<string> Options { get; set; } = [];
    public int CorrectIndex { get; set; }
    public string Explanation { get; set; } = "";
    public bool IsArchived { get; set; }
}

// ---------- Stav studenta ----------

public class CardProgress
{
    public long Id { get; set; }
    public int CardId { get; set; }
    public Card Card { get; set; } = null!;
    public int UserId { get; set; } = 1;

    /// <summary>Leitnerova krabice 1–5.</summary>
    public int Box { get; set; } = 1;
    public DateOnly DueDate { get; set; }
    public int CorrectCount { get; set; }
    public int WrongCount { get; set; }
    public bool? LastResult { get; set; }
    public DateTime? SeenAt { get; set; }
}

public enum StudyMode { Learn, Quiz, Review, Exam }

/// <summary>Zdroj pravdy pro statistiky. Nikdy se nemaže.</summary>
public class AttemptLog
{
    public long Id { get; set; }
    public int QuestionId { get; set; }
    public Question Question { get; set; } = null!;
    public int UserId { get; set; } = 1;
    public StudyMode Mode { get; set; }
    public int SelectedIndex { get; set; }
    public bool IsCorrect { get; set; }
    public DateTime AnsweredAt { get; set; }
}

public class ExamResult
{
    public long Id { get; set; }
    public int SubjectId { get; set; }
    public Subject Subject { get; set; } = null!;
    public int UserId { get; set; } = 1;
    public int Score { get; set; }
    public int Total { get; set; }

    /// <summary>JSON: rozpad výsledku po tématech.</summary>
    public string Breakdown { get; set; } = "[]";
    public DateTime StartedAt { get; set; }
    public DateTime FinishedAt { get; set; }
}

public class UserStats
{
    public int UserId { get; set; } = 1;
    public int Xp { get; set; }
    public int StreakDays { get; set; }
    public DateOnly? LastActiveDate { get; set; }
    public List<string> Badges { get; set; } = [];
}

// ---------- Audit importů obsahu ----------

public class ContentImport
{
    public long Id { get; set; }
    public DateTime ImportedAt { get; set; }
    public required string Source { get; set; }
    public List<string> Files { get; set; } = [];
    public required string Summary { get; set; }
}
