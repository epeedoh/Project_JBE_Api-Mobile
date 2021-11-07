using AutoMapper;
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
    public class NiveauController : Controller
    {

        private readonly INiveauRepository _repo;
        private readonly IMapper _mapper;

  
        public NiveauController(INiveauRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }


        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet("GetAllNiveau")]
        public NiveauResponse GetAllNiveau()
        {
            var NiveauResponse = new NiveauResponse();
            var Niveaux = _repo.GetAllNiveau();

            NiveauResponse.Niveaux = _mapper.Map<List<NiveauDto>>(Niveaux);
            NiveauResponse.Statut = (int)HttpStatusCode.OK;
            NiveauResponse.Message = "Effectuer avec succes";

            return NiveauResponse;

        }

        [HttpPost("GetNiveauByThemeId")]
        public NiveauResponse GetNiveauByThemeId(int ThemeId)
        {
            var NiveauResponse = new NiveauResponse();
            var Niveaux = _repo.GetNiveauByThemeId(ThemeId);

            NiveauResponse.Niveaux = _mapper.Map<List<NiveauDto>>(Niveaux);
            NiveauResponse.Statut = (int)HttpStatusCode.OK;
            NiveauResponse.Message = "Effectuer avec succes";

            return NiveauResponse;

        }

    }
}
