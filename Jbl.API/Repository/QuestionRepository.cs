﻿using Jbl.API.Data;
using Jbl.API.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jbl.API.Repository
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly DataContext _context;

        public QuestionRepository(DataContext context)
        {
            _context = context;
        }

        public List<Question> GetAllQuestion()
        {
            var AllQuestion = _context.Questions.ToList();

            return AllQuestion;
        }

        public List<Question> GetQuestionByNiveauId(int NiveauId)
        {
            var QuestionByNiveauSelect = _context.Questions.Where(q => q.NiveauID == NiveauId).ToList();
            return QuestionByNiveauSelect;
        }

        public List<PropositionReponse> GetPropositionReponseByQuestionId(int QuestionId)
        {
            var PropositionReponseByQuestionEnCours = _context.PropositionReponses.Where(q => q.QuestionID == QuestionId).ToList();
            return PropositionReponseByQuestionEnCours;
        }

        public List<Reponse> GetReponseByQuestionId(int QuestionId)
        {
            var ReponseByQuestionEnCours = _context.Reponses.Where(q => q.QuestionID == QuestionId).ToList();
            return ReponseByQuestionEnCours;
        }

        public bool SaveQuestion(Question question)
        {

            if (question == null)
                return false;

            //question.Niveau =
            var niveau = _context.Niveaux.Find(question.NiveauID);

            if (niveau != null)
                question.Niveau = niveau;

            _context.Questions.Add(question);

            var data = _context.SaveChanges();

            return data > 0;
        }


    }
}