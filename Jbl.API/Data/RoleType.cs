using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Jbl.API.Data
{
   public class RoleType
    {
        public RoleType()
        {

        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoleTypeID { get; set; }
        public string CodeRole { get; set; }
        public string CodeTitre { get; set; }
        public string Libelle { get; set; }
        public DateTime DateCreation { get; set; }
        public ICollection<Personne> Personnes { get; set; }
    }
}
