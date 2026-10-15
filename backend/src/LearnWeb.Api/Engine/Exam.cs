namespace LearnWeb.Api.Engine;

/// <summary>Karta kandidující do simulace zkoušky.</summary>
public sealed record ExamCandidate(int CardId, int TopicId);

/// <summary>
/// Složení simulace zkoušky (BA §2.2 E): otázky napříč všemi tématy předmětu, úměrně počtu karet tématu
/// (metoda největších zbytků), z každého tématu aspoň jedna, pokud to počet otázek dovolí. Zkouška pokrývá
/// celý sylabus — bere i neprobrané karty.
/// </summary>
public static class ExamComposer
{
    public const int MinCount = 20;
    public const int MaxCount = 30;
    public const int DefaultCount = 25;

    /// <summary>Volitelný časový limit: minuty na otázku.</summary>
    public const int MinutesPerQuestion = 1;

    public static IReadOnlyList<int> SelectCards(IReadOnlyList<ExamCandidate> cards, int count, Random rng)
    {
        count = Math.Min(count, cards.Count);
        if (count <= 0) return [];

        var topics = cards.GroupBy(c => c.TopicId)
            .Select(g => (TopicId: g.Key, Cards: Shuffle(g.Select(c => c.CardId), rng)))
            .OrderBy(t => t.TopicId)
            .ToList();
        var quota = Allocate(topics.Select(t => t.Cards.Count).ToList(), count);

        var picked = topics.SelectMany((t, i) => t.Cards.Take(quota[i])).ToList();
        return Shuffle(picked, rng);
    }

    /// <summary>Rozdělení `count` mezi skupiny podle velikosti: minimum 1 (vejde-li se), zbytek úměrně, největší zbytky.</summary>
    public static int[] Allocate(IReadOnlyList<int> sizes, int count)
    {
        var quota = new int[sizes.Count];
        var groups = Enumerable.Range(0, sizes.Count).Where(i => sizes[i] > 0).ToList();
        if (groups.Count == 0 || count <= 0) return quota;

        // Minimum jedna otázka z tématu; když je témat víc než otázek, dostanou je největší témata.
        foreach (var i in groups.OrderByDescending(i => sizes[i]).ThenBy(i => i).Take(count)) quota[i] = 1;

        var capacity = groups.Sum(i => sizes[i] - quota[i]);
        var left = Math.Min(count - quota.Sum(), capacity);
        if (left <= 0) return quota;
        var target = quota.Sum() + left;

        var exact = groups.ToDictionary(i => i, i => (double)left * (sizes[i] - quota[i]) / capacity);
        foreach (var i in groups) quota[i] += (int)Math.Floor(exact[i]);

        foreach (var i in groups.OrderByDescending(i => exact[i] - Math.Floor(exact[i])).ThenByDescending(i => sizes[i]))
        {
            if (quota.Sum() >= target) break;
            if (quota[i] < sizes[i]) quota[i]++;
        }
        return quota;
    }

    private static List<int> Shuffle(IEnumerable<int> items, Random rng)
    {
        var list = items.ToList();
        rng.Shuffle(System.Runtime.InteropServices.CollectionsMarshal.AsSpan(list));
        return list;
    }
}

public sealed record ExamAnswer(int TopicId, bool IsCorrect);

public sealed record TopicScore(int TopicId, int Correct, int Total)
{
    public double Ratio => Total == 0 ? 0 : (double)Correct / Total;
}

public sealed record ExamScore(int Correct, int Total, IReadOnlyList<TopicScore> Topics)
{
    /// <summary>Úspěšnost v celých procentech (zaokrouhleno dolů — 84,9 % není 85 %).</summary>
    public int Percent => Total == 0 ? 0 : (int)Math.Floor(100.0 * Correct / Total);
}

/// <summary>Vyhodnocení simulace zkoušky: celkové skóre a rozpad po tématech (kde jsou slabiny).</summary>
public static class ExamScoring
{
    public static ExamScore Evaluate(IEnumerable<ExamAnswer> answers)
    {
        var list = answers.ToList();
        var topics = list.GroupBy(a => a.TopicId)
            .Select(g => new TopicScore(g.Key, g.Count(a => a.IsCorrect), g.Count()))
            .OrderBy(t => t.Ratio).ThenBy(t => t.TopicId)
            .ToList();
        return new ExamScore(list.Count(a => a.IsCorrect), list.Count, topics);
    }
}
