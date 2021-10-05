using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace racesmiths.Migrations
{
    public partial class _009 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ScoreboardId",
                table: "Event",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ScoreboardId",
                table: "AspNetUsers",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Scoreboard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ChampId = table.Column<int>(type: "integer", nullable: false),
                    Points = table.Column<int>(type: "integer", nullable: true),
                    Bonus = table.Column<int>(type: "integer", nullable: true),
                    Revoke = table.Column<int>(type: "integer", nullable: true),
                    RSUserId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scoreboard", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Event_ScoreboardId",
                table: "Event",
                column: "ScoreboardId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ScoreboardId",
                table: "AspNetUsers",
                column: "ScoreboardId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Scoreboard_ScoreboardId",
                table: "AspNetUsers",
                column: "ScoreboardId",
                principalTable: "Scoreboard",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Scoreboard_ScoreboardId",
                table: "Event",
                column: "ScoreboardId",
                principalTable: "Scoreboard",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Scoreboard_ScoreboardId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Event_Scoreboard_ScoreboardId",
                table: "Event");

            migrationBuilder.DropTable(
                name: "Scoreboard");

            migrationBuilder.DropIndex(
                name: "IX_Event_ScoreboardId",
                table: "Event");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ScoreboardId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ScoreboardId",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "ScoreboardId",
                table: "AspNetUsers");
        }
    }
}
