using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Jbl.Data.Entities
{
    public class Stage
    {

        public Stage()
        {
                
        }


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StageID { get; set; }
        public string Libelle { get; set; }
 
        public virtual ICollection<Theme> Themes { get; set; }
        //public int UtilisateurID { get; set; }
        //public virtual Utilisateur Utilisateur { get; set; }
    }
}
