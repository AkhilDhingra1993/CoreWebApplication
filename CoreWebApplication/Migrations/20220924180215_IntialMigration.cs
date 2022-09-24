using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreWebApplication.Migrations
{
    public partial class IntialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EMAIL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FIRST_NAME = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    MIDDLE_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LAST_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PASSWORD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IS_DELETED = table.Column<bool>(type: "bit", nullable: false),
                    IS_ACTIVE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
