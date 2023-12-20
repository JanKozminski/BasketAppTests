using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BasketApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HistoricalPlayers_HistoricalTeams_TeamID",
                table: "HistoricalPlayers");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerHistoryLink_Players_PlayerID",
                table: "PlayerHistoryLink");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamHistoryLink_Teams_TeamID",
                table: "TeamHistoryLink");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TeamHistoryLink",
                table: "TeamHistoryLink");

            migrationBuilder.DropIndex(
                name: "IX_TeamHistoryLink_HistoricalTeamID",
                table: "TeamHistoryLink");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlayerHistoryLink",
                table: "PlayerHistoryLink");

            migrationBuilder.DropIndex(
                name: "IX_PlayerHistoryLink_HistoricalPlayerID",
                table: "PlayerHistoryLink");

            migrationBuilder.DropIndex(
                name: "IX_HistoricalPlayers_TeamID",
                table: "HistoricalPlayers");

            migrationBuilder.DropColumn(
                name: "TeamID",
                table: "HistoricalPlayers");

            migrationBuilder.RenameColumn(
                name: "LinkStartDate",
                table: "TeamHistoryLink",
                newName: "SeasonStartDate");

            migrationBuilder.RenameColumn(
                name: "LinkEndDate",
                table: "TeamHistoryLink",
                newName: "SeasonEndDate");

            migrationBuilder.RenameColumn(
                name: "TeamID",
                table: "TeamHistoryLink",
                newName: "HistoricalPlayerID");

            migrationBuilder.RenameColumn(
                name: "LinkStartDate",
                table: "PlayerHistoryLink",
                newName: "SeasonStartDate");

            migrationBuilder.RenameColumn(
                name: "LinkEndDate",
                table: "PlayerHistoryLink",
                newName: "SeasonEndDate");

            migrationBuilder.RenameColumn(
                name: "PlayerID",
                table: "PlayerHistoryLink",
                newName: "HistoricalTeamID");

            migrationBuilder.RenameColumn(
                name: "SeasonStartDate",
                table: "HistoricalPlayers",
                newName: "DraftDate");

            migrationBuilder.RenameColumn(
                name: "SeasonEndDate",
                table: "HistoricalPlayers",
                newName: "EndOfCareerDate");

            migrationBuilder.AlterColumn<int>(
                name: "HistoricalTeamID",
                table: "TeamHistoryLink",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<int>(
                name: "HistoricalPlayerID",
                table: "TeamHistoryLink",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("Relational:ColumnOrder", 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeamHistoryLink",
                table: "TeamHistoryLink",
                columns: new[] { "HistoricalTeamID", "HistoricalPlayerID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlayerHistoryLink",
                table: "PlayerHistoryLink",
                columns: new[] { "HistoricalPlayerID", "HistoricalTeamID" });

            migrationBuilder.CreateIndex(
                name: "IX_TeamHistoryLink_HistoricalPlayerID",
                table: "TeamHistoryLink",
                column: "HistoricalPlayerID");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerHistoryLink_HistoricalTeamID",
                table: "PlayerHistoryLink",
                column: "HistoricalTeamID");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerHistoryLink_HistoricalTeams_HistoricalTeamID",
                table: "PlayerHistoryLink",
                column: "HistoricalTeamID",
                principalTable: "HistoricalTeams",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamHistoryLink_HistoricalPlayers_HistoricalPlayerID",
                table: "TeamHistoryLink",
                column: "HistoricalPlayerID",
                principalTable: "HistoricalPlayers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerHistoryLink_HistoricalTeams_HistoricalTeamID",
                table: "PlayerHistoryLink");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamHistoryLink_HistoricalPlayers_HistoricalPlayerID",
                table: "TeamHistoryLink");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TeamHistoryLink",
                table: "TeamHistoryLink");

            migrationBuilder.DropIndex(
                name: "IX_TeamHistoryLink_HistoricalPlayerID",
                table: "TeamHistoryLink");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlayerHistoryLink",
                table: "PlayerHistoryLink");

            migrationBuilder.DropIndex(
                name: "IX_PlayerHistoryLink_HistoricalTeamID",
                table: "PlayerHistoryLink");

            migrationBuilder.RenameColumn(
                name: "SeasonStartDate",
                table: "TeamHistoryLink",
                newName: "LinkStartDate");

            migrationBuilder.RenameColumn(
                name: "SeasonEndDate",
                table: "TeamHistoryLink",
                newName: "LinkEndDate");

            migrationBuilder.RenameColumn(
                name: "HistoricalPlayerID",
                table: "TeamHistoryLink",
                newName: "TeamID");

            migrationBuilder.RenameColumn(
                name: "SeasonStartDate",
                table: "PlayerHistoryLink",
                newName: "LinkStartDate");

            migrationBuilder.RenameColumn(
                name: "SeasonEndDate",
                table: "PlayerHistoryLink",
                newName: "LinkEndDate");

            migrationBuilder.RenameColumn(
                name: "HistoricalTeamID",
                table: "PlayerHistoryLink",
                newName: "PlayerID");

            migrationBuilder.RenameColumn(
                name: "EndOfCareerDate",
                table: "HistoricalPlayers",
                newName: "SeasonEndDate");

            migrationBuilder.RenameColumn(
                name: "DraftDate",
                table: "HistoricalPlayers",
                newName: "SeasonStartDate");

            migrationBuilder.AlterColumn<int>(
                name: "HistoricalTeamID",
                table: "TeamHistoryLink",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<int>(
                name: "TeamID",
                table: "TeamHistoryLink",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 0);

            migrationBuilder.AddColumn<int>(
                name: "TeamID",
                table: "HistoricalPlayers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeamHistoryLink",
                table: "TeamHistoryLink",
                columns: new[] { "TeamID", "HistoricalTeamID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlayerHistoryLink",
                table: "PlayerHistoryLink",
                columns: new[] { "PlayerID", "HistoricalPlayerID" });

            migrationBuilder.CreateIndex(
                name: "IX_TeamHistoryLink_HistoricalTeamID",
                table: "TeamHistoryLink",
                column: "HistoricalTeamID");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerHistoryLink_HistoricalPlayerID",
                table: "PlayerHistoryLink",
                column: "HistoricalPlayerID");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricalPlayers_TeamID",
                table: "HistoricalPlayers",
                column: "TeamID");

            migrationBuilder.AddForeignKey(
                name: "FK_HistoricalPlayers_HistoricalTeams_TeamID",
                table: "HistoricalPlayers",
                column: "TeamID",
                principalTable: "HistoricalTeams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerHistoryLink_Players_PlayerID",
                table: "PlayerHistoryLink",
                column: "PlayerID",
                principalTable: "Players",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamHistoryLink_Teams_TeamID",
                table: "TeamHistoryLink",
                column: "TeamID",
                principalTable: "Teams",
                principalColumn: "Id");
        }
    }
}
