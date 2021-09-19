using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace racesmiths.Migrations
{
    public partial class _019 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string[]>(
                name: "SelectedUsers",
                table: "Event",
                type: "text[]",
                nullable: true);

            migrationBuilder.AddColumn<string[]>(
                name: "SelectedUsers",
                table: "Champs",
                type: "text[]",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SelectedUsers",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "SelectedUsers",
                table: "Champs");
        }
    }
}
