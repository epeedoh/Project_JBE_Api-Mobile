using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caduce.Api.Models
{
    public class Consultation
    {
        public Consultation()
        {
            patient = new Patient();
            utilisateur = new Utilisateur();
            statutConsultations = new HashSet<StatutConsultation>();
            prestation = new Prestation();
            constantes = new HashSet<Constante>();
        }

        public Guid Id { get; set; }
        public string numeroConsultation { get; set; }
        public Guid praticienId { get; set; }
        public string praticien { get; set; }
        public bool EstActif { get; set; }
        public Guid PatientId { get; set; }
        public Guid UtilisateurId { get; set; }
        public Guid PrestationId { get; set; }
        public DateTime DateCreation { get; set; }
        public Patient patient { get; set; }
        public Utilisateur utilisateur { get; set; }
        public Prestation prestation { get; set; }
        public ICollection<StatutConsultation> statutConsultations { get; set; }
        public ICollection<Constante> constantes { get; set; }
    }
}
