using AppName.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppName.Services
{
    [Xamarin.Forms.Internals.Preserve(AllMembers = true)]
    public class StageServices
    {

        JbeServiceGenerique data ;

        public List<Stage> ListeStage { get; set; }

        public StageServices()
        {
            data = new JbeServiceGenerique();
        }


        public async Task<List<Stage>> GetAllStageFromApi()
        {
            StageResponse result = new StageResponse();

            try
            {
                result = await data.PostSharp<StageResponse>("", Constants.GetAllStage);

                if(result != null)
                {
                    await App.Database.SaveStagesAsync(result.Stages);
                }
                else
                {
                    await Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Connexion", "Verifier vos parametre de connexion", "OK");
                }

            }
            catch(Exception ex)
            {
                throw ex;
            }

            return result.Stages;
        }

        public async Task<List<Stage>> GetAllStageFromPhoneDB()
        {
            var lstStage = new List<Stage>();

            try
            {
                lstStage = await App.Database.GetAllStagesAsync();

                if(lstStage.Count <=0 )
                {
                    return await GetAllStageFromApi();
                }
                else
                {
                    return lstStage;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }



    }
}
