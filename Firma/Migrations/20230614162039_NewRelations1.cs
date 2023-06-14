using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirmaSol.Migrations
{
    /// <inheritdoc />
    public partial class NewRelations1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AmetinimetusteNimekiri_Haru_HaruId",
                table: "AmetinimetusteNimekiri");

            migrationBuilder.DropForeignKey(
                name: "FK_Haigusleht_Töötaja_TöötajaId",
                table: "Haigusleht");

            migrationBuilder.DropForeignKey(
                name: "FK_LaenutatavInventar_Haru_HaruId",
                table: "LaenutatavInventar");

            migrationBuilder.DropForeignKey(
                name: "FK_Laenutus_LaenutatavInventar_LaenutatavInventarId",
                table: "Laenutus");

            migrationBuilder.DropForeignKey(
                name: "FK_Ligipääsuluba_AmetinimetusteNimekiri_AmetinimetusteNimekiriId",
                table: "Ligipääsuluba");

            migrationBuilder.DropForeignKey(
                name: "FK_Ligipääsuluba_Töötaja_TöötajaId",
                table: "Ligipääsuluba");

            migrationBuilder.DropForeignKey(
                name: "FK_Palved_Haru_HaruId",
                table: "Palved");

            migrationBuilder.DropForeignKey(
                name: "FK_Palved_Töötaja_TöötajaId",
                table: "Palved");

            migrationBuilder.DropForeignKey(
                name: "FK_Puhkused_Töötaja_TöötajaId",
                table: "Puhkused");

            migrationBuilder.DropForeignKey(
                name: "FK_Tervisekontroll_Töötaja_TöötajaId",
                table: "Tervisekontroll");

            migrationBuilder.DropForeignKey(
                name: "FK_TöötajaLapsSeos_Laps_LapsId",
                table: "TöötajaLapsSeos");

            migrationBuilder.DropForeignKey(
                name: "FK_TöötajaLapsSeos_Töötaja_TöötajaId",
                table: "TöötajaLapsSeos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vihjed_Haru_HaruId",
                table: "Vihjed");

            migrationBuilder.AddForeignKey(
                name: "FK_AmetinimetusteNimekiri_Haru_HaruId",
                table: "AmetinimetusteNimekiri",
                column: "HaruId",
                principalTable: "Haru",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Haigusleht_Töötaja_TöötajaId",
                table: "Haigusleht",
                column: "TöötajaId",
                principalTable: "Töötaja",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LaenutatavInventar_Haru_HaruId",
                table: "LaenutatavInventar",
                column: "HaruId",
                principalTable: "Haru",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Laenutus_LaenutatavInventar_LaenutatavInventarId",
                table: "Laenutus",
                column: "LaenutatavInventarId",
                principalTable: "LaenutatavInventar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ligipääsuluba_AmetinimetusteNimekiri_AmetinimetusteNimekiriId",
                table: "Ligipääsuluba",
                column: "AmetinimetusteNimekiriId",
                principalTable: "AmetinimetusteNimekiri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ligipääsuluba_Töötaja_TöötajaId",
                table: "Ligipääsuluba",
                column: "TöötajaId",
                principalTable: "Töötaja",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Palved_Haru_HaruId",
                table: "Palved",
                column: "HaruId",
                principalTable: "Haru",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Palved_Töötaja_TöötajaId",
                table: "Palved",
                column: "TöötajaId",
                principalTable: "Töötaja",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Puhkused_Töötaja_TöötajaId",
                table: "Puhkused",
                column: "TöötajaId",
                principalTable: "Töötaja",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tervisekontroll_Töötaja_TöötajaId",
                table: "Tervisekontroll",
                column: "TöötajaId",
                principalTable: "Töötaja",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TöötajaLapsSeos_Laps_LapsId",
                table: "TöötajaLapsSeos",
                column: "LapsId",
                principalTable: "Laps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TöötajaLapsSeos_Töötaja_TöötajaId",
                table: "TöötajaLapsSeos",
                column: "TöötajaId",
                principalTable: "Töötaja",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vihjed_Haru_HaruId",
                table: "Vihjed",
                column: "HaruId",
                principalTable: "Haru",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AmetinimetusteNimekiri_Haru_HaruId",
                table: "AmetinimetusteNimekiri");

            migrationBuilder.DropForeignKey(
                name: "FK_Haigusleht_Töötaja_TöötajaId",
                table: "Haigusleht");

            migrationBuilder.DropForeignKey(
                name: "FK_LaenutatavInventar_Haru_HaruId",
                table: "LaenutatavInventar");

            migrationBuilder.DropForeignKey(
                name: "FK_Laenutus_LaenutatavInventar_LaenutatavInventarId",
                table: "Laenutus");

            migrationBuilder.DropForeignKey(
                name: "FK_Ligipääsuluba_AmetinimetusteNimekiri_AmetinimetusteNimekiriId",
                table: "Ligipääsuluba");

            migrationBuilder.DropForeignKey(
                name: "FK_Ligipääsuluba_Töötaja_TöötajaId",
                table: "Ligipääsuluba");

            migrationBuilder.DropForeignKey(
                name: "FK_Palved_Haru_HaruId",
                table: "Palved");

            migrationBuilder.DropForeignKey(
                name: "FK_Palved_Töötaja_TöötajaId",
                table: "Palved");

            migrationBuilder.DropForeignKey(
                name: "FK_Puhkused_Töötaja_TöötajaId",
                table: "Puhkused");

            migrationBuilder.DropForeignKey(
                name: "FK_Tervisekontroll_Töötaja_TöötajaId",
                table: "Tervisekontroll");

            migrationBuilder.DropForeignKey(
                name: "FK_TöötajaLapsSeos_Laps_LapsId",
                table: "TöötajaLapsSeos");

            migrationBuilder.DropForeignKey(
                name: "FK_TöötajaLapsSeos_Töötaja_TöötajaId",
                table: "TöötajaLapsSeos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vihjed_Haru_HaruId",
                table: "Vihjed");

            migrationBuilder.AddForeignKey(
                name: "FK_AmetinimetusteNimekiri_Haru_HaruId",
                table: "AmetinimetusteNimekiri",
                column: "HaruId",
                principalTable: "Haru",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Haigusleht_Töötaja_TöötajaId",
                table: "Haigusleht",
                column: "TöötajaId",
                principalTable: "Töötaja",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LaenutatavInventar_Haru_HaruId",
                table: "LaenutatavInventar",
                column: "HaruId",
                principalTable: "Haru",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Laenutus_LaenutatavInventar_LaenutatavInventarId",
                table: "Laenutus",
                column: "LaenutatavInventarId",
                principalTable: "LaenutatavInventar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ligipääsuluba_AmetinimetusteNimekiri_AmetinimetusteNimekiriId",
                table: "Ligipääsuluba",
                column: "AmetinimetusteNimekiriId",
                principalTable: "AmetinimetusteNimekiri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ligipääsuluba_Töötaja_TöötajaId",
                table: "Ligipääsuluba",
                column: "TöötajaId",
                principalTable: "Töötaja",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Palved_Haru_HaruId",
                table: "Palved",
                column: "HaruId",
                principalTable: "Haru",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Palved_Töötaja_TöötajaId",
                table: "Palved",
                column: "TöötajaId",
                principalTable: "Töötaja",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Puhkused_Töötaja_TöötajaId",
                table: "Puhkused",
                column: "TöötajaId",
                principalTable: "Töötaja",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tervisekontroll_Töötaja_TöötajaId",
                table: "Tervisekontroll",
                column: "TöötajaId",
                principalTable: "Töötaja",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TöötajaLapsSeos_Laps_LapsId",
                table: "TöötajaLapsSeos",
                column: "LapsId",
                principalTable: "Laps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TöötajaLapsSeos_Töötaja_TöötajaId",
                table: "TöötajaLapsSeos",
                column: "TöötajaId",
                principalTable: "Töötaja",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vihjed_Haru_HaruId",
                table: "Vihjed",
                column: "HaruId",
                principalTable: "Haru",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
