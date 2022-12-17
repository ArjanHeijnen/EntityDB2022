using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityDB2022.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    FilmId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kwaliteit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Looptijd = table.Column<int>(type: "int", nullable: true),
                    AftitelingStart = table.Column<int>(type: "int", nullable: true),
                    Beschrijving = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.FilmId);
                });

            migrationBuilder.CreateTable(
                name: "Gebruikers",
                columns: table => new
                {
                    GebruikerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wachtwoord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoutieveinlogPogingen = table.Column<int>(name: "Foutieve_inlog_Pogingen", type: "int", nullable: true),
                    Geactiveerd = table.Column<bool>(type: "bit", nullable: true),
                    Proefversiedagen = table.Column<int>(name: "Proefversie_dagen", type: "int", nullable: true),
                    Korting = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gebruikers", x => x.GebruikerId);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreNaam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Beschrijving = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Kijkwijzers",
                columns: table => new
                {
                    KijkwijzerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KijkwijzerNaam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Beschrijving = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kijkwijzers", x => x.KijkwijzerId);
                });

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    SerieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Beschrijving = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.SerieId);
                });

            migrationBuilder.CreateTable(
                name: "Profielen",
                columns: table => new
                {
                    ProfielId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GebruikerId1 = table.Column<int>(type: "int", nullable: false),
                    Taal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Geboortedatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MediaVoorkeur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfielFoto = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profielen", x => x.ProfielId);
                    table.ForeignKey(
                        name: "FK_Profielen_Gebruikers_GebruikerId1",
                        column: x => x.GebruikerId1,
                        principalTable: "Gebruikers",
                        principalColumn: "GebruikerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Detailss",
                columns: table => new
                {
                    KijkwijzerId1 = table.Column<int>(type: "int", nullable: true),
                    GenreId1 = table.Column<int>(type: "int", nullable: true),
                    FilmId1 = table.Column<int>(type: "int", nullable: true),
                    SerienIdSerieId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Detailss_Films_FilmId1",
                        column: x => x.FilmId1,
                        principalTable: "Films",
                        principalColumn: "FilmId");
                    table.ForeignKey(
                        name: "FK_Detailss_Genres_GenreId1",
                        column: x => x.GenreId1,
                        principalTable: "Genres",
                        principalColumn: "GenreId");
                    table.ForeignKey(
                        name: "FK_Detailss_Kijkwijzers_KijkwijzerId1",
                        column: x => x.KijkwijzerId1,
                        principalTable: "Kijkwijzers",
                        principalColumn: "KijkwijzerId");
                    table.ForeignKey(
                        name: "FK_Detailss_Series_SerienIdSerieId",
                        column: x => x.SerienIdSerieId,
                        principalTable: "Series",
                        principalColumn: "SerieId");
                });

            migrationBuilder.CreateTable(
                name: "Seizoenen",
                columns: table => new
                {
                    SeizoenId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SerieId1 = table.Column<int>(type: "int", nullable: false),
                    SeizoenNummer = table.Column<int>(type: "int", nullable: true),
                    Beschrijving = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seizoenen", x => x.SeizoenId);
                    table.ForeignKey(
                        name: "FK_Seizoenen_Series_SerieId1",
                        column: x => x.SerieId1,
                        principalTable: "Series",
                        principalColumn: "SerieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Genre_Voorkeuren",
                columns: table => new
                {
                    ProfielId1 = table.Column<int>(type: "int", nullable: true),
                    GenreId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Genre_Voorkeuren_Genres_GenreId1",
                        column: x => x.GenreId1,
                        principalTable: "Genres",
                        principalColumn: "GenreId");
                    table.ForeignKey(
                        name: "FK_Genre_Voorkeuren_Profielen_ProfielId1",
                        column: x => x.ProfielId1,
                        principalTable: "Profielen",
                        principalColumn: "ProfielId");
                });

            migrationBuilder.CreateTable(
                name: "Kijklijsten",
                columns: table => new
                {
                    ProfielId1 = table.Column<int>(type: "int", nullable: true),
                    FilmId1 = table.Column<int>(type: "int", nullable: true),
                    SerieId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Kijklijsten_Films_FilmId1",
                        column: x => x.FilmId1,
                        principalTable: "Films",
                        principalColumn: "FilmId");
                    table.ForeignKey(
                        name: "FK_Kijklijsten_Profielen_ProfielId1",
                        column: x => x.ProfielId1,
                        principalTable: "Profielen",
                        principalColumn: "ProfielId");
                    table.ForeignKey(
                        name: "FK_Kijklijsten_Series_SerieId1",
                        column: x => x.SerieId1,
                        principalTable: "Series",
                        principalColumn: "SerieId");
                });

            migrationBuilder.CreateTable(
                name: "Kijkwijzer_voorkeuren",
                columns: table => new
                {
                    ProfielId1 = table.Column<int>(type: "int", nullable: true),
                    KijkwijzerId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Kijkwijzer_voorkeuren_Kijkwijzers_KijkwijzerId1",
                        column: x => x.KijkwijzerId1,
                        principalTable: "Kijkwijzers",
                        principalColumn: "KijkwijzerId");
                    table.ForeignKey(
                        name: "FK_Kijkwijzer_voorkeuren_Profielen_ProfielId1",
                        column: x => x.ProfielId1,
                        principalTable: "Profielen",
                        principalColumn: "ProfielId");
                });

            migrationBuilder.CreateTable(
                name: "Afleveringen",
                columns: table => new
                {
                    AfleveringId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeizoenId1 = table.Column<int>(type: "int", nullable: true),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kwaliteit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Looptijd = table.Column<int>(type: "int", nullable: true),
                    AftitelingStart = table.Column<int>(type: "int", nullable: true),
                    Beschrijving = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Afleveringen", x => x.AfleveringId);
                    table.ForeignKey(
                        name: "FK_Afleveringen_Seizoenen_SeizoenId1",
                        column: x => x.SeizoenId1,
                        principalTable: "Seizoenen",
                        principalColumn: "SeizoenId");
                });

            migrationBuilder.CreateTable(
                name: "Ondertitelingen",
                columns: table => new
                {
                    OndertitelingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmId1 = table.Column<int>(type: "int", nullable: true),
                    AfleveringId1 = table.Column<int>(type: "int", nullable: true),
                    Taal = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ondertitelingen", x => x.OndertitelingId);
                    table.ForeignKey(
                        name: "FK_Ondertitelingen_Afleveringen_AfleveringId1",
                        column: x => x.AfleveringId1,
                        principalTable: "Afleveringen",
                        principalColumn: "AfleveringId");
                    table.ForeignKey(
                        name: "FK_Ondertitelingen_Films_FilmId1",
                        column: x => x.FilmId1,
                        principalTable: "Films",
                        principalColumn: "FilmId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Afleveringen_SeizoenId1",
                table: "Afleveringen",
                column: "SeizoenId1");

            migrationBuilder.CreateIndex(
                name: "IX_Detailss_FilmId1",
                table: "Detailss",
                column: "FilmId1");

            migrationBuilder.CreateIndex(
                name: "IX_Detailss_GenreId1",
                table: "Detailss",
                column: "GenreId1");

            migrationBuilder.CreateIndex(
                name: "IX_Detailss_KijkwijzerId1",
                table: "Detailss",
                column: "KijkwijzerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Detailss_SerienIdSerieId",
                table: "Detailss",
                column: "SerienIdSerieId");

            migrationBuilder.CreateIndex(
                name: "IX_Genre_Voorkeuren_GenreId1",
                table: "Genre_Voorkeuren",
                column: "GenreId1");

            migrationBuilder.CreateIndex(
                name: "IX_Genre_Voorkeuren_ProfielId1",
                table: "Genre_Voorkeuren",
                column: "ProfielId1");

            migrationBuilder.CreateIndex(
                name: "IX_Kijklijsten_FilmId1",
                table: "Kijklijsten",
                column: "FilmId1");

            migrationBuilder.CreateIndex(
                name: "IX_Kijklijsten_ProfielId1",
                table: "Kijklijsten",
                column: "ProfielId1");

            migrationBuilder.CreateIndex(
                name: "IX_Kijklijsten_SerieId1",
                table: "Kijklijsten",
                column: "SerieId1");

            migrationBuilder.CreateIndex(
                name: "IX_Kijkwijzer_voorkeuren_KijkwijzerId1",
                table: "Kijkwijzer_voorkeuren",
                column: "KijkwijzerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Kijkwijzer_voorkeuren_ProfielId1",
                table: "Kijkwijzer_voorkeuren",
                column: "ProfielId1");

            migrationBuilder.CreateIndex(
                name: "IX_Ondertitelingen_AfleveringId1",
                table: "Ondertitelingen",
                column: "AfleveringId1");

            migrationBuilder.CreateIndex(
                name: "IX_Ondertitelingen_FilmId1",
                table: "Ondertitelingen",
                column: "FilmId1");

            migrationBuilder.CreateIndex(
                name: "IX_Profielen_GebruikerId1",
                table: "Profielen",
                column: "GebruikerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Seizoenen_SerieId1",
                table: "Seizoenen",
                column: "SerieId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Detailss");

            migrationBuilder.DropTable(
                name: "Genre_Voorkeuren");

            migrationBuilder.DropTable(
                name: "Kijklijsten");

            migrationBuilder.DropTable(
                name: "Kijkwijzer_voorkeuren");

            migrationBuilder.DropTable(
                name: "Ondertitelingen");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Kijkwijzers");

            migrationBuilder.DropTable(
                name: "Profielen");

            migrationBuilder.DropTable(
                name: "Afleveringen");

            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "Gebruikers");

            migrationBuilder.DropTable(
                name: "Seizoenen");

            migrationBuilder.DropTable(
                name: "Series");
        }
    }
}
