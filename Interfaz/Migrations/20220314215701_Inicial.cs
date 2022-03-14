using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Interfaz.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cajas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Peso = table.Column<int>(type: "INTEGER", nullable: false),
                    Manies = table.Column<int>(type: "INTEGER", nullable: false),
                    Pistachos = table.Column<int>(type: "INTEGER", nullable: false),
                    Pasas = table.Column<int>(type: "INTEGER", nullable: false),
                    Ciruelas = table.Column<int>(type: "INTEGER", nullable: false),
                    Arandanos = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cajas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Funditas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Peso = table.Column<int>(type: "INTEGER", nullable: false),
                    Manies = table.Column<int>(type: "INTEGER", nullable: false),
                    Pistachos = table.Column<int>(type: "INTEGER", nullable: false),
                    Pasas = table.Column<int>(type: "INTEGER", nullable: false),
                    Ciruelas = table.Column<int>(type: "INTEGER", nullable: false),
                    Arandanos = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funditas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Inventario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Concepto = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventario", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cajas");

            migrationBuilder.DropTable(
                name: "Funditas");

            migrationBuilder.DropTable(
                name: "Inventario");
        }
    }
}
