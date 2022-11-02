using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace schoolAPI.Migrations
{
    public partial class added_test_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StudyProgrammes",
                columns: new[] { "Id", "Name", "StudentId" },
                values: new object[,]
                {
                    { 1L, "System Integration", null },
                    { 2L, "Development of Large Systems", null },
                    { 3L, "Test", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
