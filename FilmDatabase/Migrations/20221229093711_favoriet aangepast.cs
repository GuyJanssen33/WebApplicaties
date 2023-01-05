using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmDatabase.Migrations
{
    public partial class favorietaangepast : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CustomUserId",
                schema: "Films",
                table: "Favoriet",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CustomUserId",
                schema: "Films",
                table: "Favoriet",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
