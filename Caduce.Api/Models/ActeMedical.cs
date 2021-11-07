using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caduce.Api.Models
{
    public class ActeMedical
    {
        public ActeMedical()
        {
         
            acteType = new ActeType();
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Libelle { get; set; }
        public string Description { get; set; }
        public DateTime DateCreation { get; set; }
        public Guid ActeTypeId { get; set; }

    
        public ActeType acteType { get; set; }


    }
}
