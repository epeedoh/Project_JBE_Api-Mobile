using Jbl.API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jbl.API.IRepository
{
    public interface INiveauRepository
    {
        List<Niveau> GetAllNiveau();
        List<Niveau> GetNiveauByThemeId(int ThemeId);
        int UpdateNiveau(Niveau anNiveau);
        int DeleteNiveau(int NiveauId);
    }
}
