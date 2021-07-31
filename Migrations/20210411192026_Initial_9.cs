using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace racesmiths.Migrations
{
    public partial class Initial_9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attachments");

            migrationBuilder.DropColumn(
                name: "OwnerUser",
                table: "Clubs");

            migrationBuilder.AddColumn<string>(
                name: "OwnerUserId",
                table: "Clubs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Club",
                table: "Champs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OwnerUserId",
                table: "Champs",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clubs_OwnerUserId",
                table: "Clubs",
                column: "OwnerUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clubs_AspNetUsers_OwnerUserId",
                table: "Clubs",
                column: "OwnerUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clubs_AspNetUsers_OwnerUserId",
                table: "Clubs");

            migrationBuilder.DropIndex(
                name: "IX_Clubs_OwnerUserId",
                table: "Clubs");

            migrationBuilder.DropColumn(
                name: "OwnerUserId",
                table: "Clubs");

            migrationBuilder.DropColumn(
                name: "Club",
                table: "Champs");

            migrationBuilder.DropColumn(
                name: "OwnerUserId",
                table: "Champs");

            migrationBuilder.AddColumn<string>(
                name: "OwnerUser",
                table: "Clubs",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Attachments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClubId = table.Column<int>(type: "integer", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    EventId = table.Column<int>(type: "integer", nullable: true),
                    FileData = table.Column<byte[]>(type: "bytea", nullable: true),
                    FileName = table.Column<string>(type: "text", nullable: true),
                    FilePath = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attachments_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Attachments_Races_EventId",
                        column: x => x.EventId,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attachments_ClubId",
                table: "Attachments",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_Attachments_EventId",
                table: "Attachments",
                column: "EventId");
        }
    }
}
