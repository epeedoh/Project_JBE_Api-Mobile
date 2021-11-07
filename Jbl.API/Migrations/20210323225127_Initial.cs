using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Jbl.API.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pays",
                columns: table => new
                {
                    PaysID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodePays = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nationalite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Capital = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pays", x => x.PaysID);
                });

            migrationBuilder.CreateTable(
                name: "Sexes",
                columns: table => new
                {
                    SexeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeSexe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sexes", x => x.SexeID);
                });

            migrationBuilder.CreateTable(
                name: "Stages",
                columns: table => new
                {
                    StageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stages", x => x.StageID);
                });

            migrationBuilder.CreateTable(
                name: "Themes",
                columns: table => new
                {
                    ThemeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeTheme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Point = table.Column<int>(type: "int", nullable: false),
                    CodeThemeSuivant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThemeActiveBackgroundColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StageID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Themes", x => x.ThemeID);
                    table.ForeignKey(
                        name: "FK_Themes_Stages_StageID",
                        column: x => x.StageID,
                        principalTable: "Stages",
                        principalColumn: "StageID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Niveaux",
                columns: table => new
                {
                    NiveauID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    ThemeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Niveaux", x => x.NiveauID);
                    table.ForeignKey(
                        name: "FK_Niveaux_Themes_ThemeID",
                        column: x => x.ThemeID,
                        principalTable: "Themes",
                        principalColumn: "ThemeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Point = table.Column<int>(type: "int", nullable: false),
                    TotalPointQuestionnaire = table.Column<int>(type: "int", nullable: false),
                    NiveauID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionID);
                    table.ForeignKey(
                        name: "FK_Questions_Niveaux_NiveauID",
                        column: x => x.NiveauID,
                        principalTable: "Niveaux",
                        principalColumn: "NiveauID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropositionReponses",
                columns: table => new
                {
                    PropositionReponseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropositionReponses", x => x.PropositionReponseID);
                    table.ForeignKey(
                        name: "FK_PropositionReponses_Questions_QuestionID",
                        column: x => x.QuestionID,
                        principalTable: "Questions",
                        principalColumn: "QuestionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reponses",
                columns: table => new
                {
                    ReponseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reponses", x => x.ReponseID);
                    table.ForeignKey(
                        name: "FK_Reponses_Questions_QuestionID",
                        column: x => x.QuestionID,
                        principalTable: "Questions",
                        principalColumn: "QuestionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JoueurNiveauScores",
                columns: table => new
                {
                    JoueurNiveauScoreID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UtilisateurID = table.Column<int>(type: "int", nullable: false),
                    StageID = table.Column<int>(type: "int", nullable: false),
                    ThemeID = table.Column<int>(type: "int", nullable: false),
                    NiveauID = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JoueurNiveauScores", x => x.JoueurNiveauScoreID);
                    table.ForeignKey(
                        name: "FK_JoueurNiveauScores_Niveaux_NiveauID",
                        column: x => x.NiveauID,
                        principalTable: "Niveaux",
                        principalColumn: "NiveauID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JoueurNiveauScores_Stages_StageID",
                        column: x => x.StageID,
                        principalTable: "Stages",
                        principalColumn: "StageID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_JoueurNiveauScores_Themes_ThemeID",
                        column: x => x.ThemeID,
                        principalTable: "Themes",
                        principalColumn: "ThemeID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Personnes",
                columns: table => new
                {
                    PersonneID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prenoms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomComplet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Domicile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateNaissance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CodeSexe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Identifiant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CompteCreate = table.Column<bool>(type: "bit", nullable: false),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SexeID = table.Column<int>(type: "int", nullable: false),
                    PaysID = table.Column<int>(type: "int", nullable: false),
                    RoleTypeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personnes", x => x.PersonneID);
                    table.ForeignKey(
                        name: "FK_Personnes_Pays_PaysID",
                        column: x => x.PaysID,
                        principalTable: "Pays",
                        principalColumn: "PaysID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personnes_Sexes_SexeID",
                        column: x => x.SexeID,
                        principalTable: "Sexes",
                        principalColumn: "SexeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Utilisateurs",
                columns: table => new
                {
                    UtilisateurID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PersonneID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateurs", x => x.UtilisateurID);
                    table.ForeignKey(
                        name: "FK_Utilisateurs_Personnes_PersonneID",
                        column: x => x.PersonneID,
                        principalTable: "Personnes",
                        principalColumn: "PersonneID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleTypes",
                columns: table => new
                {
                    RoleTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeRole = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodeTitre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UtilisateurID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleTypes", x => x.RoleTypeID);
                    table.ForeignKey(
                        name: "FK_RoleTypes_Utilisateurs_UtilisateurID",
                        column: x => x.UtilisateurID,
                        principalTable: "Utilisateurs",
                        principalColumn: "UtilisateurID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JoueurNiveauScores_NiveauID",
                table: "JoueurNiveauScores",
                column: "NiveauID");

            migrationBuilder.CreateIndex(
                name: "IX_JoueurNiveauScores_StageID",
                table: "JoueurNiveauScores",
                column: "StageID");

            migrationBuilder.CreateIndex(
                name: "IX_JoueurNiveauScores_ThemeID",
                table: "JoueurNiveauScores",
                column: "ThemeID");

            migrationBuilder.CreateIndex(
                name: "IX_JoueurNiveauScores_UtilisateurID",
                table: "JoueurNiveauScores",
                column: "UtilisateurID");

            migrationBuilder.CreateIndex(
                name: "IX_Niveaux_ThemeID",
                table: "Niveaux",
                column: "ThemeID");

            migrationBuilder.CreateIndex(
                name: "IX_Personnes_PaysID",
                table: "Personnes",
                column: "PaysID");

            migrationBuilder.CreateIndex(
                name: "IX_Personnes_RoleTypeID",
                table: "Personnes",
                column: "RoleTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Personnes_SexeID",
                table: "Personnes",
                column: "SexeID");

            migrationBuilder.CreateIndex(
                name: "IX_PropositionReponses_QuestionID",
                table: "PropositionReponses",
                column: "QuestionID");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_NiveauID",
                table: "Questions",
                column: "NiveauID");

            migrationBuilder.CreateIndex(
                name: "IX_Reponses_QuestionID",
                table: "Reponses",
                column: "QuestionID");

            migrationBuilder.CreateIndex(
                name: "IX_RoleTypes_UtilisateurID",
                table: "RoleTypes",
                column: "UtilisateurID");

            migrationBuilder.CreateIndex(
                name: "IX_Themes_StageID",
                table: "Themes",
                column: "StageID");

            migrationBuilder.CreateIndex(
                name: "IX_Utilisateurs_PersonneID",
                table: "Utilisateurs",
                column: "PersonneID");

            migrationBuilder.AddForeignKey(
                name: "FK_JoueurNiveauScores_Utilisateurs_UtilisateurID",
                table: "JoueurNiveauScores",
                column: "UtilisateurID",
                principalTable: "Utilisateurs",
                principalColumn: "UtilisateurID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Personnes_RoleTypes_RoleTypeID",
                table: "Personnes",
                column: "RoleTypeID",
                principalTable: "RoleTypes",
                principalColumn: "RoleTypeID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoleTypes_Utilisateurs_UtilisateurID",
                table: "RoleTypes");

            migrationBuilder.DropTable(
                name: "JoueurNiveauScores");

            migrationBuilder.DropTable(
                name: "PropositionReponses");

            migrationBuilder.DropTable(
                name: "Reponses");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Niveaux");

            migrationBuilder.DropTable(
                name: "Themes");

            migrationBuilder.DropTable(
                name: "Stages");

            migrationBuilder.DropTable(
                name: "Utilisateurs");

            migrationBuilder.DropTable(
                name: "Personnes");

            migrationBuilder.DropTable(
                name: "Pays");

            migrationBuilder.DropTable(
                name: "RoleTypes");

            migrationBuilder.DropTable(
                name: "Sexes");
        }
    }
}
