using LearnWeb.Api.Data;
using LearnWeb.Api.Engine;

namespace LearnWeb.Tests;

public class LeitnerStrategyTests
{
    private static readonly DateOnly Today = new(2026, 10, 13);
    private static readonly DateTime Now = new(2026, 10, 13, 10, 0, 0, DateTimeKind.Utc);
    private readonly LeitnerStrategy _s = new();

    [Fact]
    public void Learned_card_goes_to_box_1_due_tomorrow()
    {
        var p = new CardProgress();
        _s.OnLearned(p, Today, Now);
        Assert.Equal((1, Today.AddDays(1)), (p.Box, p.DueDate));
        Assert.Equal(Now, p.SeenAt);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(2, 3, 4)]
    [InlineData(3, 4, 7)]
    [InlineData(4, 5, 14)]
    [InlineData(5, 5, 14)]
    public void Correct_review_advances_box(int box, int expectedBox, int expectedDays)
    {
        var p = new CardProgress { Box = box };
        _s.OnAnswered(p, StudyMode.Review, isCorrect: true, Today, Now);
        Assert.Equal((expectedBox, Today.AddDays(expectedDays), 1), (p.Box, p.DueDate, p.CorrectCount));
    }

    [Theory]
    [InlineData(StudyMode.Quiz)]
    [InlineData(StudyMode.Review)]
    [InlineData(StudyMode.Exam)]
    public void Wrong_answer_anywhere_resets_to_box_1(StudyMode mode)
    {
        var p = new CardProgress { Box = 4, DueDate = Today.AddDays(5) };
        _s.OnAnswered(p, mode, isCorrect: false, Today, Now);
        Assert.Equal((1, Today.AddDays(1), 1, false), (p.Box, p.DueDate, p.WrongCount, p.LastResult));
    }

    [Fact]
    public void Correct_quiz_answer_does_not_advance_box()
    {
        var p = new CardProgress { Box = 2, DueDate = Today.AddDays(1) };
        _s.OnAnswered(p, StudyMode.Quiz, isCorrect: true, Today, Now);
        Assert.Equal((2, Today.AddDays(1)), (p.Box, p.DueDate));
    }

    [Fact]
    public void Topic_mastery_weights_boxes_and_counts_unseen_cards_as_zero()
    {
        // (1.0 + 0.8 + 0.6 + 0) / 5 karet; pátá karta ještě nebyla probrána
        Assert.Equal(0.48, Mastery.ForTopic(5, [5, 4, 3, 1]), 3);
        Assert.Equal(0, Mastery.ForTopic(0, []));
    }

    [Fact]
    public void Subject_mastery_averages_topics_with_cards()
    {
        Assert.Equal(0.5, Mastery.ForSubject([(10, 0.8), (4, 0.2), (0, 0)]), 3);
    }
}
