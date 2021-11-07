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
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();
        }

        private async void OnCloseButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
        }

        private void OnLoginButtonClicked(object sender, EventArgs args)
        {
             Navigation.PushAsync(new Views.JbeForm.Authentification.Login());
        }

        private void OnRegisterButtonClicked(object sender, EventArgs args)
        {
            
        }

    }
}