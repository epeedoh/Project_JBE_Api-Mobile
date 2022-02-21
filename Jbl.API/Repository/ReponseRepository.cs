using Jbl.API.Data;
using Jbl.API.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jbl.API.Repository
{
    public class ReponseRepository : IReponseRepository
    {
        private readonly DataContext _context;

        public ReponseRepository(DataContext context)
        {
            _context = context;
        }

        public bool DeleteReponse(int reponseId)
        {

            var entityReponse = _context.Reponses.Find(reponseId);

            _context.Reponses.Remove(entityReponse);

            var data = _context.SaveChanges();

            return data > 0;
        }

        public List<Reponse> GetAllResponse()
        {
            var AllReponse = _context.Reponses.ToList();
            return AllReponse;
        }

        public List<Reponse> GetReponseByQuestionId(int QuestionId)
        {
            var ReponseByQuestionId = _context.Reponses.Where(r => r.QuestionID == QuestionId).ToList();
            return ReponseByQuestionId;
        }

        public bool SaveReponse(Reponse reponse)
        {

            if (reponse == null)
                return false;

            _context.Reponses.Add(reponse);

            var data = _context.SaveChanges();

            return data > 0;
        }

        public bool UpdateReponse(Reponse reponse)
        {
            if (reponse == null)
                return false;

            var entityReponse = _context.Reponses.Find(reponse.ReponseID);

            entityReponse.Libelle = reponse.Libelle;
            entityReponse.QuestionID = reponse.QuestionID;
            //entityReponse.

            var data = _context.SaveChanges();
            return data > 0;
        }
    }
}
