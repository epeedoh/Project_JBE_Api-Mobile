using Jbl.API.Data;
using Jbl.API.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jbl.API.Repository
{
    public class NiveauRepository : INiveauRepository
    {
        private readonly DataContext _context;
        public NiveauRepository(DataContext context)
        {
            _context = context;
        }

        public List<Niveau> GetAllNiveau()
        {
            var AllNiveau = _context.Niveaux.ToList();

            return AllNiveau;
        }

        public List<Niveau> GetNiveauByThemeId(int ThemeId)
        {
            var ThemeByThemeSelect = _context.Niveaux.Where(n => n.ThemeID == ThemeId).ToList();

            return ThemeByThemeSelect;
        }
    }
}
