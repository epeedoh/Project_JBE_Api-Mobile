using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caduce.Api.Models
{
    public class Utilisateur
    {
        public Utilisateur()
        {
            entreprise = new Entreprise();
            personne = new Personne();
           
            utilisateurRoles = new HashSet<UtilisateurRoles>();
          
            Prestations = new HashSet<Prestation>();
            
        }
        public Guid id { get; set; }
        public string Username { get; set; }
        public string CodeEntreprise { get; set; }

        public byte[] Image { get; set; }
        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }
        public Guid EntrepriseId { get; set; }
        public Guid PersonneId { get; set; }
        public Entreprise entreprise { get; set; }
        public Personne personne { get; set; }
  
        public ICollection<UtilisateurRoles> utilisateurRoles { get; set; }

        public ICollection<Prestation> Prestations { get; set; }
        //public ICollection<Encaissement> Encaissements { get; set; }
    }
}
