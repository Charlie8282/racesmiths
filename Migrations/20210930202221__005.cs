using Microsoft.EntityFrameworkCore.Migrations;

namespace racesmiths.Migrations
{
    public partial class _005 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PracTimeProgression",
                table: "Event",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PracWeatherProgression",
                table: "Event",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PracWeatherSlot1",
                table: "Event",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PracWeatherSlot2",
                table: "Event",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PracWeatherSlot3",
                table: "Event",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PracWeatherSlot4",
                table: "Event",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PracTimeProgression",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "PracWeatherProgression",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "PracWeatherSlot1",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "PracWeatherSlot2",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "PracWeatherSlot3",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "PracWeatherSlot4",
                table: "Event");
        }
    }
}
