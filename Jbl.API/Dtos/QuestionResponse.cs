using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jbl.API.Dtos
{
    public class QuestionResponse: ApiReponse
    {
        public List<QuestionDto> questions { get; set; }
        public List<PropositionReponseDto> propositionReponses { get; set; }
        public List<ReponseDto> reponses { get; set; }
    }
}
