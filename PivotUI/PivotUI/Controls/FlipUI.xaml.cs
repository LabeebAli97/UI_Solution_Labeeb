using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using PivotUI.Controls;
using PivotUI.Views;
using PivotUI.Model;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace PivotUI.Controls
{
    public sealed partial class FlipUI : UserControl
    {

        public ObservableCollection<FlipItems> sampleList { get; set; }

        public FlipUI()
        {
            this.InitializeComponent();
            sampleList = new ObservableCollection<FlipItems>();
            sampleList.Add(new FlipItems() { Image = "/Assets/Images/A50.png", Name = "A50" });
            sampleList.Add(new FlipItems() { Image = "/Assets/Images/Astro_Carina 2.png", Name = "Carina2" });
            sampleList.Add(new FlipItems() { Image = "/Assets/Images/Image.png", Name = "Image" });
            sampleList.Add(new FlipItems() { Image = "/Assets/Images/Astro_Carina.png", Name = "Carina" });
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = Gallery.SelectedItem;
            Frame parentFrame = Window.Current.Content as Frame;

            switch ((selectedItem as FlipItems).Name)
            {
                case "A50":
                    parentFrame.Navigate(typeof(AstroMainPage));
                    return;
                case "Carina2":

                    return;
                case "Image":

                    return;
                case "Carina":

                    return;
            }
        }
    }
}
