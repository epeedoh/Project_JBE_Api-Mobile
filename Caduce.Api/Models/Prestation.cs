using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caduce.Api.Models
{
    public class Prestation
    {
        public Prestation()
        {
            patient = new Patient();
     
            utilisateur = new Utilisateur();
  
            entreprise = new Entreprise();
            statutPrestations = new HashSet<StatutPrestation>();
            consultations = new HashSet<Consultation>();
         
        }

        public Guid Id { get; set; }
        public string numeroPrestation { get; set; }
        public Guid ServiceMedicalId { get; set; }
        public string service { get; set; }
        public Guid praticienId { get; set; }
        public string praticien { get; set; }
        public Guid ActeMedicalEntrepriseId { get; set; }

        public string libelle { get; set; }
        public decimal cout { get; set; }
        public decimal quantite { get; set; }
        public decimal ticketModerateur { get; set; }
        public decimal PartAssurance { get; set; }
        public decimal prixTotal { get; set; }
        public decimal MontantPayer { get; set; }
        public decimal Solde { get; set; }


        public string numeroPatient { get; set; }
        public bool EstActif { get; set; }
        public Guid AssureurPersonneId { get; set; }
        public Guid PatientId { get; set; }
        public Guid UtilisateurId { get; set; }

        public DateTime DateCreation { get; set; }
        public Guid EntrepriseId { get; set; }


        public Patient patient { get; set; }
        public Utilisateur utilisateur { get; set; }
  
    
        public Entreprise entreprise { get; set; }
        public ICollection<StatutPrestation> statutPrestations { get; set; }
        public ICollection<Consultation> consultations { get; set; }


    }
}
