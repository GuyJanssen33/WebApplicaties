using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmDatabase.Migrations
{
    public partial class CustomUserData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favoriet_AspNetUsers_GebruikerId1",
                schema: "Films",
                table: "Favoriet");

            migrationBuilder.DropColumn(
                name: "Geslacht",
                schema: "Films",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                schema: "Films",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<DateTime>(
                name: "GeboorteDatum",
                schema: "Films",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Gebruiker",
                schema: "Films",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Voornaam = table.Column<string>(nullable: true),
                    Familienaam = table.Column<string>(nullable: true),
                    Geslacht = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gebruiker", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Favoriet_Gebruiker_GebruikerId1",
                schema: "Films",
                table: "Favoriet",
                column: "GebruikerId1",
                principalSchema: "Films",
                principalTable: "Gebruiker",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favoriet_Gebruiker_GebruikerId1",
                schema: "Films",
                table: "Favoriet");

            migrationBuilder.DropTable(
                name: "Gebruiker",
                schema: "Films");

            migrationBuilder.DropColumn(
                name: "GeboorteDatum",
                schema: "Films",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<bool>(
                name: "Geslacht",
                schema: "Films",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                schema: "Films",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Favoriet_AspNetUsers_GebruikerId1",
                schema: "Films",
                table: "Favoriet",
                column: "GebruikerId1",
                principalSchema: "Films",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
