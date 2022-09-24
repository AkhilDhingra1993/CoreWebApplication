using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreWebApplication.Migrations
{
    public partial class Addphotopathcolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Photopath",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photopath",
                table: "User");
        }
    }
}
