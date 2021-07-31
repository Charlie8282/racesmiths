using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace racesmiths.Migrations
{
    public partial class Initial_7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "FileData",
                table: "Clubs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "Clubs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileData",
                table: "Clubs");

            migrationBuilder.DropColumn(
                name: "FileName",
                table: "Clubs");
        }
    }
}
