using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class exxx : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "artistes",
                columns: table => new
                {
                    artisteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    contact = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    datedenaissance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    nationalite = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    nom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    prenom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_artistes", x => x.artisteId);
                });

            migrationBuilder.CreateTable(
                name: "festivals",
                columns: table => new
                {
                    festivalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    capacite = table.Column<int>(type: "int", nullable: false),
                    labelle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ville = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_festivals", x => x.festivalId);
                });

            migrationBuilder.CreateTable(
                name: "chansons",
                columns: table => new
                {
                    chansonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    datesortie = table.Column<DateTime>(type: "datetime2", nullable: false),
                    duree = table.Column<int>(type: "int", nullable: false),
                    titre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    vueyt = table.Column<int>(type: "int", nullable: false),
                    stylemusicale = table.Column<int>(type: "int", nullable: false),
                    artisteFK = table.Column<int>(type: "int", nullable: false),
                    artisteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chansons", x => x.chansonId);
                    table.ForeignKey(
                        name: "FK_chansons_artistes_artisteId",
                        column: x => x.artisteId,
                        principalTable: "artistes",
                        principalColumn: "artisteId");
                });

            migrationBuilder.CreateTable(
                name: "concertes",
                columns: table => new
                {
                    dateconcert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    artisteFK = table.Column<int>(type: "int", nullable: false),
                    festivalFK = table.Column<int>(type: "int", nullable: false),
                    cachet = table.Column<double>(type: "float", nullable: false),
                    duree = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_concertes", x => new { x.festivalFK, x.artisteFK, x.dateconcert });
                    table.ForeignKey(
                        name: "FK_concertes_artistes_artisteFK",
                        column: x => x.artisteFK,
                        principalTable: "artistes",
                        principalColumn: "artisteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_concertes_festivals_festivalFK",
                        column: x => x.festivalFK,
                        principalTable: "festivals",
                        principalColumn: "festivalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_chansons_artisteId",
                table: "chansons",
                column: "artisteId");

            migrationBuilder.CreateIndex(
                name: "IX_concertes_artisteFK",
                table: "concertes",
                column: "artisteFK");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "chansons");

            migrationBuilder.DropTable(
                name: "concertes");

            migrationBuilder.DropTable(
                name: "artistes");

            migrationBuilder.DropTable(
                name: "festivals");
        }
    }
}
