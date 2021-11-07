using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppName.Models
{

   // [Table("Stage")]
    public class Stage
    {
        //[PrimaryKey, AutoIncrement, Column("Id")]
        //public int Id { get; set; }
        public int StageID { get; set; }
        public string CodeStage { get; set; }
        public string Libelle { get; set; }
        public bool Active { get; set; }

        public string CodeStageSuivant { get; set; }
        public string StageActiveBackgroundColor { get; set; }

        //Alt+060
        //Alt+061
        //Alt+062
        //public virtual ICollection<Theme> Themes { get; set; }
    }
}
