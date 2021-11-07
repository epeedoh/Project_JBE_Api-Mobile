using System;
using System.Collections.Generic;
using System.Text;

namespace AppName.Models
{
    public class Question
    {
        public int QuestionID { get; set; }
        public string Libelle { get; set; }
        public bool Active { get; set; }
        public int Point { get; set; }
       public int TotalPointQuestionnaire { get; set; }
        public int NiveauID { get; set; }
        public virtual Niveau Niveau { get; set; }

    }
}
