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
    public partial class FormChoixLangue : ContentPage
    {
         FormChoixLangueViewModel viewModel;
        public FormChoixLangue()
        {
            InitializeComponent();
            BindingContext = viewModel = new FormChoixLangueViewModel();
        }
    }
}