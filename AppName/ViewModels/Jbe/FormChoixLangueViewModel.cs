using AppName.Models;
using AppName.Resx;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.CommunityToolkit.Helpers;
using Xamarin.Forms;

namespace AppName.ViewModels.Jbe
{
    public class FormChoixLangueViewModel : BindableObject
    {
        private ObservableCollection<Language> _SupportedLanguages;

        public ObservableCollection<Language> SupportedLanguages
        {
            get { return _SupportedLanguages; }
            //get => _SupportedLanguages;
            set
            {
                _SupportedLanguages = value;
                OnPropertyChanged();
            }
        }

        private Language _SelectedLanguage;

        public Language SelectedLanguage
        {
            get { return _SelectedLanguage; }
            set
            {
                _SelectedLanguage = value;
            }
        }

        public ICommand ChangeLanguageCommand { get; }

        //public Command ChangeLanguageCommand { get; set; }
        public FormChoixLangueViewModel()
        {
            ChangeLanguageCommand = new Command(PerformOperation);

            SupportedLanguages = new ObservableCollection<Language>()
            {
                new Language{ Name = AppResources.French, CI = "fr"},
                new Language{Name = AppResources.English, CI= "en"}
            };

            SelectedLanguage = SupportedLanguages.FirstOrDefault(pro => pro.CI == LocalizationResourceManager.Current.CurrentCulture.TwoLetterISOLanguageName);
        }

        //private void PerformOperation(object obj)
        //{
        //    LocalizationResourceManager.Current.SetCulture(CultureInfo.GetCultureInfo(SelectedLanguage.CI));
        //}

        //public Command ChangeLanguageCommand
        //{
        //    get
        //    {
        //        return new Command(() =>
        //        {


        //            PerformOperation();
        //        });

        //    }

        //}

        //async void PerformOperation()
        //{
        //    //CrossMultilingual.Current.CurrentCultureInfo = new CultureInfo("en");

        //    LocalizationResourceManager.Current.SetCulture(CultureInfo.GetCultureInfo(SelectedLanguage.CI));

        //}

        private void PerformOperation(object obj)
        {
            // Bonus Steps
            //// Get all the cultures 
            //CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.UserCustomCulture |
            //                                              CultureTypes.SpecificCultures);

            //// get the phone's culture. Playaround with it to preselect the culture as soon as the app loads. 
            //var getlanguage = System.Globalization.CultureInfo.CurrentUICulture.Name;

            LocalizationResourceManager.Current.SetCulture(CultureInfo.GetCultureInfo(SelectedLanguage.CI));

        }



    }
}
