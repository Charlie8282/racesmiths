using Microsoft.EntityFrameworkCore.Migrations;

namespace racesmiths.Migrations
{
    public partial class _030 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Game",
                table: "Champs",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "System",
                table: "Champs",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Game",
                table: "Champs");

            migrationBuilder.DropColumn(
                name: "System",
                table: "Champs");
        }
    }
}
