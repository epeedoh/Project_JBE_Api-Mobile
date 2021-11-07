using Jbl.API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jbl.API.IRepository
{
    public interface IThemeRepository
    {
        List<Theme> GetAllTheme();
        List<Theme> GetThemeByStageId(int StageId);
    }
}
