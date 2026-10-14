using LearnWeb.Api.Data;
using LearnWeb.Api.Engine;
using Microsoft.EntityFrameworkCore;

namespace LearnWeb.Api.Study;

public sealed record QuizRequest(int? TopicId = null, string? SubjectSlug = null, IReadOnlyList<int>? CardIds = null,
    StudyMode Mode = StudyMode.Quiz, int Count = 10);

public sealed record QuizOption(int Index, string Text);

/// <summary>Otázka bez prozrazení správné odpovědi; možnosti jsou zamíchané, `Index` je původní pořadí.</summary>
public sealed record QuizQuestion(int QuestionId, int CardId, string CardFront, string TopicName, string Text,
    IReadOnlyList<QuizOption> Options);

public sealed record AnswerRequest(int QuestionId, int SelectedIndex, StudyMode Mode);

public sealed record AnsweredCard(int Id, string Type, string Front, string Back);

public sealed record AnswerResult(bool IsCorrect, int CorrectIndex, string Explanation, int XpGained, int TotalXp,
    bool Reteach, int Box, AnsweredCard Card);

public sealed record LearnedResult(int XpGained, int TotalXp, bool TopicCompleted);

public sealed record StatsSummary(int Xp, int Level, int LevelStartXp, int NextLevelXp);

/// <summary>
/// Jediné místo, které mění stav studenta (CardProgress, AttemptLog, UserStats).
/// Pravidla jsou v Engine/ — tady je jen načtení dat, volání pravidel a uložení.
/// </summary>
public sealed class StudyService(LearnWebDbContext db, IRepetitionStrategy strategy, TimeProvider clock)
{
    // MVP: jeden uživatel. Až přibude autentizace, přijde z identity requestu.
    public const int UserId = 1;

    public const int RepeatedMistakesForReteach = 3;
    public const int MaxQuizCount = 50;

    private DateTime Now => clock.GetUtcNow().UtcDateTime;
    private DateOnly Today => DateOnly.FromDateTime(clock.GetLocalNow().DateTime);

    public async Task<IReadOnlyList<QuizQuestion>> BuildQuizAsync(QuizRequest req, CancellationToken ct)
    {
        var query = db.Cards.AsNoTracking().Where(c => !c.IsArchived && c.Questions.Any(q => !q.IsArchived));
        if (req.CardIds is { Count: > 0 }) query = query.Where(c => req.CardIds.Contains(c.Id));
        if (req.TopicId is { } topicId) query = query.Where(c => c.TopicId == topicId);
        if (req.SubjectSlug is { } slug) query = query.Where(c => c.Topic.Subject.Slug == slug);

        var candidates = await query
            .Select(c => new
            {
                c.Id,
                Progress = db.CardProgress.Where(p => p.CardId == c.Id && p.UserId == UserId).FirstOrDefault(),
            })
            .ToListAsync(ct);

        var cards = candidates.Select(c => c.Progress is { } p
                ? new CandidateCard(c.Id, p.SeenAt != null, p.Box, p.DueDate, p.WrongCount, p.LastResult)
                : new CandidateCard(c.Id, false, LeitnerStrategy.MinBox, null, 0, null))
            .ToList();

        var rng = Random.Shared;
        var selected = QuestionSelector.SelectCards(cards, Math.Clamp(req.Count, 1, MaxQuizCount), Today, rng);

        var details = await db.Cards.AsNoTracking()
            .Where(c => selected.Contains(c.Id))
            .Select(c => new
            {
                c.Id,
                c.Front,
                TopicName = c.Topic.Name,
                Questions = c.Questions.Where(q => !q.IsArchived)
                    .Select(q => new { q.Id, q.Text, q.Options }).ToList(),
            })
            .ToDictionaryAsync(c => c.Id, ct);

        return selected.Select(id =>
        {
            var c = details[id];
            var q = c.Questions[rng.Next(c.Questions.Count)];
            var options = q.Options.Select((text, i) => new QuizOption(i, text)).ToArray();
            rng.Shuffle(options);
            return new QuizQuestion(q.Id, c.Id, c.Front, c.TopicName, q.Text, options);
        }).ToList();
    }

    public async Task<AnswerResult?> AnswerAsync(AnswerRequest req, CancellationToken ct)
    {
        var question = await db.Questions.Include(q => q.Card)
            .SingleOrDefaultAsync(q => q.Id == req.QuestionId, ct);
        if (question is null || req.SelectedIndex < 0 || req.SelectedIndex >= question.Options.Count) return null;

        var isCorrect = req.SelectedIndex == question.CorrectIndex;
        var progress = await GetOrCreateProgressAsync(question.CardId, ct);
        strategy.OnAnswered(progress, req.Mode, isCorrect, Today, Now);

        db.AttemptLogs.Add(new AttemptLog
        {
            QuestionId = question.Id,
            UserId = UserId,
            Mode = req.Mode,
            SelectedIndex = req.SelectedIndex,
            IsCorrect = isCorrect,
            AnsweredAt = Now,
        });

        var stats = await GetOrCreateStatsAsync(ct);
        var xp = Gamification.XpForAnswer(req.Mode, isCorrect);
        stats.Xp += xp;

        await db.SaveChangesAsync(ct);

        var c = question.Card;
        return new AnswerResult(isCorrect, question.CorrectIndex, question.Explanation, xp, stats.Xp,
            Reteach: !isCorrect && progress.WrongCount >= RepeatedMistakesForReteach, progress.Box,
            new AnsweredCard(c.Id, c.Type.ToString().ToLowerInvariant(), c.Front, c.Back));
    }

    /// <summary>Karta probrána v režimu Učení. Opakované označení je bez efektu (XP jen poprvé).</summary>
    public async Task<LearnedResult?> MarkLearnedAsync(int cardId, CancellationToken ct)
    {
        var card = await db.Cards.SingleOrDefaultAsync(c => c.Id == cardId && !c.IsArchived, ct);
        if (card is null) return null;

        var progress = await GetOrCreateProgressAsync(cardId, ct);
        var stats = await GetOrCreateStatsAsync(ct);
        if (progress.SeenAt is not null) return new LearnedResult(0, stats.Xp, false);

        strategy.OnLearned(progress, Today, Now);
        var xp = Gamification.XpCardLearned;
        await db.SaveChangesAsync(ct);

        // Téma je dokončené ve chvíli, kdy je probrána poslední jeho karta.
        var unseenInTopic = await db.Cards.CountAsync(c => c.TopicId == card.TopicId && !c.IsArchived
            && !db.CardProgress.Any(p => p.CardId == c.Id && p.UserId == UserId && p.SeenAt != null), ct);
        var topicCompleted = unseenInTopic == 0;
        if (topicCompleted) xp += Gamification.XpTopicCompleted;

        stats.Xp += xp;
        await db.SaveChangesAsync(ct);
        return new LearnedResult(xp, stats.Xp, topicCompleted);
    }

    public async Task<StatsSummary> SummaryAsync(CancellationToken ct)
    {
        var xp = await db.UserStats.Where(s => s.UserId == UserId).Select(s => s.Xp).FirstOrDefaultAsync(ct);
        var level = Gamification.Level(xp);
        return new StatsSummary(xp, level, Gamification.XpForLevel(level), Gamification.XpForLevel(level + 1));
    }

    private async Task<CardProgress> GetOrCreateProgressAsync(int cardId, CancellationToken ct)
    {
        var p = await db.CardProgress.SingleOrDefaultAsync(x => x.CardId == cardId && x.UserId == UserId, ct);
        if (p is not null) return p;

        p = new CardProgress { CardId = cardId, UserId = UserId, Box = LeitnerStrategy.MinBox, DueDate = Today };
        db.CardProgress.Add(p);
        return p;
    }

    private async Task<UserStats> GetOrCreateStatsAsync(CancellationToken ct)
    {
        var s = await db.UserStats.SingleOrDefaultAsync(x => x.UserId == UserId, ct);
        if (s is not null) return s;

        s = new UserStats { UserId = UserId };
        db.UserStats.Add(s);
        return s;
    }
}
