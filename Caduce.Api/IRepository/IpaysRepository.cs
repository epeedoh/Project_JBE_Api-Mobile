using Caduce.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caduce.Api.IRepository
{
   public interface IpaysRepository
    {
        Task<Pays> CreatePays(Pays pay);

        Task<Pays> UpdatePays(Pays pay);
        Task<bool> PaysExists(string nom, string codepay);
        Task<bool> PaysExistsByCode(string codepay);
        Task<List<Pays>> AllPays();

        Task<Region> CreateRegion(Region region);

        Task<bool> CreateRegion(List<Region> listreg);

        Task<List<Region>> AllRegionByPays(string CodePays);
        Task<Region> GetRegion(string codereg, string CodePays);
        Task<List<Personne>> GetPersonneRegion(string codereg);
        Task<Pays> GetPays(string CodePays);
        Task<Pays> GetInfoPays(string CodePays);
        Task<bool> SaveAll();
    }
}
