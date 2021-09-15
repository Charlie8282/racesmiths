using Microsoft.EntityFrameworkCore.Migrations;

namespace racesmiths.Migrations
{
    public partial class _010 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Clubs_ClubId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Event_AspNetUsers_RSUserId",
                table: "Event");

            migrationBuilder.DropTable(
                name: "ClubUsers");

            migrationBuilder.DropIndex(
                name: "IX_Event_RSUserId",
                table: "Event");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ClubId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RSUserId",
                table: "Race");

            migrationBuilder.DropColumn(
                name: "RSUserId",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "ClubId",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "ClubRSUser",
                columns: table => new
                {
                    ClubUsersId = table.Column<string>(type: "text", nullable: false),
                    ClubsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubRSUser", x => new { x.ClubUsersId, x.ClubsId });
                    table.ForeignKey(
                        name: "FK_ClubRSUser_AspNetUsers_ClubUsersId",
                        column: x => x.ClubUsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClubRSUser_Clubs_ClubsId",
                        column: x => x.ClubsId,
                        principalTable: "Clubs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventRSUser",
                columns: table => new
                {
                    ClubUsersId = table.Column<string>(type: "text", nullable: false),
                    EventsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventRSUser", x => new { x.ClubUsersId, x.EventsId });
                    table.ForeignKey(
                        name: "FK_EventRSUser_AspNetUsers_ClubUsersId",
                        column: x => x.ClubUsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventRSUser_Event_EventsId",
                        column: x => x.EventsId,
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RSUserRace",
                columns: table => new
                {
                    ClubUsersId = table.Column<string>(type: "text", nullable: false),
                    RacesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RSUserRace", x => new { x.ClubUsersId, x.RacesId });
                    table.ForeignKey(
                        name: "FK_RSUserRace_AspNetUsers_ClubUsersId",
                        column: x => x.ClubUsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RSUserRace_Race_RacesId",
                        column: x => x.RacesId,
                        principalTable: "Race",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClubRSUser_ClubsId",
                table: "ClubRSUser",
                column: "ClubsId");

            migrationBuilder.CreateIndex(
                name: "IX_EventRSUser_EventsId",
                table: "EventRSUser",
                column: "EventsId");

            migrationBuilder.CreateIndex(
                name: "IX_RSUserRace_RacesId",
                table: "RSUserRace",
                column: "RacesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClubRSUser");

            migrationBuilder.DropTable(
                name: "EventRSUser");

            migrationBuilder.DropTable(
                name: "RSUserRace");

            migrationBuilder.AddColumn<string>(
                name: "RSUserId",
                table: "Race",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RSUserId",
                table: "Event",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClubId",
                table: "AspNetUsers",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ClubUsers",
                columns: table => new
                {
                    ClubId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    EventId = table.Column<int>(type: "integer", nullable: true),
                    RaceId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubUsers", x => new { x.ClubId, x.UserId });
                    table.ForeignKey(
                        name: "FK_ClubUsers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClubUsers_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClubUsers_Event_EventId",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClubUsers_Race_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Race",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Event_RSUserId",
                table: "Event",
                column: "RSUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ClubId",
                table: "AspNetUsers",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_ClubUsers_EventId",
                table: "ClubUsers",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_ClubUsers_RaceId",
                table: "ClubUsers",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_ClubUsers_UserId",
                table: "ClubUsers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Clubs_ClubId",
                table: "AspNetUsers",
                column: "ClubId",
                principalTable: "Clubs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Event_AspNetUsers_RSUserId",
                table: "Event",
                column: "RSUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
