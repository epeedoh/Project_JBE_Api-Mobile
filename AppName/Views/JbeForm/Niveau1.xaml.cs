using AppName.Models;
using AppName.Services;
using AppName.ViewModels.Jbe;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppName.Views.JbeForm
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Niveau1 : ContentPage
    {

     

        private int _currentIndex;
        private List<Color> _backgroundColors = new List<Color>();
        NiveauxServices _services ;
        public Wrapper Wrapper { get; set; }
        public Command LoadContratsCommand { get; set; }
        public ObservableCollection<Question> ListQuestion;
        public ObservableCollection<CarouselItem> MvvmItems { get; set; }

        //public Niveau1()
        //{
        //    InitializeComponent();
        //    MvvmItems = new ObservableCollection<CarouselItem>();
        //    _services = new NiveauxServices();
        //    ListQuestion = new ObservableCollection<Question>();
        //    LoadQuestion();

        //    Title = "Niveau 1";

        //}

        public Niveau1()
        {
            InitializeComponent();
            ////MvvmItems = new ObservableCollection<CarouselItem>();

            ////_services = new NiveauxServices();
            ////ListQuestion = new ObservableCollection<Question>();
            ////LoadQuestion();

            ////Title = "Niveau 1";

            //////  MvvmItems.Clear();

            ////foreach (var item in ListQuestion)
            ////{
            ////    //  ListProduitPoliceMontantCotisationMobile.Add(item);

            ////    var anCaroussel = new CarouselItem()
            ////    {
                    
            ////        LibelleQuestion = item.Libelle,

                   
            ////        //     BackgroundColor = Color.FromHex("FFFF"),
            ////        Position = 0,
            ////        StartColor = Color.FromHex("#0d1f61"),
            ////        EndColor = Color.FromHex("#0d1f61")
            ////    };

            ////    MvvmItems.Add(anCaroussel);


            ////}

            ////Wrapper = new Wrapper
            ////{
            ////    Items = MvvmItems
            ////};

            ////// Create out a list of background colors based on our items colors so we can do a gradient on scroll.
            ////for (int i = 0; i < Wrapper.Items.Count; i++)
            ////{
            ////    var current = Wrapper.Items[i];
            ////    var next = Wrapper.Items.Count > i + 1 ? Wrapper.Items[i + 1] : null;

            ////    /*  if (next != null)
            ////          _backgroundColors.AddRange(SetGradients(current.BackgroundColor, next.BackgroundColor, 100));
            ////      else
            ////          _backgroundColors.Add(current.BackgroundColor); */
            ////}



            ////this.BindingContext = Wrapper;








        }


        private ObservableCollection<Question> LoadQuestion()
        {
            ListQuestion = _services.GetListQuestionNiveauEnCour();

            return ListQuestion;
        }

        private async void OnCloseButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
        }

        private void OnRegisterButtonClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Views.JbeForm.FormQuestionnaire());
        }


    }
}