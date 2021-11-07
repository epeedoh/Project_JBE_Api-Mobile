using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caduce.Api.Models
{
    public class RoleType
    {
        public RoleType()
        {
            personnes = new HashSet<Personne>();
        }
        public Guid Id { get; set; }
        public string CodeRole { get; set; }
        public string CodeTitre { get; set; }
        public string Libelle { get; set; }
        public DateTime DateCreation { get; set; }
        public ICollection<Personne> personnes { get; set; }
    }
}
