using AppName.Views.JbeForm.Authentification;
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
    public partial class FormPresentation : ContentPage
    {
        public FormPresentation()
        {
            InitializeComponent();
        }


        private void OnBtnJouerClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Login());
        }

        private void OnBtnQuitterClicked(object sender, EventArgs e)
        {

        }
    }
}