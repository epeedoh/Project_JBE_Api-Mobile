using AppName.Views.JbeForm.Authentification;
using Xamarin.Forms;
using System;
using System.IO;
using AppName.Data;
using AppName.Views.JbeForm;
using Xamarin.CommunityToolkit.Helpers;
using AppName.Resx;
//using AppName.Database;

namespace AppName
{
    public partial class App : Application
    {

        static Database database;

        public static Database Database
        {
            get
            {
                if (database == null)
                {
                    database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "people.db3"));
                }
                return database;
            }
        }


        public App()
        {
            LocalizationResourceManager.Current.Init(JbeResources.ResourceManager);

            InitializeComponent();

            Resources["DefaultStringResources"] = new Resx.JbeResources();

            //Idioma
            Resources["DefaultStringResources"] = new Resx.AppResources();


            SamplesCatalog.Initialize();

            //Página principal
            //MainPage = GetMainPage();


            //MainPage = new NavigationPage(new EcommerceMainPage());



            //MainPage = new NavigationPage(new ProductsCarouselPage());

            //MainPage = new NavigationPage(new Login());
            MainPage = new NavigationPage(new FormPresentation());


            //MainPage = new NavigationPage(new FormChoixLangue());



        }

        public static Page GetMainPage()
         {
            return new RootMasterDetailPage();
          }
    }
}
