using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caduce.Api.Models
{
    public class TypeStatutPrestation
    {
        public TypeStatutPrestation()
        {
            statutPrestations = new HashSet<StatutPrestation>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Libelle { get; set; }

        public bool EstActif { get; set; }
        public DateTime DateCreation { get; set; }


        public ICollection<StatutPrestation> statutPrestations { get; set; }
    }
}
