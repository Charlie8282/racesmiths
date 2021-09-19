using Microsoft.EntityFrameworkCore.Migrations;

namespace racesmiths.Migrations
{
    public partial class _027 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Laps",
                table: "Champs");

            migrationBuilder.AddColumn<int>(
                name: "Laps",
                table: "Event",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QualifyLengthMinutes",
                table: "Event",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RaceLengthMinutes",
                table: "Event",
                type: "integer",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Laps",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "QualifyLengthMinutes",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "RaceLengthMinutes",
                table: "Event");

            migrationBuilder.AddColumn<int>(
                name: "Laps",
                table: "Champs",
                type: "integer",
                nullable: true);
        }
    }
}
