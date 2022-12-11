using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicatie_GuyJanssen_r0237357.Data.Migrations
{
    public partial class VeldPosterToegevoegd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Poster",
                schema: "Films",
                table: "Film",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Poster",
                schema: "Films",
                table: "Film");
        }
    }
}
