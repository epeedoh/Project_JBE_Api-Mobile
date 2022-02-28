using Jbl.API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jbl.API.IRepository
{
    public interface IPropositionReponseRepository
    {
        List<PropositionReponse> GetAllPropositionReponse();
        List<PropositionReponse> GetAllPropositionReponseByQuestionId(int QuestionId);
        bool SavePropositionReponse(PropositionReponse PropositionReponse);
        bool UpdatePropositionReponse(PropositionReponse PropositionReponse);
        bool DeletePropositionReponse(int propositionId);
    }
}
