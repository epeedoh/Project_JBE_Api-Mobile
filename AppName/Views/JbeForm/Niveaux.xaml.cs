using AppName.Models;
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
    public partial class Niveaux : ContentPage
    {
        NiveauxViewModel viewModel;
        public Niveaux(int themeID)
        {
            InitializeComponent();
            BindingContext = viewModel = new NiveauxViewModel();
        }

        private async void OnCloseButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
        }

        private async Task clvNiveaux_SelectionChangedAsync(object sender, SelectionChangedEventArgs e)
        {
           // await Navigation.PushModalAsync(new FormQuestionnaire());

            #if !NAVIGATION
                        //await Navigation.PushAsync(new WalkthroughImagePage());

                        //await Navigation.PushAsync(new MenuThemes());
                        //  await Navigation.PushAsync(new Stage());
                        await Navigation.PushModalAsync(new ThemeCarrous());
            #endif
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.ListNiveau.Count == 0)
                viewModel.CmdLoadNiveauCommand.Execute(null);

        }

        void UpdateSelectionNiveauData(IEnumerable<object> previousSelectedData, IEnumerable<object> currentSelectedData)
        {
            Constant.NiveauSelect = new Models.Niveau();

            var selectedNiveau = currentSelectedData.LastOrDefault() as Models.Niveau;

            Constant.NiveauSelect = selectedNiveau;

        }

        private void clvNiveaux_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateSelectionNiveauData(e.PreviousSelection, e.CurrentSelection);

            Navigation.PushModalAsync(new FormQuestionnaire());
        }
    }
}