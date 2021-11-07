using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caduce.Api.Models
{
    public class Constante
    {
        public Constante()
        {
            patient = new Patient();
            utilisateur = new Utilisateur();
            consultation = new Consultation();
            prestation = new Prestation();
        }

        public Guid Id { get; set; }
        public string numeroConsultation { get; set; }
        public string NumeroPatient { get; set; }
        public decimal Temperature { get; set; }
        public decimal Pulsation { get; set; }
        public decimal FrequenceRespiratoire { get; set; }
        public string TensionArterielle { get; set; }
        public decimal Selles { get; set; }
        public decimal Diurese { get; set; }
        public decimal Taille { get; set; }
        public decimal Poids { get; set; }
        public string CodeEntreprise { get; set; }
        public string Test { get; set; }
        public bool EstActif { get; set; }
        public Guid PatientId { get; set; }
        public Guid UtilisateurId { get; set; }
        public Guid ConsultationId { get; set; }
        public Guid PrestationId { get; set; }
        public DateTime DateCreation { get; set; }
        public Patient patient { get; set; }
        public Utilisateur utilisateur { get; set; }
        public Prestation prestation { get; set; }
        public Consultation consultation { get; set; }
    }
}
