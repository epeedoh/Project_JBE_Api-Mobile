using AutoMapper;
using Jbl.API.Dtos;
using Jbl.API.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        //public PropositionReponseDto GetAllPropositionReponse()
        //{
        //    var QuestionResponse = new QuestionResponse();
        //    var Questions = _repo.GetAllQuestion();

        //    QuestionResponse.questions = _mapper.Map<List<QuestionDto>>(Questions);
        //    QuestionResponse.Statut = (int)HttpStatusCode.OK;
        //    QuestionResponse.Message = "Effectuer avec succes";

        //    return QuestionResponse;
        //}

    }
}
