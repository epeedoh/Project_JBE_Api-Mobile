using AppName.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppName.Services
{
    [Xamarin.Forms.Internals.Preserve(AllMembers = true)]
    public class ThemeServices
    {

        JbeServiceGenerique data = new JbeServiceGenerique();

        public List<Theme> ListeThemeByIdStage { get; set; }


        //public List<Theme> GetThemeByIdStage(int IdStage)
        //{
        //  var ListeTheme = new List<Theme>()
        //    {
        //        new Theme
        //        {
        //            Id = 1,
        //            Libelle = "Theme 1: Généralités sur la bible ",
        //            Active = true,
        //            IdStage = 1,
        //            Point = 5
                    
        //        },
        //        new Theme
        //        {
        //            Id = 2,
        //            Libelle = "Theme 2: Généralités sur la foi",
        //            Active = false,
        //            IdStage = 1
        //        },
        //        new Theme
        //        {
        //            Id = 3,
        //            Libelle = "Theme 3: Généralités sur la divinité",
        //            Active = false,
        //            IdStage = 1
        //        },
        //        new Theme
        //        {
        //            Id = 4,
        //            Libelle = "Theme 4: Généralités sur la grace",
        //            Active = false,
        //            IdStage = 1
        //        }
        //    };

         

        //    ListeThemeByIdStage = ListeTheme.Where(t => t.IdStage == IdStage).ToList();

        //    return ListeThemeByIdStage;
        //}


        public List<Theme> SaveTheme()
        {
            var ListeTheme = new List<Theme>()
            {
                new Theme
                {
                    ThemeID = 1,
                    CodeTheme = "Theme_1",
                    Libelle = "Theme 1: Généralités sur la bible ",
                    Active = true,
                    StageID = 1,
                    Point = 2,
                    CodeThemeSuivant ="Theme_2",
                    ThemeActiveBackgroundColor = "Green"

                },
                new Theme
                {
                    ThemeID = 2,
                     CodeTheme = "Theme_2",
                    Libelle = "Theme 2: Généralités sur la foi",
                    Active = false,
                    StageID = 1,
                      CodeThemeSuivant ="Theme_3",
                },
                new Theme
                {
                    ThemeID = 3,
                     CodeTheme = "Theme_3",
                    Libelle = "Theme 3: Généralités sur la divinité",
                    Active = false,
                    StageID = 1,
                    CodeThemeSuivant ="Theme_4"
                },
                new Theme
                {
                    ThemeID = 4,
                     CodeTheme = "Theme_4",
                    Libelle = "Theme 4: Généralités sur la grace",
                    Active = false,
                    StageID = 1,
                    CodeThemeSuivant ="Theme_5"
                }
            };


            //foreach(var item in ListeTheme)
            //{
            //    App.Database.SaveThemeAsync(item);
            //}

            App.Database.SaveThemeAsync(ListeTheme);


            // ListeThemeByIdStage = ListeTheme.Where(t => t.IdStage == IdStage).ToList();

            //  return ListeThemeByIdStage;
            return null;
        }


        public async Task<List<Theme>> GetAllThemesAsync()
        {
            var data = await App.Database.GetThemeAsync();

            return data;
        }

        public async Task<List<Theme>> GetThemeByIdStage(int IdStage)
        {
            var data = await App.Database.GetThemeByIdStage(IdStage);

            return data;
        }



        public async Task<List<Theme>> GetAllThemeFromAPI()
        {
            //var listTheme = new List<Theme>();
            ThemeResponse result = new ThemeResponse();
            try
            {
                result = await data.PostSharp<ThemeResponse>("", Constants.GetAllTheme);

                if (result != null)
                {
                    await App.Database.SaveThemeAsync(result.Themes);

                    //listTheme = the
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
            return result.Themes;
        }

        public async Task<List<Theme>> GetAllThemeFromPhoneDB()
        {
            var lstTheme = new List<Theme>();

            try
            {
                lstTheme = await App.Database.GetThemeAsync();

                if (lstTheme.Count <= 0)
                {
                    return await GetAllThemeFromAPI();
                }
                else
                {
                    return lstTheme;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }






    }
}


