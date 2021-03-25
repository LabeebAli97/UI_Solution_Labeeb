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
using PivotUI.Views;
using Windows.UI;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace PivotUI.Controls
{
    public sealed partial class DaisyChainUI : UserControl
    {

        ObservableCollection<ChainListItems> chainList = new ObservableCollection<ChainListItems> { };
        

        public DaisyChainUI()
        {
            this.InitializeComponent();
            ChainList.ItemsSource = GetData();
            ChainList.SelectedItem = chainList[0];
        }

        private ObservableCollection<ChainListItems> GetData()
        {
            chainList.Add(new ChainListItems("Team Red", "Connected", "#FF3600","1"));
            chainList.Add(new ChainListItems("Team Blue", "Not Connected", "Gray","0"));
            chainList.Add(new ChainListItems("Chain 3", "Locked", "Gray","0"));
            chainList.Add(new ChainListItems("Chain 4", "Blocked", "Gray","0"));


            return chainList;
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            if (!ChainCreatePopup.IsOpen) { ChainCreatePopup.IsOpen = true; }
        }

        private void ClosePopupClicked(object sender, RoutedEventArgs e)
        {

            // if the Popup is open, then close it 
            if (ChainCreatePopup.IsOpen) { ChainCreatePopup.IsOpen = false; }
        }


        private void chainAdd_Click(object sender, RoutedEventArgs e)
        {
            chainList.Insert(0, new ChainListItems(createText.Text, "Connected", "#FF3600","1"));

            ChainList.ItemsSource = chainList;

            ChainList.SelectedItem = chainList[0];

            if (ChainCreatePopup.IsOpen) { ChainCreatePopup.IsOpen = false; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var itemSelected = ((Windows.UI.Xaml.FrameworkElement)e.OriginalSource).DataContext;

            if ((itemSelected as ChainListItems).Name == "Team Red")
            {
                this.Visibility = Visibility.Collapsed;
                RelativePanel relativePanel = this.Parent as RelativePanel;
                TeamRedUI teamRedUI = relativePanel.FindName("TeamRed") as TeamRedUI;
                teamRedUI.Visibility = Visibility.Visible;
            }


        }

        private void ChainList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            ListView ListView = (ListView)sender as ListView;

            foreach (var item in ListView.Items)
            {
                var ListViewItem = (ListViewItem)ListView.ContainerFromItem(item) as ListViewItem;

                var select = ChainList.SelectedItem;

                

                if (ListViewItem != null)
                {
                    var itemGrid = (Grid)ListViewItem.ContentTemplateRoot as Grid;
                    var status = itemGrid.FindName("conn") as TextBlock;
                    var name = itemGrid.FindName("name") as TextBlock;
                    var selectedRect = itemGrid.FindName("selectedRect") as Border;

                    if (ListViewItem.IsSelected)
                    {
                        if (status.Text != "Locked" && status.Text != "Blocked")
                        {
                            status.Text = "Connected";
                            status.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 54, 0));
                            selectedRect.Opacity = 1;
                            (select as ChainListItems).Colour = "#FF3600";
                            (select as ChainListItems).RectOpacity = "1";

                        }
                    }
                    else if ((select as ChainListItems).Connection == "Locked" || (select as ChainListItems).Connection == "Blocked")
                    {
                        
                    }
                    else
                    {
                        if (status.Text != "Locked" && status.Text != "Blocked")
                        {
                            status.Text = "Not Connected";
                            status.Foreground = new SolidColorBrush(Colors.Gray);
                            selectedRect.Opacity = 0;

                            (item as ChainListItems).Colour = "Gray";
                            (item as ChainListItems).RectOpacity = "0";
                            

                        }
                    }


                }
                else
                {
                    if(item == select && (select as ChainListItems).Name!="Blocked" && (select as ChainListItems).Name != "Locked")
                    {
                        (select as ChainListItems).Connection = "Connected";
                        (select as ChainListItems).Colour = "#FF3600";
                        (select as ChainListItems).RectOpacity = "1";



                    }
                    else if((item as ChainListItems).Connection != "Blocked" && (item as ChainListItems).Connection != "Locked")
                    {
                        (item as ChainListItems).Connection = "Not Connected";
                        (item as ChainListItems).Colour = "Gray";
                        (item as ChainListItems).RectOpacity = "0";

                    }



                }
            }
        }

    }
}

