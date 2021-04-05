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
using Windows.UI;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace PivotUI.Controls
{
    public sealed partial class TeamRedUI : UserControl
    {
        ObservableCollection<TeamRedItems> redList = new ObservableCollection<TeamRedItems> { };
        //ObservableCollection<TeamRedItems.FlyoutItems> flyoutList;
        Object SelectedItemFromTheList;
        bool flag = true;

        public TeamRedUI()
        {
            this.InitializeComponent();
            RedList.ItemsSource = GetData();
 
            //flyoutList = TeamRedItems.FlyoutItems.FlyList();
            //this.DataContext = flyoutList;

        }

        

        private ObservableCollection<TeamRedItems> GetData()
        {
            redList.Add(new TeamRedItems("User 1 (You)", "Host-Team Red"));
            redList.Add(new TeamRedItems("User 2", "Team Red"));
            redList.Add(new TeamRedItems("User 3", "Team Red"));
            redList.Add(new TeamRedItems("User 4", "Team Red"));

            return redList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;

            RelativePanel relativePanel = this.Parent as RelativePanel;

            DaisyChainUI daisyChainUI = relativePanel.FindName("Chain") as DaisyChainUI;
            daisyChainUI.Visibility = Visibility.Visible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var itemSelected1 = ((Windows.UI.Xaml.FrameworkElement)e.OriginalSource).DataContext;
            SelectedItemFromTheList = itemSelected1;
        }

        private void FlyList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //ListView ListView = (ListView)sender as ListView;

            //foreach (var item in ListView.Items)
            //{
            //    var ListViewItem = (ListViewItem)ListView.ContainerFromItem(item) as ListViewItem;

            //}
        }

        private void MuteStatus_Checked(object sender, RoutedEventArgs e)
        {
            //ListView ListView = (ListView)sender as ListView;

            //foreach (var item in ListView.Items)
            //{
            //    var ListViewItem = (ListViewItem)ListView.ContainerFromItem(item) as ListViewItem;

            //    if (ListViewItem != null)
            //    {
            //        var itemGrid = (Grid)ListViewItem.ContentTemplateRoot as Grid;
            //        var name = itemGrid.FindName("UserName") as TextBlock;
            //        var status = itemGrid.FindName("UserStatus") as TextBlock;
            //        var btn = itemGrid.FindName("MuteStatus") as ToggleButton;

            //        if (ListViewItem.IsSelected)
            //        {

            //        }
            //    }
            //}
        }

        private void RedList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        //private void MuteStatus_Click(object sender, RoutedEventArgs e)
        //{
        //    ListView ListView = RedList as ListView;

        //    foreach (var item in ListView.Items)
        //    {
        //        var ListViewItem = (ListViewItem)ListView.ContainerFromItem(item) as ListViewItem;


        //        var itemGrid = (Grid)ListViewItem.ContentTemplateRoot as Grid;
        //        var name = itemGrid.FindName("UserName") as TextBlock;
        //        var status = itemGrid.FindName("UserStatus") as TextBlock;
        //        var muteStatus = itemGrid.FindName("MuteStatus") as MenuFlyoutItem;
        //        var chainStatus = itemGrid.FindName("ChainStatus") as MenuFlyoutItem;
        //        var hostStatus = itemGrid.FindName("HostStatus") as MenuFlyoutItem;



        //        if (item == SelectedItemFromTheList && muteStatus.Text == "Mute User" && chainStatus.Text == "Block From Chain")
        //        {
        //            status.Text = status.Text + " -Muted";
        //            status.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 54, 0));

        //            muteStatus.Text = "Unmute User";
        //        }
        //        else if (item == SelectedItemFromTheList && muteStatus.Text == "Unmute User" && chainStatus.Text == "Block From Chain")
        //        {
        //            status.Text = (SelectedItemFromTheList as TeamRedItems).Status;
        //            status.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 54, 0));

        //            muteStatus.Text = "Mute User";
        //        }
        //        else if (item == SelectedItemFromTheList && muteStatus.Text == "Unmute User" && chainStatus.Text == "Unblock From Chain")
        //        {
        //            status.Text = "Blocked";
        //            status.Foreground = new SolidColorBrush(Colors.Gray);

        //        }
        //        else if (item == SelectedItemFromTheList && muteStatus.Text == "Mute User" && chainStatus.Text == "Unblock From Chain")
        //        {
        //            status.Text = "Blocked";
        //            status.Foreground = new SolidColorBrush(Colors.Gray);


        //        }

        //    }
        //}

        //private void ChainStatus_Click(object sender, RoutedEventArgs e)
        //{
        //    ListView ListView = RedList as ListView;

        //    foreach (var item in ListView.Items)
        //    {
        //        var ListViewItem = (ListViewItem)ListView.ContainerFromItem(item) as ListViewItem;


        //        var itemGrid = (Grid)ListViewItem.ContentTemplateRoot as Grid;
        //        var name = itemGrid.FindName("UserName") as TextBlock;
        //        var status = itemGrid.FindName("UserStatus") as TextBlock;
        //        var muteStatus = itemGrid.FindName("MuteStatus") as MenuFlyoutItem;
        //        var chainStatus = itemGrid.FindName("ChainStatus") as MenuFlyoutItem;
        //        var hostStatus = itemGrid.FindName("HostStatus") as MenuFlyoutItem;



        //        if (item == SelectedItemFromTheList && chainStatus.Text == "Block From Chain")
        //        {
        //            status.Text = "Blocked";
        //            status.Foreground = new SolidColorBrush(Colors.Gray);

        //            chainStatus.Text = "Unblock From Chain";
        //        }
        //        else if (item == SelectedItemFromTheList && muteStatus.Text == "Unmute User" && chainStatus.Text == "Unblock From Chain")
        //        {
        //            status.Text = (SelectedItemFromTheList as TeamRedItems).Status + " -Muted";
        //            status.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 54, 0));

        //            chainStatus.Text = "Block From Chain";

        //        }
        //        else if (item == SelectedItemFromTheList && muteStatus.Text == "Mute User" && chainStatus.Text == "Unblock From Chain")
        //        {
        //            status.Text = (SelectedItemFromTheList as TeamRedItems).Status;
        //            status.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 54, 0));

        //            chainStatus.Text = "Block From Chain";

        //        }


        //    }
        //}

        //private void HostStatus_Click(object sender, RoutedEventArgs e)
        //{
        //    ListView ListView = RedList as ListView;

        //    foreach (var item in ListView.Items)
        //    {
        //        var ListViewItem = (ListViewItem)ListView.ContainerFromItem(item) as ListViewItem;


        //        var itemGrid = (Grid)ListViewItem.ContentTemplateRoot as Grid;
        //        var name = itemGrid.FindName("UserName") as TextBlock;
        //        var status = itemGrid.FindName("UserStatus") as TextBlock;
        //        var muteStatus = itemGrid.FindName("MuteStatus") as MenuFlyoutItem;
        //        var chainStatus = itemGrid.FindName("ChainStatus") as MenuFlyoutItem;
        //        var hostStatus = itemGrid.FindName("HostStatus") as MenuFlyoutItem;

        //        if (item == SelectedItemFromTheList && hostStatus.Text == "Make Host" && chainStatus.Text=="Unblock From Chain")
        //        {
        //            status.Text = "Blocked";
        //            status.Foreground = new SolidColorBrush(Colors.Gray);
        //        }
        //        else if (item == SelectedItemFromTheList && hostStatus.Text == "Remove Host" && chainStatus.Text == "Unblock From Chain")
        //        {
        //            status.Text = "Blocked";
        //            status.Foreground = new SolidColorBrush(Colors.Gray);
        //        }
        //        else if (item == SelectedItemFromTheList && hostStatus.Text == "Make Host" && chainStatus.Text == "Block From Chain" && muteStatus.Text=="Mute User")
        //        {
        //            status.Text = "Host-Team Red";
        //            status.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 54, 0));
        //            hostStatus.Text = "Remove Host";
        //        }
        //        else if (item == SelectedItemFromTheList && hostStatus.Text == "Make Host" && chainStatus.Text == "Block From Chain" && muteStatus.Text == "Unmute User")
        //        {
        //            status.Text = "Host-Team Red -Muted";
        //            status.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 54, 0));
        //            hostStatus.Text = "Remove Host";

        //        }
        //        else if (item == SelectedItemFromTheList && hostStatus.Text == "Remove Host" && chainStatus.Text == "Block From Chain" && muteStatus.Text == "Mute User")
        //        {
        //            status.Text = "Team Red";
        //            status.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 54, 0));
        //            hostStatus.Text = "Make Host";


        //        }
        //        else if (item == SelectedItemFromTheList && hostStatus.Text == "Remove Host" && chainStatus.Text == "Block From Chain" && muteStatus.Text == "Unmute User")
        //        {
        //            status.Text = "Team Red -Muted";
        //            status.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 54, 0));
        //            hostStatus.Text = "Make Host";

        //        }
        //    }
        //}


        private void MuteStatus_Click(object sender, RoutedEventArgs e)
        {
            ListView ListView = RedList as ListView;

            foreach (var item in ListView.Items)
            {
                var ListViewItem = (ListViewItem)ListView.ContainerFromItem(item) as ListViewItem;


                var itemGrid = (Grid)ListViewItem.ContentTemplateRoot as Grid;
                var name = itemGrid.FindName("UserName") as TextBlock;
                var status = itemGrid.FindName("UserStatus") as TextBlock;
                var muteStatus = itemGrid.FindName("MuteStatus") as MenuFlyoutItem;
                var chainStatus = itemGrid.FindName("ChainStatus") as MenuFlyoutItem;
                var hostStatus = itemGrid.FindName("HostStatus") as MenuFlyoutItem;


                if (item == SelectedItemFromTheList)
                {
                    if (muteStatus.Text == "Mute User" && chainStatus.Text == "Block From Chain" && hostStatus.Text == "Make Host")
                    {
                        status.Text = status.Text + " -Muted";
                        status.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 54, 0));
                        muteStatus.Text = "Unmute User";
                    }
                    else if (muteStatus.Text == "Unmute User" && chainStatus.Text == "Block From Chain" && hostStatus.Text == "Make Host")
                    {
                        status.Text = (SelectedItemFromTheList as TeamRedItems).Status;
                        status.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 54, 0));
                        muteStatus.Text = "Mute User";
                    }
                    else if (muteStatus.Text == "Mute User" && chainStatus.Text == "Unblock From Chain" && hostStatus.Text == "Make Host")
                    {
                        status.Text = "Blocked";
                        status.Foreground = new SolidColorBrush(Colors.Gray);
                    }
                    else if (muteStatus.Text == "Unmute User" && chainStatus.Text == "Unblock From Chain" && hostStatus.Text == "Make Host")
                    {
                        status.Text = "Blocked";
                        status.Foreground = new SolidColorBrush(Colors.Gray);
                    }
                    else if (muteStatus.Text == "Mute User" && chainStatus.Text == "Block From Chain" && hostStatus.Text == "Remove Host")
                    {
                        status.Text = status.Text + " -Muted";
                        status.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 54, 0));
                        muteStatus.Text = "Unmute User";
                    }
                    else if (muteStatus.Text == "Unmute User" && chainStatus.Text == "Block From Chain" && hostStatus.Text == "Remove Host")
                    {
                        status.Text = (SelectedItemFromTheList as TeamRedItems).Status;
                        status.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 54, 0));
                        muteStatus.Text = "Mute User";
                    }
                    else if (muteStatus.Text == "Mute User" && chainStatus.Text == "Unblock From Chain" && hostStatus.Text == "Remove Host")
                    {
                        status.Text = "Blocked";
                        status.Foreground = new SolidColorBrush(Colors.Gray);
                    }
                    else if (muteStatus.Text == "Unmute User" && chainStatus.Text == "Unblock From Chain" && hostStatus.Text == "Remove Host")
                    {
                        status.Text = "Blocked";
                        status.Foreground = new SolidColorBrush(Colors.Gray);
                    }
                }
            }
        }

        private void ChainStatus_Click(object sender, RoutedEventArgs e)
        {
            ListView ListView = RedList as ListView;

            foreach (var item in ListView.Items)
            {
                var ListViewItem = (ListViewItem)ListView.ContainerFromItem(item) as ListViewItem;


                var itemGrid = (Grid)ListViewItem.ContentTemplateRoot as Grid;
                var name = itemGrid.FindName("UserName") as TextBlock;
                var status = itemGrid.FindName("UserStatus") as TextBlock;
                var muteStatus = itemGrid.FindName("MuteStatus") as MenuFlyoutItem;
                var chainStatus = itemGrid.FindName("ChainStatus") as MenuFlyoutItem;
                var hostStatus = itemGrid.FindName("HostStatus") as MenuFlyoutItem;


                if (item == SelectedItemFromTheList)
                {
                    if (muteStatus.Text == "Mute User" && chainStatus.Text == "Block From Chain" && hostStatus.Text == "Make Host")
                    {
                        status.Text = "Blocked";
                        status.Foreground = new SolidColorBrush(Colors.Gray);
                        chainStatus.Text = "Unblock From Chain";
                    }
                    else if (muteStatus.Text == "Unmute User" && chainStatus.Text == "Block From Chain" && hostStatus.Text == "Make Host")
                    {
                        status.Text = "Blocked";
                        status.Foreground = new SolidColorBrush(Colors.Gray);
                        chainStatus.Text = "Unblock From Chain";
                    }
                    else if (muteStatus.Text == "Mute User" && chainStatus.Text == "Unblock From Chain" && hostStatus.Text == "Make Host")
                    {
                        status.Text = (SelectedItemFromTheList as TeamRedItems).Status;
                        status.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 54, 0));
                        chainStatus.Text = "Block From Chain";
                    }
                    else if (muteStatus.Text == "Unmute User" && chainStatus.Text == "Unblock From Chain" && hostStatus.Text == "Make Host")
                    {
                        status.Text = (SelectedItemFromTheList as TeamRedItems).Status + " -Muted";
                        status.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 54, 0));
                        chainStatus.Text = "Block From Chain";
                    }
                    else if (muteStatus.Text == "Mute User" && chainStatus.Text == "Block From Chain" && hostStatus.Text == "Remove Host")
                    {
                       
                    }
                    else if (muteStatus.Text == "Unmute User" && chainStatus.Text == "Block From Chain" && hostStatus.Text == "Remove Host")
                    {
                        
                    }
                    else if (muteStatus.Text == "Mute User" && chainStatus.Text == "Unblock From Chain" && hostStatus.Text == "Remove Host")
                    {
                        status.Text = (SelectedItemFromTheList as TeamRedItems).Status;
                        status.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 54, 0));
                        chainStatus.Text = "Block From Chain";
                    }
                    else if (muteStatus.Text == "Unmute User" && chainStatus.Text == "Unblock From Chain" && hostStatus.Text == "Remove Host")
                    {
                        status.Text = (SelectedItemFromTheList as TeamRedItems).Status + " -Muted";
                        status.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 54, 0));
                        chainStatus.Text = "Block From Chain";
                    }
                }
            }
        }

        private void HostStatus_Click(object sender, RoutedEventArgs e)
        {
            ListView ListView = RedList as ListView;

            foreach (var item in ListView.Items)
            {
                var ListViewItem = (ListViewItem)ListView.ContainerFromItem(item) as ListViewItem;


                var itemGrid = (Grid)ListViewItem.ContentTemplateRoot as Grid;
                var name = itemGrid.FindName("UserName") as TextBlock;
                var status = itemGrid.FindName("UserStatus") as TextBlock;
                var muteStatus = itemGrid.FindName("MuteStatus") as MenuFlyoutItem;
                var chainStatus = itemGrid.FindName("ChainStatus") as MenuFlyoutItem;
                var hostStatus = itemGrid.FindName("HostStatus") as MenuFlyoutItem;

                if (item == SelectedItemFromTheList && chainStatus.Text == "Unblock From Chain")
                {
                    flag = false;
                }
            }

            foreach (var item in ListView.Items)
            {
                var ListViewItem = (ListViewItem)ListView.ContainerFromItem(item) as ListViewItem;


                var itemGrid = (Grid)ListViewItem.ContentTemplateRoot as Grid;
                var name = itemGrid.FindName("UserName") as TextBlock;
                var status = itemGrid.FindName("UserStatus") as TextBlock;
                var muteStatus = itemGrid.FindName("MuteStatus") as MenuFlyoutItem;
                var chainStatus = itemGrid.FindName("ChainStatus") as MenuFlyoutItem;
                var hostStatus = itemGrid.FindName("HostStatus") as MenuFlyoutItem;

                if (chainStatus.Text == "Block From Chain")
                {

                    if (item == SelectedItemFromTheList)
                    {

                        if (muteStatus.Text == "Mute User" && chainStatus.Text == "Block From Chain" && hostStatus.Text == "Make Host")
                        {
                            (SelectedItemFromTheList as TeamRedItems).Status = "Host-Team Red";
                            status.Text = (SelectedItemFromTheList as TeamRedItems).Status;
                            status.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 54, 0));
                            hostStatus.Text = "Remove Host";
                        }
                        else if (muteStatus.Text == "Unmute User" && chainStatus.Text == "Block From Chain" && hostStatus.Text == "Make Host")
                        {
                            (SelectedItemFromTheList as TeamRedItems).Status = "Host-Team Red";
                            status.Text = (SelectedItemFromTheList as TeamRedItems).Status + " -Muted";
                            status.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 54, 0));
                            hostStatus.Text = "Remove Host";
                        }
                        else if (muteStatus.Text == "Mute User" && chainStatus.Text == "Unblock From Chain" && hostStatus.Text == "Make Host")
                        {
                            status.Text = "Blocked";
                            status.Foreground = new SolidColorBrush(Colors.Gray);

                        }
                        else if (muteStatus.Text == "Unmute User" && chainStatus.Text == "Unblock From Chain" && hostStatus.Text == "Make Host")
                        {
                            status.Text = "Blocked";
                            status.Foreground = new SolidColorBrush(Colors.Gray);
                        }
                        else if (muteStatus.Text == "Mute User" && chainStatus.Text == "Block From Chain" && hostStatus.Text == "Remove Host")
                        {
                            (SelectedItemFromTheList as TeamRedItems).Status = "Team Red";
                            status.Text = (SelectedItemFromTheList as TeamRedItems).Status;
                            status.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 54, 0));
                            hostStatus.Text = "Make Host";
                        }
                        else if (muteStatus.Text == "Unmute User" && chainStatus.Text == "Block From Chain" && hostStatus.Text == "Remove Host")
                        {
                            (SelectedItemFromTheList as TeamRedItems).Status = "Team Red";
                            status.Text = (SelectedItemFromTheList as TeamRedItems).Status + " -Muted";
                            status.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 54, 0));
                            hostStatus.Text = "Make Host";
                        }
                        else if (muteStatus.Text == "Mute User" && chainStatus.Text == "Unblock From Chain" && hostStatus.Text == "Remove Host")
                        {
                            status.Text = "Blocked";
                            status.Foreground = new SolidColorBrush(Colors.Gray);
                        }
                        else if (muteStatus.Text == "Unmute User" && chainStatus.Text == "Unblock From Chain" && hostStatus.Text == "Remove Host")
                        {
                            status.Text = "Blocked";
                            status.Foreground = new SolidColorBrush(Colors.Gray);
                        }
                    }
                    else
                    {
                        if (flag)
                        {


                            //(item as TeamRedItems).Status = "Team Red";
                            //status.Text = (item as TeamRedItems).Status;
                            hostStatus.Text = "Make Host";

                            if (muteStatus.Text == "Mute User" && chainStatus.Text == "Block From Chain" && hostStatus.Text == "Make Host")
                            {
                                (SelectedItemFromTheList as TeamRedItems).Status = "Team Red";
                                status.Text = (SelectedItemFromTheList as TeamRedItems).Status;
                                status.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 54, 0));

                            }
                            else if (muteStatus.Text == "Unmute User" && chainStatus.Text == "Block From Chain" && hostStatus.Text == "Make Host")
                            {
                                (SelectedItemFromTheList as TeamRedItems).Status = "Team Red";
                                status.Text = (SelectedItemFromTheList as TeamRedItems).Status + " -Muted";
                                status.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 54, 0));
                            }
                            else if (muteStatus.Text == "Mute User" && chainStatus.Text == "Unblock From Chain" && hostStatus.Text == "Make Host")
                            {
                                status.Text = "Blocked";
                                status.Foreground = new SolidColorBrush(Colors.Gray);

                            }
                            else if (muteStatus.Text == "Unmute User" && chainStatus.Text == "Unblock From Chain" && hostStatus.Text == "Make Host")
                            {
                                status.Text = "Blocked";
                                status.Foreground = new SolidColorBrush(Colors.Gray);
                            }
                        }
                    }

                }


            }
            flag = true;
        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;

            RelativePanel relativePanel = this.Parent as RelativePanel;

            DaisyChainUI daisyChainUI = relativePanel.FindName("Chain") as DaisyChainUI;
            daisyChainUI.Visibility = Visibility.Visible;
        }
    }
}
