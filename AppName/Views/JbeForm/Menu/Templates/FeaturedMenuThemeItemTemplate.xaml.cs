using Xamarin.Forms;
using AppName.Core;

namespace AppName
{
    public partial class FeaturedMenuThemeItemTemplate : ContentView
    {
        public FeaturedMenuThemeItemTemplate()
        {
            InitializeComponent();
        }

        private void OnMoveToSecond(object sender, System.EventArgs e)
        {
            carousel.Position = 1;
        }

        private void Play1_Clicked(object sender, System.EventArgs e)
        {

            //Navigation.PushAsync(new Views.JbeForm.Themes());
            Navigation.PushAsync(new Views.JbeForm.ThemeCarrous());
        }
    }
}
