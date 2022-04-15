using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WEBAPI.Migrations
{
    public partial class bir : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personeller",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AdıveİkinciAdı = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyadı = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eposta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personeller", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personeller");
        }
    }
}
