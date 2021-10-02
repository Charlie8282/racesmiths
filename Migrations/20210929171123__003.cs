using Microsoft.EntityFrameworkCore.Migrations;

namespace racesmiths.Migrations
{
    public partial class _003 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IGTimePractice",
                table: "Event",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "NoPractice",
                table: "Event",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "NoQualify",
                table: "Event",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "NoRealism",
                table: "Event",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "NoRules",
                table: "Event",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "NoPractice",
                table: "Champs",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "NoQualify",
                table: "Champs",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "NoRealism",
                table: "Champs",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "NoRules",
                table: "Champs",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IGTimePractice",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "NoPractice",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "NoQualify",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "NoRealism",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "NoRules",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "NoPractice",
                table: "Champs");

            migrationBuilder.DropColumn(
                name: "NoQualify",
                table: "Champs");

            migrationBuilder.DropColumn(
                name: "NoRealism",
                table: "Champs");

            migrationBuilder.DropColumn(
                name: "NoRules",
                table: "Champs");
        }
    }
}
