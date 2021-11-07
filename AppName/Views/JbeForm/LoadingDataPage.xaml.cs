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
    public partial class LoadingDataPage : ContentPage
    {

        LoadingDataViewModel viewModel;

        public LoadingDataPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new LoadingDataViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            //if (viewModel.ListStage.Count == 0)
                viewModel.LoadDataCommand.Execute(null);

           // if (viewModel.JoueurNiveauScore != null)
               // viewModel.CmdSaveJoueurNiveauScoreCommand.Execute(null);

        }

    }
}