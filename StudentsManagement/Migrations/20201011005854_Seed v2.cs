using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentsManagement.Migrations
{
    public partial class Seedv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Class",
                table: "Students",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class", "Email", "Faculty", "Name", "Surname" },
                values: new object[] { 2, "IIIB", "ma.rek@gmail.com", 4, "Marek", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Class",
                table: "Students",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
