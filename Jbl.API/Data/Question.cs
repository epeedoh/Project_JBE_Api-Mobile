using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Jbl.API.Data
{
    public class Question
    {

        public Question()
        {

        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuestionID { get; set; }
        [Required]
        public string Libelle { get; set; }
        public bool Active { get; set; }
        public int Point { get; set; }
       public int TotalPointQuestionnaire { get; set; }

        [Required]
        public int NiveauID { get; set; }
        public virtual Niveau Niveau { get; set; }

        public virtual ICollection<PropositionReponse> PropositionReponses { get; set; }
        public virtual ICollection<Reponse> Reponses { get; set; }


    }
}
