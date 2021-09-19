using Microsoft.EntityFrameworkCore.Migrations;

namespace racesmiths.Migrations
{
    public partial class _026 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QualifyLengthHours",
                table: "Champs");

            migrationBuilder.DropColumn(
                name: "RaceLengthHours",
                table: "Champs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QualifyLengthHours",
                table: "Champs",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RaceLengthHours",
                table: "Champs",
                type: "integer",
                nullable: true);
        }
    }
}
