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
    public class NiveauxViewModel : BaseViewModel
    {

        NiveauxServices _services = new NiveauxServices();

        ThemeServices _servicesServices = new ThemeServices();
        // public Command LoadNiveauCommand { get; set; }
        public Command CmdLoadQuestion { get; set; }
        public Command CmdLoadNiveauCommand { get; set; }
        public Command CmdLoadThemeCommand { get; set; }

        public ObservableCollection<Question> ListQuestion;
        public ObservableCollection<Theme> ListTheme { get; set; } 
        public ObservableCollection<Niveau> ListNiveau { get; set; }

        public NiveauxViewModel()
        {

            //  LoadNiveauCommand = new Command(async () => await InitialiseData());

            CmdLoadQuestion = new Command(() => LoadQuestion());
            CmdLoadThemeCommand = new Command(() => LoadThemes(1));
            ListQuestion = new ObservableCollection<Question>();
            ListTheme = new ObservableCollection<Theme>();
            ListNiveau = new ObservableCollection<Niveau>();
            CmdLoadNiveauCommand = new Command(() => LoadNiveaux(Constant.ThemeSelect.ThemeID));
            LoadQuestion();
        }

        public NiveauxViewModel(int IdStage)
        {

            //  LoadNiveauCommand = new Command(async () => await InitialiseData());

            CmdLoadQuestion = new Command(() => LoadQuestion());
            ListQuestion = new ObservableCollection<Question>();
            ListTheme = new ObservableCollection<Theme>();
            ListNiveau = new ObservableCollection<Niveau>();
            CmdLoadNiveauCommand = new Command(() => LoadNiveaux(IdStage));
            LoadQuestion();

            LoadThemes(1);
            LoadNiveaux(1);
        }

        private ObservableCollection<Question> LoadQuestion()
        {
            ListQuestion = _services.GetListQuestionNiveauEnCour();

            return ListQuestion;
        }

        public async Task<ObservableCollection<Theme>> LoadThemes(int IdStage)
        {
            var listAnThemes = await _servicesServices.GetThemeByIdStage(IdStage);

            foreach (var item in listAnThemes)
            {
                var anTheme = new Theme()
                {
                    
                    Active = item.Active,
                    ThemeID = item.ThemeID,
                    CodeTheme = item.CodeTheme,
                    StageID = item.StageID,
                    Libelle = item.Libelle,
                    Point = item.Point,
                    CodeThemeSuivant = item.CodeThemeSuivant,
                    ThemeActiveBackgroundColor = item.ThemeActiveBackgroundColor
                };
                ListTheme.Add(anTheme);
            }

            return ListTheme; 
        }


        public ObservableCollection<Niveau> LoadNiveaux(int IdTheme)
        {
            var result = _services.GetNiveauByIdTheme(IdTheme);

            foreach(var item in result)
            {
                //var anNiveau = new Niveau
                //{

                //}
                ListNiveau.Add(item);
            }


            return ListNiveau;
        }

    }
}
