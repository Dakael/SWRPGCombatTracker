using Microsoft.EntityFrameworkCore.Migrations;

namespace SWRPGCombatTracker.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DestinyPoints",
                columns: table => new
                {
                    Dark = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Light = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DestinyPoints", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Agility = table.Column<int>(nullable: false),
                    Brawn = table.Column<int>(nullable: false),
                    Career = table.Column<string>(nullable: false),
                    CharacterName = table.Column<string>(nullable: false),
                    Credits = table.Column<int>(nullable: false),
                    Cunning = table.Column<int>(nullable: false),
                    CurrentStrain = table.Column<int>(nullable: false),
                    CurrentWounds = table.Column<int>(nullable: false),
                    CurrentXP = table.Column<int>(nullable: false),
                    Encumberance = table.Column<int>(nullable: false),
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Intellect = table.Column<int>(nullable: false),
                    MaxEncumberance = table.Column<int>(nullable: false),
                    MeleeDefense = table.Column<int>(nullable: false),
                    Morality = table.Column<int>(nullable: false),
                    Presence = table.Column<int>(nullable: false),
                    RangedDefense = table.Column<int>(nullable: false),
                    SoakValue = table.Column<int>(nullable: false),
                    Species = table.Column<string>(nullable: false),
                    StrainThreshold = table.Column<int>(nullable: false),
                    TotalXP = table.Column<int>(nullable: false),
                    Willpower = table.Column<int>(nullable: false),
                    WoundThreshold = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "IndividualObligations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Obligation = table.Column<string>(nullable: false),
                    Value = table.Column<int>(nullable: false),
                    PlayerModelID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndividualObligations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndividualObligations_Players_PlayerModelID",
                        column: x => x.PlayerModelID,
                        principalTable: "Players",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PartyObligations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Obligation = table.Column<string>(nullable: false),
                    Value = table.Column<int>(nullable: false),
                    PlayerModelID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartyObligations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PartyObligations_Players_PlayerModelID",
                        column: x => x.PlayerModelID,
                        principalTable: "Players",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Specializations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Specialization = table.Column<string>(nullable: false),
                    PlayerModelID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specializations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Specializations_Players_PlayerModelID",
                        column: x => x.PlayerModelID,
                        principalTable: "Players",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IndividualObligations_PlayerModelID",
                table: "IndividualObligations",
                column: "PlayerModelID");

            migrationBuilder.CreateIndex(
                name: "IX_PartyObligations_PlayerModelID",
                table: "PartyObligations",
                column: "PlayerModelID");

            migrationBuilder.CreateIndex(
                name: "IX_Specializations_PlayerModelID",
                table: "Specializations",
                column: "PlayerModelID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DestinyPoints");

            migrationBuilder.DropTable(
                name: "IndividualObligations");

            migrationBuilder.DropTable(
                name: "PartyObligations");

            migrationBuilder.DropTable(
                name: "Specializations");

            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
