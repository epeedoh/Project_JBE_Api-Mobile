using AppName.Controls.Popups.GestionTraceAgroModale;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace AppName.Controls.StepProgress
{
    public class StepProgressBarControl : StackLayout
    {
        Button _lastStepSelected;
        public static readonly BindableProperty StepsProperty = BindableProperty.Create(nameof(Steps), typeof(int), typeof(StepProgressBarControl), 0);
        public static readonly BindableProperty StepSelectedProperty = BindableProperty.Create(nameof(StepSelected), typeof(int), typeof(StepProgressBarControl), 0, defaultBindingMode: BindingMode.TwoWay);
        public static readonly BindableProperty StepColorProperty = BindableProperty.Create(nameof(StepColor), typeof(Xamarin.Forms.Color), typeof(StepProgressBarControl), Color.Black, defaultBindingMode: BindingMode.TwoWay);

        public Color StepColor
        {
            get { return (Color)GetValue(StepColorProperty); }
            set { SetValue(StepColorProperty, value); }
        }

        public int Steps
        {
            get { return (int)GetValue(StepsProperty); }
            set { SetValue(StepsProperty, value); }
        }

        public int StepSelected
        {
            get { return (int)GetValue(StepSelectedProperty); }
            set { SetValue(StepSelectedProperty, value); }
        }


        public StepProgressBarControl()
        {
            //Orientation = StackOrientation.Horizontal;
            //HorizontalOptions = LayoutOptions.FillAndExpand;


            Orientation = StackOrientation.Vertical;
            VerticalOptions = LayoutOptions.StartAndExpand;


            Padding = new Thickness(0, 10);
            Spacing = 0;
            AddStyles();

        }

        protected override void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == StepsProperty.PropertyName)
            {
                for (int i = 0; i < Steps; i++)
                {
                    var button = new Button()
                    {
                        Text = $"{i + 1}",
                        ClassId = $"{i + 1}",
                        Style = Resources["unSelectedStyle"] as Style
                    };

                    button.Clicked += Handle_Clicked;

                    this.Children.Add(button);

                    if (i < Steps - 1)
                    {
                        var separatorLine = new BoxView()
                        {
                            BackgroundColor = Color.Silver,
                            //HeightRequest = 1,
                            //WidthRequest = 5,

                            HeightRequest = 5,
                            WidthRequest = 1,

                            //VerticalOptions = LayoutOptions.Center,
                            //HorizontalOptions = LayoutOptions.FillAndExpand
                          HorizontalOptions   = LayoutOptions.Center,
                           VerticalOptions  = LayoutOptions.FillAndExpand

                        };
                        this.Children.Add(separatorLine);
                    }
                }
            }
            else if (propertyName == StepSelectedProperty.PropertyName)
            {
                var children = this.Children.First(p => (!string.IsNullOrEmpty(p.ClassId) && Convert.ToInt32(p.ClassId) == StepSelected));
                if (children != null) SelectElement(children as Button);

            }
            else if (propertyName == StepColorProperty.PropertyName)
            {
                AddStyles();
            }
        }
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            SelectElement(sender as Button);
        }

        async void SelectElement(Button elementSelected)
        {

            if (_lastStepSelected != null) _lastStepSelected.Style = Resources["unSelectedStyle"] as Style;

            elementSelected.Style = Resources["selectedStyle"] as Style;

            StepSelected = Convert.ToInt32(elementSelected.Text);
            _lastStepSelected = elementSelected;

            //if(StepSelected == 1)
            //{
            //    var dialog = new SimpleDialogNoTitle();
            //    await PopupNavigation.Instance.PushAsync(dialog);
            //}

            switch(StepSelected)
            {
                case 1:
                    var dialog = new ModaleNewProducteurStep1();
                    await PopupNavigation.Instance.PushAsync(dialog);
                    break;
                case 2:
                    var dialog2 = new CustomActionSheet();
                    await PopupNavigation.Instance.PushAsync(dialog2);
                    break;
                case 3:
                    var dialog3 = new SimpleDialogNoTitleInverse();
                    await PopupNavigation.Instance.PushAsync(dialog3);
                    break;
                case 4:
                    var dialog4 = new NotificationPopup();
                    await PopupNavigation.Instance.PushAsync(dialog4);
                    break;

                case 5:
                    var dialog5 = new SimpleDialog();
                    await PopupNavigation.Instance.PushAsync(dialog5);
                    break;

                case 6:
                    var dialog6 = new SimpleDialogNoTitleInverse();
                    await PopupNavigation.Instance.PushAsync(dialog6);
                    break;


            }

        }

        [Obsolete]
        void AddStyles()
        {
            var unselectedStyle = new Style(typeof(Button))
            {
                Setters = {
                    new Setter { Property = BackgroundColorProperty,   Value = Color.Transparent },
                    new Setter { Property = Button.BorderColorProperty,   Value = StepColor },
                    new Setter { Property = Button.TextColorProperty,   Value = StepColor },
                    new Setter { Property = Button.BorderWidthProperty,   Value = 0.5 },
                    new Setter { Property = Button.BorderRadiusProperty,   Value = 20 },
                    new Setter { Property = HeightRequestProperty,   Value = 40 },
                    new Setter { Property = WidthRequestProperty,   Value = 40 }
            }
            };

            var selectedStyle = new Style(typeof(Button))
            {
                Setters = {
                    new Setter { Property = BackgroundColorProperty, Value = StepColor },
                    new Setter { Property = Button.TextColorProperty, Value = Color.White },
                    new Setter { Property = Button.BorderColorProperty, Value = StepColor },
                    new Setter { Property = Button.BorderWidthProperty,   Value = 0.5 },
                    new Setter { Property = Button.BorderRadiusProperty,   Value = 20 },
                    new Setter { Property = HeightRequestProperty,   Value = 40 },
                    new Setter { Property = WidthRequestProperty,   Value = 40 },
                    new Setter { Property = Button.FontAttributesProperty,   Value = FontAttributes.Bold }
            }
            };

            Resources = new ResourceDictionary();
            Resources.Add("unSelectedStyle", unselectedStyle);
            Resources.Add("selectedStyle", selectedStyle);
        }
    }
}

