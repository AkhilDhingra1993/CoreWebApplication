using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreWebApplication.Migrations
{
    public partial class CreateAUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 2L);

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "EMAIL", "FIRST_NAME", "IS_ACTIVE", "IS_DELETED", "LAST_NAME", "MIDDLE_NAME", "PASSWORD" },
                values: new object[] { 4L, "jyoti@gmail.com", "Jyoti", false, false, "Dhingra", null, "321" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "EMAIL", "FIRST_NAME", "IS_ACTIVE", "IS_DELETED", "LAST_NAME", "MIDDLE_NAME", "PASSWORD" },
                values: new object[] { 5L, "mukesh@gmail.com", "Mukesh", false, false, "Dhingra", null, "546" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 5L);

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "EMAIL", "FIRST_NAME", "IS_ACTIVE", "IS_DELETED", "LAST_NAME", "MIDDLE_NAME", "PASSWORD" },
                values: new object[] { 2L, "jyoti@gmail.com", "Jyoti", false, false, "Dhingra", null, "321" });
        }
    }
}
