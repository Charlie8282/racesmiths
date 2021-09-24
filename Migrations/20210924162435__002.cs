using Microsoft.EntityFrameworkCore.Migrations;

namespace racesmiths.Migrations
{
    public partial class _002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IGTimePractice",
                table: "Champs",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PracTimeProgression",
                table: "Champs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PracWeatherProgression",
                table: "Champs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PracWeatherSlot1",
                table: "Champs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PracWeatherSlot2",
                table: "Champs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PracWeatherSlot3",
                table: "Champs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PracWeatherSlot4",
                table: "Champs",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IGTimePractice",
                table: "Champs");

            migrationBuilder.DropColumn(
                name: "PracTimeProgression",
                table: "Champs");

            migrationBuilder.DropColumn(
                name: "PracWeatherProgression",
                table: "Champs");

            migrationBuilder.DropColumn(
                name: "PracWeatherSlot1",
                table: "Champs");

            migrationBuilder.DropColumn(
                name: "PracWeatherSlot2",
                table: "Champs");

            migrationBuilder.DropColumn(
                name: "PracWeatherSlot3",
                table: "Champs");

            migrationBuilder.DropColumn(
                name: "PracWeatherSlot4",
                table: "Champs");
        }
    }
}
