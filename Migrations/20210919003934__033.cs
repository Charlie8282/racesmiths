using Microsoft.EntityFrameworkCore.Migrations;

namespace racesmiths.Migrations
{
    public partial class _033 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IGTQualify",
                table: "Event",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IGTRace",
                table: "Event",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WeatherSlot1",
                table: "Event",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WeatherSlot2",
                table: "Event",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WeatherSlot3",
                table: "Event",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WeatherSlot4",
                table: "Event",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InGameTimeQualify",
                table: "Champs",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InGameTimeRace",
                table: "Champs",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WeatherSlot1",
                table: "Champs",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WeatherSlot2",
                table: "Champs",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WeatherSlot3",
                table: "Champs",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WeatherSlot4",
                table: "Champs",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IGTQualify",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "IGTRace",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "WeatherSlot1",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "WeatherSlot2",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "WeatherSlot3",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "WeatherSlot4",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "InGameTimeQualify",
                table: "Champs");

            migrationBuilder.DropColumn(
                name: "InGameTimeRace",
                table: "Champs");

            migrationBuilder.DropColumn(
                name: "WeatherSlot1",
                table: "Champs");

            migrationBuilder.DropColumn(
                name: "WeatherSlot2",
                table: "Champs");

            migrationBuilder.DropColumn(
                name: "WeatherSlot3",
                table: "Champs");

            migrationBuilder.DropColumn(
                name: "WeatherSlot4",
                table: "Champs");
        }
    }
}
