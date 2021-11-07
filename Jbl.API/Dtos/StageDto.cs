using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jbl.API.Dtos
{
    public class StageDto
    {
        public int StageID { get; set; }
        public string CodeStage { get; set; }
        public string Libelle { get; set; }
        public bool Active { get; set; }
        public string CodeStageSuivant { get; set; }
        public string StageActiveBackgroundColor { get; set; }
        public virtual ICollection<ThemeDto> Themes { get; set; }
    }
}
