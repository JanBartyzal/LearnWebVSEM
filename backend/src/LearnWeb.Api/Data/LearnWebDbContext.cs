using Microsoft.EntityFrameworkCore;

namespace LearnWeb.Api.Data;

public class LearnWebDbContext(DbContextOptions<LearnWebDbContext> options) : DbContext(options)
{
    public DbSet<Subject> Subjects => Set<Subject>();
    public DbSet<Topic> Topics => Set<Topic>();
    public DbSet<Card> Cards => Set<Card>();
    public DbSet<Question> Questions => Set<Question>();
    public DbSet<CardProgress> CardProgress => Set<CardProgress>();
    public DbSet<AttemptLog> AttemptLogs => Set<AttemptLog>();
    public DbSet<ExamResult> ExamResults => Set<ExamResult>();
    public DbSet<UserStats> UserStats => Set<UserStats>();
    public DbSet<ContentImport> ContentImports => Set<ContentImport>();

    protected override void OnModelCreating(ModelBuilder b)
    {
        b.Entity<Subject>(e =>
        {
            e.HasIndex(x => x.Slug).IsUnique();
            e.Property(x => x.Slug).HasMaxLength(100);
            e.Property(x => x.Name).HasMaxLength(300);
        });

        b.Entity<Topic>(e =>
        {
            e.HasIndex(x => new { x.SubjectId, x.Slug }).IsUnique();
            e.Property(x => x.Slug).HasMaxLength(100);
            e.Property(x => x.Name).HasMaxLength(300);
        });

        b.Entity<Card>(e =>
        {
            e.HasIndex(x => new { x.TopicId, x.Key }).IsUnique();
            e.Property(x => x.Key).HasMaxLength(100);
            e.Property(x => x.Type).HasConversion<string>().HasMaxLength(20);
        });

        b.Entity<Question>(e => e.HasIndex(x => new { x.CardId, x.Order }).IsUnique());

        b.Entity<CardProgress>(e =>
        {
            e.HasIndex(x => new { x.CardId, x.UserId }).IsUnique();
            e.HasIndex(x => new { x.UserId, x.DueDate });
        });

        b.Entity<AttemptLog>(e =>
        {
            e.Property(x => x.Mode).HasConversion<string>().HasMaxLength(20);
            e.HasIndex(x => new { x.UserId, x.AnsweredAt });
            // Historie se nemaže ani při změně obsahu.
            e.HasOne(x => x.Question).WithMany().OnDelete(DeleteBehavior.Restrict);
        });

        b.Entity<ExamResult>(e => e.Property(x => x.Breakdown).HasColumnType("jsonb"));

        b.Entity<UserStats>(e =>
        {
            e.HasKey(x => x.UserId);
            e.Property(x => x.UserId).ValueGeneratedNever();
        });
    }
}
