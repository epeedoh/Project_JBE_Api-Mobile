using Jbl.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jbl.Data.DataContext
{
    public class DatabaseContext:DbContext
    {
        public class OptionsBuild
        {
            public OptionsBuild()
            {
                settings = new AppConfiguration();
                opsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
                opsBuilder.UseSqlServer(settings.sqlConnectionString);
                //opsBuilder.UseSqlite(settings.sqlConnectionString);
                dbOptions = opsBuilder.Options;
            }
            public DbContextOptionsBuilder<DatabaseContext> opsBuilder { get; set; }
            public DbContextOptions<DatabaseContext> dbOptions { get; set; }
            private AppConfiguration settings { get; set; }

        }
        public static OptionsBuild ops = new OptionsBuild();
        public DatabaseContext (DbContextOptions<DatabaseContext> options) : base(options) { }
        //public DbSet<User> Users { get; set; }
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

    }
}
