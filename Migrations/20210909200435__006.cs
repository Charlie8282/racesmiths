using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace racesmiths.Migrations
{
    public partial class _006 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Event_EventId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Champs_AspNetUsers_UserId",
                table: "Champs");

            migrationBuilder.DropTable(
                name: "Round");

            migrationBuilder.DropIndex(
                name: "IX_Champs_UserId",
                table: "Champs");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_EventId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Champs");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "QualifyLength",
                table: "Race",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RaceNumber",
                table: "Race",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RoundNumber",
                table: "Event",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "ClubUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RaceId",
                table: "ClubUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ChampUserId",
                table: "Champs",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Event_RSUserId",
                table: "Event",
                column: "RSUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ClubUsers_EventId",
                table: "ClubUsers",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_ClubUsers_RaceId",
                table: "ClubUsers",
                column: "RaceId");

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
                name: "FK_ClubUsers_Event_EventId",
                table: "ClubUsers",
                column: "EventId",
                principalTable: "Event",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClubUsers_Race_RaceId",
                table: "ClubUsers",
                column: "RaceId",
                principalTable: "Race",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Champs_AspNetUsers_ChampUserId",
                table: "Champs");

            migrationBuilder.DropForeignKey(
                name: "FK_ClubUsers_Event_EventId",
                table: "ClubUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_ClubUsers_Race_RaceId",
                table: "ClubUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Event_AspNetUsers_RSUserId",
                table: "Event");

            migrationBuilder.DropIndex(
                name: "IX_Event_RSUserId",
                table: "Event");

            migrationBuilder.DropIndex(
                name: "IX_ClubUsers_EventId",
                table: "ClubUsers");

            migrationBuilder.DropIndex(
                name: "IX_ClubUsers_RaceId",
                table: "ClubUsers");

            migrationBuilder.DropIndex(
                name: "IX_Champs_ChampUserId",
                table: "Champs");

            migrationBuilder.DropColumn(
                name: "QualifyLength",
                table: "Race");

            migrationBuilder.DropColumn(
                name: "RaceNumber",
                table: "Race");

            migrationBuilder.DropColumn(
                name: "RoundNumber",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "ClubUsers");

            migrationBuilder.DropColumn(
                name: "RaceId",
                table: "ClubUsers");

            migrationBuilder.DropColumn(
                name: "ChampUserId",
                table: "Champs");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Champs",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "AspNetUsers",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Round",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EventId = table.Column<int>(type: "integer", nullable: false),
                    RoundNumber = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Round", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Round_Event_EventId",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Champs_UserId",
                table: "Champs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_EventId",
                table: "AspNetUsers",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Round_EventId",
                table: "Round",
                column: "EventId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Event_EventId",
                table: "AspNetUsers",
                column: "EventId",
                principalTable: "Event",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Champs_AspNetUsers_UserId",
                table: "Champs",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
