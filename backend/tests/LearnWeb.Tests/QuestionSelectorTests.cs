using LearnWeb.Api.Engine;

namespace LearnWeb.Tests;

public class QuestionSelectorTests
{
    private static readonly DateOnly Today = new(2026, 10, 14);

    private static CandidateCard Weak(int id) => new(id, true, 1, Today.AddDays(1), 2, false);
    private static CandidateCard Due(int id) => new(id, true, 3, Today, 0, true);
    private static CandidateCard Fine(int id) => new(id, true, 4, Today.AddDays(5), 0, true);
    private static CandidateCard Unseen(int id) => new(id, false, 1, null, 0, null);

    [Fact]
    public void Respects_50_30_20_split_when_all_groups_are_large()
    {
        var cards = Enumerable.Range(0, 20).Select(Weak)
            .Concat(Enumerable.Range(100, 20).Select(Due))
            .Concat(Enumerable.Range(200, 20).Select(Fine))
            .ToList();

        var picked = QuestionSelector.SelectCards(cards, 10, Today, new Random(1));

        Assert.Equal(10, picked.Distinct().Count());
        Assert.Equal(5, picked.Count(id => id < 100));
        Assert.Equal(3, picked.Count(id => id is >= 100 and < 200));
        Assert.Equal(2, picked.Count(id => id >= 200));
    }

    [Fact]
    public void Fills_missing_quota_by_priority_and_uses_unseen_last()
    {
        var cards = new[] { Weak(1), Due(2), Fine(3) }.Concat(Enumerable.Range(10, 10).Select(Unseen)).ToList();

        var picked = QuestionSelector.SelectCards(cards, 5, Today, new Random(2));

        Assert.Equal(5, picked.Count);
        Assert.Contains(1, picked);
        Assert.Contains(2, picked);
        Assert.Contains(3, picked);
        Assert.Equal(2, picked.Count(id => id >= 10));
    }

    [Fact]
    public void Returns_all_cards_when_fewer_than_requested()
    {
        var picked = QuestionSelector.SelectCards([Unseen(1), Unseen(2)], 10, Today, new Random(3));
        Assert.Equal([1, 2], picked.Order());
    }

    [Fact]
    public void Weak_card_definition()
    {
        Assert.True(new CandidateCard(1, true, 4, Today, 1, false).IsWeak);   // poslední odpověď špatně
        Assert.True(new CandidateCard(1, true, 2, Today, 1, true).IsWeak);    // chybovaná v nízké krabici
        Assert.False(new CandidateCard(1, true, 3, Today, 1, true).IsWeak);   // chyba už vyřešena
        Assert.False(new CandidateCard(1, false, 1, null, 0, null).IsWeak);   // neprobraná
    }
}

public class GamificationTests
{
    [Theory]
    [InlineData(0, 1)]
    [InlineData(99, 1)]
    [InlineData(100, 2)]
    [InlineData(399, 2)]
    [InlineData(400, 3)]
    [InlineData(900, 4)]
    public void Level_follows_quadratic_curve(int xp, int level) => Assert.Equal(level, Gamification.Level(xp));

    [Fact]
    public void Answer_xp_depends_on_mode()
    {
        Assert.Equal(10, Gamification.XpForAnswer(LearnWeb.Api.Data.StudyMode.Quiz, true));
        Assert.Equal(15, Gamification.XpForAnswer(LearnWeb.Api.Data.StudyMode.Review, true));
        Assert.Equal(0, Gamification.XpForAnswer(LearnWeb.Api.Data.StudyMode.Review, false));
    }
}
