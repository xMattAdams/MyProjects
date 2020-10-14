using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentsManagement.Migrations
{
    public partial class Creatingaccountwithphoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PicturePath",
                table: "Students",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PicturePath",
                table: "Students");
        }
    }
}
