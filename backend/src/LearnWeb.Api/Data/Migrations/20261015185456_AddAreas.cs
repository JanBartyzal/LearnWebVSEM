using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace LearnWeb.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAreas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "area_id",
                table: "subjects",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "exam_minutes",
                table: "subjects",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "exam_pass_percent",
                table: "subjects",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "exam_questions",
                table: "subjects",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "areas",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    slug = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    name = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    order = table.Column<int>(type: "integer", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_areas", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "ix_subjects_area_id",
                table: "subjects",
                column: "area_id");

            migrationBuilder.CreateIndex(
                name: "ix_areas_slug",
                table: "areas",
                column: "slug",
                unique: true);

            // Dosavadní předměty patří pod oblast VŠEM (progress se nemění — identita předmětu je slug).
            // Na prázdné DB se oblast založí také; seed z content/ ji pak jen aktualizuje.
            migrationBuilder.Sql("""
                INSERT INTO areas (slug, name, description, "order", updated_at)
                VALUES ('vsem', 'VŠEM', '', 1, now());
                UPDATE subjects SET area_id = (SELECT id FROM areas WHERE slug = 'vsem');
                """);

            migrationBuilder.AddForeignKey(
                name: "fk_subjects_areas_area_id",
                table: "subjects",
                column: "area_id",
                principalTable: "areas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_subjects_areas_area_id",
                table: "subjects");

            migrationBuilder.DropTable(
                name: "areas");

            migrationBuilder.DropIndex(
                name: "ix_subjects_area_id",
                table: "subjects");

            migrationBuilder.DropColumn(
                name: "area_id",
                table: "subjects");

            migrationBuilder.DropColumn(
                name: "exam_minutes",
                table: "subjects");

            migrationBuilder.DropColumn(
                name: "exam_pass_percent",
                table: "subjects");

            migrationBuilder.DropColumn(
                name: "exam_questions",
                table: "subjects");
        }
    }
}
