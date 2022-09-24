using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreWebApplication.Migrations
{
    public partial class SeedUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "EMAIL", "FIRST_NAME", "IS_ACTIVE", "IS_DELETED", "LAST_NAME", "MIDDLE_NAME", "PASSWORD" },
                values: new object[] { 2L, "jyoti@gmail.com", "Jyoti", false, false, "Dhingra", null, "321" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 2L);
        }
    }
}
