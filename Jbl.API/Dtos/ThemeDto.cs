using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jbl.API.Dtos
{
    public class ThemeDto
    {

        public int ThemeID { get; set; }
        public string CodeTheme { get; set; }
        public string Libelle { get; set; }
        public bool Active { get; set; }
        public int Point { get; set; }
        public string CodeThemeSuivant { get; set; }
        public string ThemeActiveBackgroundColor { get; set; }

        public int StageID { get; set; }
        public virtual StageDto Stage { get; set; }
       // public virtual ICollection<Niveau> Niveaux { get; set; }

    }
}
