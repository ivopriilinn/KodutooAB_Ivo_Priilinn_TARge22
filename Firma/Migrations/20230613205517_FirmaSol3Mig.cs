using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirmaSol.Migrations
{
    /// <inheritdoc />
    public partial class FirmaSol3Mig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Töötaja_HaruId",
                table: "Töötaja",
                column: "HaruId");

            migrationBuilder.AddForeignKey(
                name: "FK_Töötaja_Haru_HaruId",
                table: "Töötaja",
                column: "HaruId",
                principalTable: "Haru",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Töötaja_Haru_HaruId",
                table: "Töötaja");

            migrationBuilder.DropIndex(
                name: "IX_Töötaja_HaruId",
                table: "Töötaja");
        }
    }
}
