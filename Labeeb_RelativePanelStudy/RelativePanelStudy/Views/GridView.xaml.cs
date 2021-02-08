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
using RelativePanelStudy.Model;
using RelativePanelStudy.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace RelativePanelStudy.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GridView : Page
    {

        
        private ObservableCollection<BikeDetails> bikeItems_;
        

        public GridView()
        {
            this.InitializeComponent();
            bikeItems_ = BikeDetails.BikeList();
            this.DataContext = bikeItems_;
        }

        

        private void AddGrid_Click(object sender, RoutedEventArgs e)
        {

            bikeItems_.Add(new BikeDetails
            {
                Brand = "Royal Enfield",
                Price = 200000,
                Model = "Classic 350",
                Image = "/Assets/Images/bike1.png"
            });
        }

        private void GridItem_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            
            this.Frame.Navigate(typeof(Main));
        }
    }
}
