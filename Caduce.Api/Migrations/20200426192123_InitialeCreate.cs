using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Caduce.Api.Migrations
{
    public partial class InitialeCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActeTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    Libelle = table.Column<string>(nullable: true),
                    DateCreation = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActeTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pays",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CodePays = table.Column<string>(nullable: true),
                    Libelle = table.Column<string>(nullable: true),
                    Nationalite = table.Column<string>(nullable: true),
                    Capital = table.Column<string>(nullable: true),
                    Image = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Professions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CodeProfession = table.Column<string>(nullable: true),
                    Libelle = table.Column<string>(nullable: true),
                    DateCreation = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CodeRole = table.Column<string>(nullable: true),
                    CodeTitre = table.Column<string>(nullable: true),
                    Libelle = table.Column<string>(nullable: true),
                    DateCreation = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sexes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CodeSexe = table.Column<string>(nullable: true),
                    Libelle = table.Column<string>(nullable: true),
                    DateCreation = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sexes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeStatutConsultations",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    Libelle = table.Column<string>(nullable: true),
                    EstActif = table.Column<bool>(nullable: false),
                    DateCreation = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeStatutConsultations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeStatutPrestations",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    Libelle = table.Column<string>(nullable: true),
                    EstActif = table.Column<bool>(nullable: false),
                    DateCreation = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeStatutPrestations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActeMedicals",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    Libelle = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DateCreation = table.Column<DateTime>(nullable: false),
                    ActeTypeId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActeMedicals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActeMedicals_ActeTypes_ActeTypeId",
                        column: x => x.ActeTypeId,
                        principalTable: "ActeTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CodeRegion = table.Column<string>(nullable: true),
                    Libelle = table.Column<string>(nullable: true),
                    CodePays = table.Column<string>(nullable: true),
                    ChefLieu = table.Column<string>(nullable: true),
                    DateCreation = table.Column<DateTime>(nullable: false),
                    PaysId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Regions_Pays_PaysId",
                        column: x => x.PaysId,
                        principalTable: "Pays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personnes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nom = table.Column<string>(nullable: true),
                    Prenoms = table.Column<string>(nullable: true),
                    NomComplet = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true),
                    Domicile = table.Column<string>(nullable: true),
                    DateNaissance = table.Column<DateTime>(nullable: false),
                    ProfessionId = table.Column<int>(nullable: false),
                    CodeProfession = table.Column<string>(nullable: true),
                    CodeRegion = table.Column<string>(nullable: true),
                    SexeId = table.Column<int>(nullable: false),
                    PaysId = table.Column<int>(nullable: false),
                    CodeSexe = table.Column<string>(nullable: true),
                    RegionId = table.Column<int>(nullable: false),
                    Identifiant = table.Column<string>(nullable: true),
                    Image = table.Column<byte[]>(nullable: true),
                    CompteCreate = table.Column<bool>(nullable: false),
                    DateCreation = table.Column<DateTime>(nullable: false),
                    RoleTypeId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personnes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personnes_Pays_PaysId",
                        column: x => x.PaysId,
                        principalTable: "Pays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personnes_Professions_ProfessionId",
                        column: x => x.ProfessionId,
                        principalTable: "Professions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personnes_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personnes_RoleTypes_RoleTypeId",
                        column: x => x.RoleTypeId,
                        principalTable: "RoleTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personnes_Sexes_SexeId",
                        column: x => x.SexeId,
                        principalTable: "Sexes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Entreprises",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nom = table.Column<string>(nullable: true),
                    CodeEntreprise = table.Column<string>(nullable: true),
                    CodePays = table.Column<string>(nullable: true),
                    Logo = table.Column<byte[]>(nullable: true),
                    PaysId = table.Column<int>(nullable: false),
                    PersonneId = table.Column<Guid>(nullable: false),
                    Addresse = table.Column<string>(nullable: true),
                    TelephoneMobile = table.Column<string>(nullable: true),
                    TelephoneFixe = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: true),
                    Ville = table.Column<string>(nullable: true),
                    Commune = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entreprises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entreprises_Pays_PaysId",
                        column: x => x.PaysId,
                        principalTable: "Pays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Entreprises_Personnes_PersonneId",
                        column: x => x.PersonneId,
                        principalTable: "Personnes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    NumeroPatient = table.Column<string>(nullable: true),
                    CodeEntreprise = table.Column<string>(nullable: true),
                    DateEnregistrement = table.Column<DateTime>(nullable: false),
                    EntrepriseId = table.Column<Guid>(nullable: false),
                    PersonneId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_Entreprises_EntrepriseId",
                        column: x => x.EntrepriseId,
                        principalTable: "Entreprises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patients_Personnes_PersonneId",
                        column: x => x.PersonneId,
                        principalTable: "Personnes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Utilisateurs",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    Username = table.Column<string>(nullable: true),
                    CodeEntreprise = table.Column<string>(nullable: true),
                    Image = table.Column<byte[]>(nullable: true),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true),
                    EntrepriseId = table.Column<Guid>(nullable: false),
                    PersonneId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateurs", x => x.id);
                    table.ForeignKey(
                        name: "FK_Utilisateurs_Entreprises_EntrepriseId",
                        column: x => x.EntrepriseId,
                        principalTable: "Entreprises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Utilisateurs_Personnes_PersonneId",
                        column: x => x.PersonneId,
                        principalTable: "Personnes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prestations",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    numeroPrestation = table.Column<string>(nullable: true),
                    ServiceMedicalId = table.Column<Guid>(nullable: false),
                    service = table.Column<string>(nullable: true),
                    praticienId = table.Column<Guid>(nullable: false),
                    praticien = table.Column<string>(nullable: true),
                    ActeMedicalEntrepriseId = table.Column<Guid>(nullable: false),
                    libelle = table.Column<string>(nullable: true),
                    cout = table.Column<decimal>(nullable: false),
                    quantite = table.Column<decimal>(nullable: false),
                    ticketModerateur = table.Column<decimal>(nullable: false),
                    PartAssurance = table.Column<decimal>(nullable: false),
                    prixTotal = table.Column<decimal>(nullable: false),
                    MontantPayer = table.Column<decimal>(nullable: false),
                    Solde = table.Column<decimal>(nullable: false),
                    numeroPatient = table.Column<string>(nullable: true),
                    EstActif = table.Column<bool>(nullable: false),
                    AssureurPersonneId = table.Column<Guid>(nullable: false),
                    PatientId = table.Column<Guid>(nullable: false),
                    UtilisateurId = table.Column<Guid>(nullable: false),
                    DateCreation = table.Column<DateTime>(nullable: false),
                    EntrepriseId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prestations_Entreprises_EntrepriseId",
                        column: x => x.EntrepriseId,
                        principalTable: "Entreprises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prestations_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prestations_Utilisateurs_UtilisateurId",
                        column: x => x.UtilisateurId,
                        principalTable: "Utilisateurs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UtilisateurRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    RoleTypeId = table.Column<Guid>(nullable: false),
                    UtilisateurId = table.Column<Guid>(nullable: false),
                    DateCreation = table.Column<DateTime>(nullable: false),
                    CodeRole = table.Column<string>(nullable: true),
                    EstActif = table.Column<bool>(nullable: false),
                    DateDebut = table.Column<DateTime>(nullable: false),
                    DateFin = table.Column<DateTime>(nullable: false),
                    UsercreateId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UtilisateurRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UtilisateurRoles_RoleTypes_RoleTypeId",
                        column: x => x.RoleTypeId,
                        principalTable: "RoleTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UtilisateurRoles_Utilisateurs_UtilisateurId",
                        column: x => x.UtilisateurId,
                        principalTable: "Utilisateurs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Consultations",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    numeroConsultation = table.Column<string>(nullable: true),
                    praticienId = table.Column<Guid>(nullable: false),
                    praticien = table.Column<string>(nullable: true),
                    EstActif = table.Column<bool>(nullable: false),
                    PatientId = table.Column<Guid>(nullable: false),
                    UtilisateurId = table.Column<Guid>(nullable: false),
                    PrestationId = table.Column<Guid>(nullable: false),
                    DateCreation = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Consultations_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Consultations_Prestations_PrestationId",
                        column: x => x.PrestationId,
                        principalTable: "Prestations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Consultations_Utilisateurs_UtilisateurId",
                        column: x => x.UtilisateurId,
                        principalTable: "Utilisateurs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StatutPrestations",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CodeStatut = table.Column<string>(nullable: true),
                    Statut = table.Column<string>(nullable: true),
                    EstActif = table.Column<bool>(nullable: false),
                    DateCreation = table.Column<DateTime>(nullable: false),
                    PeriodeDebut = table.Column<DateTime>(nullable: false),
                    PeriodeFin = table.Column<DateTime>(nullable: true),
                    TypeStatutPrestationId = table.Column<Guid>(nullable: false),
                    UtilisateurId = table.Column<Guid>(nullable: false),
                    PrestationId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatutPrestations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StatutPrestations_Prestations_PrestationId",
                        column: x => x.PrestationId,
                        principalTable: "Prestations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StatutPrestations_TypeStatutPrestations_TypeStatutPrestation~",
                        column: x => x.TypeStatutPrestationId,
                        principalTable: "TypeStatutPrestations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StatutPrestations_Utilisateurs_UtilisateurId",
                        column: x => x.UtilisateurId,
                        principalTable: "Utilisateurs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Constantes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    numeroConsultation = table.Column<string>(nullable: true),
                    NumeroPatient = table.Column<string>(nullable: true),
                    Temperature = table.Column<decimal>(nullable: false),
                    Pulsation = table.Column<decimal>(nullable: false),
                    FrequenceRespiratoire = table.Column<decimal>(nullable: false),
                    TensionArterielle = table.Column<string>(nullable: true),
                    Selles = table.Column<decimal>(nullable: false),
                    Diurese = table.Column<decimal>(nullable: false),
                    Taille = table.Column<decimal>(nullable: false),
                    Poids = table.Column<decimal>(nullable: false),
                    CodeEntreprise = table.Column<string>(nullable: true),
                    Test = table.Column<string>(nullable: true),
                    EstActif = table.Column<bool>(nullable: false),
                    PatientId = table.Column<Guid>(nullable: false),
                    UtilisateurId = table.Column<Guid>(nullable: false),
                    ConsultationId = table.Column<Guid>(nullable: false),
                    PrestationId = table.Column<Guid>(nullable: false),
                    DateCreation = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Constantes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Constantes_Consultations_ConsultationId",
                        column: x => x.ConsultationId,
                        principalTable: "Consultations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Constantes_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Constantes_Prestations_PrestationId",
                        column: x => x.PrestationId,
                        principalTable: "Prestations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Constantes_Utilisateurs_UtilisateurId",
                        column: x => x.UtilisateurId,
                        principalTable: "Utilisateurs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StatutConsultations",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CodeStatut = table.Column<string>(nullable: true),
                    Statut = table.Column<string>(nullable: true),
                    NumeroConsultation = table.Column<string>(nullable: true),
                    EstActif = table.Column<bool>(nullable: false),
                    DateCreation = table.Column<DateTime>(nullable: false),
                    PeriodeDebut = table.Column<DateTime>(nullable: false),
                    PeriodeFin = table.Column<DateTime>(nullable: true),
                    TypeStatutConsultationId = table.Column<Guid>(nullable: false),
                    ConsultationId = table.Column<Guid>(nullable: false),
                    UtilisateurId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatutConsultations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StatutConsultations_Consultations_ConsultationId",
                        column: x => x.ConsultationId,
                        principalTable: "Consultations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StatutConsultations_TypeStatutConsultations_TypeStatutConsul~",
                        column: x => x.TypeStatutConsultationId,
                        principalTable: "TypeStatutConsultations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StatutConsultations_Utilisateurs_UtilisateurId",
                        column: x => x.UtilisateurId,
                        principalTable: "Utilisateurs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActeMedicals_ActeTypeId",
                table: "ActeMedicals",
                column: "ActeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Constantes_ConsultationId",
                table: "Constantes",
                column: "ConsultationId");

            migrationBuilder.CreateIndex(
                name: "IX_Constantes_PatientId",
                table: "Constantes",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Constantes_PrestationId",
                table: "Constantes",
                column: "PrestationId");

            migrationBuilder.CreateIndex(
                name: "IX_Constantes_UtilisateurId",
                table: "Constantes",
                column: "UtilisateurId");

            migrationBuilder.CreateIndex(
                name: "IX_Consultations_PatientId",
                table: "Consultations",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Consultations_PrestationId",
                table: "Consultations",
                column: "PrestationId");

            migrationBuilder.CreateIndex(
                name: "IX_Consultations_UtilisateurId",
                table: "Consultations",
                column: "UtilisateurId");

            migrationBuilder.CreateIndex(
                name: "IX_Entreprises_PaysId",
                table: "Entreprises",
                column: "PaysId");

            migrationBuilder.CreateIndex(
                name: "IX_Entreprises_PersonneId",
                table: "Entreprises",
                column: "PersonneId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_EntrepriseId",
                table: "Patients",
                column: "EntrepriseId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_PersonneId",
                table: "Patients",
                column: "PersonneId");

            migrationBuilder.CreateIndex(
                name: "IX_Personnes_PaysId",
                table: "Personnes",
                column: "PaysId");

            migrationBuilder.CreateIndex(
                name: "IX_Personnes_ProfessionId",
                table: "Personnes",
                column: "ProfessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Personnes_RegionId",
                table: "Personnes",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Personnes_RoleTypeId",
                table: "Personnes",
                column: "RoleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Personnes_SexeId",
                table: "Personnes",
                column: "SexeId");

            migrationBuilder.CreateIndex(
                name: "IX_Prestations_EntrepriseId",
                table: "Prestations",
                column: "EntrepriseId");

            migrationBuilder.CreateIndex(
                name: "IX_Prestations_PatientId",
                table: "Prestations",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Prestations_UtilisateurId",
                table: "Prestations",
                column: "UtilisateurId");

            migrationBuilder.CreateIndex(
                name: "IX_Regions_PaysId",
                table: "Regions",
                column: "PaysId");

            migrationBuilder.CreateIndex(
                name: "IX_StatutConsultations_ConsultationId",
                table: "StatutConsultations",
                column: "ConsultationId");

            migrationBuilder.CreateIndex(
                name: "IX_StatutConsultations_TypeStatutConsultationId",
                table: "StatutConsultations",
                column: "TypeStatutConsultationId");

            migrationBuilder.CreateIndex(
                name: "IX_StatutConsultations_UtilisateurId",
                table: "StatutConsultations",
                column: "UtilisateurId");

            migrationBuilder.CreateIndex(
                name: "IX_StatutPrestations_PrestationId",
                table: "StatutPrestations",
                column: "PrestationId");

            migrationBuilder.CreateIndex(
                name: "IX_StatutPrestations_TypeStatutPrestationId",
                table: "StatutPrestations",
                column: "TypeStatutPrestationId");

            migrationBuilder.CreateIndex(
                name: "IX_StatutPrestations_UtilisateurId",
                table: "StatutPrestations",
                column: "UtilisateurId");

            migrationBuilder.CreateIndex(
                name: "IX_UtilisateurRoles_RoleTypeId",
                table: "UtilisateurRoles",
                column: "RoleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UtilisateurRoles_UtilisateurId",
                table: "UtilisateurRoles",
                column: "UtilisateurId");

            migrationBuilder.CreateIndex(
                name: "IX_Utilisateurs_EntrepriseId",
                table: "Utilisateurs",
                column: "EntrepriseId");

            migrationBuilder.CreateIndex(
                name: "IX_Utilisateurs_PersonneId",
                table: "Utilisateurs",
                column: "PersonneId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActeMedicals");

            migrationBuilder.DropTable(
                name: "Constantes");

            migrationBuilder.DropTable(
                name: "StatutConsultations");

            migrationBuilder.DropTable(
                name: "StatutPrestations");

            migrationBuilder.DropTable(
                name: "UtilisateurRoles");

            migrationBuilder.DropTable(
                name: "ActeTypes");

            migrationBuilder.DropTable(
                name: "Consultations");

            migrationBuilder.DropTable(
                name: "TypeStatutConsultations");

            migrationBuilder.DropTable(
                name: "TypeStatutPrestations");

            migrationBuilder.DropTable(
                name: "Prestations");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Utilisateurs");

            migrationBuilder.DropTable(
                name: "Entreprises");

            migrationBuilder.DropTable(
                name: "Personnes");

            migrationBuilder.DropTable(
                name: "Professions");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropTable(
                name: "RoleTypes");

            migrationBuilder.DropTable(
                name: "Sexes");

            migrationBuilder.DropTable(
                name: "Pays");
        }
    }
}
