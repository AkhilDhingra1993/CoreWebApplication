using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreWebApplication.Migrations
{
    public partial class Addphotopathcolumn1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photopath",
                table: "User");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Photopath",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
