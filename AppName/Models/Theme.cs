using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppName.Models
{
    public class Theme
    {
        //[SQLite.PrimaryKey]
        [PrimaryKey, AutoIncrement]
        public int ThemeID { get; set; }
        public string CodeTheme { get; set; }
        public string Libelle { get; set; }
        public bool Active { get; set; }
        public int Point { get; set; }       
        public string CodeThemeSuivant { get; set; }
        public string ThemeActiveBackgroundColor { get; set; }
        public int StageID { get; set; }
        //public virtual Stage Stage { get; set; }

        //public virtual ICollection<Niveau> Niveaux { get; set; }
    }
}
