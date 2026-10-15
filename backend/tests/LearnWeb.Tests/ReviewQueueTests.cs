using LearnWeb.Api.Data;
using LearnWeb.Api.Engine;

namespace LearnWeb.Tests;

public class ReviewQueueTests
{
    private static readonly DateOnly Today = new(2026, 10, 15);
    private static readonly Dictionary<int, int> NoneReviewed = [];

    private static ReviewCandidate Card(int id, int subject = 1, int box = 2, int dueInDays = 0, bool? last = true,
        int topicOrder = 1, int cardOrder = 1) =>
        new(id, subject, box, Today.AddDays(dueInDays), last, topicOrder, cardOrder);

    [Fact]
    public void Only_due_cards_enter_the_session()
    {
        var session = ReviewQueue.BuildSession([Card(1, dueInDays: -3), Card(2), Card(3, dueInDays: 1)], Today, NoneReviewed);
        Assert.Equal([1, 2], session);
    }

    [Fact]
    public void Mistakes_first_then_most_overdue_then_lower_box_then_syllabus_order()
    {
        var cards = new[]
        {
            Card(1, box: 1, dueInDays: 0, topicOrder: 2),
            Card(2, box: 4, dueInDays: -5),
            Card(3, box: 3, dueInDays: 0, last: false),
            Card(4, box: 1, dueInDays: 0, topicOrder: 1),
            Card(5, box: 2, dueInDays: -5),
        };

        var session = ReviewQueue.BuildSession(cards, Today, NoneReviewed);

        Assert.Equal([3, 5, 2, 4, 1], session);
    }

    [Fact]
    public void Daily_limit_per_subject_counts_cards_reviewed_earlier_today()
    {
        var cards = Enumerable.Range(1, 10).Select(i => Card(i, subject: 1))
            .Concat(Enumerable.Range(11, 10).Select(i => Card(i, subject: 2)))
            .ToList();
        var reviewed = new Dictionary<int, int> { [1] = 17 };

        var session = ReviewQueue.BuildSession(cards, Today, reviewed, dailyLimit: 20);

        Assert.Equal(3, session.Count(id => id <= 10));
        Assert.Equal(10, session.Count(id => id > 10));
    }

    [Fact]
    public void Limit_can_be_ignored_but_session_size_still_applies()
    {
        var cards = Enumerable.Range(1, 30).Select(i => Card(i)).ToList();
        var reviewed = new Dictionary<int, int> { [1] = 20 };

        Assert.Empty(ReviewQueue.BuildSession(cards, Today, reviewed));
        Assert.Equal(20, ReviewQueue.BuildSession(cards, Today, reviewed, ignoreDailyLimit: true).Count);
    }

    [Theory]
    [InlineData(35, 0, 20)]
    [InlineData(35, 12, 8)]
    [InlineData(5, 12, 5)]
    [InlineData(35, 25, 0)]
    [InlineData(0, 0, 0)]
    public void Available_respects_due_count_and_remaining_limit(int due, int reviewedToday, int expected) =>
        Assert.Equal(expected, ReviewQueue.Available(due, reviewedToday));
}

public class HotQueueTests
{
    [Theory]
    [InlineData(StudyMode.Review, false, 0, true)]
    [InlineData(StudyMode.Quiz, false, 1, true)]
    [InlineData(StudyMode.Review, false, HotQueue.MaxRepeatsPerCard, false)]
    [InlineData(StudyMode.Review, true, 0, false)]
    [InlineData(StudyMode.Learn, false, 0, false)]
    [InlineData(StudyMode.Exam, false, 0, false)]
    public void Requeues_only_wrong_answers_in_quiz_and_review_up_to_limit(StudyMode mode, bool correct, int repeat, bool expected) =>
        Assert.Equal(expected, HotQueue.ShouldRequeue(mode, correct, repeat));

    [Fact]
    public void Repeat_in_review_does_not_promote_box_but_mistake_still_resets()
    {
        var strategy = new LeitnerStrategy();
        var today = new DateOnly(2026, 10, 15);
        var p = new CardProgress { Box = 1, DueDate = today, SeenAt = DateTime.UtcNow };

        strategy.OnAnswered(p, HotQueue.EffectiveMode(StudyMode.Review, repeat: 1), isCorrect: true, today, DateTime.UtcNow);
        Assert.Equal(1, p.Box);

        p.Box = 3;
        strategy.OnAnswered(p, HotQueue.EffectiveMode(StudyMode.Review, repeat: 1), isCorrect: false, today, DateTime.UtcNow);
        Assert.Equal(1, p.Box);
        Assert.Equal(today.AddDays(1), p.DueDate);

        Assert.Equal(StudyMode.Review, HotQueue.EffectiveMode(StudyMode.Review, repeat: 0));
    }
}

public class ContinueRuleTests
{
    private static TopicProgress T(int id, int order, int cards, int seen) => new(id, order, cards, seen);

    [Fact]
    public void Continues_unfinished_last_topic()
    {
        var target = ContinueRule.Next(2, [T(1, 1, 10, 3), T(2, 2, 10, 4), T(3, 3, 10, 0)]);
        Assert.Equal(new ContinueTarget(ContinueKind.Learn, 2), target);
    }

    [Fact]
    public void Moves_to_next_open_topic_in_syllabus_order()
    {
        var target = ContinueRule.Next(2, [T(1, 1, 10, 3), T(2, 2, 10, 10), T(3, 3, 0, 0), T(4, 4, 10, 0)]);
        Assert.Equal(new ContinueTarget(ContinueKind.Learn, 4), target);
    }

    [Fact]
    public void Falls_back_to_earlier_skipped_topic()
    {
        var target = ContinueRule.Next(3, [T(1, 1, 10, 3), T(2, 2, 10, 10), T(3, 3, 10, 10)]);
        Assert.Equal(new ContinueTarget(ContinueKind.Learn, 1), target);
    }

    [Fact]
    public void Everything_learned_means_practice()
    {
        var target = ContinueRule.Next(2, [T(1, 1, 10, 10), T(2, 2, 10, 10)]);
        Assert.Equal(new ContinueTarget(ContinueKind.Practice, 2), target);
    }
}
