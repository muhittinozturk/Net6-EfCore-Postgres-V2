using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PostgresDb.Migrations
{
    public partial class update_columns_name_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Year",
                table: "Teams",
                newName: "racing_year");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "racing_year",
                table: "Teams",
                newName: "Year");
        }
    }
}
