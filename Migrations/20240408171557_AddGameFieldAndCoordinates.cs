using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GuidonApp.Migrations
{
    /// <inheritdoc />
    public partial class AddGameFieldAndCoordinates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bosses",
                columns: table => new
                {
                    BossID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Health = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bosses", x => x.BossID);
                });

            migrationBuilder.CreateTable(
                name: "GameField",
                columns: table => new
                {
                    GameFieldID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Width = table.Column<int>(type: "INTEGER", nullable: false),
                    Height = table.Column<int>(type: "INTEGER", nullable: false),
                    HeroID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameField", x => x.GameFieldID);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemID);
                });

            migrationBuilder.CreateTable(
                name: "NPCs",
                columns: table => new
                {
                    NPCID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NPCs", x => x.NPCID);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    SkillID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Cooldown = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.SkillID);
                });

            migrationBuilder.CreateTable(
                name: "GameFieldBoss",
                columns: table => new
                {
                    GameFieldID = table.Column<int>(type: "INTEGER", nullable: false),
                    BossID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameFieldBoss", x => new { x.BossID, x.GameFieldID });
                    table.ForeignKey(
                        name: "FK_GameFieldBoss_Bosses_BossID",
                        column: x => x.BossID,
                        principalTable: "Bosses",
                        principalColumn: "BossID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameFieldBoss_GameField_GameFieldID",
                        column: x => x.GameFieldID,
                        principalTable: "GameField",
                        principalColumn: "GameFieldID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Heroes",
                columns: table => new
                {
                    HeroID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    Health = table.Column<int>(type: "INTEGER", nullable: false),
                    Mana = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    PositionX = table.Column<int>(type: "INTEGER", nullable: false),
                    PositionY = table.Column<int>(type: "INTEGER", nullable: false),
                    GameFieldID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heroes", x => x.HeroID);
                    table.ForeignKey(
                        name: "FK_Heroes_GameField_GameFieldID",
                        column: x => x.GameFieldID,
                        principalTable: "GameField",
                        principalColumn: "GameFieldID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BossesDrops",
                columns: table => new
                {
                    BossID = table.Column<int>(type: "INTEGER", nullable: false),
                    ItemID = table.Column<int>(type: "INTEGER", nullable: false),
                    DropRate = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BossesDrops", x => new { x.BossID, x.ItemID });
                    table.ForeignKey(
                        name: "FK_BossesDrops_Bosses_BossID",
                        column: x => x.BossID,
                        principalTable: "Bosses",
                        principalColumn: "BossID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BossesDrops_Items_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GameFieldNPC",
                columns: table => new
                {
                    GameFieldID = table.Column<int>(type: "INTEGER", nullable: false),
                    NPCID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameFieldNPC", x => new { x.NPCID, x.GameFieldID });
                    table.ForeignKey(
                        name: "FK_GameFieldNPC_GameField_GameFieldID",
                        column: x => x.GameFieldID,
                        principalTable: "GameField",
                        principalColumn: "GameFieldID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameFieldNPC_NPCs_NPCID",
                        column: x => x.NPCID,
                        principalTable: "NPCs",
                        principalColumn: "NPCID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NPCsItems",
                columns: table => new
                {
                    NPCID = table.Column<int>(type: "INTEGER", nullable: false),
                    ItemID = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NPCsItems", x => new { x.NPCID, x.ItemID });
                    table.ForeignKey(
                        name: "FK_NPCsItems_Items_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NPCsItems_NPCs_NPCID",
                        column: x => x.NPCID,
                        principalTable: "NPCs",
                        principalColumn: "NPCID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BossesSkills",
                columns: table => new
                {
                    BossID = table.Column<int>(type: "INTEGER", nullable: false),
                    SkillID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BossesSkills", x => new { x.BossID, x.SkillID });
                    table.ForeignKey(
                        name: "FK_BossesSkills_Bosses_BossID",
                        column: x => x.BossID,
                        principalTable: "Bosses",
                        principalColumn: "BossID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BossesSkills_Skills_SkillID",
                        column: x => x.SkillID,
                        principalTable: "Skills",
                        principalColumn: "SkillID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HeroesSkills",
                columns: table => new
                {
                    HeroID = table.Column<int>(type: "INTEGER", nullable: false),
                    SkillID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroesSkills", x => new { x.SkillID, x.HeroID });
                    table.ForeignKey(
                        name: "FK_HeroesSkills_Heroes_HeroID",
                        column: x => x.HeroID,
                        principalTable: "Heroes",
                        principalColumn: "HeroID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HeroesSkills_Skills_SkillID",
                        column: x => x.SkillID,
                        principalTable: "Skills",
                        principalColumn: "SkillID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    InventoryID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ItemID = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    HeroId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.InventoryID);
                    table.ForeignKey(
                        name: "FK_Inventories_Heroes_HeroId",
                        column: x => x.HeroId,
                        principalTable: "Heroes",
                        principalColumn: "HeroID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inventories_Items_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BossesDrops_ItemID",
                table: "BossesDrops",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_BossesSkills_SkillID",
                table: "BossesSkills",
                column: "SkillID");

            migrationBuilder.CreateIndex(
                name: "IX_GameFieldBoss_GameFieldID",
                table: "GameFieldBoss",
                column: "GameFieldID");

            migrationBuilder.CreateIndex(
                name: "IX_GameFieldNPC_GameFieldID",
                table: "GameFieldNPC",
                column: "GameFieldID");

            migrationBuilder.CreateIndex(
                name: "IX_Heroes_GameFieldID",
                table: "Heroes",
                column: "GameFieldID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HeroesSkills_HeroID",
                table: "HeroesSkills",
                column: "HeroID");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_HeroId",
                table: "Inventories",
                column: "HeroId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_ItemID",
                table: "Inventories",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_NPCsItems_ItemID",
                table: "NPCsItems",
                column: "ItemID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BossesDrops");

            migrationBuilder.DropTable(
                name: "BossesSkills");

            migrationBuilder.DropTable(
                name: "GameFieldBoss");

            migrationBuilder.DropTable(
                name: "GameFieldNPC");

            migrationBuilder.DropTable(
                name: "HeroesSkills");

            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DropTable(
                name: "NPCsItems");

            migrationBuilder.DropTable(
                name: "Bosses");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Heroes");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "NPCs");

            migrationBuilder.DropTable(
                name: "GameField");
        }
    }
}
