using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class hi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_chansons_artistes_artisteId",
                table: "chansons");

            migrationBuilder.DropIndex(
                name: "IX_chansons_artisteId",
                table: "chansons");

            migrationBuilder.DropColumn(
                name: "artisteId",
                table: "chansons");

            migrationBuilder.CreateIndex(
                name: "IX_chansons_artisteFK",
                table: "chansons",
                column: "artisteFK");

            migrationBuilder.AddForeignKey(
                name: "FK_chansons_artistes_artisteFK",
                table: "chansons",
                column: "artisteFK",
                principalTable: "artistes",
                principalColumn: "artisteId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_chansons_artistes_artisteFK",
                table: "chansons");

            migrationBuilder.DropIndex(
                name: "IX_chansons_artisteFK",
                table: "chansons");

            migrationBuilder.AddColumn<int>(
                name: "artisteId",
                table: "chansons",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_chansons_artisteId",
                table: "chansons",
                column: "artisteId");

            migrationBuilder.AddForeignKey(
                name: "FK_chansons_artistes_artisteId",
                table: "chansons",
                column: "artisteId",
                principalTable: "artistes",
                principalColumn: "artisteId");
        }
    }
}
