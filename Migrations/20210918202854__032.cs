using Microsoft.EntityFrameworkCore.Migrations;

namespace racesmiths.Migrations
{
    public partial class _032 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RaceLengthMinutes",
                table: "Champs",
                newName: "RaceLength");

            migrationBuilder.RenameColumn(
                name: "QualifyLengthMinutes",
                table: "Champs",
                newName: "QualifyLength");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RaceLength",
                table: "Champs",
                newName: "RaceLengthMinutes");

            migrationBuilder.RenameColumn(
                name: "QualifyLength",
                table: "Champs",
                newName: "QualifyLengthMinutes");
        }
    }
}
