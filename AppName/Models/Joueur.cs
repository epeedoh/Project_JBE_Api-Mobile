using System;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AppName.Models
{
   public class Joueur
    {
        //[Key]
       // [ForeignKey("Personnes")]
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string NomComplet { get; set; }
        public bool Active { get; set; }

       // public virtual Personnes Personnes { get; set; }
    }
}
