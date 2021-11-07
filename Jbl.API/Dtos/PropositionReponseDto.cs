using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jbl.API.Dtos
{
    public class PropositionReponseDto
    {
        public int PropositionReponseID { get; set; }
        public string Libelle { get; set; }
        public int QuestionID { get; set; }
        public virtual QuestionDto Question { get; set; }
    }
}
