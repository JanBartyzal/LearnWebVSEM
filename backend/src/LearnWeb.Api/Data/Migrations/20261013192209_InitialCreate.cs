using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace LearnWeb.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "content_imports",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    imported_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    source = table.Column<string>(type: "text", nullable: false),
                    files = table.Column<List<string>>(type: "text[]", nullable: false),
                    summary = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_content_imports", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "subjects",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    slug = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    name = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    goal = table.Column<string>(type: "text", nullable: false),
                    order = table.Column<int>(type: "integer", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_subjects", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user_stats",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "integer", nullable: false),
                    xp = table.Column<int>(type: "integer", nullable: false),
                    streak_days = table.Column<int>(type: "integer", nullable: false),
                    last_active_date = table.Column<DateOnly>(type: "date", nullable: true),
                    badges = table.Column<List<string>>(type: "text[]", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_user_stats", x => x.user_id);
                });

            migrationBuilder.CreateTable(
                name: "exam_results",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    subject_id = table.Column<int>(type: "integer", nullable: false),
                    user_id = table.Column<int>(type: "integer", nullable: false),
                    score = table.Column<int>(type: "integer", nullable: false),
                    total = table.Column<int>(type: "integer", nullable: false),
                    breakdown = table.Column<string>(type: "jsonb", nullable: false),
                    started_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    finished_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_exam_results", x => x.id);
                    table.ForeignKey(
                        name: "fk_exam_results_subjects_subject_id",
                        column: x => x.subject_id,
                        principalTable: "subjects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "topics",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    subject_id = table.Column<int>(type: "integer", nullable: false),
                    slug = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    name = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    order = table.Column<int>(type: "integer", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_topics", x => x.id);
                    table.ForeignKey(
                        name: "fk_topics_subjects_subject_id",
                        column: x => x.subject_id,
                        principalTable: "subjects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cards",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    topic_id = table.Column<int>(type: "integer", nullable: false),
                    key = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    type = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    front = table.Column<string>(type: "text", nullable: false),
                    back = table.Column<string>(type: "text", nullable: false),
                    order = table.Column<int>(type: "integer", nullable: false),
                    is_archived = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cards", x => x.id);
                    table.ForeignKey(
                        name: "fk_cards_topics_topic_id",
                        column: x => x.topic_id,
                        principalTable: "topics",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "card_progress",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    card_id = table.Column<int>(type: "integer", nullable: false),
                    user_id = table.Column<int>(type: "integer", nullable: false),
                    box = table.Column<int>(type: "integer", nullable: false),
                    due_date = table.Column<DateOnly>(type: "date", nullable: false),
                    correct_count = table.Column<int>(type: "integer", nullable: false),
                    wrong_count = table.Column<int>(type: "integer", nullable: false),
                    last_result = table.Column<bool>(type: "boolean", nullable: true),
                    seen_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_card_progress", x => x.id);
                    table.ForeignKey(
                        name: "fk_card_progress_cards_card_id",
                        column: x => x.card_id,
                        principalTable: "cards",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "questions",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    card_id = table.Column<int>(type: "integer", nullable: false),
                    order = table.Column<int>(type: "integer", nullable: false),
                    text = table.Column<string>(type: "text", nullable: false),
                    options = table.Column<List<string>>(type: "text[]", nullable: false),
                    correct_index = table.Column<int>(type: "integer", nullable: false),
                    explanation = table.Column<string>(type: "text", nullable: false),
                    is_archived = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_questions", x => x.id);
                    table.ForeignKey(
                        name: "fk_questions_cards_card_id",
                        column: x => x.card_id,
                        principalTable: "cards",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "attempt_logs",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    question_id = table.Column<int>(type: "integer", nullable: false),
                    user_id = table.Column<int>(type: "integer", nullable: false),
                    mode = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    selected_index = table.Column<int>(type: "integer", nullable: false),
                    is_correct = table.Column<bool>(type: "boolean", nullable: false),
                    answered_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_attempt_logs", x => x.id);
                    table.ForeignKey(
                        name: "fk_attempt_logs_questions_question_id",
                        column: x => x.question_id,
                        principalTable: "questions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "ix_attempt_logs_question_id",
                table: "attempt_logs",
                column: "question_id");

            migrationBuilder.CreateIndex(
                name: "ix_attempt_logs_user_id_answered_at",
                table: "attempt_logs",
                columns: new[] { "user_id", "answered_at" });

            migrationBuilder.CreateIndex(
                name: "ix_card_progress_card_id_user_id",
                table: "card_progress",
                columns: new[] { "card_id", "user_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_card_progress_user_id_due_date",
                table: "card_progress",
                columns: new[] { "user_id", "due_date" });

            migrationBuilder.CreateIndex(
                name: "ix_cards_topic_id_key",
                table: "cards",
                columns: new[] { "topic_id", "key" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_exam_results_subject_id",
                table: "exam_results",
                column: "subject_id");

            migrationBuilder.CreateIndex(
                name: "ix_questions_card_id_order",
                table: "questions",
                columns: new[] { "card_id", "order" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_subjects_slug",
                table: "subjects",
                column: "slug",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_topics_subject_id_slug",
                table: "topics",
                columns: new[] { "subject_id", "slug" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "attempt_logs");

            migrationBuilder.DropTable(
                name: "card_progress");

            migrationBuilder.DropTable(
                name: "content_imports");

            migrationBuilder.DropTable(
                name: "exam_results");

            migrationBuilder.DropTable(
                name: "user_stats");

            migrationBuilder.DropTable(
                name: "questions");

            migrationBuilder.DropTable(
                name: "cards");

            migrationBuilder.DropTable(
                name: "topics");

            migrationBuilder.DropTable(
                name: "subjects");
        }
    }
}
