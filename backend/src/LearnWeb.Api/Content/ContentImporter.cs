using System.IO.Compression;
using System.Text;
using LearnWeb.Api.Data;
using Microsoft.EntityFrameworkCore;

namespace LearnWeb.Api.Content;

public sealed record ContentFile(string Name, string Text);

public sealed class ImportCounts
{
    public int AreasCreated { get; set; }
    public int AreasUpdated { get; set; }
    public int SubjectsCreated { get; set; }
    public int SubjectsUpdated { get; set; }
    public int TopicsCreated { get; set; }
    public int TopicsUpdated { get; set; }
    public int CardsCreated { get; set; }
    public int CardsUpdated { get; set; }
    public int CardsArchived { get; set; }
    public int QuestionsCreated { get; set; }
    public int QuestionsUpdated { get; set; }
    public int QuestionsArchived { get; set; }

    public override string ToString() =>
        $"oblasti +{AreasCreated}/~{AreasUpdated}, předměty +{SubjectsCreated}/~{SubjectsUpdated}, témata +{TopicsCreated}/~{TopicsUpdated}, " +
        $"karty +{CardsCreated}/~{CardsUpdated}/-{CardsArchived}, otázky +{QuestionsCreated}/~{QuestionsUpdated}/-{QuestionsArchived}";
}

public sealed record ImportReport(bool Applied, bool DryRun, int FileCount, IReadOnlyList<ContentIssue> Issues, ImportCounts Counts);

/// <summary>
/// Import MD obsahu do DB. Idempotentní upsert: předmět dle slugu, téma dle (předmět, slug),
/// karta dle (téma, klíč), otázka dle (karta, pořadí). Nic se nemaže — co ze souboru zmizí,
/// archivuje se, aby se neztratil progress ani historie odpovědí.
/// Téma, které v importu chybí, zůstává beze změny (lze nahrát jen jeden soubor).
/// </summary>
public sealed class ContentImporter(LearnWebDbContext db, TimeProvider clock)
{
    public static IEnumerable<ContentFile> ReadUpload(string fileName, Stream stream)
    {
        if (!fileName.EndsWith(".zip", StringComparison.OrdinalIgnoreCase))
        {
            using var reader = new StreamReader(stream, Encoding.UTF8);
            yield return new ContentFile(fileName, reader.ReadToEnd());
            yield break;
        }

        using var zip = new ZipArchive(stream, ZipArchiveMode.Read);
        foreach (var entry in zip.Entries.Where(e => IsContentFile(e.FullName)))
        {
            using var reader = new StreamReader(entry.Open(), Encoding.UTF8);
            yield return new ContentFile(entry.FullName, reader.ReadToEnd());
        }
    }

    public static IEnumerable<ContentFile> ReadDirectory(string root) =>
        Directory.EnumerateFiles(root, "*.md", SearchOption.AllDirectories)
            .Where(IsContentFile)
            .Order(StringComparer.Ordinal)
            .Select(p => new ContentFile(Path.GetRelativePath(root, p).Replace('\\', '/'), File.ReadAllText(p, Encoding.UTF8)));

    private static bool IsContentFile(string path) =>
        path.EndsWith(".md", StringComparison.OrdinalIgnoreCase)
        && !Path.GetFileName(path).Equals("README.md", StringComparison.OrdinalIgnoreCase);

    public async Task<ImportReport> ImportAsync(IReadOnlyList<ContentFile> files, string source, bool dryRun, CancellationToken ct = default)
    {
        var counts = new ImportCounts();
        var issues = new List<ContentIssue>();
        var docs = new List<ContentDocument>();

        foreach (var f in files)
        {
            var r = MarkdownContentParser.Parse(f.Name, f.Text);
            issues.AddRange(r.Issues);
            if (r.Document is not null) docs.Add(r.Document);
        }

        var areas = docs.OfType<AreaDocument>().ToList();
        var subjects = docs.OfType<SubjectDocument>().ToList();
        var topics = docs.OfType<TopicDocument>().ToList();

        foreach (var dup in areas.GroupBy(a => a.Slug).Where(g => g.Count() > 1))
            issues.Add(new ContentIssue(dup.Last().FileName, 1, $"Oblast '{dup.Key}' je v importu vícekrát."));
        foreach (var dup in subjects.GroupBy(s => s.Slug).Where(g => g.Count() > 1))
            issues.Add(new ContentIssue(dup.Last().FileName, 1, $"Předmět '{dup.Key}' je v importu vícekrát."));
        foreach (var dup in topics.GroupBy(t => (t.SubjectSlug, t.Slug)).Where(g => g.Count() > 1))
            issues.Add(new ContentIssue(dup.Last().FileName, 1, $"Téma '{dup.Key.Slug}' předmětu '{dup.Key.SubjectSlug}' je v importu vícekrát."));

        var slugs = subjects.Select(s => s.Slug).Concat(topics.Select(t => t.SubjectSlug)).Distinct().ToList();
        var existing = await db.Subjects.Where(s => slugs.Contains(s.Slug)).ToDictionaryAsync(s => s.Slug, ct);

        foreach (var t in topics.Where(t => !existing.ContainsKey(t.SubjectSlug) && subjects.All(s => s.Slug != t.SubjectSlug)))
            issues.Add(new ContentIssue(t.FileName, 1,
                $"Předmět '{t.SubjectSlug}' neexistuje — nahrajte i jeho soubor _predmet.md."));

        var areaSlugs = areas.Select(a => a.Slug).Concat(subjects.Select(s => s.AreaSlug)).Distinct().ToList();
        var existingAreas = await db.Areas.Where(a => areaSlugs.Contains(a.Slug)).ToDictionaryAsync(a => a.Slug, ct);
        foreach (var s in subjects.Where(s => !existingAreas.ContainsKey(s.AreaSlug) && areas.All(a => a.Slug != s.AreaSlug)))
            issues.Add(new ContentIssue(s.FileName, 1,
                $"Oblast '{s.AreaSlug}' neexistuje — nahrajte i její soubor _oblast.md."));

        if (issues.Any(i => i.IsError))
            return new ImportReport(false, dryRun, files.Count, issues, counts);

        var now = clock.GetUtcNow().UtcDateTime;
        await using var tx = await db.Database.BeginTransactionAsync(ct);

        foreach (var a in areas)
        {
            if (!existingAreas.TryGetValue(a.Slug, out var area))
            {
                area = new Area { Slug = a.Slug, Name = a.Name };
                db.Areas.Add(area);
                existingAreas[a.Slug] = area;
                counts.AreasCreated++;
            }
            else if (area.Name != a.Name || area.Description != a.Description || area.Order != a.Order)
            {
                counts.AreasUpdated++;
            }
            else continue;

            area.Name = a.Name;
            area.Description = a.Description;
            area.Order = a.Order;
            area.UpdatedAt = now;
        }
        await db.SaveChangesAsync(ct);

        foreach (var s in subjects)
        {
            var area = existingAreas[s.AreaSlug];
            if (!existing.TryGetValue(s.Slug, out var entity))
            {
                entity = new Subject { Slug = s.Slug, Name = s.Name };
                db.Subjects.Add(entity);
                existing[s.Slug] = entity;
                counts.SubjectsCreated++;
            }
            else if (entity.Name != s.Name || entity.Goal != s.Goal || entity.Order != s.Order || entity.AreaId != area.Id
                     || entity.ExamQuestions != s.Exam?.Questions || entity.ExamMinutes != s.Exam?.Minutes
                     || entity.ExamPassPercent != s.Exam?.PassPercent)
            {
                counts.SubjectsUpdated++;
            }
            else continue;

            entity.Area = area;
            entity.Name = s.Name;
            entity.Goal = s.Goal;
            entity.Order = s.Order;
            entity.ExamQuestions = s.Exam?.Questions;
            entity.ExamMinutes = s.Exam?.Minutes;
            entity.ExamPassPercent = s.Exam?.PassPercent;
            entity.UpdatedAt = now;
        }
        await db.SaveChangesAsync(ct);

        foreach (var t in topics)
            await UpsertTopicAsync(existing[t.SubjectSlug], t, counts, now, ct);

        db.ContentImports.Add(new ContentImport
        {
            ImportedAt = now,
            Source = source,
            Files = files.Select(f => f.Name).ToList(),
            Summary = counts.ToString(),
        });
        await db.SaveChangesAsync(ct);

        if (dryRun) await tx.RollbackAsync(ct);
        else await tx.CommitAsync(ct);

        db.ChangeTracker.Clear();
        return new ImportReport(!dryRun, dryRun, files.Count, issues, counts);
    }

    private async Task UpsertTopicAsync(Subject subject, TopicDocument doc, ImportCounts counts, DateTime now, CancellationToken ct)
    {
        var topic = await db.Topics
            .Include(t => t.Cards).ThenInclude(c => c.Questions)
            .SingleOrDefaultAsync(t => t.SubjectId == subject.Id && t.Slug == doc.Slug, ct);

        if (topic is null)
        {
            topic = new Topic { Subject = subject, Slug = doc.Slug, Name = doc.Name };
            db.Topics.Add(topic);
            counts.TopicsCreated++;
        }
        else if (topic.Name != doc.Name || topic.Description != doc.Description || topic.Order != doc.Order)
        {
            counts.TopicsUpdated++;
        }

        topic.Name = doc.Name;
        topic.Description = doc.Description;
        topic.Order = doc.Order;
        topic.UpdatedAt = now;

        var cardsByKey = topic.Cards.ToDictionary(c => c.Key);
        for (var i = 0; i < doc.Cards.Count; i++)
        {
            var cd = doc.Cards[i];
            if (!cardsByKey.TryGetValue(cd.Key, out var card))
            {
                card = new Card { Key = cd.Key, Front = cd.Front, Back = cd.Back };
                topic.Cards.Add(card);
                counts.CardsCreated++;
            }
            else if (card.Type != cd.Type || card.Front != cd.Front || card.Back != cd.Back || card.Order != i + 1 || card.IsArchived)
            {
                counts.CardsUpdated++;
            }

            card.Type = cd.Type;
            card.Front = cd.Front;
            card.Back = cd.Back;
            card.Order = i + 1;
            card.IsArchived = false;
            UpsertQuestions(card, cd, counts);
        }

        var keys = doc.Cards.Select(c => c.Key).ToHashSet();
        foreach (var gone in topic.Cards.Where(c => !c.IsArchived && !keys.Contains(c.Key)))
        {
            gone.IsArchived = true;
            counts.CardsArchived++;
        }

        await db.SaveChangesAsync(ct);
    }

    private static void UpsertQuestions(Card card, CardDocument doc, ImportCounts counts)
    {
        var byOrder = card.Questions.ToDictionary(q => q.Order);
        for (var i = 0; i < doc.Questions.Count; i++)
        {
            var qd = doc.Questions[i];
            if (!byOrder.TryGetValue(i + 1, out var q))
            {
                q = new Question { Order = i + 1, Text = qd.Text };
                card.Questions.Add(q);
                counts.QuestionsCreated++;
            }
            else if (q.Text != qd.Text || !q.Options.SequenceEqual(qd.Options) || q.CorrectIndex != qd.CorrectIndex
                     || q.Explanation != qd.Explanation || q.IsArchived)
            {
                counts.QuestionsUpdated++;
            }

            q.Text = qd.Text;
            q.Options = qd.Options.ToList();
            q.CorrectIndex = qd.CorrectIndex;
            q.Explanation = qd.Explanation;
            q.IsArchived = false;
        }

        foreach (var gone in card.Questions.Where(q => !q.IsArchived && q.Order > doc.Questions.Count))
        {
            gone.IsArchived = true;
            counts.QuestionsArchived++;
        }
    }
}
