using AutoMapper;
using Jbl.API.Dtos;
using Jbl.API.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Jbl.API.Data;

namespace Jbl.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropositionReponseController : Controller
    {

        private readonly IPropositionReponseRepository _repo;
        private readonly IMapper _mapper;

        public PropositionReponseController(IPropositionReponseRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }


        [HttpPost("GetAllPropositionReponse")]
        public PropositionReponseResponse GetAllPropositionReponse()
        {
            var PropositionReponseResponse = new PropositionReponseResponse();
            var PropositionReponses = _repo.GetAllPropositionReponse();

            PropositionReponseResponse.PropositionReponses = _mapper.Map<List<PropositionReponseDto>>(PropositionReponses);
            PropositionReponseResponse.Statut = (int)HttpStatusCode.OK;
            PropositionReponseResponse.Message = "Effectuer avec succes";

            return PropositionReponseResponse;
        }

        [HttpPost("GetAllPropositionReponseByQuestionId")]
        public PropositionReponseResponse GetAllPropositionReponseByQuestionId([FromBody]ParamGetResponse Question)
        {
            var PropositionReponseResponse = new PropositionReponseResponse();
            var PropositionReponses = _repo.GetAllPropositionReponseByQuestionId(Question.QuestionId);

            PropositionReponseResponse.PropositionReponses = _mapper.Map<List<PropositionReponseDto>>(PropositionReponses);
            PropositionReponseResponse.Statut = (int)HttpStatusCode.OK;
            PropositionReponseResponse.Message = "Effectuer avec succes";

            return PropositionReponseResponse;
        }

        [HttpPost("SavePropositionReponse")]
        public PropositionReponseResponse SavePropositionReponse(PropositionReponseDto PropositionReponse)
        {
            PropositionReponseResponse PropositionReponseResponse = new PropositionReponseResponse();

            if (ModelState.IsValid)
            {
                var dataPropositionReponse = Mapper.Map<PropositionReponseDto, PropositionReponse>(PropositionReponse);
                Mapper.AssertConfigurationIsValid();

                PropositionReponseResponse.IsSave = _repo.SavePropositionReponse(dataPropositionReponse);

                PropositionReponseResponse.Statut = (int)HttpStatusCode.OK;
                PropositionReponseResponse.Message = "Effectuer avec succes";
            }
            return PropositionReponseResponse;

        } 

        [HttpPost("UpdatePropositionReponse")]
        public PropositionReponseResponse UpdatePropositionReponse(PropositionReponseDto PropositionReponse)
        {
            PropositionReponseResponse PropositionReponseResponse = new PropositionReponseResponse();
            if(ModelState.IsValid)
            {
                var dataPropositionReponse = Mapper.Map<PropositionReponseDto, PropositionReponse>(PropositionReponse);
                Mapper.AssertConfigurationIsValid();

                PropositionReponseResponse.IsSave = _repo.UpdatePropositionReponse(dataPropositionReponse);
                PropositionReponseResponse.Statut = (int)HttpStatusCode.OK;
                PropositionReponseResponse.Message = "Effectuer avec succes";

            }
            return PropositionReponseResponse;
        }

        [HttpPost("DeletePropositionReponse")]
        public PropositionReponseResponse DeletePropositionReponse(int IdPropositionReponse)
        {
            PropositionReponseResponse PropositionReponseResponse = new PropositionReponseResponse();
            if(ModelState.IsValid)
            {
                //var dataPropositionReponse = Mapper.Map<PropositionReponseDto, PropositionReponse>(PropositionReponse);
                //Mapper.AssertConfigurationIsValid();

                PropositionReponseResponse.IsSave = _repo.DeletePropositionReponse(IdPropositionReponse);
                PropositionReponseResponse.Statut = (int)HttpStatusCode.OK;
                PropositionReponseResponse.Message = "Effectuer avec succes";
            }
            return PropositionReponseResponse;
        }
    }
}
