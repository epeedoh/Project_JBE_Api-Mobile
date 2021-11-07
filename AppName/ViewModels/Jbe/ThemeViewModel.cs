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
    public class ThemeViewModel : BaseViewModel
    {

        NiveauxServices _services = new NiveauxServices();
        ThemeServices _servicesTheme = new ThemeServices();

       // public Command LoadNiveauCommand { get; set; }
        public Command CmdLoadQuestion { get; set; }
        public Command CmdLoadNiveauCommand { get; set; }
        public Command CmdLoadThemeCommand { get; set; }

        public ObservableCollection<Question> ListQuestion;
        public ObservableCollection<Theme> ListTheme { get; set; } 
        public List<Niveau> ListNiveau { get; set; }

        public ThemeViewModel()
        {

            //  LoadNiveauCommand = new Command(async () => await InitialiseData());

            CmdLoadQuestion = new Command(() => LoadQuestion());
            CmdLoadThemeCommand = new Command(() => LoadThemesAsync(Constant.StageSelect.StageID));
            ListQuestion = new ObservableCollection<Question>();
            ListTheme = new ObservableCollection<Theme>();
            ListNiveau = new List<Niveau>();

            LoadQuestion();
        }

        public int UpdateThemeStatut(Theme theme)
        {
            var data = _services.UpdateThemeStatut(theme);
            return data.Result;
        }


        public string ActiveNextTheme(string CodeThemeSuivant)
        {
            var data = _services.ActiveNextTheme(CodeThemeSuivant);
            return data;
        }

        private ObservableCollection<Question> LoadQuestion()
        {
            ListQuestion = _services.GetListQuestionNiveauEnCour();

            return ListQuestion;
        }

        

        public async Task<ObservableCollection<Theme>> LoadThemesAsync(int IdStage)
        {
            //var listAnThemes = _services.GetThemeByIdStage(IdStage);
  var listAnThemes = await _servicesTheme.GetThemeByIdStage(IdStage);


            foreach (var item in listAnThemes)
            {
                var anTheme = new Theme()
                {
                    Active = item.Active,
                    ThemeID = item.ThemeID,
                    StageID = item.StageID,
                    Libelle = item.Libelle,
                    Point = item.Point,
                    ThemeActiveBackgroundColor = item.ThemeActiveBackgroundColor
                };
                ListTheme.Add(anTheme);
            }

            return ListTheme; 
        }


        public List<Niveau> LoadNiveaux(int IdTheme)
        {
            ListNiveau = _services.GetNiveauByIdTheme(IdTheme);
            return ListNiveau;
        }

    }
}
