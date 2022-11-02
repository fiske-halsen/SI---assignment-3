using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace schoolAPI.Migrations
{
    public partial class will_work_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "StudyProgrammes",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "StudyProgrammes",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "StudyProgrammes",
                keyColumn: "Id",
                keyValue: 3L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[,]
                {
                    { 1L, "dsd", "asd" },
                    { 2L, "fsdff", "jeasdasdwadns" },
                    { 3L, "asdasdfdsf", "sdfsdfasf" }
                });

            migrationBuilder.InsertData(
                table: "StudyProgrammes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1L, "System Integration" },
                    { 2L, "Development of Large Systems" },
                    { 3L, "Test" }
                });
        }
    }
}
