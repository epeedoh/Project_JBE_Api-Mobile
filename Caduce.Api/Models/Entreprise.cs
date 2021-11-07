using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caduce.Api.Models
{
    public class Entreprise
    {
        public Entreprise()
        {
            utilisateurs = new HashSet<Utilisateur>();
            pays = new Pays();
          
            personne = new Personne();
         
            patients = new HashSet<Patient>();
            Prestations = new HashSet<Prestation>();
        }
        public Guid Id { get; set; }
        public string Nom { get; set; }
        public string CodeEntreprise { get; set; }
        public string CodePays { get; set; }

        public byte[] Logo { get; set; }

        public int PaysId { get; set; }

        public Guid PersonneId { get; set; }

        public string Addresse { get; set; }
        public string TelephoneMobile { get; set; }
        public string TelephoneFixe { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }

        public string Ville { get; set; }
        public string Commune { get; set; }

        public ICollection<Utilisateur> utilisateurs { get; set; }
        public Pays pays { get; set; }
        public Personne personne { get; set; }
       
        public ICollection<Patient> patients { get; set; }
   
        public ICollection<Prestation> Prestations { get; set; }
      

    }
}
