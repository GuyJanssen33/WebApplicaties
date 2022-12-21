using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmDatabase.Migrations
{
    public partial class geboortedatumToegevoegd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Geboortedatum",
                schema: "Films",
                table: "Gebruiker",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Geboortedatum",
                schema: "Films",
                table: "Gebruiker");
        }
    }
}
