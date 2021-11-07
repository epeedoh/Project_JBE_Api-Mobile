using AppName.ViewModels.Jbe;
using AppName.Views.JbeForm.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppName.Views.JbeForm.AccueilForms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Accueil : ContentPage
    {

        SetDataViewModel viewModel = new SetDataViewModel();
        public Accueil()
        {
            InitializeComponent();

            BindingContext = viewModel = new SetDataViewModel();
            //viewModel.

        }

        public async void OnWhatsNew(object sender, EventArgs e)
        {
#if !NAVIGATION
            //await Navigation.PushAsync(new WalkthroughImagePage());

            //await Navigation.PushAsync(new MenuThemes());
          //  await Navigation.PushAsync(new Stage());
            await Navigation.PushModalAsync(new Stage());
#endif


        }

        private async void OnClose(object sender, EventArgs e)
        {
            //await Navigation.PopModalAsync();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (viewModel.JoueurNiveauScore == null)
                viewModel.CmdLoadJoueurNiveauScoreCommand.Execute(null);
        }

    }
}