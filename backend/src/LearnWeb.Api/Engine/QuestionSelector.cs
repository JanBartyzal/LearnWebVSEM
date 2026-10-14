namespace LearnWeb.Api.Engine;

/// <summary>Karta kandidující do kvízu — jen data potřebná pro výběr (bez DB).</summary>
public sealed record CandidateCard(int CardId, bool Seen, int Box, DateOnly? DueDate, int WrongCount, bool? LastResult)
{
    /// <summary>Problematická karta: poslední odpověď špatně, nebo opakované chyby v nízké krabici.</summary>
    public bool IsWeak => Seen && (LastResult == false || (WrongCount > 0 && Box <= 2));
}

/// <summary>
/// Výběr karet do kvízu (BA §2.3 pravidlo 5): 50 % problematické, 30 % splatné, 20 % ostatní probrané.
/// Chybějící kvóty se doplní z ostatních skupin; neprobrané karty jdou na řadu až nakonec
/// (kvíz lze spustit i nad tématem, které student ještě neprošel).
/// </summary>
public static class QuestionSelector
{
    public const double WeakShare = 0.5;
    public const double DueShare = 0.3;

    public static IReadOnlyList<int> SelectCards(IReadOnlyList<CandidateCard> cards, int count, DateOnly today, Random rng)
    {
        if (count <= 0 || cards.Count == 0) return [];

        var weak = Shuffle(cards.Where(c => c.IsWeak), rng);
        var due = Shuffle(cards.Where(c => c.Seen && !c.IsWeak && c.DueDate <= today), rng);
        var rest = Shuffle(cards.Where(c => c.Seen && !c.IsWeak && !(c.DueDate <= today)), rng);
        var unseen = Shuffle(cards.Where(c => !c.Seen), rng);

        var weakQuota = (int)Math.Round(count * WeakShare);
        var dueQuota = (int)Math.Round(count * DueShare);
        var restQuota = count - weakQuota - dueQuota;

        var picked = new List<CandidateCard>();
        picked.AddRange(weak.Take(weakQuota));
        picked.AddRange(due.Take(dueQuota));
        picked.AddRange(rest.Take(restQuota));

        // Doplnění nevyčerpaných kvót v pořadí priority.
        foreach (var pool in new[] { weak, due, rest, unseen })
            foreach (var c in pool)
            {
                if (picked.Count >= count) break;
                if (!picked.Contains(c)) picked.Add(c);
            }

        return Shuffle(picked, rng).Select(c => c.CardId).ToList();
    }

    private static List<T> Shuffle<T>(IEnumerable<T> items, Random rng)
    {
        var list = items.ToList();
        rng.Shuffle(System.Runtime.InteropServices.CollectionsMarshal.AsSpan(list));
        return list;
    }
}
