using Microsoft.EntityFrameworkCore.Migrations;

namespace racesmiths.Migrations
{
    public partial class _006 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Settings",
                table: "Event");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Settings",
                table: "Event",
                type: "character varying(1000)",
                maxLength: 1000,
                nullable: true);
        }
    }
}
