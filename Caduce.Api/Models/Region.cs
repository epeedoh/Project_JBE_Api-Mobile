using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caduce.Api.Models
{
    public class Region
    {
        public Region()
        {
            pays = new Pays();
            personne = new HashSet<Personne>();
        }

        public int Id { get; set; }
        public string CodeRegion { get; set; }
        public string Libelle { get; set; }
        public string CodePays { get; set; }
        public string ChefLieu { get; set; }
        public DateTime DateCreation { get; set; }

        public int PaysId { get; set; }

        public ICollection<Personne> personne { get; set; }
        public Pays pays { get; set; }
    }
}
