using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PostgresDb.Migrations
{
    public partial class update_column_name : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "F12022Drivers",
                newName: "driver_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "driver_id",
                table: "F12022Drivers",
                newName: "Id");
        }
    }
}
