using Microsoft.EntityFrameworkCore.Migrations;

namespace Projekt_Kristian.Migrations
{
    public partial class Link_Slik : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Link_Slika",
                table: "Proizvod",
                maxLength: 255,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Link_Slika",
                table: "Proizvod");
        }
    }
}
