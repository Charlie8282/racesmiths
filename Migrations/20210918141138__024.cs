using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace racesmiths.Migrations
{
    public partial class _024 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QualifyLength",
                table: "Race");

            migrationBuilder.DropColumn(
                name: "RaceLength",
                table: "Race");

            migrationBuilder.DropColumn(
                name: "RaceNumber",
                table: "Race");

            migrationBuilder.RenameColumn(
                name: "Laps",
                table: "Race",
                newName: "Revoke");

            migrationBuilder.AlterColumn<int>(
                name: "Position",
                table: "Race",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "Points",
                table: "Race",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "Bonus",
                table: "Race",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Scheduled",
                table: "Event",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bonus",
                table: "Race");

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

            migrationBuilder.RenameColumn(
                name: "Revoke",
                table: "Race",
                newName: "Laps");

            migrationBuilder.AlterColumn<int>(
                name: "Position",
                table: "Race",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Points",
                table: "Race",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "QualifyLength",
                table: "Race",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RaceLength",
                table: "Race",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RaceNumber",
                table: "Race",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Scheduled",
                table: "Event",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");
        }
    }
}
