using Microsoft.EntityFrameworkCore.Migrations;

namespace racesmiths.Migrations
{
    public partial class _007 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clubs_AspNetUsers_RSUserId",
                table: "Clubs");

            migrationBuilder.DropForeignKey(
                name: "FK_Race_AspNetUsers_RSUserId",
                table: "Race");

            migrationBuilder.DropIndex(
                name: "IX_Race_RSUserId",
                table: "Race");

            migrationBuilder.DropIndex(
                name: "IX_Clubs_RSUserId",
                table: "Clubs");

            migrationBuilder.DropColumn(
                name: "RSUserId",
                table: "Clubs");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ClubId",
                table: "AspNetUsers",
                column: "ClubId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Clubs_ClubId",
                table: "AspNetUsers",
                column: "ClubId",
                principalTable: "Clubs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Clubs_ClubId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ClubId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "RSUserId",
                table: "Clubs",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Race_RSUserId",
                table: "Race",
                column: "RSUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Clubs_RSUserId",
                table: "Clubs",
                column: "RSUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clubs_AspNetUsers_RSUserId",
                table: "Clubs",
                column: "RSUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Race_AspNetUsers_RSUserId",
                table: "Race",
                column: "RSUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
