using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace schoolAPI.Migrations
{
    public partial class will_not_work : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudyProgrammes_Students_StudentId",
                table: "StudyProgrammes");

            migrationBuilder.DropIndex(
                name: "IX_StudyProgrammes_StudentId",
                table: "StudyProgrammes");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "StudyProgrammes");

            migrationBuilder.CreateTable(
                name: "StudentStudyProgramme",
                columns: table => new
                {
                    StudentsId = table.Column<long>(type: "bigint", nullable: false),
                    StudyProgrammesId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentStudyProgramme", x => new { x.StudentsId, x.StudyProgrammesId });
                    table.ForeignKey(
                        name: "FK_StudentStudyProgramme_Students_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentStudyProgramme_StudyProgrammes_StudyProgrammesId",
                        column: x => x.StudyProgrammesId,
                        principalTable: "StudyProgrammes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentStudyProgramme_StudyProgrammesId",
                table: "StudentStudyProgramme",
                column: "StudyProgrammesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentStudyProgramme");

            migrationBuilder.AddColumn<long>(
                name: "StudentId",
                table: "StudyProgrammes",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudyProgrammes_StudentId",
                table: "StudyProgrammes",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudyProgrammes_Students_StudentId",
                table: "StudyProgrammes",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");
        }
    }
}
