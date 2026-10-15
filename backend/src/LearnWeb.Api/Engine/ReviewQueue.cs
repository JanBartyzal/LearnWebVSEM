namespace LearnWeb.Api.Engine;

/// <summary>Probraná karta kandidující do denní fronty opakování — jen data potřebná pro výběr (bez DB).</summary>
public sealed record ReviewCandidate(int CardId, int SubjectId, int Box, DateOnly DueDate, bool? LastResult, int TopicOrder,
    int CardOrder);

/// <summary>
/// Denní fronta opakování (BA §2.2 D): karty splatné podle Leitnera, nejdřív chybované, pak nejdéle čekající.
/// Na předmět platí denní limit (BA §6 — „příliš mnoho karet → demotivace"); karty nad limit zůstávají splatné
/// a přesouvají se na další dny. Výběr je deterministický, náhoda je jen ve volbě otázky ke kartě.
/// </summary>
public static class ReviewQueue
{
    public const int DailyLimitPerSubject = 20;
    public const int SessionSize = 20;

    /// <summary>
    /// Které karty se opakují: probrané (Učení, Procvičování) a navíc ty, na které student chyboval
    /// (např. ve zkoušce nanečisto — ta kartu „neprobírá", chyby ale do opakování patří). Výraz jde přeložit do SQL.
    /// </summary>
    public static readonly System.Linq.Expressions.Expression<Func<Data.CardProgress, bool>> InPoolExpression =
        p => p.SeenAt != null || p.WrongCount > 0;

    private static readonly Func<Data.CardProgress, bool> InPoolCompiled = InPoolExpression.Compile();

    public static bool InPool(Data.CardProgress p) => InPoolCompiled(p);

    public static bool IsDue(ReviewCandidate c, DateOnly today) => c.DueDate <= today;

    /// <summary>Kolik karet předmětu lze dnes ještě opakovat v rámci denního limitu.</summary>
    public static int Available(int dueCount, int reviewedToday, int dailyLimit = DailyLimitPerSubject) =>
        Math.Max(0, Math.Min(dueCount, dailyLimit - reviewedToday));

    /// <summary>Priorita: poslední odpověď špatně → nejstarší splatnost → nižší krabice → pořadí v sylabu.</summary>
    public static IEnumerable<ReviewCandidate> Prioritize(IEnumerable<ReviewCandidate> cards) =>
        cards.OrderByDescending(c => c.LastResult == false)
            .ThenBy(c => c.DueDate)
            .ThenBy(c => c.Box)
            .ThenBy(c => c.TopicOrder)
            .ThenBy(c => c.CardOrder)
            .ThenBy(c => c.CardId);

    /// <summary>
    /// Karty jedné seance: splatné, seřazené podle priority, z každého předmětu nejvýš tolik,
    /// kolik zbývá z denního limitu (pokud student limit výslovně nepřekročí).
    /// </summary>
    public static IReadOnlyList<int> BuildSession(IEnumerable<ReviewCandidate> cards, DateOnly today,
        IReadOnlyDictionary<int, int> reviewedTodayBySubject, bool ignoreDailyLimit = false,
        int sessionSize = SessionSize, int dailyLimit = DailyLimitPerSubject)
    {
        var takenBySubject = new Dictionary<int, int>();
        var session = new List<int>();
        foreach (var c in Prioritize(cards.Where(c => IsDue(c, today))))
        {
            if (session.Count >= sessionSize) break;
            var taken = takenBySubject.GetValueOrDefault(c.SubjectId);
            if (!ignoreDailyLimit && reviewedTodayBySubject.GetValueOrDefault(c.SubjectId) + taken >= dailyLimit) continue;

            takenBySubject[c.SubjectId] = taken + 1;
            session.Add(c.CardId);
        }
        return session;
    }
}

/// <summary>
/// Horká fronta seance (BA §2.3 pravidlo 3): chybná karta se ještě v téže seanci vrátí na konec.
/// </summary>
public static class HotQueue
{
    /// <summary>Kolikrát nejvýš se chybná karta v jedné seanci vrátí — seance nesmí uvíznout ve smyčce.</summary>
    public const int MaxRepeatsPerCard = 2;

    /// <summary>Vrátit kartu na konec seance? Jen v Procvičování a Opakování (v Učení a zkoušce ne).</summary>
    public static bool ShouldRequeue(Data.StudyMode mode, bool isCorrect, int repeat) =>
        !isCorrect && mode is Data.StudyMode.Quiz or Data.StudyMode.Review && repeat < MaxRepeatsPerCard;

    /// <summary>
    /// Zopakování chyby v téže seanci kartu jen ověřuje: do vyšší krabice nepostoupí (zítra přijde znovu
    /// podle Leitnera), chyba ji ale dál vrací do krabice 1. Proto se opakování v Opakování hodnotí jako kvíz.
    /// </summary>
    public static Data.StudyMode EffectiveMode(Data.StudyMode mode, int repeat) =>
        repeat > 0 && mode == Data.StudyMode.Review ? Data.StudyMode.Quiz : mode;
}

public sealed record TopicProgress(int TopicId, int Order, int CardCount, int SeenCount)
{
    public bool IsFinished => SeenCount >= CardCount;
}

public enum ContinueKind { Learn, Practice }

public sealed record ContinueTarget(ContinueKind Kind, int TopicId);

/// <summary>„Pokračovat tam, kde jsi skončil" (BA §2.2 A).</summary>
public static class ContinueRule
{
    /// <summary>
    /// Nedokončené poslední téma → další neprobrané téma předmětu v pořadí sylabu (případně dřívější přeskočené)
    /// → všechno probráno: procvičit předmět.
    /// </summary>
    public static ContinueTarget Next(int lastTopicId, IReadOnlyList<TopicProgress> subjectTopics)
    {
        var last = subjectTopics.FirstOrDefault(t => t.TopicId == lastTopicId);
        if (last is { IsFinished: false }) return new ContinueTarget(ContinueKind.Learn, last.TopicId);

        var open = subjectTopics.Where(t => t.CardCount > 0 && !t.IsFinished).OrderBy(t => t.Order).ToList();
        var next = open.FirstOrDefault(t => last is null || t.Order > last.Order) ?? open.FirstOrDefault();
        return next is not null
            ? new ContinueTarget(ContinueKind.Learn, next.TopicId)
            : new ContinueTarget(ContinueKind.Practice, lastTopicId);
    }
}
