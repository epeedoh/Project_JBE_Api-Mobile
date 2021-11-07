using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caduce.Api.Models
{
    public class Pays
    {
        public Pays()
        {
            entreprise = new HashSet<Entreprise>();
            regions = new HashSet<Region>();
          
        }

        public int Id { get; set; }
        public string CodePays { get; set; }
        public string Libelle { get; set; }
        public string Nationalite { get; set; }
        public string Capital { get; set; }

        public byte[] Image { get; set; }

        public ICollection<Entreprise> entreprise { get; set; }
        public ICollection<Region> regions { get; set; }
     
    }
}
