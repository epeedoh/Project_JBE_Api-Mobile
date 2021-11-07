using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jbl.API.Dtos
{
    public class NiveauResponse: ApiReponse
    {
        public List<NiveauDto> Niveaux { get; set; }
    }
}
