using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Caduce.Api.Dto
{
    public class PaysDto
    {
        [Required]
        public string CodePays { get; set; }
        [Required]
        public string Libelle { get; set; }
        public string Image { get; set; }
        public string Nationalite { get; set; }
        public string Capital { get; set; }
    }
}
