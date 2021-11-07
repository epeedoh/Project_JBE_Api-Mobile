using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caduce.Api.Models
{
    public class Profession
    {
        public Profession()
        {
            personnes = new HashSet<Personne>();
        }

        public int Id { get; set; }
        public string CodeProfession { get; set; }
        public string Libelle { get; set; }
        public DateTime DateCreation { get; set; }

        public ICollection<Personne> personnes { get; set; }
    }
}
