using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmDatabase.Migrations
{
    public partial class CustomuserNogEensAangepast : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favoriet_Gebruiker_GebruikerId1",
                schema: "Films",
                table: "Favoriet");

            migrationBuilder.DropTable(
                name: "Gebruiker",
                schema: "Films");

            migrationBuilder.DropIndex(
                name: "IX_Favoriet_GebruikerId1",
                schema: "Films",
                table: "Favoriet");

            migrationBuilder.DropColumn(
                name: "GebruikerId1",
                schema: "Films",
                table: "Favoriet");

            migrationBuilder.DropColumn(
                name: "Naam",
                schema: "Films",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "GeboorteDatum",
                schema: "Films",
                table: "AspNetUsers",
                newName: "Geboortedatum");

            migrationBuilder.AddColumn<string>(
                name: "CustomUserId",
                schema: "Films",
                table: "Favoriet",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Geboortedatum",
                schema: "Films",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "Familienaam",
                schema: "Films",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Geslacht",
                schema: "Films",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Voornaam",
                schema: "Films",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Favoriet_CustomUserId",
                schema: "Films",
                table: "Favoriet",
                column: "CustomUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Favoriet_AspNetUsers_CustomUserId",
                schema: "Films",
                table: "Favoriet",
                column: "CustomUserId",
                principalSchema: "Films",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favoriet_AspNetUsers_CustomUserId",
                schema: "Films",
                table: "Favoriet");

            migrationBuilder.DropIndex(
                name: "IX_Favoriet_CustomUserId",
                schema: "Films",
                table: "Favoriet");

            migrationBuilder.DropColumn(
                name: "CustomUserId",
                schema: "Films",
                table: "Favoriet");

            migrationBuilder.DropColumn(
                name: "Familienaam",
                schema: "Films",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Geslacht",
                schema: "Films",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Voornaam",
                schema: "Films",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Geboortedatum",
                schema: "Films",
                table: "AspNetUsers",
                newName: "GeboorteDatum");

            migrationBuilder.AddColumn<string>(
                name: "GebruikerId1",
                schema: "Films",
                table: "Favoriet",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "GeboorteDatum",
                schema: "Films",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Naam",
                schema: "Films",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Gebruiker",
                schema: "Films",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    Familienaam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Geboortedatum = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Geslacht = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Voornaam = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gebruiker", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Favoriet_GebruikerId1",
                schema: "Films",
                table: "Favoriet",
                column: "GebruikerId1");

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
    }
}
