using System.IO.Compression;
using System.Text;
using LearnWeb.Api.Data;
using Microsoft.EntityFrameworkCore;

namespace LearnWeb.Api.Content;

/// <summary>Záloha obsahu z DB do MD souborů (ZIP se stejnou strukturou jako složka content/).</summary>
public sealed class ContentExporter(LearnWebDbContext db)
{
    public async Task<IReadOnlyList<ContentFile>> ExportAsync(string? subjectSlug = null, CancellationToken ct = default)
    {
        var subjects = await db.Subjects.AsNoTracking()
            .Where(s => subjectSlug == null || s.Slug == subjectSlug)
            .Include(s => s.Topics).ThenInclude(t => t.Cards.Where(c => !c.IsArchived))
            .ThenInclude(c => c.Questions.Where(q => !q.IsArchived))
            .OrderBy(s => s.Order)
            .ToListAsync(ct);

        var files = new List<ContentFile>();
        foreach (var s in subjects)
        {
            var sd = ToDocument(s);
            files.Add(new ContentFile($"{s.Slug}/{sd.FileName}", MarkdownContentWriter.Write(sd)));
            foreach (var t in s.Topics.OrderBy(t => t.Order))
            {
                var td = ToDocument(s, t);
                files.Add(new ContentFile($"{s.Slug}/{td.FileName}", MarkdownContentWriter.Write(td)));
            }
        }
        return files;
    }

    public static SubjectDocument ToDocument(Subject s) =>
        new(MarkdownContentWriter.SubjectFileName, s.Slug, s.Name, s.Order, s.Goal);

    public static TopicDocument ToDocument(Subject s, Topic t) =>
        new(MarkdownContentWriter.TopicFileName(t.Order, t.Slug), s.Slug, t.Slug, t.Name, t.Order, t.Description,
            t.Cards.OrderBy(c => c.Order).Select(c => new CardDocument(c.Key, c.Type, c.Front, c.Back,
                c.Questions.OrderBy(q => q.Order)
                    .Select(q => new QuestionDocument(q.Text, q.Options, q.CorrectIndex, q.Explanation, 0)).ToList(),
                0)).ToList());

    public static byte[] Zip(IEnumerable<ContentFile> files)
    {
        using var ms = new MemoryStream();
        using (var zip = new ZipArchive(ms, ZipArchiveMode.Create, leaveOpen: true))
        {
            foreach (var f in files)
            {
                using var w = new StreamWriter(zip.CreateEntry(f.Name, CompressionLevel.Optimal).Open(), new UTF8Encoding(false));
                w.Write(f.Text);
            }
        }
        return ms.ToArray();
    }
}
