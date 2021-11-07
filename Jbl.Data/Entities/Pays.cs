using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Jbl.Data.Entities
{
    public class Pays
    {

        public Pays()
        {

        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PaysID { get; set; }
        public string CodePays { get; set; }
        public string Libelle { get; set; }
        public string Nationalite { get; set; }
        public string Capital { get; set; }

        public byte[] Image { get; set; }

      
    }
}
