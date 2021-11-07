using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caduce.Api.Models
{
    public class StatutPrestation
    {
        public StatutPrestation()
        {
            typeStatutPrestation = new TypeStatutPrestation();
            utilisateur = new Utilisateur();

            prestation = new Prestation();
        }
        public Guid Id { get; set; }
        public string CodeStatut { get; set; }
        public string Statut { get; set; }

        public bool EstActif { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime PeriodeDebut { get; set; }
        public DateTime? PeriodeFin { get; set; }
        public Guid TypeStatutPrestationId { get; set; }
        public Guid UtilisateurId { get; set; }
        public Guid PrestationId { get; set; }
        public Utilisateur utilisateur { get; set; }
        public TypeStatutPrestation typeStatutPrestation { get; set; }
        public Prestation prestation { get; set; }
    }
}
