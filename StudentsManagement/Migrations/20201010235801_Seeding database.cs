using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentsManagement.Migrations
{
    public partial class Seedingdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class", "Email", "Faculty", "Name", "Surname" },
                values: new object[] { 1, "IIIA", "woj.tek@gmail.com", 1, "Wojciech", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
