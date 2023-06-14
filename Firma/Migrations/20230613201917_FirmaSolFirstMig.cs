using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirmaSol.Migrations
{
    /// <inheritdoc />
    public partial class FirmaSolFirstMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AmetinimetusteAjalugu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ametinimetused = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AmetinimetusteNimekiriId = table.Column<int>(type: "int", nullable: false),
                    AmetisseMääramiseKuupäev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AmetisOldudAeg = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmetinimetusteAjalugu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AmetinimetusteNimekiri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ametinimetused = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HaruId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmetinimetusteNimekiri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Haigusleht",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TöötajaId = table.Column<int>(type: "int", nullable: false),
                    LiikHaiguslehtHooldusleht = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HaigusleheKestvusePikkus = table.Column<int>(type: "int", nullable: false),
                    HaigusleAvamiseKuupäev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HaigusleLõpetamiseKuupäev = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Haigusleht", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Haru",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HaruNimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aadress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistriKood = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Haru", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LaenutatavInventar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InventariNimetus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HaruId = table.Column<int>(type: "int", nullable: false),
                    Kirjeldus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaenutatavInventar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Laenutus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InventariNimetus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LaenutatavInventarId = table.Column<int>(type: "int", nullable: false),
                    TöötajaId = table.Column<int>(type: "int", nullable: false),
                    LaenutuseAlgus = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LaenutuseLõpp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laenutus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Laps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    TöötajaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ligipääsuluba",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AmetinimetusteNimekiriId = table.Column<int>(type: "int", nullable: false),
                    TöötajaId = table.Column<int>(type: "int", nullable: false),
                    Kirjeldus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KehtivuseAlgus = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KehtivuseLõpp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ligipääsuluba", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Palved",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TöötajaId = table.Column<int>(type: "int", nullable: false),
                    HaruId = table.Column<int>(type: "int", nullable: false),
                    Kirjeldus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kuupäev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Olek = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Palved", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Puhkused",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TöötajaId = table.Column<int>(type: "int", nullable: false),
                    PuhkuseLiik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PuhkusePikkus = table.Column<int>(type: "int", nullable: false),
                    PuhkuseAlguseKuupäev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PuhkuseLõpuKuupäev = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puhkused", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tervisekontroll",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TöötajaId = table.Column<int>(type: "int", nullable: false),
                    SooritamiseKuupäev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KehtivuseLõpp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Piirangud = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Abivahendid = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tervisekontroll", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Töötaja",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AmetinimetusteAjaluguId = table.Column<int>(type: "int", nullable: false),
                    HaruId = table.Column<int>(type: "int", nullable: false),
                    IdKood = table.Column<int>(type: "int", nullable: false),
                    Aadress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArveldusArve = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TöölepinguAlguseKuupäev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TöölepinguLõpuKuupäev = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Töötaja", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TöötajaLapsSeos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TöötajaId = table.Column<int>(type: "int", nullable: false),
                    LapsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TöötajaLapsSeos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vihjed",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kirjeldus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kuupäev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Olek = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HaruId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vihjed", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AmetinimetusteAjalugu");

            migrationBuilder.DropTable(
                name: "AmetinimetusteNimekiri");

            migrationBuilder.DropTable(
                name: "Haigusleht");

            migrationBuilder.DropTable(
                name: "Haru");

            migrationBuilder.DropTable(
                name: "LaenutatavInventar");

            migrationBuilder.DropTable(
                name: "Laenutus");

            migrationBuilder.DropTable(
                name: "Laps");

            migrationBuilder.DropTable(
                name: "Ligipääsuluba");

            migrationBuilder.DropTable(
                name: "Palved");

            migrationBuilder.DropTable(
                name: "Puhkused");

            migrationBuilder.DropTable(
                name: "Tervisekontroll");

            migrationBuilder.DropTable(
                name: "Töötaja");

            migrationBuilder.DropTable(
                name: "TöötajaLapsSeos");

            migrationBuilder.DropTable(
                name: "Vihjed");
        }
    }
}
