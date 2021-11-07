using Caduce.Api.Data;
using Caduce.Api.IRepository;
using Caduce.Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caduce.Api.Repository
{
    public class PaysRepository : IpaysRepository
    {
        private readonly DataContext _context;
        public PaysRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Pays>> AllPays()
        {
            var allpays = await _context.Pays.ToListAsync();
            return allpays;
        }

        public async Task<List<Region>> AllRegionByPays(string CodePays)
        {
            var AllRegion = await _context.Regions.Include(x => x.pays).Where(a => a.CodePays == CodePays).ToListAsync();
            return AllRegion;
        }

        public async Task<Pays> CreatePays(Pays pay)
        {
            await _context.Pays.AddAsync(pay);
            await _context.SaveChangesAsync();
            return pay;
        }

        public async Task<Region> CreateRegion(Region region)
        {
            await _context.Regions.AddAsync(region);
            await _context.SaveChangesAsync();
            return region;
        }

        public async Task<bool> CreateRegion(List<Region> listreg)
        {
            try
            {
                foreach (var reg in listreg)
                {
                    await _context.Regions.AddAsync(reg);
                }
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public async Task<List<Personne>> GetPersonneRegion(string codereg)
        {
            var AllRegionPersonne = await _context.Personnes.Where(a => a.CodeRegion == codereg)
            .ToListAsync();
            return AllRegionPersonne;
        }

        public async Task<Region> GetRegion(string codereg, string CodePays)
        {

            var region = await _context.Regions
            .Include(x => x.pays)
            .FirstOrDefaultAsync(x => x.CodeRegion == codereg && x.CodePays == CodePays);
            return region;
        }

        public async Task<bool> PaysExists(string nom, string codepay)
        {
            if (await _context.Pays.AnyAsync(u => u.Libelle == nom || u.CodePays == codepay))
                return true;
            return false;
        }

        public async Task<bool> PaysExistsByCode(string codepay)
        {
            if (await _context.Pays.AnyAsync(u => u.CodePays == codepay))
                return true;
            return false;
        }

        public async Task<Pays> UpdatePays(Pays pay)
        {
            await _context.Pays.AddAsync(pay);
            await _context.SaveChangesAsync();
            return pay;
        }

        public async Task<Pays> GetPays(string CodePays)
        {
            var pays = await _context.Pays.FirstOrDefaultAsync(x => x.CodePays == CodePays);
            return pays;
        }

        public async Task<Pays> GetInfoPays(string CodePays)
        {
            var pays = await _context.Pays.Include(x => x.regions).Include(x => x.entreprise).FirstOrDefaultAsync(x => x.CodePays == CodePays);
            return pays;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
