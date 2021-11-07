using AppName.Services;
using AppName.ViewModels.Jbe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppName.Models;
using System.Collections.ObjectModel;
using CarouselView.FormsPlugin.Abstractions;
using Rg.Plugins.Popup.Services;

namespace AppName.Views.JbeForm
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FormQuestionnaire : ContentPage
    {


        private int _currentIndex;
        private List<Color> _backgroundColors = new List<Color>();
        public PropositionReponse PropositionReponseSelect {get;set;}
     
        public int Score = 0;

        NiveauxServices _services;
        public Wrapper Wrapper { get; set; }
        public Command LoadContratsCommand { get; set; }
        public ObservableCollection<Question> ListQuestion;
        public ObservableCollection<CarouselItem> MvvmItems { get; set; }
        FormQuestionnaireViewModel viewModel;

        public FormQuestionnaire()
        {
            InitializeComponent();
            Constant.PointTotalNiveauObtenue = 0;
            PropositionReponseSelect = new PropositionReponse();

            MvvmItems = new ObservableCollection<CarouselItem>();

            _services = new NiveauxServices();
            //ListQuestion = new ObservableCollection<Question>();
            //LoadQuestion();

            Title = "Niveau 1";

   

            BindingContext = viewModel = new FormQuestionnaireViewModel();
       
        }

        //private ObservableCollection<Question> LoadQuestion()
        //{
        //    ListQuestion = _services.GetListQuestionNiveauEnCour();

        //    return ListQuestion;
        //}

        public void Handle_PositionSelected(object sender, PositionSelectedEventArgs e)
        {


           

            _currentIndex = e.NewValue;
            Wrapper.SlidePosition = 0;

            //if(Wrapper.Items.Count !=0)
            //{

            var numPolice = Wrapper.Items[_currentIndex].LibelleQuestion;

        
            //   }


    

        }

        public void Handle_Scrolled(object sender, CarouselView.FormsPlugin.Abstractions.ScrolledEventArgs e)
        {



          

            int position = 0;

            if (e.Direction == ScrollDirection.Right)
                position = (int)((_currentIndex * 100) + e.NewValue);
            else if (e.Direction == ScrollDirection.Left)
                position = (int)((_currentIndex * 100) - e.NewValue);

            // Set the background color of our page to the item in the color gradient
            // array, matching the current scrollindex.

            //if (position > _backgroundColors.Count - 1)
            //    page.BackgroundColor = _backgroundColors.Last();
            //else if (position < 0)
            //    page.BackgroundColor = _backgroundColors.First();
            //else
            //    page.BackgroundColor = _backgroundColors[position];

            // Save the current scroll position
            Wrapper.SlidePosition = e.NewValue;

            if (e.Direction == ScrollDirection.Right)
            {
                // When scrolling right, we offset the current item and the next one.
                Wrapper.Items[_currentIndex].Position = -Wrapper.SlidePosition;

                if (_currentIndex < Wrapper.Items.Count - 1)
                {
                    Wrapper.Items[_currentIndex + 1].Position = 100 - Wrapper.SlidePosition;
                }

                var numPolice = Wrapper.Items[_currentIndex].LibelleQuestion;

                //ExecuteLoadDetailProduitClient(numPolice);

            }
            else if (e.Direction == ScrollDirection.Left)
            {
                // When scrolling left, we offset the current item and the previous one.
                Wrapper.Items[_currentIndex].Position = Wrapper.SlidePosition;

                if (_currentIndex > 0)
                {
                    Wrapper.Items[_currentIndex - 1].Position = -100 + Wrapper.SlidePosition;
                }

                var numPolice = Wrapper.Items[_currentIndex].LibelleQuestion;

                //ExecuteLoadDetailProduitClient(numPolice);
            }

          

        }



        protected override void OnAppearing()
        {
            base.OnAppearing();

            //if (viewModel.ListQuestion.Count == 0)
            //    viewModel.LoadQuestion();

            //viewModel.ListPropositionsEnCours = viewModel.LoadPropositionsRepose(1);
            //lstViewPropositon.ItemsSource = viewModel.ListPropositionsEnCours;
        }

        private void CarouselView_PositionChanged(object sender, PositionChangedEventArgs e)
        {
            //viewModel.ListPropositionsEnCours = viewModel.LoadPropositionsRepose(1);
            //lstViewPropositon.ItemsSource = viewModel.ListPropositionsEnCours;
        }

        private void CarouselView_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
        {
            Question previousItem = e.PreviousItem as Question;
            Question currentItem = e.CurrentItem as Question;


            viewModel.ListPropositionsEnCours = viewModel.LoadPropositionsRepose(currentItem.QuestionID);
            lstViewPropositon.ItemsSource = viewModel.ListPropositionsEnCours;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var CurrentData = CarrousForm.CurrentItem;
            var CurrentQuestion = CurrentData as Question;

            
            //var CurrentDataItemSourceCount = CarrousForm.ItemsSource.GetCount();
            //var CurrentItem = CarrousForm.Position;
            // CarrousForm.Position = CurrentItem + 1;

          var lstBonneReponse = viewModel.LoadDonneeBonneReponse(CurrentQuestion.QuestionID);

            foreach(var item in lstBonneReponse)
            {

                if (item.Libelle == PropositionReponseSelect.Libelle)
                {
                    // lstViewPropositon.SelectedItem .BackgroundColor = Color.Green;
                    //var selection = lstViewPropositon.SelectedItem as PropositionReponse;
                    //   selection.ba

                    Constant.PointTotalNiveauObtenue = Constant.PointTotalNiveauObtenue + CurrentQuestion.Point;


                    stackCorrige.IsVisible = true;
                    lblCorrige.IsVisible = true;
                    lblCorrige.Text = PropositionReponseSelect.Libelle;
                        lblCorrige.BackgroundColor = Color.Green;
                    BtnValider.IsVisible = false;

                    var pointQuestionEncour = CurrentQuestion.Point;
                    lblPoint.Text = "+" + " " + pointQuestionEncour.ToString() +" " + "Point(s)";
                    lblPoint.IsVisible = true;

                    //Constant.ScoreStatic = Constant.ScoreStatic + pointQuestionEncour;
                    // lblScore.Text = Constant.ScoreStatic.ToString();

                    lblScore.Text = Constant.PointTotalNiveauObtenue.ToString();
                                       //lblScore.IsVisible = true;
                }
                else
                {
                    lblCorrige.IsVisible = true;
                    lblCorrige.Text = item.Libelle;
                    lblCorrige.BackgroundColor = Color.Red;
                    BtnValider.IsVisible = false;


                    stackCorrige.IsVisible = true;

                }
            }

            stackCorrige.IsVisible = true;

            BtnPoursuivre.IsVisible = true;

            //var dialog = new IrregularDialog();

            //if (CurrentDataItemSourceCount == CurrentItem+1)
            //{
            //     OpenIrregularDialog();
            //}



        }

        public void OpenIrregularDialog()
        {
            var dialog = new IrregularDialogValidNiveau();
             PopupNavigation.Instance.PushAsync(dialog);
        }

        private void lstViewPropositon_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            PropositionReponseSelect = e.SelectedItem as PropositionReponse;
            //selectedItem.ItemBackground = Color.Aqua;

            //foreach (var item in this.contactList.ItemsSource)
            //{
            //    if (item != selectedItem)
            //        (item as PlatformInfo).ItemBackground = Color.Transparent;
            //}
        }

        private void ButtonPoursuivre_Clicked(object sender, EventArgs e)
        {
            var CurrentData = CarrousForm.CurrentItem;
            var CurrentQuestion = CurrentData as Question;
            var CurrentDataItemSourceCount = CarrousForm.ItemsSource.GetCount();

          

            var CurrentItem = CarrousForm.Position;

            
            if(CurrentDataItemSourceCount != CurrentItem + 1)
            
                CarrousForm.Position = CurrentItem + 1;

            //var lstBonneReponse = viewModel.LoadDonneeBonneReponse(CurrentQuestion.Id);

            //foreach (var item in lstBonneReponse)
            //{

            //    if (item.Id == PropositionReponseSelect.Id)
            //    {
            //        // lstViewPropositon.SelectedItem .BackgroundColor = Color.Green;
            //        //var selection = lstViewPropositon.SelectedItem as PropositionReponse;
            //        //   selection.ba
            //        lblCorrige.IsVisible = true;
            //        lblCorrige.Text = PropositionReponseSelect.Libelle;
            //        lblCorrige.BackgroundColor = Color.Green;

            //    }
            //    else
            //    {
            //        lblCorrige.IsVisible = true;
            //        lblCorrige.Text = PropositionReponseSelect.Libelle;
            //        lblCorrige.BackgroundColor = Color.Red;
            //    }
            //}

            //var dialog = new IrregularDialog();

            if (CurrentDataItemSourceCount == CurrentItem + 1)
            {
                OpenIrregularDialog();
            }

            lblCorrige.IsVisible = false;
            BtnPoursuivre.IsVisible = false;
            BtnValider.IsVisible = true;

            lblPoint.Text = "0";
            lblPoint.IsVisible = false;
            stackCorrige.IsVisible = false;

        }

        private void OnCloseButtonClicked(object sender, EventArgs e)
        {

             Navigation.PopModalAsync();
        }
    }


    //public class Constant
    //{
    //    public static int PointTotalNiveau = 0;
    //    public static int ScoreStatic = 0;
    //}

}