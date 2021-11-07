using Microsoft.EntityFrameworkCore.Migrations;

namespace Jbl.API.Migrations
{
    public partial class UpdateModel2407 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CodeStageSuivant",
                table: "Stages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StageActiveBackgroundColor",
                table: "Stages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CodeNiveauSuivant",
                table: "Niveaux",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NiveauActiveBackgroundColor",
                table: "Niveaux",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodeStageSuivant",
                table: "Stages");

            migrationBuilder.DropColumn(
                name: "StageActiveBackgroundColor",
                table: "Stages");

            migrationBuilder.DropColumn(
                name: "CodeNiveauSuivant",
                table: "Niveaux");

            migrationBuilder.DropColumn(
                name: "NiveauActiveBackgroundColor",
                table: "Niveaux");
        }
    }
}
