using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace AppName.ViewModels
{
    [Xamarin.Forms.Internals.Preserve(AllMembers = true)]

    public class BaseViewModel : INotifyPropertyChanged
    {
        //public IDataStore<Item> DataStore => DependencyService.Get<IDataStore<Item>>() ?? new MockDataStore();

        //public IGetMenuItems<MasterPageItem> DataStoreMasterPage => DependencyService.Get<IGetMenuItems<MasterPageItem>>() ?? new GetMenuItems();



        //public IDataProduiClientStore<ProduitClient> DataStoreProduitClient => DependencyService.Get<IDataProduiClientStore<ProduitClient>>() ?? new DataProduiClientStore();

        // public IAppMobileNsiaChapService<AuthentificationReponse> DataStoreAuth => DependencyService.Get<IAppMobileNsiaChapService<AuthentificationReponse>>() ?? new PostSharp();





        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }

        string title = string.Empty;
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName] string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }

}
