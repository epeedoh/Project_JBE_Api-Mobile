using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Jbl.Data.Entities
{
    public class Question
    {

        public Question()
        {

        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuestionID { get; set; }
        public string Libelle { get; set; }
        public bool Active { get; set; }
        public int Point { get; set; }
       public int TotalPointQuestionnaire { get; set; }

        public int NiveauID { get; set; }
        public virtual Niveau Niveau { get; set; }

        public virtual ICollection<PropositionReponse> PropositionReponses { get; set; }
        public virtual ICollection<Reponse> Reponses { get; set; }

    }
}
