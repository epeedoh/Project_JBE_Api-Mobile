using AppName.ViewModels.Jbe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppName.Views.JbeForm
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Themes : ContentPage
    {

        NiveauxViewModel viewModel = new NiveauxViewModel();
        public Themes() : this(null)
        {
       

        }

        public Themes(FeaturedMoviesViewModel context) 
        {
            InitializeComponent();
          //  BindingContext = context ?? new FeaturedMoviesViewModel();
            BindingContext = viewModel = new NiveauxViewModel();
        }


        private void Play_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.JbeForm.Niveau1());

        }

        private void OnClose(object sender, EventArgs e)
        {

        }

        

        private void Poursuivre_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.JbeForm.Niveau1());
        }

        private async void OnCloseButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
        }

        private void OnBeginButtonClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Views.JbeForm.FormQuestionnaire());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.ListTheme.Count == 0)
                viewModel.CmdLoadThemeCommand.Execute(null);

        }

    }
}