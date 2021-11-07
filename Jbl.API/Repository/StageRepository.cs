using Jbl.API.Data;
using Jbl.API.Dtos;
using Jbl.API.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jbl.API.Repository
{
    public class StageRepository : IStageRepository
    {
        private readonly DataContext _context;

        public StageRepository(DataContext context)
        {
            _context = context;
        }

        //public async Task<List<Stage>> GetAllStage()
        //{
        //    var AllStage = await _context.Stages.ToListAsync();
        //    return AllStage;
        //}

        public List<Stage> GetAllStage()
        {
            var AllStage =  _context.Stages.ToList();
            return AllStage;
        }

        //Task<List<StageDto>> IStageRepository.GetAllStage()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
