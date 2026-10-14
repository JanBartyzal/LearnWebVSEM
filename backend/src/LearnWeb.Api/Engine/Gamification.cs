namespace LearnWeb.Api.Engine;

/// <summary>XP a úrovně (BA §2.4). Jen jako koření — jádro je fronta opakování.</summary>
public static class Gamification
{
    public const int XpCardLearned = 5;
    public const int XpCorrectAnswer = 10;
    public const int XpCorrectReview = 15;
    public const int XpTopicCompleted = 50;
    public const int XpExamPassed = 200;

    public static int XpForAnswer(Data.StudyMode mode, bool isCorrect) =>
        !isCorrect ? 0 : mode == Data.StudyMode.Review ? XpCorrectReview : XpCorrectAnswer;

    /// <summary>Celkové XP potřebné k dosažení úrovně: 100 · (n−1)² (1 → 0, 2 → 100, 3 → 400, 4 → 900…).</summary>
    public static int XpForLevel(int level) => 100 * (level - 1) * (level - 1);

    public static int Level(int xp)
    {
        var level = 1 + (int)Math.Floor(Math.Sqrt(Math.Max(xp, 0) / 100.0));
        // Ochrana proti chybě zaokrouhlení u hranic.
        while (XpForLevel(level + 1) <= xp) level++;
        while (level > 1 && XpForLevel(level) > xp) level--;
        return level;
    }
}
