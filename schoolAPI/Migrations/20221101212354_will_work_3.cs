using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace schoolAPI.Migrations
{
    public partial class will_work_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentStudyProgramme_Students_StudentId",
                table: "StudentStudyProgramme");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentStudyProgramme_StudyProgrammes_StudyProgrammeId",
                table: "StudentStudyProgramme");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentStudyProgramme",
                table: "StudentStudyProgramme");

            migrationBuilder.RenameTable(
                name: "StudentStudyProgramme",
                newName: "StudentStudyProgrammes");

            migrationBuilder.RenameIndex(
                name: "IX_StudentStudyProgramme_StudyProgrammeId",
                table: "StudentStudyProgrammes",
                newName: "IX_StudentStudyProgrammes_StudyProgrammeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentStudyProgrammes",
                table: "StudentStudyProgrammes",
                columns: new[] { "StudentId", "StudyProgrammeId" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Email", "Name" },
                values: new object[] { "dsd", "asd" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Email", "Name" },
                values: new object[] { "fsdff", "jeasdasdwadns" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Email", "Name" },
                values: new object[] { "asdasdfdsf", "sdfsdfasf" });

            migrationBuilder.AddForeignKey(
                name: "FK_StudentStudyProgrammes_Students_StudentId",
                table: "StudentStudyProgrammes",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentStudyProgrammes_StudyProgrammes_StudyProgrammeId",
                table: "StudentStudyProgrammes",
                column: "StudyProgrammeId",
                principalTable: "StudyProgrammes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentStudyProgrammes_Students_StudentId",
                table: "StudentStudyProgrammes");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentStudyProgrammes_StudyProgrammes_StudyProgrammeId",
                table: "StudentStudyProgrammes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentStudyProgrammes",
                table: "StudentStudyProgrammes");

            migrationBuilder.RenameTable(
                name: "StudentStudyProgrammes",
                newName: "StudentStudyProgramme");

            migrationBuilder.RenameIndex(
                name: "IX_StudentStudyProgrammes_StudyProgrammeId",
                table: "StudentStudyProgramme",
                newName: "IX_StudentStudyProgramme_StudyProgrammeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentStudyProgramme",
                table: "StudentStudyProgramme",
                columns: new[] { "StudentId", "StudyProgrammeId" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Email", "Name" },
                values: new object[] { "mail", "jens" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Email", "Name" },
                values: new object[] { "mail", "jens" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Email", "Name" },
                values: new object[] { "mail", "jens" });

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
    }
}
