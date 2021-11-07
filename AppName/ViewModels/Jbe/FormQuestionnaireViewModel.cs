using AppName.Models;
using AppName.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace AppName.ViewModels.Jbe
{
    public class FormQuestionnaireViewModel: BaseViewModel
    {

        NiveauxServices _services;
        public ObservableCollection<Question> ListQuestion { get; set; }

 public ObservableCollection<PropositionReponse> ListPropositionsReponse { get; set; }
        public List<Reponse> ListBonneReponse { get; set; }

        public ObservableCollection<PropositionReponse> ListPropositionsEnCours { get; set; }


        public Command LoadQuestionCommand { get; set; }

        public FormQuestionnaireViewModel()
        {
            ListQuestion = new ObservableCollection<Question>();
            _services = new NiveauxServices();
         //   LoadQuestion = new Command(async () => LoadQuestion());
            LoadQuestion();
        }


        public ObservableCollection<Question> LoadQuestion()
        {
            Random rnd = new Random();


           // ListQuestion = _services.GetListQuestionNiveauEnCour();

           ListQuestion = _services.GetListQuestionByNiveauID(Constant.NiveauSelect.NiveauID);


            return ListQuestion;
        }

        public ObservableCollection<PropositionReponse> LoadPropositionsRepose(int IdQuestion)
        {
            //ListPropositionsReponse = _services.GetListPropositionReponseByQuestionId(IdQuestion);

           ListPropositionsReponse = _services.GetAllListPropositionReponseByQuestionID(IdQuestion);


            return ListPropositionsReponse;
        }

        public List<Reponse> LoadDonneeBonneReponse(int IdQuestion)
        {
            ListBonneReponse = _services.GetAllListBonneReponse(IdQuestion);

            return ListBonneReponse;
        }



    }
}
