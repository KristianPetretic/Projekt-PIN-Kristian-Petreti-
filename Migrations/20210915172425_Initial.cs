using Microsoft.EntityFrameworkCore.Migrations;

namespace Projekt_Kristian.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Proizvod",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv_Proizvoda = table.Column<string>(maxLength: 30, nullable: false),
                    Cijena = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proizvod", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Narudžba",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Proizvod_Id = table.Column<int>(nullable: false),
                    ProizvodId = table.Column<int>(nullable: true),
                    Količina = table.Column<int>(nullable: false),
                    Narudžba_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Narudžba", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Narudžba_Proizvod_ProizvodId",
                        column: x => x.ProizvodId,
                        principalTable: "Proizvod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Narudžba_ProizvodId",
                table: "Narudžba",
                column: "ProizvodId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Narudžba");

            migrationBuilder.DropTable(
                name: "Proizvod");
        }
    }
}
