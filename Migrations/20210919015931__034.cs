using Microsoft.EntityFrameworkCore.Migrations;

namespace racesmiths.Migrations
{
    public partial class _034 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InGameTimeRace",
                table: "Champs",
                newName: "Season");

            migrationBuilder.RenameColumn(
                name: "InGameTimeQualify",
                table: "Champs",
                newName: "QualWeatherSlot4");

            migrationBuilder.AddColumn<string>(
                name: "QualWeatherSlot1",
                table: "Event",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "QualWeatherSlot2",
                table: "Event",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "QualWeatherSlot3",
                table: "Event",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "QualWeatherSlot4",
                table: "Event",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Season",
                table: "Event",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IGTQualify",
                table: "Champs",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IGTRace",
                table: "Champs",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "QualWeatherSlot1",
                table: "Champs",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "QualWeatherSlot2",
                table: "Champs",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "QualWeatherSlot3",
                table: "Champs",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QualWeatherSlot1",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "QualWeatherSlot2",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "QualWeatherSlot3",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "QualWeatherSlot4",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Season",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "IGTQualify",
                table: "Champs");

            migrationBuilder.DropColumn(
                name: "IGTRace",
                table: "Champs");

            migrationBuilder.DropColumn(
                name: "QualWeatherSlot1",
                table: "Champs");

            migrationBuilder.DropColumn(
                name: "QualWeatherSlot2",
                table: "Champs");

            migrationBuilder.DropColumn(
                name: "QualWeatherSlot3",
                table: "Champs");

            migrationBuilder.RenameColumn(
                name: "Season",
                table: "Champs",
                newName: "InGameTimeRace");

            migrationBuilder.RenameColumn(
                name: "QualWeatherSlot4",
                table: "Champs",
                newName: "InGameTimeQualify");
        }
    }
}
