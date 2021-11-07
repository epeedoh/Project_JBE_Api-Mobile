using AutoMapper;
using Jbl.API.Data;
using Jbl.API.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jbl.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Stage, StageDto>();
            CreateMap<StageDto, Stage>();
        }
    }
}
