using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mirza_Andrei_Lab2.Migrations
{
    public partial class AuthorCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Author");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Author",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
