using Microsoft.EntityFrameworkCore.Migrations;

namespace racesmiths.Migrations
{
    public partial class _004 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Champs_AspNetUsers_RSUserId",
                table: "Champs");

            migrationBuilder.DropIndex(
                name: "IX_Champs_RSUserId",
                table: "Champs");

            migrationBuilder.DropColumn(
                name: "RSUserId",
                table: "Champs");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Champs",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Champs_UserId",
                table: "Champs",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Champs_AspNetUsers_UserId",
                table: "Champs",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Champs_AspNetUsers_UserId",
                table: "Champs");

            migrationBuilder.DropIndex(
                name: "IX_Champs_UserId",
                table: "Champs");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Champs");

            migrationBuilder.AddColumn<string>(
                name: "RSUserId",
                table: "Champs",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Champs_RSUserId",
                table: "Champs",
                column: "RSUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Champs_AspNetUsers_RSUserId",
                table: "Champs",
                column: "RSUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
