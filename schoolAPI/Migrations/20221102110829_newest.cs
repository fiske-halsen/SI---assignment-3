using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace schoolAPI.Migrations
{
    public partial class newest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Email", "Name" },
                values: new object[] { "Phillip@gmail.com", "Phillip" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Email", "Name" },
                values: new object[] { "Lukas@gmail.com", "Lukas" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Email", "Name" },
                values: new object[] { "Christoffer@gmail.com", "Christoffer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
