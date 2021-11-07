using Xamarin.Forms;
using AppName.Core;

namespace AppName
{
    public partial class FeaturedThemeNiveauItemTemplate : ContentView
    {
        public FeaturedThemeNiveauItemTemplate()
        {
            InitializeComponent();
        }

        private void OnMoveToSecond(object sender, System.EventArgs e)
        {
            //carousel.Position = 1;
        }

        private void Play_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Views.JbeForm.FormQuestionnaire());
        }
    }
}
