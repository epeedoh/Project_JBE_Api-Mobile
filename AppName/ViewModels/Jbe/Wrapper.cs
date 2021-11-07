using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace AppName.ViewModels.Jbe
{
    public class Wrapper : BaseViewModel
    {



        public ObservableCollection<CarouselItem> Items { get; set; } = new ObservableCollection<CarouselItem>();

        private double _slidePosition;

        public event PropertyChangedEventHandler PropertyChanged;

        public double SlidePosition
        {
            get => _slidePosition; set
            {
                if (_slidePosition != value)
                {
                    _slidePosition = value;
                    OnPropertyChanged();
                }
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //public static implicit operator Wrapper(Wrapper v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
