using System;
using System.Collections.Generic;
using System.Text;

namespace AppName.Models
{
   public class Personnes
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public virtual Joueur Joueur { get; set; }

    }
}
