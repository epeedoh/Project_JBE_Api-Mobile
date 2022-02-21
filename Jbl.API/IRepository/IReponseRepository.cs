using Jbl.API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jbl.API.IRepository
{
    public interface IReponseRepository
    {
        List<Reponse> GetAllResponse();
        List<Reponse> GetReponseByQuestionId(int NiveauId);
        bool SaveReponse(Reponse reponse);
        bool UpdateReponse(Reponse reponse);
        bool DeleteReponse(int reponseId);
    }
}
