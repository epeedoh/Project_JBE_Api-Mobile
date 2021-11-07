using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caduce.Api.Models
{
    public class ActeType
    {
        public ActeType()
        {
            ActeMedical = new HashSet<ActeMedical>();
        }
        public Guid Id { get; set; }
        public string Code { get; set; }

        public string Libelle { get; set; }
        public DateTime DateCreation { get; set; }
        public ICollection<ActeMedical> ActeMedical { get; set; }
    }
}
