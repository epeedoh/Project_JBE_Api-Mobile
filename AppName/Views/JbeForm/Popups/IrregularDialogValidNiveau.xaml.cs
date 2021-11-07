using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using AppName.Core;
using AppName.Views.JbeForm;
using AppName.Models;
using AppName.ViewModels.Jbe;

namespace AppName
{
    public partial class IrregularDialogValidNiveau : PopupPage
    {
        ThemeViewModel viewModel = new ThemeViewModel();
        public IrregularDialogValidNiveau()
        {
            InitializeComponent();
            BindingContext = viewModel = new ThemeViewModel();

            lblPointTotalNiveau.Text =  Constant.PointTotalNiveauObtenue.ToString() + " " +  "/" + " " + Constant.ThemeSelect.Point.ToString()+ " " + "Point ";

            if(Constant.ThemeSelect.Point == Constant.PointTotalNiveauObtenue)
            {
                lblMsgFelicitation.Text = "F�licitation";
                lblNiveauEstValide.Text = "Niveau valid�";
                btnPoursuivre.IsVisible = true;
                btnReprendre.IsVisible = true;
                var data = viewModel.ActiveNextTheme(Constant.ThemeSelect.CodeThemeSuivant);
            }
            else
            {
                lblMsgFelicitation.Text = "D�sol�!";
                btnPoursuivre.IsVisible = false;
            }
        }

        private void OnClose(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.JbeForm.ThemeCarrous());
            PopupNavigation.Instance.PopAsync();

        }
        private void OnReprendre(object sender, EventArgs e)
        {
        
            Navigation.PushAsync(new Views.JbeForm.ThemeCarrous());
            PopupNavigation.Instance.PopAsync();
        }
    }
}
