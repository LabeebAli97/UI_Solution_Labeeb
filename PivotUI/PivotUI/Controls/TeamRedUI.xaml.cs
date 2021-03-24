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
using PivotUI.Model;
using System.Collections.ObjectModel;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace PivotUI.Controls
{
    public sealed partial class TeamRedUI : UserControl
    {
        ObservableCollection<TeamRedItems> redList = new ObservableCollection<TeamRedItems> { };


        public TeamRedUI()
        {
            this.InitializeComponent();
            RedList.ItemsSource = GetData();

        }

        private ObservableCollection<TeamRedItems> GetData()
        {
            redList.Add(new TeamRedItems("User 1"));
            redList.Add(new TeamRedItems("User 2"));
            redList.Add(new TeamRedItems("User 3"));
            redList.Add(new TeamRedItems("User 4"));


            return redList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;

            RelativePanel relativePanel = this.Parent as RelativePanel;

            DaisyChainUI daisyChainUI = relativePanel.FindName("Chain") as DaisyChainUI;
            daisyChainUI.Visibility = Visibility.Visible;
        }
    }
}
