using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using DataBaseLibrary;

namespace DataBaseStudy
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NewPage : Page
    {
        Equalizer equalizer = new Equalizer();

        Windows.Storage.ApplicationDataContainer localSettings =
    Windows.Storage.ApplicationData.Current.LocalSettings;
        Windows.Storage.StorageFolder localFolder =
            Windows.Storage.ApplicationData.Current.LocalFolder;

        Windows.Storage.ApplicationDataCompositeValue composite =
                new Windows.Storage.ApplicationDataCompositeValue();

        public NewPage()
        {
            this.InitializeComponent();

            //First.IsChecked=DataBaseLibraryAccess.GetBtnData("First");
            //Second.IsChecked=DataBaseLibraryAccess.GetBtnData("Second");

            Windows.Storage.ApplicationDataCompositeValue composite =
                (Windows.Storage.ApplicationDataCompositeValue)localSettings.Values["AppData"];
            // Composite setting
            if (composite == null)
            {
                // No data
                Grid1.Children.Clear();
                equalizer.HorizontalAlignment = HorizontalAlignment.Center;
                equalizer.VerticalAlignment = VerticalAlignment.Center;
                Grid1.Children.Add(equalizer);
            }
            else
            {
                First.IsChecked = (bool)composite["firstChecked"];
                Second.IsChecked = (bool)composite["secondChecked"];

                var Slider1 = equalizer.FindName("MySlider") as Slider;
                Slider1.Value = (int)composite["sliderOne"];

                var Slider2 = equalizer.FindName("MySlider2") as Slider;
                Slider2.Value = (int)composite["sliderTwo"];

                var Slider3 = equalizer.FindName("MySlider3") as Slider;
                Slider3.Value = (int)composite["sliderThree"];

                var Slider4 = equalizer.FindName("MySlider4") as Slider;
                Slider4.Value = (int)composite["sliderFour"];

                var Slider5 = equalizer.FindName("MySlider5") as Slider;
                Slider5.Value = (int)composite["sliderFive"];
                equalizer.HorizontalAlignment = HorizontalAlignment.Center;
                equalizer.VerticalAlignment = VerticalAlignment.Center;
                Grid1.Children.Add(equalizer);

            }
        }


        private void First_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            First.Content = "Active";
            First.Foreground = new SolidColorBrush(Windows.UI.Colors.OrangeRed);
            
        }

        private void Second_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Second.Content = "Active"; 
            Second.Foreground = new SolidColorBrush(Windows.UI.Colors.OrangeRed);
            
        }

        private void First_Unchecked(object sender, RoutedEventArgs e)
        {
            First.Content = "InActive";
            First.Foreground = new SolidColorBrush(Windows.UI.Colors.Blue);
            
        }

        private void Second_Unchecked(object sender, RoutedEventArgs e)
        {
            Second.Content = "InActive";
            Second.Foreground = new SolidColorBrush(Windows.UI.Colors.Blue);
            
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            var Slider1 = equalizer.FindName("MySlider") as Slider;
            var Slider2 = equalizer.FindName("MySlider2") as Slider;
            var Slider3 = equalizer.FindName("MySlider3") as Slider;
            var Slider4 = equalizer.FindName("MySlider4") as Slider;
            var Slider5 = equalizer.FindName("MySlider5") as Slider;
            //if ((bool)First.IsChecked)
            //{
            //    DataBaseLibraryAccess.UpdateCheck(1, "First");
            //    DataBaseLibraryAccess.UpdateCheck(0, "Second");
            //}
            //else
            //{
            //    DataBaseLibraryAccess.UpdateCheck(0, "First");
            //    DataBaseLibraryAccess.UpdateCheck(1, "Second");
            //}

            //DataBaseLibraryAccess.UpdateCheck((int)Slider1.Value, "sliderOne");
            //DataBaseLibraryAccess.UpdateCheck((int)Slider2.Value, "sliderTwo");
            //DataBaseLibraryAccess.UpdateCheck((int)Slider3.Value, "sliderThree");
            //DataBaseLibraryAccess.UpdateCheck((int)Slider4.Value, "sliderFour");
            //DataBaseLibraryAccess.UpdateCheck((int)Slider5.Value, "sliderFive");

            // Composite setting

            if (First.IsChecked == true)
            {
                composite["firstChecked"] = true;
                composite["secondChecked"] = false;             
            }
            else
            {
                composite["firstChecked"] = false;
                composite["secondChecked"] = true;             
            }

            composite["sliderOne"] = (int)Slider1.Value;
            composite["sliderTwo"] = (int)Slider2.Value;
            composite["sliderThree"] = (int)Slider3.Value;
            composite["sliderFour"] = (int)Slider4.Value;
            composite["sliderFive"] = (int)Slider5.Value;

            localSettings.Values["AppData"] = composite;
        }
    }
}
