using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Jbl.API.Data
{
    public class Reponse
    {

        public Reponse()
        {

        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReponseID { get; set; }
        public string Libelle { get; set; }
        public int QuestionID { get; set; }
        public virtual Question Question { get; set; }
    }
}
