using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Jbl.API.Data
{
    public class Sexe
    {

        public Sexe()
        {

        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SexeID { get; set; }
        public string CodeSexe { get; set; }
        public string Libelle { get; set; }
        public DateTime DateCreation { get; set; }
        public ICollection<Personne> Personnes { get; set; }
    }
}
