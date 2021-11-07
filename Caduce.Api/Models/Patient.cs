using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caduce.Api.Models
{
    public class Patient
    {
        public Patient()
        {
            entreprise = new Entreprise();
            personne = new Personne();
            //ventes = new HashSet<Vente>();
            prestations = new HashSet<Prestation>();
            consultations = new HashSet<Consultation>();
        }

        public Guid Id { get; set; }
        public string NumeroPatient { get; set; }
        public string CodeEntreprise { get; set; }
        public DateTime DateEnregistrement { get; set; }
        public Guid EntrepriseId { get; set; }
        public Guid PersonneId { get; set; }
        public Entreprise entreprise { get; set; }
        public Personne personne { get; set; }
        //public ICollection<Vente> ventes { get; set; }
        public ICollection<Prestation> prestations { get; set; }
        public ICollection<Consultation> consultations { get; set; }
    }
}
