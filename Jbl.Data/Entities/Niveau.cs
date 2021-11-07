using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Jbl.Data.Entities
{
    public class Niveau
    {

        public Niveau()
        {
                
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NiveauID { get; set; }
        public string Libelle { get; set; }
        public bool Active { get; set; }

        public int ThemeID { get; set; }
        public virtual Theme Theme { get; set; }

        public virtual ICollection<Question> Questions { get; set; }

        //public int UtilisateurID { get; set; }
        //public virtual Utilisateur Utilisateur { get; set; }

    }
} 
