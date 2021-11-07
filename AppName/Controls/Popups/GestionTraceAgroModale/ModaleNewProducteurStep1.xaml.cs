using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppName.Controls.Popups.GestionTraceAgroModale
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ModaleNewProducteurStep1 :PopupPage
    {
        public ModaleNewProducteurStep1()
        {
            InitializeComponent();
        }
        private void OnClose(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAsync();
        }
    }
}