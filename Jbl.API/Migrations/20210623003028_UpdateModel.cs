using Microsoft.EntityFrameworkCore.Migrations;

namespace Jbl.API.Migrations
{
    public partial class UpdateModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Stages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "CodeStage",
                table: "Stages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdJoueur",
                table: "Niveaux",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Stages");

            migrationBuilder.DropColumn(
                name: "CodeStage",
                table: "Stages");

            migrationBuilder.DropColumn(
                name: "IdJoueur",
                table: "Niveaux");
        }
    }
}
