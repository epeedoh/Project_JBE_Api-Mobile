using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppName.Views.JbeForm.Authentification
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }


        private async void OnCloseButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
        }

        private void OnRegisterButtonClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Views.JbeForm.Authentification.Register());
        }

        private void OnLoginButtonClicked(object sender, EventArgs args)
        {
           // Navigation.PushAsync(new Views.JbeForm.AccueilForms.Accueil());
            Navigation.PushAsync(new Views.JbeForm.LoadingDataPage());

        }

    }
}