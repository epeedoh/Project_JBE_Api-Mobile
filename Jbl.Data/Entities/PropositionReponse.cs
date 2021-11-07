using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Jbl.Data.Entities
{
    public class PropositionReponse
    {

        public PropositionReponse()
        {

        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PropositionReponseID { get; set; }
        public string Libelle { get; set; }
        public int QuestionID { get; set; }
        public virtual Question Question { get; set; }

    }
}
