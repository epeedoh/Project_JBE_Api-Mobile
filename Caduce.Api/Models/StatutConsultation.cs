using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caduce.Api.Models
{
    public class StatutConsultation
    {
        public StatutConsultation()
        {
            typeStatutConsultation = new TypeStatutConsultation();
            utilisateur = new Utilisateur();

            consultation = new Consultation();
        }
        public Guid Id { get; set; }
        public string CodeStatut { get; set; }
        public string Statut { get; set; }
        public string NumeroConsultation { get; set; }

        public bool EstActif { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime PeriodeDebut { get; set; }
        public DateTime? PeriodeFin { get; set; }
        public Guid TypeStatutConsultationId { get; set; }
        public Guid ConsultationId { get; set; }
        public Guid UtilisateurId { get; set; }
        public Utilisateur utilisateur { get; set; }
        public TypeStatutConsultation typeStatutConsultation { get; set; }
        public Consultation consultation { get; set; }
    }
}
