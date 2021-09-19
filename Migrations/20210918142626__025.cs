using Microsoft.EntityFrameworkCore.Migrations;

namespace racesmiths.Migrations
{
    public partial class _025 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPublished",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Laps",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "QualifyLengthHours",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "QualifyLengthMinutes",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "RaceLengthHours",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "RaceLengthMinutes",
                table: "Event");

            migrationBuilder.AddColumn<bool>(
                name: "IsPublished",
                table: "Champs",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Laps",
                table: "Champs",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QualifyLengthHours",
                table: "Champs",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QualifyLengthMinutes",
                table: "Champs",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RaceLengthHours",
                table: "Champs",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RaceLengthMinutes",
                table: "Champs",
                type: "integer",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPublished",
                table: "Champs");

            migrationBuilder.DropColumn(
                name: "Laps",
                table: "Champs");

            migrationBuilder.DropColumn(
                name: "QualifyLengthHours",
                table: "Champs");

            migrationBuilder.DropColumn(
                name: "QualifyLengthMinutes",
                table: "Champs");

            migrationBuilder.DropColumn(
                name: "RaceLengthHours",
                table: "Champs");

            migrationBuilder.DropColumn(
                name: "RaceLengthMinutes",
                table: "Champs");

            migrationBuilder.AddColumn<bool>(
                name: "IsPublished",
                table: "Event",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Laps",
                table: "Event",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QualifyLengthHours",
                table: "Event",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QualifyLengthMinutes",
                table: "Event",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RaceLengthHours",
                table: "Event",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RaceLengthMinutes",
                table: "Event",
                type: "integer",
                nullable: true);
        }
    }
}
