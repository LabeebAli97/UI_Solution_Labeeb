using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Globalization;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using PivotUI.Controls;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace PivotUI.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AstroMainPage : Page
    {
        public AstroMainPage()
        {
            this.InitializeComponent();

            languageSetup();

        }

        private void languageSetup()
        {
            if (ApplicationLanguages.PrimaryLanguageOverride == "ar-SA")
            {
                var returnBtn = TeamRed.FindName("btnReturn") as Button;
                returnBtn.Content = "\xE76C";


                var listPanel = Chain.FindName("listPanel") as RelativePanel;
                var list = listPanel.FindName("ChainList") as ListView;
                var item = list.ItemTemplate;
                
                //var itemGrid = item.FindName("ItemGrid") as Grid;
                //var btn = itemGrid.FindName("listBtn") as Button;
                //btn.Content = "\xE76B";

            }
        }

        private void tourBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(TourPage));
        }
    }
}
