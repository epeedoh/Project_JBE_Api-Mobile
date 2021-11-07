using Jbl.API.Data;
using Jbl.API.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jbl.API.Repository
{



    public class ThemeRepository : IThemeRepository
    {

        private readonly DataContext _context;

        public ThemeRepository(DataContext context)
        {
            _context = context;
        }

        public List<Theme> GetAllTheme()
        {
            var AllTheme = _context.Themes.ToList();
            return AllTheme;
        }

        public List<Theme> GetThemeByStageId(int StageId)
        {
            var ThemeByStageSelect = _context.Themes.Where(t => t.StageID == StageId).ToList();

            return ThemeByStageSelect;
        }
    }
}
