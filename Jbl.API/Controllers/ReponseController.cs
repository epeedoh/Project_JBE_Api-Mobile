using AutoMapper;
using Jbl.API.Data;
using Jbl.API.IRepository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jbl.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReponseController : Controller
    {
        private readonly IReponseRepository _repo;
        private readonly IMapper _mapper;

        public ReponseController(IReponseRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpPost("SaveReponse")]
        public bool SaveReponse(Reponse reponse)
        {
            bool retour = false;

            if (ModelState.IsValid)
            {
                //var QuestionResponse = new QuestionResponse();
                retour = _repo.SaveReponse(reponse);
                //QuestionResponse.questions = _mapper.Map<List<QuestionDto>>(Questions);
                //QuestionResponse.Statut = (int)HttpStatusCode.OK;
                //QuestionResponse.Message = "Effectuer avec succes";
            }
            else
            {
                retour = false;
            }
            return retour;
        }

        [HttpPost("UpdateReponse")]
        public bool UpdateReponse([FromBody]Reponse reponse)
        {
            bool retour = false;
            if(ModelState.IsValid)
            {
                retour = _repo.UpdateReponse(reponse);
            }
            else
            {
                retour = false;
            }

            return retour;
        }

        [HttpPost("DeleteReponse")]
        public bool DeleteReponse([FromBody]int reponseId)
        {
            bool retour = false;

            if(ModelState.IsValid)
            {
                retour = _repo.DeleteReponse(reponseId);
            }
            else
            {
                retour = false;
            }

            return retour;
        }

    }
}

