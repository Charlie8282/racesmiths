using Microsoft.EntityFrameworkCore.Migrations;

namespace racesmiths.Migrations
{
    public partial class Initial_8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attachments_Races_RaceId",
                table: "Attachments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Races_RaceId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Races_Races_RaceId",
                table: "Races");

            migrationBuilder.DropIndex(
                name: "IX_Races_RaceId",
                table: "Races");

            migrationBuilder.DropIndex(
                name: "IX_Comments_RaceId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Attachments_RaceId",
                table: "Attachments");

            migrationBuilder.DropColumn(
                name: "RaceId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "RaceId",
                table: "Attachments");

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Races",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Comments",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Attachments",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Races_EventId",
                table: "Races",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_EventId",
                table: "Comments",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Attachments_EventId",
                table: "Attachments",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attachments_Races_EventId",
                table: "Attachments",
                column: "EventId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Races_EventId",
                table: "Comments",
                column: "EventId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Races_Races_EventId",
                table: "Races",
                column: "EventId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attachments_Races_EventId",
                table: "Attachments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Races_EventId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Races_Races_EventId",
                table: "Races");

            migrationBuilder.DropIndex(
                name: "IX_Races_EventId",
                table: "Races");

            migrationBuilder.DropIndex(
                name: "IX_Comments_EventId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Attachments_EventId",
                table: "Attachments");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Attachments");

            migrationBuilder.AddColumn<int>(
                name: "RaceId",
                table: "Comments",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RaceId",
                table: "Attachments",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Races_RaceId",
                table: "Races",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_RaceId",
                table: "Comments",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Attachments_RaceId",
                table: "Attachments",
                column: "RaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attachments_Races_RaceId",
                table: "Attachments",
                column: "RaceId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Races_RaceId",
                table: "Comments",
                column: "RaceId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Races_Races_RaceId",
                table: "Races",
                column: "RaceId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
