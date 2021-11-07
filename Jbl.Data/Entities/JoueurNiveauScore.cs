using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Jbl.Data.Entities
{
    public class JoueurNiveauScore
    {

        public JoueurNiveauScore()
        {

        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JoueurNiveauScoreID { get; set; }
        public int UtilisateurID { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }

        public int StageID { get; set; }
        public virtual Stage Stage { get; set; }

        public int ThemeID { get; set; }
        public virtual Theme Theme { get; set; }

        public int NiveauID { get; set; }
        public virtual Niveau Niveau { get; set; }

        public int Score { get; set; }

        public DateTime DateTime { get; set; }
    }
}
