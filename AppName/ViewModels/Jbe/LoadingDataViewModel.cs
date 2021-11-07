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
    public class LoadingDataViewModel : BaseViewModel
    {

        StageServices _services = new StageServices();
        ThemeServices _serviceTheme = new ThemeServices();

        JbeServiceGenerique data;
        public List<Stage> ListStage { get; set; }

        public Command LoadDataCommand { get; set; }

        public Command LoadStageCommand { get; set; }
        public Command LoadJoueurNiveauScore { get; set; }

        public Command CmdSaveJoueurNiveauScoreCommand { get; set; }

        bool isBusy = false;
        private bool _Show = true;

        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                isBusy = value;
                OnPropertyChanged();
            }
        }


        public LoadingDataViewModel()
        {
            data = new JbeServiceGenerique();
            ListStage = new List<Stage>();
            //  LoadStageCommand = new Command(async () => await GetAllStage());

            LoadDataCommand = new Command(async () => await InitData());

          //  InitData();
          //  LoadJoueurNiveauScore = new Command(async () =>  GetStaticJoueurNiveauScore());

          //CmdSaveJoueurNiveauScoreCommand = new Command(async () => SaveStaticJoueurNiveauScore());
        }

        public async Task InitData()
        {

          var lstTheme = await _serviceTheme.GetAllThemeFromPhoneDB();

            if(lstTheme.Count <= 0)
            {
                await _serviceTheme.GetAllThemeFromAPI();
            }

            var lstStage = await _services.GetAllStageFromPhoneDB();

            if(lstStage.Count <=0)
            {
                await _services.GetAllStageFromApi();
            }


            Application.Current.MainPage = new NavigationPage(new Views.JbeForm.AccueilForms.Accueil());
        }

        public async Task GetAllStage()
        {

            //if(IsBusy)

            try
            {
                StageResponse result = await data.PostSharp<StageResponse>("", Constants.GetAllStage);

                if (result != null)
                {
                    ListStage = result.Stages;
                    await App.Database.SaveStagesAsync(ListStage);
                }
                else
                {

                    //ListStage = GetAllStaticStage();
                    //await App.Database.SaveStagesAsync(ListStage);
                    await App.Current.MainPage.DisplayAlert("Connexion", "Verifier vos parametre de connexion", "OK");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            //finally





            //{
            //    IsBusy = false;
            //}

            //Navigation.PushAsync(new Views.JbeForm.AccueilForms.Accueil());

            Application.Current.MainPage = new NavigationPage(new Views.JbeForm.AccueilForms.Accueil());
        }

       

        public JoueurNiveauScore SaveStaticJoueurNiveauScore()
        {
            var dataJoueur = new JoueurNiveauScore
            {
                DateTime = DateTime.Now,
                NiveauID = 1,
                StageID = 1,
                ThemeID = 1,
                Score = 50

            };

            //var resultJNS = App.Database.SaveJoueurNiveauScore(dataJoueur);

            //var resultJNS2 = App.Database.GetdataJoueurNiveauScore();

            return dataJoueur;
        }



        public ObservableCollection<Stage> GetAllStaticStage()
        {
            var ListeStage = new ObservableCollection<Stage>()
            {
                new Stage
                {
                    StageID = 1,
                    CodeStage = "Stage 1",
                    Libelle = "Généralités",
                     Active = true,

                },
                new Stage
                {
                      StageID = 2,
                 CodeStage = "Stage 2",
                    Libelle = "Spécialités",
                     Active = false,
                },
                new Stage
                {
                      StageID = 3,
                       CodeStage = "Stage 3",
                    Libelle = "Etudes approfondies",
                     Active = false,
                },
                new Stage
                {
                    StageID = 4,
                    CodeStage = "Stage 4",
                    Libelle = "Experts",
                     Active = false,
                }
            };



            //ListNiveauById = ListeNiveau.Where(t => t.IdTheme == IdTheme).ToList();

            return ListeStage;
        }



    }
}
