﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BasketApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "PlayerHistoryLink",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "PlayerHistoryLink");
        }
    }
}
