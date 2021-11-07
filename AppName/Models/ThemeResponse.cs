using System;
using System.Collections.Generic;
using System.Text;

namespace AppName.Models
{
    public class ThemeResponse: ApiReponse
    {
        public List<Theme> Themes { get; set; }
    }
}
