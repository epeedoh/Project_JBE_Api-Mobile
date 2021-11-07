using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Jbl.API.Dtos
{
    public class StageResponse: ApiReponse
    {
        public List<StageDto> Stages { get; set; }
    }
}
