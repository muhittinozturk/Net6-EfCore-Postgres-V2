using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PostgresDb.Migrations
{
    public partial class updating_columns_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameAndRacingNumber",
                table: "F12022Drivers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NameAndRacingNumber",
                table: "F12022Drivers",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
