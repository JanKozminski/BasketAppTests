using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BasketApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Conferences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conferences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamPhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityID = table.Column<int>(type: "int", nullable: false),
                    ConferenceID = table.Column<int>(type: "int", nullable: false),
                    StateID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_Cities_CityID",
                        column: x => x.CityID,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Teams_Conferences_ConferenceID",
                        column: x => x.ConferenceID,
                        principalTable: "Conferences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Teams_States_StateID",
                        column: x => x.StateID,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Coaches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoachPhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coaches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coaches_Teams_TeamID",
                        column: x => x.TeamID,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Team1ID = table.Column<int>(type: "int", nullable: false),
                    Team2ID = table.Column<int>(type: "int", nullable: false),
                    FinalScore = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_Teams_Team1ID",
                        column: x => x.Team1ID,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Games_Teams_Team2ID",
                        column: x => x.Team2ID,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HistoricalTeams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamID = table.Column<int>(type: "int", nullable: false),
                    SeasonStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SeasonEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SuperStarPlayer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricalTeams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoricalTeams_Teams_TeamID",
                        column: x => x.TeamID,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamID = table.Column<int>(type: "int", nullable: true),
                    PlayerPhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_Teams_TeamID",
                        column: x => x.TeamID,
                        principalTable: "Teams",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TeamHistoryLink",
                columns: table => new
                {
                    TeamID = table.Column<int>(type: "int", nullable: false),
                    HistoricalTeamID = table.Column<int>(type: "int", nullable: false),
                    LinkStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LinkEndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamHistoryLink", x => new { x.TeamID, x.HistoricalTeamID });
                    table.ForeignKey(
                        name: "FK_TeamHistoryLink_HistoricalTeams_HistoricalTeamID",
                        column: x => x.HistoricalTeamID,
                        principalTable: "HistoricalTeams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamHistoryLink_Teams_TeamID",
                        column: x => x.TeamID,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HistoricalPlayers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerID = table.Column<int>(type: "int", nullable: false),
                    TeamID = table.Column<int>(type: "int", nullable: false),
                    SeasonStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SeasonEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricalPlayers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoricalPlayers_HistoricalTeams_TeamID",
                        column: x => x.TeamID,
                        principalTable: "HistoricalTeams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistoricalPlayers_Players_PlayerID",
                        column: x => x.PlayerID,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerGamesStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameID = table.Column<int>(type: "int", nullable: false),
                    PlayerID = table.Column<int>(type: "int", nullable: false),
                    Points = table.Column<int>(type: "int", nullable: false),
                    Assists = table.Column<int>(type: "int", nullable: false),
                    Rebounds = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerGamesStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerGamesStats_Games_GameID",
                        column: x => x.GameID,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerGamesStats_Players_PlayerID",
                        column: x => x.PlayerID,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerHistoryLink",
                columns: table => new
                {
                    PlayerID = table.Column<int>(type: "int", nullable: false),
                    HistoricalPlayerID = table.Column<int>(type: "int", nullable: false),
                    LinkStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LinkEndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerHistoryLink", x => new { x.PlayerID, x.HistoricalPlayerID });
                    table.ForeignKey(
                        name: "FK_PlayerHistoryLink_HistoricalPlayers_HistoricalPlayerID",
                        column: x => x.HistoricalPlayerID,
                        principalTable: "HistoricalPlayers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerHistoryLink_Players_PlayerID",
                        column: x => x.PlayerID,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Coaches_TeamID",
                table: "Coaches",
                column: "TeamID");

            migrationBuilder.CreateIndex(
                name: "IX_Games_Team1ID",
                table: "Games",
                column: "Team1ID");

            migrationBuilder.CreateIndex(
                name: "IX_Games_Team2ID",
                table: "Games",
                column: "Team2ID");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricalPlayers_PlayerID",
                table: "HistoricalPlayers",
                column: "PlayerID");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricalPlayers_TeamID",
                table: "HistoricalPlayers",
                column: "TeamID");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricalTeams_TeamID",
                table: "HistoricalTeams",
                column: "TeamID");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerGamesStats_GameID",
                table: "PlayerGamesStats",
                column: "GameID");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerGamesStats_PlayerID",
                table: "PlayerGamesStats",
                column: "PlayerID");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerHistoryLink_HistoricalPlayerID",
                table: "PlayerHistoryLink",
                column: "HistoricalPlayerID");

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamID",
                table: "Players",
                column: "TeamID");

            migrationBuilder.CreateIndex(
                name: "IX_TeamHistoryLink_HistoricalTeamID",
                table: "TeamHistoryLink",
                column: "HistoricalTeamID");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_CityID",
                table: "Teams",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_ConferenceID",
                table: "Teams",
                column: "ConferenceID");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_StateID",
                table: "Teams",
                column: "StateID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coaches");

            migrationBuilder.DropTable(
                name: "PlayerGamesStats");

            migrationBuilder.DropTable(
                name: "PlayerHistoryLink");

            migrationBuilder.DropTable(
                name: "TeamHistoryLink");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "HistoricalPlayers");

            migrationBuilder.DropTable(
                name: "HistoricalTeams");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Conferences");

            migrationBuilder.DropTable(
                name: "States");
        }
    }
}
