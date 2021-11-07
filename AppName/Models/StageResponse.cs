using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AppName.Models
{
    public class StageResponse:ApiReponse
    {
        public List<Stage> Stages { get; set; }
    }
}
