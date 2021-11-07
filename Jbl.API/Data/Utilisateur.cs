using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Jbl.API.Data
{
    public class Utilisateur
    {
        public Utilisateur()
        {

        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UtilisateurID { get; set; }
        public string Username { get; set; }

        public byte[] Image { get; set; }
        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }
        public int PersonneID { get; set; }
        public virtual Personne Personne { get; set; }
        public virtual ICollection<RoleType> UtilisateurRoles { get; set; }



    }
}
