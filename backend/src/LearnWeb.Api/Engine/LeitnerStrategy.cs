using LearnWeb.Api.Data;

namespace LearnWeb.Api.Engine;

/// <summary>
/// Vyměnitelná strategie opakování (Leitner teď, SM-2 případně později).
/// Čisté funkce bez I/O — veškerá pravidla enginu jsou deterministická a testovaná.
/// </summary>
public interface IRepetitionStrategy
{
    /// <summary>Karta poprvé probrána v režimu Učení.</summary>
    void OnLearned(CardProgress p, DateOnly today, DateTime now);

    /// <summary>Výsledek odpovědi na otázku karty v daném režimu.</summary>
    void OnAnswered(CardProgress p, StudyMode mode, bool isCorrect, DateOnly today, DateTime now);
}

public sealed class LeitnerStrategy : IRepetitionStrategy
{
    public const int MinBox = 1;
    public const int MaxBox = 5;

    /// <summary>Interval opakování ve dnech pro krabice 1–5.</summary>
    public static int IntervalDays(int box) => box switch
    {
        <= 1 => 1,
        2 => 2,
        3 => 4,
        4 => 7,
        _ => 14,
    };

    public void OnLearned(CardProgress p, DateOnly today, DateTime now)
    {
        if (p.SeenAt is not null) return;
        p.Box = MinBox;
        p.DueDate = today.AddDays(IntervalDays(MinBox));
        p.SeenAt = now;
    }

    public void OnAnswered(CardProgress p, StudyMode mode, bool isCorrect, DateOnly today, DateTime now)
    {
        p.SeenAt ??= now;
        p.LastResult = isCorrect;

        if (!isCorrect)
        {
            // Chyba kdekoli vrací kartu do krabice 1 (zítra znovu).
            p.WrongCount++;
            p.Box = MinBox;
            p.DueDate = today.AddDays(1);
            return;
        }

        p.CorrectCount++;
        // Postup do vyšší krabice jen v Opakování — kvíz a zkouška pouze potvrzují stav.
        if (mode == StudyMode.Review)
        {
            p.Box = Math.Min(p.Box + 1, MaxBox);
            p.DueDate = today.AddDays(IntervalDays(p.Box));
        }
    }
}

public static class Mastery
{
    /// <summary>Váha krabice pro zvládnutí: box 3 = 0.6, 4 = 0.8, 5 = 1.0, nižší = 0.</summary>
    public static double BoxWeight(int box) => box switch
    {
        >= 5 => 1.0,
        4 => 0.8,
        3 => 0.6,
        _ => 0.0,
    };

    /// <summary>Zvládnutí tématu 0–1. Neprobrané karty se počítají jako 0.</summary>
    public static double ForTopic(int cardCount, IEnumerable<int> boxes) =>
        cardCount == 0 ? 0 : boxes.Sum(BoxWeight) / cardCount;

    /// <summary>Zvládnutí předmětu = průměr témat, která mají karty.</summary>
    public static double ForSubject(IEnumerable<(int CardCount, double Mastery)> topics)
    {
        var withCards = topics.Where(t => t.CardCount > 0).ToList();
        return withCards.Count == 0 ? 0 : withCards.Average(t => t.Mastery);
    }
}
