using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caduce.Api.Dto
{
    public class PersonneDto
    {
        public string Nom { get; set; }
        public string Prenoms { get; set; }

        public string NomComplet { get; set; }

        public string Telephone { get; set; }

        public string Domicile { get; set; }
        public DateTime DateNaissance { get; set; }
        public int ProfessionId { get; set; }

        public string CodeProfession { get; set; }

        public string CodeRegion { get; set; }


        public int SexeId { get; set; }
        public string CodeSexe { get; set; }

        public int RegionId { get; set; }
        public string Image { get; set; }
        public string Nationalite { get; set; }
    }
}
