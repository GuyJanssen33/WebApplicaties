using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmDatabase.Migrations
{
    public partial class Favoriet_aangepast : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "GebruikerId",
                schema: "Films",
                table: "Favoriet");

            migrationBuilder.AlterColumn<int>(
                name: "CustomUserId",
                schema: "Films",
                table: "Favoriet",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CustomUserId",
                schema: "Films",
                table: "Favoriet",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "GebruikerId",
                schema: "Films",
                table: "Favoriet",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
