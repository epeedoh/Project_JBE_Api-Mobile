using Jbl.API.Data;
using Jbl.API.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jbl.API.IRepository
{
    public interface IStageRepository
    {
        //Task<List<Stage>> GetAllStage();
        List<Stage> GetAllStage();
    }
}
