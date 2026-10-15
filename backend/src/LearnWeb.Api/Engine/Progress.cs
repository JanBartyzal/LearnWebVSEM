namespace LearnWeb.Api.Engine;

public sealed record StreakInfo(int Current, int Longest, bool ActiveToday);

/// <summary>
/// Série dní (BA §2.4): den se počítá, když v něm student dokončí aspoň jednu seanci (Učení, Procvičování,
/// Opakování nebo zkoušku). Dnešek, který ještě nezačal, sérii nepřerušuje — počítá se od včerejška.
/// </summary>
public static class Streak
{
    public static StreakInfo Compute(IEnumerable<DateOnly> activeDays, DateOnly today)
    {
        var days = activeDays.Where(d => d <= today).ToHashSet();
        var activeToday = days.Contains(today);

        var current = 0;
        for (var d = activeToday ? today : today.AddDays(-1); days.Contains(d); d = d.AddDays(-1)) current++;

        var longest = 0;
        foreach (var start in days.Where(d => !days.Contains(d.AddDays(-1))))
        {
            var length = 0;
            for (var d = start; days.Contains(d); d = d.AddDays(1)) length++;
            longest = Math.Max(longest, length);
        }
        return new StreakInfo(current, longest, activeToday);
    }
}

public sealed record BadgeDefinition(string Code, string Name, string Description);

/// <summary>Údaje, ze kterých se odznaky vyhodnocují — počítá je StudyService z DB.</summary>
public sealed record BadgeContext(int CompletedTopics, int CurrentStreak, double BestSubjectMastery, int BestExamPercent,
    int CardsToday);

/// <summary>Odznaky (BA §2.4). Jen koření — nic se jimi neodemyká a nikdy se neodebírají.</summary>
public static class Badges
{
    public const int StreakDays = 7;
    public const double MasteredSubject = 0.8;
    public const int ExamPercent = 90;
    public const int CardsPerDay = 50;

    public static readonly IReadOnlyList<BadgeDefinition> All =
    [
        new("first-topic", "První téma", "Probral jsi všechny karty jednoho tématu."),
        new("streak-7", "7 dní v řadě", $"Učil ses {StreakDays} dní po sobě."),
        new("subject-mastered", "Předmět zvládnut", $"Zvládnutí předmětu dosáhlo {MasteredSubject * 100:0} %."),
        new("exam-90", "Zkouška nanečisto ≥ 90 %", $"Ve zkoušce nanečisto jsi měl aspoň {ExamPercent} %."),
        new("cards-50", "50 karet za den", $"Za jediný den jsi prošel aspoň {CardsPerDay} karet."),
    ];

    /// <summary>Kódy odznaků, které kontext splňuje.</summary>
    public static IReadOnlyList<string> Earned(BadgeContext c)
    {
        var earned = new List<string>();
        if (c.CompletedTopics >= 1) earned.Add("first-topic");
        if (c.CurrentStreak >= StreakDays) earned.Add("streak-7");
        if (c.BestSubjectMastery >= MasteredSubject) earned.Add("subject-mastered");
        if (c.BestExamPercent >= ExamPercent) earned.Add("exam-90");
        if (c.CardsToday >= CardsPerDay) earned.Add("cards-50");
        return earned;
    }

    /// <summary>Nově získané odznaky — už udělené se neopakují ani neodebírají.</summary>
    public static IReadOnlyList<string> NewlyEarned(BadgeContext c, IEnumerable<string> owned)
    {
        var have = owned.ToHashSet();
        return Earned(c).Where(code => !have.Contains(code)).ToList();
    }

    public static BadgeDefinition? Find(string code) => All.FirstOrDefault(b => b.Code == code);
}
