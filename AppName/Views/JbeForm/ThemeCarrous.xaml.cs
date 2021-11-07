using AppName.Models;
using AppName.ViewModels.Jbe;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppName.Views.JbeForm
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThemeCarrous : ContentPage
    {

        ThemeViewModel viewModel = new ThemeViewModel();

        public ThemeCarrous()
        {

            InitializeComponent();
            BindingContext = viewModel = new ThemeViewModel();
        }

        public ThemeCarrous(int StageID)
        {

            InitializeComponent();
            BindingContext = viewModel = new ThemeViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.ListTheme.Count == 0)
                viewModel.CmdLoadThemeCommand.Execute(null);
           // collectionView.ItemsSource = await App.Database.GetPeopleAsync();

        }

        private void OnBannerTapped(object sender, EventArgs e)
        {

        }

        private void RowThemeSelected(object sender, SelectionChangedEventArgs e)
        {

        }


        async void CollectionViewListSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateSelectionData(e.PreviousSelection, e.CurrentSelection);
            // Navigation.PushAsync(new Views.JbeForm.FormQuestionnaire());

            var ThemeID = Constant.ThemeSelect.ThemeID;

            //await Navigation.PushModalAsync(new FormQuestionnaire());



        #if !NAVIGATION
                    //await Navigation.PushAsync(new WalkthroughImagePage());

                    //await Navigation.PushAsync(new MenuThemes());
                    //  await Navigation.PushAsync(new Stage());
                    await Navigation.PushModalAsync(new Niveaux(ThemeID));
        #endif

        }

        void UpdateSelectionData(IEnumerable<object> previousSelectedContact, IEnumerable<object> currentSelectedTheme)
        {
            var selectedTheme = currentSelectedTheme.LastOrDefault() as Theme;
            Debug.WriteLine("Libelle: " + selectedTheme.Libelle);
            Debug.WriteLine("Active: " + selectedTheme.Active);

            Constant.ThemeSelect = selectedTheme;
          

        }

        private async void OnCloseButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
        }

        //public ThemeCarrous()
        //{
        //    InitializeComponent();
        //    BindingContext = viewModel = new NiveauxViewModel();

        //    var model = new NiveauxViewModel();

        //    for (var i = 0; i < model.ListTheme.Count; i++)
        //    {
        //        Children.Add(new NiveauxViewModel(model.ListTheme[i]));
        //    }

        //}
    }
}