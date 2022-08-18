using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PostgresDb.Migrations
{
    public partial class add_columns_comments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Teams",
                type: "text",
                nullable: false,
                comment: "This is a sample comment for a column",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "RacingNumber",
                table: "F12022Drivers",
                type: "integer",
                nullable: false,
                comment: "This is the designated unique driver number",
                oldClrType: typeof(int),
                oldType: "integer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Teams",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldComment: "This is a sample comment for a column");

            migrationBuilder.AlterColumn<int>(
                name: "RacingNumber",
                table: "F12022Drivers",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "This is the designated unique driver number");
        }
    }
}
