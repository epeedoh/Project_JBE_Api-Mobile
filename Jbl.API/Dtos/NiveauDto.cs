using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jbl.API.Dtos
{
    public class NiveauDto
    {
        public int NiveauID { get; set; }
        public string Libelle { get; set; }
        public bool Active { get; set; }
        public string CodeNiveauSuivant { get; set; }
        public string NiveauActiveBackgroundColor { get; set; }
        public int IdJoueur { get; set; }
        public int ThemeID { get; set; }
        public virtual ThemeDto Theme { get; set; }

        public virtual ICollection<QuestionDto> Questions { get; set; }
    }
}
