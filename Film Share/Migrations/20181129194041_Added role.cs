using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmShare.Migrations
{
    public partial class Addedrole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "ActorsInFilms",
                nullable: true,
                defaultValue: "No information");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "ActorsInFilms");
        }
    }
}
