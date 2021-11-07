using System;
using System.Collections.Generic;
using System.Text;

namespace AppName.Models
{
    public class Niveau
    {
        public int NiveauID { get; set; }
        public string Libelle { get; set; }
        public bool Active { get; set; }
     
        public int IdJoueur { get; set; }
        public int ThemeID { get; set; }
        public virtual Theme Theme { get; set; }

        public virtual ICollection<Question> Questions { get; set; }


    }
} 
