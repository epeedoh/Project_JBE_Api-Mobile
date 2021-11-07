using AutoMapper;
using Jbl.API.Data;
using Jbl.API.Dtos;
using Jbl.API.IRepository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Jbl.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : Controller
    {
        private readonly IQuestionRepository _repo;
        private readonly IMapper _mapper;
        public QuestionController(IQuestionRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpPost("GetAllQuestion")]
        public QuestionResponse GetAllQuestion()
        {
            var QuestionResponse = new QuestionResponse();
            var Questions = _repo.GetAllQuestion();

            QuestionResponse.questions = _mapper.Map<List<QuestionDto>>(Questions);
            QuestionResponse.Statut = (int)HttpStatusCode.OK;
            QuestionResponse.Message = "Effectuer avec succes";

            return QuestionResponse;

        }

        [HttpPost("GetQuestionByNiveauId")]
        public QuestionResponse GetQuestionByNiveauId([FromBody] ParamGetQuestion param)
        {
            var QuestionResponse = new QuestionResponse();
            var Questions = _repo.GetQuestionByNiveauId(param.NiveauId);

            QuestionResponse.questions = _mapper.Map<List<QuestionDto>>(Questions);
            QuestionResponse.Statut = (int)HttpStatusCode.OK;
            QuestionResponse.Message = "Effectuer avec succes";

            return QuestionResponse;

        }

        [HttpPost("GetPropositionReponseByQuestionId")]
        public QuestionResponse GetPropositionReponseByQuestionId(int QuestionId)
        {
            var QuestionResponse = new QuestionResponse();
            var Questions = _repo.GetPropositionReponseByQuestionId(QuestionId);

            QuestionResponse.questions = _mapper.Map<List<QuestionDto>>(Questions);
            QuestionResponse.Statut = (int)HttpStatusCode.OK;
            QuestionResponse.Message = "Effectuer avec succes";

            return QuestionResponse;

        }

        [HttpPost("GetReponseByQuestionId")]
        public QuestionResponse GetReponseByQuestionId(int QuestionId)
        {
            var QuestionResponse = new QuestionResponse();
            var Questions = _repo.GetReponseByQuestionId(QuestionId);

            QuestionResponse.questions = _mapper.Map<List<QuestionDto>>(Questions);
            QuestionResponse.Statut = (int)HttpStatusCode.OK;
            QuestionResponse.Message = "Effectuer avec succes";

            return QuestionResponse;

        }


        [HttpPost("SaveQuestion")]
        public bool SaveQuestion(Question question)
        {
            bool retour = false  ;

            if(ModelState.IsValid)
            {
                //var QuestionResponse = new QuestionResponse();
                 retour = _repo.SaveQuestion(question);

                //QuestionResponse.questions = _mapper.Map<List<QuestionDto>>(Questions);
               // QuestionResponse.Statut = (int)HttpStatusCode.OK;
                //QuestionResponse.Message = "Effectuer avec succes";
            }
            else
            {
                retour = false;
            }


            return retour;

        }



    }
}
