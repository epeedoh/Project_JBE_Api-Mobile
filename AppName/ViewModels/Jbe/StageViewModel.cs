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

    public class StageViewModel : BaseViewModel
    {

        JbeServiceGenerique data;
        public ObservableCollection<Stage> ListStage { get; set; }
        public Command LoadStageCommand { get; set; }

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

        public StageViewModel()
        {
            data = new JbeServiceGenerique();

            ListStage = new ObservableCollection<Stage>();

            LoadStageCommand = new Command(async () => await GetAllStage());
        }

        public async Task GetAllStage()
        {

            //if(IsBusy)

                try
                {
                    //var result = await data.PostSharp<StageResponse> ("", Constants.GetAllStage);

                var result = await App.Database.GetAllStagesAsync();


                          if (result != null)
                          {

                            foreach(var item in result)
                                {
                                    //  var dataStage =  Stage

                                    ListStage.Add(item);
                                }

                                     //   ListStage = result;

                          //  await App.Database.SaveStagesAsync(ListStage);

                          }
                        else
                        {
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

        }


    }
}
