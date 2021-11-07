using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jbl.API.Data
{
    public class DataContext: DbContext
    {

        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }


        public DbSet<JoueurNiveauScore> JoueurNiveauScores { get; set; }

        public DbSet<Niveau> Niveaux { get; set; }
        public DbSet<Pays> Pays { get; set; }
        public DbSet<Personne> Personnes { get; set; }
        public DbSet<PropositionReponse> PropositionReponses { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Reponse> Reponses { get; set; }
        public DbSet<RoleType> RoleTypes { get; set; }
        public DbSet<Sexe> Sexes { get; set; }
        public DbSet<Stage> Stages { get; set; }
        public DbSet<Theme> Themes { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }



        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{



        //    //builder.Entity<JoueurNiveauScore>().HasMany(i => i.JoueurNiveauScoreID).WithRequired().WillCascadeOnDelete(false);

        //    //builder.Entity<Qualification>().HasRequired(x => x.Employee).WithMany(e => e.Qualifications);
        //    //builder.Entity<University>.HasRequired(x => x.Qualification).WithMany(e => e.Universities);


        //    //builder.Conventions.Remove<OneToManyCascadeDeleteConvention>();


        //    //modelBuilder.Entity<JoueurNiveauScore>()
        //    //            .HasRequired(f => f.Obligations)
        //    //            .WithRequiredDependent()
        //    //            .WillCascadeOnDelete(false);
        //}

    }
}
