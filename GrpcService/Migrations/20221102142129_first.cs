using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GrpcService.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Subject = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Author = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsAvailable = table.Column<bool>(type: "boolean", nullable: false),
                    StudyProgrammeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookStudentOrders",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "integer", nullable: false),
                    StudentId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookStudentOrders", x => new { x.StudentId, x.BookId });
                    table.ForeignKey(
                        name: "FK_BookStudentOrders_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "IsAvailable", "Price", "ReleaseDate", "StudyProgrammeId", "Subject", "Title" },
                values: new object[,]
                {
                    { 1, "TestAuthor1", true, 200.0, new DateTime(2022, 11, 2, 14, 21, 29, 151, DateTimeKind.Utc).AddTicks(1391), 1, "System integration", "Enterprise integration patterns" },
                    { 2, "TestAuthor2", true, 300.0, new DateTime(2022, 11, 2, 14, 21, 29, 151, DateTimeKind.Utc).AddTicks(1393), 1, "System integration", "Soa" },
                    { 3, "TestAuthor3", true, 200.0, new DateTime(2022, 11, 2, 14, 21, 29, 151, DateTimeKind.Utc).AddTicks(1394), 2, "Development of large systems", "Guide to CI/CD" },
                    { 4, "TestAuthor4", true, 350.0, new DateTime(2022, 11, 2, 14, 21, 29, 151, DateTimeKind.Utc).AddTicks(1395), 2, "Development of large systems", "Guide to Git flow" },
                    { 5, "TestAuthor5", true, 150.0, new DateTime(2022, 11, 2, 14, 21, 29, 151, DateTimeKind.Utc).AddTicks(1396), 3, "Test", "Unit testing" },
                    { 6, "TestAuthor6", true, 350.0, new DateTime(2022, 11, 2, 14, 21, 29, 151, DateTimeKind.Utc).AddTicks(1397), 3, "Test", "Integration testing" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookStudentOrders_BookId",
                table: "BookStudentOrders",
                column: "BookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookStudentOrders");

            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
