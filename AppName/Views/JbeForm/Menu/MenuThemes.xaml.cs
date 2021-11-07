using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppName.Views.JbeForm.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuThemes : ContentPage
    {
        public MenuThemes() : this(null)
        {
        }
        public MenuThemes(FeaturedMoviesViewModel context)
        {
            InitializeComponent();

            BindingContext = context ?? new FeaturedMoviesViewModel();
        }


    }
}