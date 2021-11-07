using AppName.Models;
using AppName.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppName.ViewModels.Jbe
{
    public class SetDataViewModel : BaseViewModel
    {

        NiveauxServices _services = new NiveauxServices();
       // public Command LoadNiveauCommand { get; set; }
        public Command CmdLoadQuestion { get; set; }
        public Command CmdLoadNiveauCommand { get; set; }
        public Command CmdLoadThemeCommand { get; set; }
        public Command CmdLoadJoueurNiveauScoreCommand { get; set; }
        public JoueurNiveauScore JoueurNiveauScore { get; set; }
        public ObservableCollection<Question> ListQuestion;
        public ObservableCollection<Theme> ListTheme { get; set; } 
        public List<Niveau> ListNiveau { get; set; }

        public SetDataViewModel()
        {

            //  LoadNiveauCommand = new Command(async () => await InitialiseData());

            //CmdLoadQuestion = new Command(() => LoadQuestion());
            // CmdLoadThemeCommand = new Command(() => LoadThemes(1));
            LoadThemes();
            ListQuestion = new ObservableCollection<Question>();
            ListTheme = new ObservableCollection<Theme>();
            ListNiveau = new List<Niveau>();
            GenerateTheme();
            LoadQuestion();
            JoueurNiveauScore = new JoueurNiveauScore();
          //  CmdLoadJoueurNiveauScoreCommand = new Command(async () => await GetStaticJoueurNiveauScore());
        }

              public async Task GetStaticJoueurNiveauScore()
              {
            JoueurNiveauScore = await App.Database.GetdataJoueurNiveauScore();

        }

        public SetDataViewModel(int IdStage)
        {

            //  LoadNiveauCommand = new Command(async () => await InitialiseData());

            CmdLoadQuestion = new Command(() => LoadQuestion());
            ListQuestion = new ObservableCollection<Question>();
            ListTheme = new ObservableCollection<Theme>();
            ListNiveau = new List<Niveau>();
            CmdLoadNiveauCommand = new Command(() => LoadNiveaux(IdStage));
            LoadQuestion();

            GenerateTheme();
         //   LoadThemes();
            LoadNiveaux(1);
        }

        private ObservableCollection<Question> LoadQuestion()
        {
            ListQuestion = _services.GetListQuestionNiveauEnCour();

            return ListQuestion;
        }

        public void GenerateTheme()
        {
            var data = _services.SaveTheme();
        }

        public ObservableCollection<Theme> LoadThemes()
        {
            var listAnThemes = _services.GetThemesAsync();

            //foreach (var item in listAnThemes)
            //{
            //    var anTheme = new Theme()
            //    {
            //        Active = item.Active,
            //        Id = item.Id,
            //        IdStage = item.IdStage,
            //        Libelle = item.Libelle,
            //        Point = item.Point
            //    };
            //    ListTheme.Add(anTheme);
            //}

            return null; 
        }


        public List<Niveau> LoadNiveaux(int IdTheme)
        {
            ListNiveau = _services.GetNiveauByIdTheme(IdTheme);
            return ListNiveau;
        }

    }
}
