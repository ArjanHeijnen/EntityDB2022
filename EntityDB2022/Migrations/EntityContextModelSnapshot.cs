﻿// <auto-generated />
using System;
using EntityDB2022.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityDB2022.Migrations
{
    [DbContext(typeof(EntityContext))]
    partial class EntityContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DatabasesEntity.Models.Aflevering", b =>
                {
                    b.Property<int>("AfleveringId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AfleveringId"));

                    b.Property<int?>("AftitelingStart")
                        .HasColumnType("int");

                    b.Property<string>("Beschrijving")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kwaliteit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Looptijd")
                        .HasColumnType("int");

                    b.Property<int?>("SeizoenId1")
                        .HasColumnType("int");

                    b.Property<string>("Titel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AfleveringId");

                    b.HasIndex("SeizoenId1");

                    b.ToTable("Afleveringen");
                });

            modelBuilder.Entity("DatabasesEntity.Models.Details", b =>
                {
                    b.Property<int?>("FilmId1")
                        .HasColumnType("int");

                    b.Property<int?>("GenreId1")
                        .HasColumnType("int");

                    b.Property<int?>("KijkwijzerId1")
                        .HasColumnType("int");

                    b.Property<int?>("SerienIdSerieId")
                        .HasColumnType("int");

                    b.HasIndex("FilmId1");

                    b.HasIndex("GenreId1");

                    b.HasIndex("KijkwijzerId1");

                    b.HasIndex("SerienIdSerieId");

                    b.ToTable("Detailss");
                });

            modelBuilder.Entity("DatabasesEntity.Models.Film", b =>
                {
                    b.Property<int>("FilmId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FilmId"));

                    b.Property<int?>("AftitelingStart")
                        .HasColumnType("int");

                    b.Property<string>("Beschrijving")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kwaliteit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Looptijd")
                        .HasColumnType("int");

                    b.Property<string>("Titel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FilmId");

                    b.ToTable("Films");
                });

            modelBuilder.Entity("DatabasesEntity.Models.Gebruiker", b =>
                {
                    b.Property<int>("GebruikerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GebruikerId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Foutieve_inlog_Pogingen")
                        .HasColumnType("int");

                    b.Property<bool?>("Geactiveerd")
                        .HasColumnType("bit");

                    b.Property<bool?>("Korting")
                        .HasColumnType("bit");

                    b.Property<int?>("Proefversie_dagen")
                        .HasColumnType("int");

                    b.Property<string>("Wachtwoord")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GebruikerId");

                    b.ToTable("Gebruikers");
                });

            modelBuilder.Entity("DatabasesEntity.Models.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreId"));

                    b.Property<string>("Beschrijving")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GenreNaam")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("DatabasesEntity.Models.Genre_Voorkeur", b =>
                {
                    b.Property<int?>("GenreId1")
                        .HasColumnType("int");

                    b.Property<int?>("ProfielId1")
                        .HasColumnType("int");

                    b.HasIndex("GenreId1");

                    b.HasIndex("ProfielId1");

                    b.ToTable("Genre_Voorkeuren");
                });

            modelBuilder.Entity("DatabasesEntity.Models.Kijklijst", b =>
                {
                    b.Property<int?>("FilmId1")
                        .HasColumnType("int");

                    b.Property<int?>("ProfielId1")
                        .HasColumnType("int");

                    b.Property<int?>("SerieId1")
                        .HasColumnType("int");

                    b.HasIndex("FilmId1");

                    b.HasIndex("ProfielId1");

                    b.HasIndex("SerieId1");

                    b.ToTable("Kijklijsten");
                });

            modelBuilder.Entity("DatabasesEntity.Models.Kijkwijzer", b =>
                {
                    b.Property<int>("KijkwijzerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KijkwijzerId"));

                    b.Property<string>("Beschrijving")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KijkwijzerNaam")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KijkwijzerId");

                    b.ToTable("Kijkwijzers");
                });

            modelBuilder.Entity("DatabasesEntity.Models.Kijkwijzer_voorkeur", b =>
                {
                    b.Property<int?>("KijkwijzerId1")
                        .HasColumnType("int");

                    b.Property<int?>("ProfielId1")
                        .HasColumnType("int");

                    b.HasIndex("KijkwijzerId1");

                    b.HasIndex("ProfielId1");

                    b.ToTable("Kijkwijzer_voorkeuren");
                });

            modelBuilder.Entity("DatabasesEntity.Models.Ondertiteling", b =>
                {
                    b.Property<int>("OndertitelingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OndertitelingId"));

                    b.Property<int?>("AfleveringId1")
                        .HasColumnType("int");

                    b.Property<int?>("FilmId1")
                        .HasColumnType("int");

                    b.Property<string>("Taal")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OndertitelingId");

                    b.HasIndex("AfleveringId1");

                    b.HasIndex("FilmId1");

                    b.ToTable("Ondertitelingen");
                });

            modelBuilder.Entity("DatabasesEntity.Models.Profiel", b =>
                {
                    b.Property<int>("ProfielId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProfielId"));

                    b.Property<DateTime>("Geboortedatum")
                        .HasColumnType("datetime2");

                    b.Property<int>("GebruikerId1")
                        .HasColumnType("int");

                    b.Property<string>("MediaVoorkeur")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfielFoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Taal")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProfielId");

                    b.HasIndex("GebruikerId1");

                    b.ToTable("Profielen");
                });

            modelBuilder.Entity("DatabasesEntity.Models.Seizoen", b =>
                {
                    b.Property<int>("SeizoenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SeizoenId"));

                    b.Property<string>("Beschrijving")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SeizoenNummer")
                        .HasColumnType("int");

                    b.Property<int>("SerieId1")
                        .HasColumnType("int");

                    b.HasKey("SeizoenId");

                    b.HasIndex("SerieId1");

                    b.ToTable("Seizoenen");
                });

            modelBuilder.Entity("DatabasesEntity.Models.Serie", b =>
                {
                    b.Property<int>("SerieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SerieId"));

                    b.Property<string>("Beschrijving")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SerieId");

                    b.ToTable("Series");
                });

            modelBuilder.Entity("DatabasesEntity.Models.Aflevering", b =>
                {
                    b.HasOne("DatabasesEntity.Models.Seizoen", "SeizoenId")
                        .WithMany()
                        .HasForeignKey("SeizoenId1");

                    b.Navigation("SeizoenId");
                });

            modelBuilder.Entity("DatabasesEntity.Models.Details", b =>
                {
                    b.HasOne("DatabasesEntity.Models.Film", "FilmId")
                        .WithMany()
                        .HasForeignKey("FilmId1");

                    b.HasOne("DatabasesEntity.Models.Genre", "GenreId")
                        .WithMany()
                        .HasForeignKey("GenreId1");

                    b.HasOne("DatabasesEntity.Models.Kijkwijzer", "KijkwijzerId")
                        .WithMany()
                        .HasForeignKey("KijkwijzerId1");

                    b.HasOne("DatabasesEntity.Models.Serie", "SerienId")
                        .WithMany()
                        .HasForeignKey("SerienIdSerieId");

                    b.Navigation("FilmId");

                    b.Navigation("GenreId");

                    b.Navigation("KijkwijzerId");

                    b.Navigation("SerienId");
                });

            modelBuilder.Entity("DatabasesEntity.Models.Genre_Voorkeur", b =>
                {
                    b.HasOne("DatabasesEntity.Models.Genre", "GenreId")
                        .WithMany()
                        .HasForeignKey("GenreId1");

                    b.HasOne("DatabasesEntity.Models.Profiel", "ProfielId")
                        .WithMany()
                        .HasForeignKey("ProfielId1");

                    b.Navigation("GenreId");

                    b.Navigation("ProfielId");
                });

            modelBuilder.Entity("DatabasesEntity.Models.Kijklijst", b =>
                {
                    b.HasOne("DatabasesEntity.Models.Film", "FilmId")
                        .WithMany()
                        .HasForeignKey("FilmId1");

                    b.HasOne("DatabasesEntity.Models.Profiel", "ProfielId")
                        .WithMany()
                        .HasForeignKey("ProfielId1");

                    b.HasOne("DatabasesEntity.Models.Serie", "SerieId")
                        .WithMany()
                        .HasForeignKey("SerieId1");

                    b.Navigation("FilmId");

                    b.Navigation("ProfielId");

                    b.Navigation("SerieId");
                });

            modelBuilder.Entity("DatabasesEntity.Models.Kijkwijzer_voorkeur", b =>
                {
                    b.HasOne("DatabasesEntity.Models.Kijkwijzer", "KijkwijzerId")
                        .WithMany()
                        .HasForeignKey("KijkwijzerId1");

                    b.HasOne("DatabasesEntity.Models.Profiel", "ProfielId")
                        .WithMany()
                        .HasForeignKey("ProfielId1");

                    b.Navigation("KijkwijzerId");

                    b.Navigation("ProfielId");
                });

            modelBuilder.Entity("DatabasesEntity.Models.Ondertiteling", b =>
                {
                    b.HasOne("DatabasesEntity.Models.Aflevering", "AfleveringId")
                        .WithMany()
                        .HasForeignKey("AfleveringId1");

                    b.HasOne("DatabasesEntity.Models.Film", "FilmId")
                        .WithMany()
                        .HasForeignKey("FilmId1");

                    b.Navigation("AfleveringId");

                    b.Navigation("FilmId");
                });

            modelBuilder.Entity("DatabasesEntity.Models.Profiel", b =>
                {
                    b.HasOne("DatabasesEntity.Models.Gebruiker", "GebruikerId")
                        .WithMany()
                        .HasForeignKey("GebruikerId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GebruikerId");
                });

            modelBuilder.Entity("DatabasesEntity.Models.Seizoen", b =>
                {
                    b.HasOne("DatabasesEntity.Models.Serie", "SerieId")
                        .WithMany()
                        .HasForeignKey("SerieId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SerieId");
                });
#pragma warning restore 612, 618
        }
    }
}
