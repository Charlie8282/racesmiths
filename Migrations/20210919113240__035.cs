using Microsoft.EntityFrameworkCore.Migrations;

namespace racesmiths.Migrations
{
    public partial class _035 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Multi1",
                table: "Event",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Multi2",
                table: "Event",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Multi3",
                table: "Event",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Multi4",
                table: "Event",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TrackVariant",
                table: "Event",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vehicle",
                table: "Event",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VehicleClass",
                table: "Event",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExcludeVehicle",
                table: "Champs",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Multi1",
                table: "Champs",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Multi2",
                table: "Champs",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Multi3",
                table: "Champs",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Multi4",
                table: "Champs",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vehicle",
                table: "Champs",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VehicleClass",
                table: "Champs",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Multi1",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Multi2",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Multi3",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Multi4",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "TrackVariant",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Vehicle",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "VehicleClass",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "ExcludeVehicle",
                table: "Champs");

            migrationBuilder.DropColumn(
                name: "Multi1",
                table: "Champs");

            migrationBuilder.DropColumn(
                name: "Multi2",
                table: "Champs");

            migrationBuilder.DropColumn(
                name: "Multi3",
                table: "Champs");

            migrationBuilder.DropColumn(
                name: "Multi4",
                table: "Champs");

            migrationBuilder.DropColumn(
                name: "Vehicle",
                table: "Champs");

            migrationBuilder.DropColumn(
                name: "VehicleClass",
                table: "Champs");
        }
    }
}
