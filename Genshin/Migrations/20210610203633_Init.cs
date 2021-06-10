using Microsoft.EntityFrameworkCore.Migrations;

namespace Genshin.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Element",
                table: "Elements");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Elements",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_WeaponType",
                table: "Weapons",
                column: "WeaponType",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Elements_Name",
                table: "Elements",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Weapons_WeaponType",
                table: "Weapons");

            migrationBuilder.DropIndex(
                name: "IX_Elements_Name",
                table: "Elements");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Elements");

            migrationBuilder.AddColumn<string>(
                name: "Element",
                table: "Elements",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");
        }
    }
}
