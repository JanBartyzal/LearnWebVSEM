using LearnWeb.Api.Engine;

namespace LearnWeb.Tests;

public class ExamComposerTests
{
    [Fact]
    public void Allocation_is_proportional_with_one_question_minimum()
    {
        var quota = ExamComposer.Allocate([40, 20, 10, 2], 20);

        Assert.Equal(20, quota.Sum());
        Assert.All(quota, q => Assert.True(q >= 1));
        Assert.True(quota[0] > quota[1] && quota[1] > quota[2]);
        Assert.True(quota[3] <= 2);
    }

    [Fact]
    public void More_topics_than_questions_prefers_largest_topics()
    {
        var quota = ExamComposer.Allocate([5, 30, 10, 20], 2);
        Assert.Equal([0, 1, 0, 1], quota);
    }

    [Fact]
    public void Allocation_never_exceeds_topic_size_and_skips_empty_topics()
    {
        var quota = ExamComposer.Allocate([1, 0, 3], 10);
        Assert.Equal([1, 0, 3], quota);
    }

    [Fact]
    public void Selects_distinct_cards_across_all_topics()
    {
        var cards = Enumerable.Range(0, 60).Select(i => new ExamCandidate(i, i % 6)).ToList();

        var picked = ExamComposer.SelectCards(cards, 25, new Random(7));

        Assert.Equal(25, picked.Distinct().Count());
        Assert.Equal(6, picked.Select(id => id % 6).Distinct().Count());
    }
}

public class ExamScoringTests
{
    [Fact]
    public void Breakdown_by_topic_weakest_first()
    {
        var score = ExamScoring.Evaluate([
            new ExamAnswer(1, true), new ExamAnswer(1, true), new ExamAnswer(2, false), new ExamAnswer(2, true),
            new ExamAnswer(3, false),
        ]);

        Assert.Equal(3, score.Correct);
        Assert.Equal(5, score.Total);
        Assert.Equal(60, score.Percent);
        Assert.Equal([3, 2, 1], score.Topics.Select(t => t.TopicId));
        Assert.Equal(new TopicScore(2, 1, 2), score.Topics[1]);
    }

    [Theory]
    [InlineData(17, 20, 85, 200)]
    [InlineData(24, 25, 96, 200)]
    [InlineData(21, 25, 84, 0)]
    public void Exam_bonus_from_85_percent(int correct, int total, int percent, int xp)
    {
        var score = new ExamScore(correct, total, []);
        Assert.Equal(percent, score.Percent);
        Assert.Equal(xp, Gamification.XpForExam(score.Percent));
    }
}

public class StreakTests
{
    private static readonly DateOnly Today = new(2026, 10, 15);
    private static DateOnly D(int daysAgo) => Today.AddDays(-daysAgo);

    [Fact]
    public void Counts_consecutive_days_ending_today()
    {
        Assert.Equal(new StreakInfo(3, 3, true), Streak.Compute([D(0), D(1), D(2), D(4)], Today));
    }

    [Fact]
    public void Today_not_started_yet_keeps_yesterdays_streak()
    {
        Assert.Equal(new StreakInfo(2, 2, false), Streak.Compute([D(1), D(2)], Today));
    }

    [Fact]
    public void Gap_breaks_streak_but_longest_is_kept()
    {
        Assert.Equal(new StreakInfo(0, 4, false), Streak.Compute([D(2), D(10), D(11), D(12), D(13)], Today));
    }

    [Fact]
    public void No_activity()
    {
        Assert.Equal(new StreakInfo(0, 0, false), Streak.Compute([], Today));
    }
}

public class BadgeTests
{
    [Fact]
    public void Earned_badges_by_thresholds()
    {
        var none = new BadgeContext(0, 6, 0.79, 89, 49);
        Assert.Empty(Badges.Earned(none));

        var all = new BadgeContext(1, 7, 0.8, 90, 50);
        Assert.Equal(Badges.All.Select(b => b.Code), Badges.Earned(all));
    }

    [Fact]
    public void Newly_earned_skips_owned_and_never_revokes()
    {
        var context = new BadgeContext(2, 0, 0, 95, 0);
        Assert.Equal(["exam-90"], Badges.NewlyEarned(context, ["first-topic", "streak-7"]));
    }
}
