using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicatie_GuyJanssen_r0237357.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Films");

            migrationBuilder.CreateTable(
                name: "Acteur",
                schema: "Films",
                columns: table => new
                {
                    ActeurId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Voornaam = table.Column<string>(nullable: true),
                    Familienaam = table.Column<string>(nullable: true),
                    GeboorteDatum = table.Column<DateTime>(nullable: true),
                    GeboortePlaats = table.Column<string>(nullable: true),
                    GeboorteLand = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acteur", x => x.ActeurId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                schema: "Films",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                schema: "Films",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
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
                    Discriminator = table.Column<string>(nullable: false),
                    Voornaam = table.Column<string>(nullable: true),
                    Familienaam = table.Column<string>(nullable: true),
                    Geslacht = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Film",
                schema: "Films",
                columns: table => new
                {
                    FilmId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titel = table.Column<string>(nullable: false),
                    Genre = table.Column<string>(nullable: false),
                    Lengte = table.Column<string>(nullable: false),
                    Schrijver = table.Column<string>(nullable: false),
                    Samenvatting = table.Column<string>(nullable: true),
                    ReleaseDatum = table.Column<DateTime>(nullable: true),
                    Verdeler = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Film", x => x.FilmId);
                });

            migrationBuilder.CreateTable(
                name: "Producent",
                schema: "Films",
                columns: table => new
                {
                    ProducentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Voornaam = table.Column<string>(nullable: true),
                    Familienaam = table.Column<string>(nullable: true),
                    GeboorteDatum = table.Column<DateTime>(nullable: true),
                    GeboortePlaats = table.Column<string>(nullable: true),
                    GeboorteLand = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producent", x => x.ProducentId);
                });

            migrationBuilder.CreateTable(
                name: "Regisseur",
                schema: "Films",
                columns: table => new
                {
                    RegisseurId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Voornaam = table.Column<string>(nullable: true),
                    Familienaam = table.Column<string>(nullable: true),
                    GeboorteDatum = table.Column<DateTime>(nullable: true),
                    GeboortePlaats = table.Column<string>(nullable: true),
                    GeboorteLand = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regisseur", x => x.RegisseurId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                schema: "Films",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Films",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                schema: "Films",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "Films",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                schema: "Films",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "Films",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                schema: "Films",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Films",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "Films",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                schema: "Films",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "Films",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Favoriet",
                schema: "Films",
                columns: table => new
                {
                    FavorietId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmId = table.Column<int>(nullable: false),
                    GebruikerId = table.Column<int>(nullable: false),
                    GebruikerId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favoriet", x => x.FavorietId);
                    table.ForeignKey(
                        name: "FK_Favoriet_Film_FilmId",
                        column: x => x.FilmId,
                        principalSchema: "Films",
                        principalTable: "Film",
                        principalColumn: "FilmId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Favoriet_AspNetUsers_GebruikerId1",
                        column: x => x.GebruikerId1,
                        principalSchema: "Films",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FilmActeur",
                schema: "Films",
                columns: table => new
                {
                    FilmActeurId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmId = table.Column<int>(nullable: false),
                    ActeurId = table.Column<int>(nullable: false),
                    Personage = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmActeur", x => x.FilmActeurId);
                    table.ForeignKey(
                        name: "FK_FilmActeur_Acteur_ActeurId",
                        column: x => x.ActeurId,
                        principalSchema: "Films",
                        principalTable: "Acteur",
                        principalColumn: "ActeurId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmActeur_Film_FilmId",
                        column: x => x.FilmId,
                        principalSchema: "Films",
                        principalTable: "Film",
                        principalColumn: "FilmId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmProducent",
                schema: "Films",
                columns: table => new
                {
                    FilmProducentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmId = table.Column<int>(nullable: false),
                    ProducentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmProducent", x => x.FilmProducentId);
                    table.ForeignKey(
                        name: "FK_FilmProducent_Film_FilmId",
                        column: x => x.FilmId,
                        principalSchema: "Films",
                        principalTable: "Film",
                        principalColumn: "FilmId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmProducent_Producent_ProducentId",
                        column: x => x.ProducentId,
                        principalSchema: "Films",
                        principalTable: "Producent",
                        principalColumn: "ProducentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmRegisseur",
                schema: "Films",
                columns: table => new
                {
                    FilmRegisseurId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmId = table.Column<int>(nullable: false),
                    RegisseurId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmRegisseur", x => x.FilmRegisseurId);
                    table.ForeignKey(
                        name: "FK_FilmRegisseur_Film_FilmId",
                        column: x => x.FilmId,
                        principalSchema: "Films",
                        principalTable: "Film",
                        principalColumn: "FilmId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmRegisseur_Regisseur_RegisseurId",
                        column: x => x.RegisseurId,
                        principalSchema: "Films",
                        principalTable: "Regisseur",
                        principalColumn: "RegisseurId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                schema: "Films",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "Films",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                schema: "Films",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                schema: "Films",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                schema: "Films",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "Films",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "Films",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Favoriet_FilmId",
                schema: "Films",
                table: "Favoriet",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_Favoriet_GebruikerId1",
                schema: "Films",
                table: "Favoriet",
                column: "GebruikerId1");

            migrationBuilder.CreateIndex(
                name: "IX_FilmActeur_ActeurId",
                schema: "Films",
                table: "FilmActeur",
                column: "ActeurId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmActeur_FilmId",
                schema: "Films",
                table: "FilmActeur",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmProducent_FilmId",
                schema: "Films",
                table: "FilmProducent",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmProducent_ProducentId",
                schema: "Films",
                table: "FilmProducent",
                column: "ProducentId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmRegisseur_FilmId",
                schema: "Films",
                table: "FilmRegisseur",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmRegisseur_RegisseurId",
                schema: "Films",
                table: "FilmRegisseur",
                column: "RegisseurId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims",
                schema: "Films");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims",
                schema: "Films");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins",
                schema: "Films");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles",
                schema: "Films");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens",
                schema: "Films");

            migrationBuilder.DropTable(
                name: "Favoriet",
                schema: "Films");

            migrationBuilder.DropTable(
                name: "FilmActeur",
                schema: "Films");

            migrationBuilder.DropTable(
                name: "FilmProducent",
                schema: "Films");

            migrationBuilder.DropTable(
                name: "FilmRegisseur",
                schema: "Films");

            migrationBuilder.DropTable(
                name: "AspNetRoles",
                schema: "Films");

            migrationBuilder.DropTable(
                name: "AspNetUsers",
                schema: "Films");

            migrationBuilder.DropTable(
                name: "Acteur",
                schema: "Films");

            migrationBuilder.DropTable(
                name: "Producent",
                schema: "Films");

            migrationBuilder.DropTable(
                name: "Film",
                schema: "Films");

            migrationBuilder.DropTable(
                name: "Regisseur",
                schema: "Films");
        }
    }
}
