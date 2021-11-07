using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Caduce.Api.Models
{
    public class Vente
    {
        public Vente()
        {
            //medicamentprix = new MedicamentPrix();
            pharmacien = new Pharmacien();
            patient = new Patient();
        }

        [Key]
        public Guid Id { get; set; }
        public DateTime DateVente { get; set; }
        public int Quantite { get; set; }
        public float PrixUnitaire { get; set; }
        public Guid medicamentprixId { get; set; }
        public MedicamentPrix medicamentprix { get; set; }
        public Guid PharmacienId { get; set; }
        public Guid PatientId { get; set; }
        public Pharmacien pharmacien { get; set; }
        public Patient patient { get; set; }
    }
}
