using Caduce.Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caduce.Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Personne> Personnes { get; set; }
        public DbSet<Entreprise> Entreprises { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Pays> Pays { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Sexe> Sexes { get; set; }
    
        public DbSet<ActeMedical> ActeMedicals { get; set; }

        public DbSet<RoleType> RoleTypes { get; set; }
        public DbSet<UtilisateurRoles> UtilisateurRoles { get; set; }
        public DbSet<Prestation> Prestations { get; set; }
        public DbSet<ActeType> ActeTypes { get; set; }
        public DbSet<Consultation> Consultations { get; set; }

        public DbSet<StatutConsultation> StatutConsultations { get; set; }

        public DbSet<StatutPrestation> StatutPrestations { get; set; }

        public DbSet<TypeStatutPrestation> TypeStatutPrestations { get; set; }
        public DbSet<TypeStatutConsultation> TypeStatutConsultations { get; set; }

        public DbSet<Constante> Constantes { get; set; }



    }
}
