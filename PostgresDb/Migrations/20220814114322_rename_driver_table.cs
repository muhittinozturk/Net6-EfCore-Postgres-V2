using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PostgresDb.Migrations
{
    public partial class rename_driver_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DriverMedias_F1Drivers_DriverId",
                table: "DriverMedias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_F1Drivers",
                table: "F1Drivers");

            migrationBuilder.RenameTable(
                name: "F1Drivers",
                newName: "F12022Drivers");

            migrationBuilder.RenameIndex(
                name: "IX_F1Drivers_TeamId",
                table: "F12022Drivers",
                newName: "IX_F12022Drivers_TeamId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_F12022Drivers",
                table: "F12022Drivers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DriverMedias_F12022Drivers_DriverId",
                table: "DriverMedias",
                column: "DriverId",
                principalTable: "F12022Drivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DriverMedias_F12022Drivers_DriverId",
                table: "DriverMedias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_F12022Drivers",
                table: "F12022Drivers");

            migrationBuilder.RenameTable(
                name: "F12022Drivers",
                newName: "F1Drivers");

            migrationBuilder.RenameIndex(
                name: "IX_F12022Drivers_TeamId",
                table: "F1Drivers",
                newName: "IX_F1Drivers_TeamId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_F1Drivers",
                table: "F1Drivers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DriverMedias_F1Drivers_DriverId",
                table: "DriverMedias",
                column: "DriverId",
                principalTable: "F1Drivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
