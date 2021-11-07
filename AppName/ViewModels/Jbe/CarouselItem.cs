using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace AppName.ViewModels.Jbe
{

    public class CarouselItem : INotifyPropertyChanged
    {

        public CarouselItem()
        {
            this.Title = string.Empty;
            this.Price = default(int);
            this.Name = string.Empty;
            this.StartColor = default(Color);
            this.EndColor = default(Color);
            this.BackgroundColor = default(Color);
            this.Type = string.Empty;
            this.Rotation = default(int);
            this.Description = string.Empty;
            this.CodeQuestion = string.Empty;
            this.LibelleQuestion = string.Empty;
            this.MontantCotisations = default(decimal);
            this.ImageSrc = string.Empty;
        }
        public string Title { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public Color StartColor { get; set; }
        public Color EndColor { get; set; }
        public Color BackgroundColor { get; set; }
        public string Type { get; set; }
        //public string ImageSrc { get; set; }
        public int Rotation { get; set; }
        public string Description { get; set; } = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean pretium dolor sed felis varius, at elementum nunc blandit.";



        public string CodeQuestion { get; set; }
        public string LibelleQuestion { get; set; }
      
        public Nullable<decimal> MontantCotisations { get; set; }
        public string ImageSrc { get; set; }

        double _position;
        public event PropertyChangedEventHandler PropertyChanged;

        public double Position
        {
            get { return _position; }
            set
            {
                if (_position != value)
                {
                    _position = value;
                    OnPropertyChanged();
                }
            }
        }






        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


}
