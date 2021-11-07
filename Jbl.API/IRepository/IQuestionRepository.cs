using Jbl.API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jbl.API.IRepository
{
    public interface IQuestionRepository
    {
        List<Question> GetAllQuestion();
        List<Question> GetQuestionByNiveauId(int NiveauId);
        List<PropositionReponse> GetPropositionReponseByQuestionId(int QuestionId);
        List<Reponse> GetReponseByQuestionId(int QuestionId);
        bool SaveQuestion(Question question);
    }
}
