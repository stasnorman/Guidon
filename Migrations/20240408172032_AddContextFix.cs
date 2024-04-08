using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GuidonApp.Migrations
{
    /// <inheritdoc />
    public partial class AddContextFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameFieldBoss_Bosses_BossID",
                table: "GameFieldBoss");

            migrationBuilder.DropForeignKey(
                name: "FK_GameFieldBoss_GameField_GameFieldID",
                table: "GameFieldBoss");

            migrationBuilder.DropForeignKey(
                name: "FK_GameFieldNPC_GameField_GameFieldID",
                table: "GameFieldNPC");

            migrationBuilder.DropForeignKey(
                name: "FK_GameFieldNPC_NPCs_NPCID",
                table: "GameFieldNPC");

            migrationBuilder.DropForeignKey(
                name: "FK_Heroes_GameField_GameFieldID",
                table: "Heroes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameFieldNPC",
                table: "GameFieldNPC");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameFieldBoss",
                table: "GameFieldBoss");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameField",
                table: "GameField");

            migrationBuilder.RenameTable(
                name: "GameFieldNPC",
                newName: "GameFieldNPCs");

            migrationBuilder.RenameTable(
                name: "GameFieldBoss",
                newName: "GameFieldBosses");

            migrationBuilder.RenameTable(
                name: "GameField",
                newName: "GameFields");

            migrationBuilder.RenameIndex(
                name: "IX_GameFieldNPC_GameFieldID",
                table: "GameFieldNPCs",
                newName: "IX_GameFieldNPCs_GameFieldID");

            migrationBuilder.RenameIndex(
                name: "IX_GameFieldBoss_GameFieldID",
                table: "GameFieldBosses",
                newName: "IX_GameFieldBosses_GameFieldID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameFieldNPCs",
                table: "GameFieldNPCs",
                columns: new[] { "NPCID", "GameFieldID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameFieldBosses",
                table: "GameFieldBosses",
                columns: new[] { "BossID", "GameFieldID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameFields",
                table: "GameFields",
                column: "GameFieldID");

            migrationBuilder.AddForeignKey(
                name: "FK_GameFieldBosses_Bosses_BossID",
                table: "GameFieldBosses",
                column: "BossID",
                principalTable: "Bosses",
                principalColumn: "BossID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameFieldBosses_GameFields_GameFieldID",
                table: "GameFieldBosses",
                column: "GameFieldID",
                principalTable: "GameFields",
                principalColumn: "GameFieldID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameFieldNPCs_GameFields_GameFieldID",
                table: "GameFieldNPCs",
                column: "GameFieldID",
                principalTable: "GameFields",
                principalColumn: "GameFieldID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameFieldNPCs_NPCs_NPCID",
                table: "GameFieldNPCs",
                column: "NPCID",
                principalTable: "NPCs",
                principalColumn: "NPCID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Heroes_GameFields_GameFieldID",
                table: "Heroes",
                column: "GameFieldID",
                principalTable: "GameFields",
                principalColumn: "GameFieldID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameFieldBosses_Bosses_BossID",
                table: "GameFieldBosses");

            migrationBuilder.DropForeignKey(
                name: "FK_GameFieldBosses_GameFields_GameFieldID",
                table: "GameFieldBosses");

            migrationBuilder.DropForeignKey(
                name: "FK_GameFieldNPCs_GameFields_GameFieldID",
                table: "GameFieldNPCs");

            migrationBuilder.DropForeignKey(
                name: "FK_GameFieldNPCs_NPCs_NPCID",
                table: "GameFieldNPCs");

            migrationBuilder.DropForeignKey(
                name: "FK_Heroes_GameFields_GameFieldID",
                table: "Heroes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameFields",
                table: "GameFields");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameFieldNPCs",
                table: "GameFieldNPCs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameFieldBosses",
                table: "GameFieldBosses");

            migrationBuilder.RenameTable(
                name: "GameFields",
                newName: "GameField");

            migrationBuilder.RenameTable(
                name: "GameFieldNPCs",
                newName: "GameFieldNPC");

            migrationBuilder.RenameTable(
                name: "GameFieldBosses",
                newName: "GameFieldBoss");

            migrationBuilder.RenameIndex(
                name: "IX_GameFieldNPCs_GameFieldID",
                table: "GameFieldNPC",
                newName: "IX_GameFieldNPC_GameFieldID");

            migrationBuilder.RenameIndex(
                name: "IX_GameFieldBosses_GameFieldID",
                table: "GameFieldBoss",
                newName: "IX_GameFieldBoss_GameFieldID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameField",
                table: "GameField",
                column: "GameFieldID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameFieldNPC",
                table: "GameFieldNPC",
                columns: new[] { "NPCID", "GameFieldID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameFieldBoss",
                table: "GameFieldBoss",
                columns: new[] { "BossID", "GameFieldID" });

            migrationBuilder.AddForeignKey(
                name: "FK_GameFieldBoss_Bosses_BossID",
                table: "GameFieldBoss",
                column: "BossID",
                principalTable: "Bosses",
                principalColumn: "BossID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameFieldBoss_GameField_GameFieldID",
                table: "GameFieldBoss",
                column: "GameFieldID",
                principalTable: "GameField",
                principalColumn: "GameFieldID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameFieldNPC_GameField_GameFieldID",
                table: "GameFieldNPC",
                column: "GameFieldID",
                principalTable: "GameField",
                principalColumn: "GameFieldID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameFieldNPC_NPCs_NPCID",
                table: "GameFieldNPC",
                column: "NPCID",
                principalTable: "NPCs",
                principalColumn: "NPCID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Heroes_GameField_GameFieldID",
                table: "Heroes",
                column: "GameFieldID",
                principalTable: "GameField",
                principalColumn: "GameFieldID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
