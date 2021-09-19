using Microsoft.EntityFrameworkCore.Migrations;

namespace racesmiths.Migrations
{
    public partial class _018 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Champs_AspNetUsers_ChampUserId",
                table: "Champs");

            migrationBuilder.DropForeignKey(
                name: "FK_EventRSUser_AspNetUsers_ClubUsersId",
                table: "EventRSUser");

            migrationBuilder.DropIndex(
                name: "IX_Champs_ChampUserId",
                table: "Champs");

            migrationBuilder.DropColumn(
                name: "ChampUserId",
                table: "Champs");

            migrationBuilder.RenameColumn(
                name: "ClubUsersId",
                table: "EventRSUser",
                newName: "EventUsersId");

            migrationBuilder.CreateTable(
                name: "ChampRSUser",
                columns: table => new
                {
                    ChampUsersId = table.Column<string>(type: "text", nullable: false),
                    ChampsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChampRSUser", x => new { x.ChampUsersId, x.ChampsId });
                    table.ForeignKey(
                        name: "FK_ChampRSUser_AspNetUsers_ChampUsersId",
                        column: x => x.ChampUsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChampRSUser_Champs_ChampsId",
                        column: x => x.ChampsId,
                        principalTable: "Champs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChampRSUser_ChampsId",
                table: "ChampRSUser",
                column: "ChampsId");

            migrationBuilder.AddForeignKey(
                name: "FK_EventRSUser_AspNetUsers_EventUsersId",
                table: "EventRSUser",
                column: "EventUsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventRSUser_AspNetUsers_EventUsersId",
                table: "EventRSUser");

            migrationBuilder.DropTable(
                name: "ChampRSUser");

            migrationBuilder.RenameColumn(
                name: "EventUsersId",
                table: "EventRSUser",
                newName: "ClubUsersId");

            migrationBuilder.AddColumn<string>(
                name: "ChampUserId",
                table: "Champs",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Champs_ChampUserId",
                table: "Champs",
                column: "ChampUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Champs_AspNetUsers_ChampUserId",
                table: "Champs",
                column: "ChampUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EventRSUser_AspNetUsers_ClubUsersId",
                table: "EventRSUser",
                column: "ClubUsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
