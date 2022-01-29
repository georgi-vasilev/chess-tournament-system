using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChessTournamentSystem.Migrations
{
    public partial class FixColumnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DefeatedId",
                table: "PlayerGame");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DefeatedId",
                table: "PlayerGame",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
