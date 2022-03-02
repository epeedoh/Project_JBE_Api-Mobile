using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jbl.API.Dtos
{
    public class PropositionReponseResponse:ApiReponse
    {
      public List<PropositionReponseDto> PropositionReponses { get; set; }
    }
}
