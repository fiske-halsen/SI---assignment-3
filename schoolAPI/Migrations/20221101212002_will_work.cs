using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace schoolAPI.Migrations
{
    public partial class will_work : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentStudyProgramme_Students_StudentsId",
                table: "StudentStudyProgramme");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentStudyProgramme_StudyProgrammes_StudyProgrammesId",
                table: "StudentStudyProgramme");

            migrationBuilder.RenameColumn(
                name: "StudyProgrammesId",
                table: "StudentStudyProgramme",
                newName: "StudyProgrammeId");

            migrationBuilder.RenameColumn(
                name: "StudentsId",
                table: "StudentStudyProgramme",
                newName: "StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentStudyProgramme_StudyProgrammesId",
                table: "StudentStudyProgramme",
                newName: "IX_StudentStudyProgramme_StudyProgrammeId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentStudyProgramme_Students_StudentId",
                table: "StudentStudyProgramme",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentStudyProgramme_StudyProgrammes_StudyProgrammeId",
                table: "StudentStudyProgramme",
                column: "StudyProgrammeId",
                principalTable: "StudyProgrammes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentStudyProgramme_Students_StudentId",
                table: "StudentStudyProgramme");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentStudyProgramme_StudyProgrammes_StudyProgrammeId",
                table: "StudentStudyProgramme");

            migrationBuilder.RenameColumn(
                name: "StudyProgrammeId",
                table: "StudentStudyProgramme",
                newName: "StudyProgrammesId");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "StudentStudyProgramme",
                newName: "StudentsId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentStudyProgramme_StudyProgrammeId",
                table: "StudentStudyProgramme",
                newName: "IX_StudentStudyProgramme_StudyProgrammesId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentStudyProgramme_Students_StudentsId",
                table: "StudentStudyProgramme",
                column: "StudentsId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentStudyProgramme_StudyProgrammes_StudyProgrammesId",
                table: "StudentStudyProgramme",
                column: "StudyProgrammesId",
                principalTable: "StudyProgrammes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
