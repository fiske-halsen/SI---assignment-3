using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace schoolAPI.Migrations
{
    public partial class Done : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentStudyProgrammes",
                keyColumns: new[] { "StudentId", "StudyProgrammeId" },
                keyValues: new object[] { 1L, 1L });

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
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "StudyProgrammes",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "StudyProgrammes",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "StudyProgrammes",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "StudyProgrammeId",
                table: "StudentStudyProgrammes",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "StudentStudyProgrammes",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Students",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[,]
                {
                    { 1, "Phillip@gmail.com", "Phillip" },
                    { 2, "Lukas@gmail.com", "Lukas" },
                    { 3, "Christoffer@gmail.com", "Christoffer" }
                });

            migrationBuilder.InsertData(
                table: "StudyProgrammes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "System Integration" },
                    { 2, "Development of Large Systems" },
                    { 3, "Test" }
                });

            migrationBuilder.InsertData(
                table: "StudentStudyProgrammes",
                columns: new[] { "StudentId", "StudyProgrammeId" },
                values: new object[] { 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentStudyProgrammes",
                keyColumns: new[] { "StudentId", "StudyProgrammeId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StudyProgrammes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StudyProgrammes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StudyProgrammes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "StudyProgrammes",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<long>(
                name: "StudyProgrammeId",
                table: "StudentStudyProgrammes",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "StudentId",
                table: "StudentStudyProgrammes",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Students",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[,]
                {
                    { 1L, "Phillip@gmail.com", "Phillip" },
                    { 2L, "Lukas@gmail.com", "Lukas" },
                    { 3L, "Christoffer@gmail.com", "Christoffer" }
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

            migrationBuilder.InsertData(
                table: "StudentStudyProgrammes",
                columns: new[] { "StudentId", "StudyProgrammeId" },
                values: new object[] { 1L, 1L });
        }
    }
}
