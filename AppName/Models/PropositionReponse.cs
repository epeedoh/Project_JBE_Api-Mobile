using System;
using System.Collections.Generic;
using System.Text;

namespace AppName.Models
{
    public class PropositionReponse
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public int IdQestion  { get; set; }
    }
}
