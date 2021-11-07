using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Jbl.API.Data
{
   public class Personne
    {

        public Personne()
        {

        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonneID { get; set; }
        public string Nom { get; set; }
        public string Prenoms { get; set; }

        public string NomComplet { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }

        public string Domicile { get; set; }
        public DateTime DateNaissance { get; set; }
        public string CodeSexe { get; set; }

        public string Identifiant { get; set; }
        public byte[] Image { get; set; }
        public bool CompteCreate { get; set; }

        public DateTime DateCreation { get; set; }
        public ICollection<Utilisateur> Utilisateurs { get; set; }

        public int SexeID { get; set; }
        public virtual Sexe Sexe { get; set; }

        public int PaysID { get; set; }
        public virtual Pays Pays { get; set; }


    }
}
