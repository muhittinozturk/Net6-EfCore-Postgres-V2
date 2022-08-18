using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PostgresDb.Migrations
{
    public partial class adding_comments_to_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable(
                name: "Teams",
                comment: "This table is for the F1 Teams to manage their Season");

            migrationBuilder.AlterTable(
                name: "F12022Drivers",
                comment: "This is a table for f1 drivers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable(
                name: "Teams",
                oldComment: "This table is for the F1 Teams to manage their Season");

            migrationBuilder.AlterTable(
                name: "F12022Drivers",
                oldComment: "This is a table for f1 drivers");
        }
    }
}
