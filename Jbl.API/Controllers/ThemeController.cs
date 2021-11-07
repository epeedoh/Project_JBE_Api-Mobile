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
    public class ThemeController : Controller
    {

        private readonly IThemeRepository _repo;
        private readonly IMapper _mapper;

        public ThemeController(IThemeRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpPost("GetAllTheme")]
        public ThemeResponse GetAllTheme()
        {
            var ThemeResponse = new ThemeResponse();
            var Themes = _repo.GetAllTheme();

            ThemeResponse.Themes = _mapper.Map<List<ThemeDto>>(Themes);
            ThemeResponse.Statut = (int)HttpStatusCode.OK;
            ThemeResponse.Message = "Effectuer avec succes";

            return ThemeResponse;
        }

        [HttpPost("GetThemeByStageId")]
        public ThemeResponse GetThemeByStageId(int StageId)
        {
            var ThemeResponse = new ThemeResponse();
            var Themes = _repo.GetThemeByStageId(StageId);
            ThemeResponse.Themes = _mapper.Map<List<ThemeDto>>(Themes);
            ThemeResponse.Statut = (int)HttpStatusCode.OK;
            ThemeResponse.Message = "Effectuer avec succes";

            return ThemeResponse;
        }


    }
}
