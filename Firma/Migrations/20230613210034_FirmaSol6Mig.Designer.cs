﻿// <auto-generated />
using System;
using FirmaSol.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FirmaSol.Migrations
{
    [DbContext(typeof(Firma))]
    [Migration("20230613210034_FirmaSol6Mig")]
    partial class FirmaSol6Mig
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FirmaSol.Models.AmetinimetusteAjalugu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ametinimetused")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AmetinimetusteNimekiriId")
                        .HasColumnType("int");

                    b.Property<int>("AmetisOldudAeg")
                        .HasColumnType("int");

                    b.Property<DateTime>("AmetisseMääramiseKuupäev")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("AmetinimetusteAjalugu");
                });

            modelBuilder.Entity("FirmaSol.Models.AmetinimetusteNimekiri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ametinimetused")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HaruId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AmetinimetusteNimekiri");
                });

            modelBuilder.Entity("FirmaSol.Models.Haigusleht", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("HaigusleAvamiseKuupäev")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HaigusleLõpetamiseKuupäev")
                        .HasColumnType("datetime2");

                    b.Property<int>("HaigusleheKestvusePikkus")
                        .HasColumnType("int");

                    b.Property<string>("LiikHaiguslehtHooldusleht")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TöötajaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Haigusleht");
                });

            modelBuilder.Entity("FirmaSol.Models.Haru", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aadress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HaruNimi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RegistriKood")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Haru");
                });

            modelBuilder.Entity("FirmaSol.Models.LaenutatavInventar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("HaruId")
                        .HasColumnType("int");

                    b.Property<string>("InventariNimetus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kirjeldus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LaenutatavInventar");
                });

            modelBuilder.Entity("FirmaSol.Models.Laenutus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("InventariNimetus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LaenutatavInventarId")
                        .HasColumnType("int");

                    b.Property<DateTime>("LaenutuseAlgus")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LaenutuseLõpp")
                        .HasColumnType("datetime2");

                    b.Property<int>("TöötajaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Laenutus");
                });

            modelBuilder.Entity("FirmaSol.Models.Laps", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Nimi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TöötajaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Laps");
                });

            modelBuilder.Entity("FirmaSol.Models.Ligipääsuluba", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AmetinimetusteNimekiriId")
                        .HasColumnType("int");

                    b.Property<DateTime>("KehtivuseAlgus")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("KehtivuseLõpp")
                        .HasColumnType("datetime2");

                    b.Property<string>("Kirjeldus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TöötajaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Ligipääsuluba");
                });

            modelBuilder.Entity("FirmaSol.Models.Palved", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("HaruId")
                        .HasColumnType("int");

                    b.Property<string>("Kirjeldus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Kuupäev")
                        .HasColumnType("datetime2");

                    b.Property<string>("Olek")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TöötajaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Palved");
                });

            modelBuilder.Entity("FirmaSol.Models.Puhkused", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("PuhkuseAlguseKuupäev")
                        .HasColumnType("datetime2");

                    b.Property<string>("PuhkuseLiik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PuhkuseLõpuKuupäev")
                        .HasColumnType("datetime2");

                    b.Property<int>("PuhkusePikkus")
                        .HasColumnType("int");

                    b.Property<int>("TöötajaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Puhkused");
                });

            modelBuilder.Entity("FirmaSol.Models.Tervisekontroll", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Abivahendid")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("KehtivuseLõpp")
                        .HasColumnType("datetime2");

                    b.Property<string>("Piirangud")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SooritamiseKuupäev")
                        .HasColumnType("datetime2");

                    b.Property<int>("TöötajaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tervisekontroll");
                });

            modelBuilder.Entity("FirmaSol.Models.Töötaja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aadress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AmetinimetusteAjaluguId")
                        .HasColumnType("int");

                    b.Property<string>("ArveldusArve")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HaruId")
                        .HasColumnType("int");

                    b.Property<int>("IdKood")
                        .HasColumnType("int");

                    b.Property<string>("Nimi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TöölepinguAlguseKuupäev")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TöölepinguLõpuKuupäev")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("HaruId");

                    b.ToTable("Töötaja");
                });

            modelBuilder.Entity("FirmaSol.Models.TöötajaLapsSeos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("LapsId")
                        .HasColumnType("int");

                    b.Property<int>("TöötajaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TöötajaLapsSeos");
                });

            modelBuilder.Entity("FirmaSol.Models.Vihjed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("HaruId")
                        .HasColumnType("int");

                    b.Property<string>("Kirjeldus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Kuupäev")
                        .HasColumnType("datetime2");

                    b.Property<string>("Olek")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vihjed");
                });

            modelBuilder.Entity("FirmaSol.Models.Töötaja", b =>
                {
                    b.HasOne("FirmaSol.Models.Haru", "muunimi")
                        .WithMany()
                        .HasForeignKey("HaruId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("muunimi");
                });
#pragma warning restore 612, 618
        }
    }
}
