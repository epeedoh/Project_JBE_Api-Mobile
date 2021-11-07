using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caduce.Api.Models
{
    public class Personne
    {


        public Personne()
        {
            utilisateurs = new HashSet<Utilisateur>();
            Profession = new Profession();
            region = new Region();
            sexe = new Sexe();
            pays = new Pays();
            entreprises = new HashSet<Entreprise>();
            patients = new HashSet<Patient>();
       
        }
        public Guid Id { get; set; }
        public string Nom { get; set; }
        public string Prenoms { get; set; }

        public string NomComplet { get; set; }

        public string Telephone { get; set; }

        public string Domicile { get; set; }
        public DateTime DateNaissance { get; set; }
        public int ProfessionId { get; set; }

        public string CodeProfession { get; set; }

        public string CodeRegion { get; set; }


        public int SexeId { get; set; }
        public int PaysId { get; set; }
        public string CodeSexe { get; set; }

        public int RegionId { get; set; }
        public string Identifiant { get; set; }
        public byte[] Image { get; set; }
        public bool CompteCreate { get; set; }

        public DateTime DateCreation { get; set; }
        public ICollection<Utilisateur> utilisateurs { get; set; }
        public Profession Profession { get; set; }
        public Region region { get; set; }
        public Sexe sexe { get; set; }
        public Pays pays { get; set; }

        public ICollection<Entreprise> entreprises { get; set; }
        public ICollection<Patient> patients { get; set; }


    }
}
