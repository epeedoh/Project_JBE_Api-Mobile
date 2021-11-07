using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jbl.API.Dtos
{
    public class ThemeResponse: ApiReponse
    {
        public List<ThemeDto> Themes { get; set; }
    }
}
