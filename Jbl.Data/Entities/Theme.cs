
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Jbl.Data.Entities
{
    public class Theme
    {
        public Theme()
        {

        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ThemeID { get; set; }
        public string CodeTheme { get; set; }
        public string Libelle { get; set; }
        public bool Active { get; set; }
        public int Point { get; set; }
        public string CodeThemeSuivant { get; set; }
        public string ThemeActiveBackgroundColor { get; set; }

        public int StageID { get; set; }
        public virtual Stage Stage { get; set; }
        public virtual ICollection<Niveau> Niveaux { get; set; }
    }
}
