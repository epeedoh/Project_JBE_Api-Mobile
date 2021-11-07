using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jbl.API.Dtos
{
    public class QuestionDto
    {
        public int QuestionID { get; set; }
        public string Libelle { get; set; }
        public bool Active { get; set; }
        public int Point { get; set; }
        public int TotalPointQuestionnaire { get; set; }

        public int NiveauID { get; set; }
        public virtual NiveauDto Niveau { get; set; }

        //public virtual ICollection<PropositionReponse> PropositionReponses { get; set; }
        //public virtual ICollection<Reponse> Reponses { get; set; }
    }
}
