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
    public partial class Stage : ContentPage
    {

        StageViewModel viewModel;

        public Stage()
        {
            InitializeComponent();
            BindingContext = viewModel = new StageViewModel();
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.ListStage.Count == 0)
                viewModel.LoadStageCommand.Execute(null);

        }

        void UpdateSelectionStageData(IEnumerable<object> previousSelectedData, IEnumerable<object> currentSelectedData)
        {
            Constant.StageSelect = new Models.Stage();

            var selectedStage = currentSelectedData.LastOrDefault() as Models.Stage;

            Constant.StageSelect = selectedStage;

        }

        private async void clvStage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            //  Navigation.PushAsync(new Views.JbeForm.ThemeCarrous());
            //Constant.SelectedStage = new Models.Stage();
            //var data = currentSelectedStage.FirstOrDefault() as Models.Stage;

            UpdateSelectionStageData(e.PreviousSelection, e.CurrentSelection);

            #if !NAVIGATION
                        //await Navigation.PushAsync(new WalkthroughImagePage());

                        //await Navigation.PushAsync(new MenuThemes());
                        //  await Navigation.PushAsync(new Stage());
                        await Navigation.PushModalAsync(new ThemeCarrous());
            #endif
        }


        private async void OnCloseButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
        }



    }
}