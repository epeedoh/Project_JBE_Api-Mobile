using AutoMapper;
using Jbl.API.Dtos;
using Jbl.API.IRepository;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Threading.Tasks;


namespace Jbl.API.Controllers
{

    //[ApiController]
    //[Route("[controller]")]
    [Route("api/[controller]")]
    [ApiController]
    public class StageController : Controller
    {
        private readonly IStageRepository _repo;
        private readonly IMapper _mapper;


        public StageController(IStageRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        //[HttpGet("")]

        //[HttpPost("GetAllStage")]

        //   [ProducesResponseType(typeof(List<StageDto>),200)]
        //   public async Task<IActionResult> GetAllStage()
        //   {
        //       var allAssureur = await _repo.GetAllStage();
        //       var stage = _mapper.Map<List<StageDto>>(allAssureur);
        //       return Ok(stage);
        //   }





        //[HttpPost("GetAllStage")]

        //[ProducesResponseType(typeof(ObservableCollection<StageDto>), 200)]
        //public async Task<StageResponse> GetAllStage()
        //{
        //    var StageResponse = new StageResponse();
        //    var Stages = await _repo.GetAllStage();
        //    //StageResponse.
        //    StageResponse.Stages = _mapper.Map<ObservableCollection<StageDto>>(Stages);
        //    return StageResponse;
        //}

        //[EnableCors("CorsPolicy")]
        [HttpPost("GetAllStage")]

        //[ProducesResponseType(typeof(ObservableCollection<StageDto>), 200)]
        public StageResponse GetAllStage()
        {
            var StageResponse = new StageResponse();
            var Stages = _repo.GetAllStage();
            //StageResponse.
            StageResponse.Stages = _mapper.Map<List<StageDto>>(Stages);
            StageResponse.Statut = (int)HttpStatusCode.OK;
            StageResponse.Message = "Effectuer avec succes";

            return StageResponse;
        }


    }
}
