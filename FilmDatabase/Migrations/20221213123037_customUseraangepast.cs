using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmDatabase.Migrations
{
    public partial class customUseraangepast : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Familienaam",
                schema: "Films",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Voornaam",
                schema: "Films",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "Naam",
                schema: "Films",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Naam",
                schema: "Films",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "Familienaam",
                schema: "Films",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Voornaam",
                schema: "Films",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
