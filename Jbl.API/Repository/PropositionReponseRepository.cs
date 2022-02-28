using Jbl.API.Data;
using Jbl.API.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jbl.API.Repository
{
    public class PropositionReponseRepository : IPropositionReponseRepository
    {
        private readonly DataContext _context;

        public PropositionReponseRepository(DataContext context)
        {
            _context = context; 
        }

        public bool DeletePropositionReponse(int propositionId)
        {
            var entityPropositionReponse = _context.PropositionReponses.Find(propositionId);
            _context.PropositionReponses.Remove(entityPropositionReponse);
            var data = _context.SaveChanges();
            return data > 0;
        
        }

        public List<PropositionReponse> GetAllPropositionReponse()
        {
            var AllPropositionReponse = _context.PropositionReponses.ToList();
            return AllPropositionReponse;
        }

        public List<PropositionReponse> GetAllPropositionReponseByQuestionId(int QuestionId)
        {
            var PropositionReponseByQuestionId = _context.PropositionReponses.Where(p => p.QuestionID == QuestionId).ToList();
            return PropositionReponseByQuestionId;
        }

        public bool SavePropositionReponse(PropositionReponse PropositionReponse)
        {
            if (PropositionReponse == null)
                return false;
            _context.PropositionReponses.Add(PropositionReponse);
            var data = _context.SaveChanges();

            return data > 0;
        }

        public bool UpdatePropositionReponse(PropositionReponse PropositionReponse)
        {
            if (PropositionReponse == null)
                return false;

            var entityPropositionReponse = _context.PropositionReponses.Find(PropositionReponse);
            entityPropositionReponse.Libelle = PropositionReponse.Libelle;
            entityPropositionReponse.QuestionID = PropositionReponse.QuestionID;

            var data = _context.SaveChanges();

            return data > 0;


        }
    }
}
