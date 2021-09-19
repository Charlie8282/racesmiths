using Microsoft.EntityFrameworkCore.Migrations;

namespace racesmiths.Migrations
{
    public partial class _031 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Laps",
                table: "Champs",
                type: "integer",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Laps",
                table: "Champs");
        }
    }
}
