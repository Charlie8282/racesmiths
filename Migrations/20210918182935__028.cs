using Microsoft.EntityFrameworkCore.Migrations;

namespace racesmiths.Migrations
{
    public partial class _028 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RaceLengthMinutes",
                table: "Event",
                newName: "RaceLength");

            migrationBuilder.RenameColumn(
                name: "QualifyLengthMinutes",
                table: "Event",
                newName: "QualifyLength");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RaceLength",
                table: "Event",
                newName: "RaceLengthMinutes");

            migrationBuilder.RenameColumn(
                name: "QualifyLength",
                table: "Event",
                newName: "QualifyLengthMinutes");
        }
    }
}
