using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caduce.Api.Models
{
    public class UtilisateurRoles
    {
        public UtilisateurRoles()
        {
            roleType = new RoleType();
            utilisateur = new Utilisateur();
            //  Usercreate =  new Utilisateur();

        }
        public Guid Id { get; set; }
        public Guid RoleTypeId { get; set; }
        public Guid UtilisateurId { get; set; }

        public DateTime DateCreation { get; set; }
        public string CodeRole { get; set; }
        public bool EstActif { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public Guid UsercreateId { get; set; }

        public RoleType roleType { get; set; }
        public Utilisateur utilisateur { get; set; }
        // public Utilisateur Usercreate { get; set; }
    }
}
