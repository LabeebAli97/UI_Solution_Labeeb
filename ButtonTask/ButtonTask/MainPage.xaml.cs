using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ButtonTask
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        
        

        bool check1= true;
        bool check2 = false;
        bool check3 = false;
        bool check4 = true;
        bool check5 = false;
        bool check6 = false;
        BitmapImage bitmapImageOne = new BitmapImage();
        BitmapImage bitmapImageTwo = new BitmapImage();
        ObservableCollection<Info> _reference;
        //ObservableCollection<Info> _selection;


        private ObservableCollection<Info> dragCollection;
        private ObservableCollection<Info> dropCollection;
        private object dragedItem;
        private ListView dragListView;
        private ListView dropListView;

        public MainPage()
        {
            this.InitializeComponent();

            

            _reference = GetSampleData();
            //_selection = GetSelectionData();

            List1.ItemsSource = _reference;
            //List2.ItemsSource = _selection;

           
        }


        private ObservableCollection<Info> GetSampleData()
        {
            return new ObservableCollection<Info>
            {
                new Info(){name="Alecs Iphone",image="Assets/slowicon.png",check=true},
                new Info(){name="Wireless",image="Assets/Profile.png",check=false},
                new Info(){name="3.5mm",image="Assets/StoreLogo.png",check=false},
                new Info(){name="Element 4",image="Assets/Profile.png",check=false}
            };
        }

        private ObservableCollection<Info> GetSelectionData()
        {


            return new ObservableCollection<Info>
            {
                //new Info(){name="Element 1",image="Assets/slowicon.png",check=true},
                //new Info(){name="Element 2",image="Assets/Profile.png",check=false},
            };
        }


        private void List1_DragItemsStarting(object sender, DragItemsStartingEventArgs e)
        {

            var listView = sender as ListView;
            if (listView != null)
            {
                dragListView = listView;
                dragCollection = listView.ItemsSource as ObservableCollection<Info>;

                //if (dropListView == dragListView)
                //{
                //    return;
                //}
                if (e.Items.Count == 1)
                {
                    dragedItem = e.Items[0];
                    e.Data.RequestedOperation = DataPackageOperation.Copy;

                }
            }
        }

        private void List2_DragOver(object sender, DragEventArgs e)
        {
            e.DragUIOverride.IsCaptionVisible = false;
            e.DragUIOverride.IsGlyphVisible = false;
            e.AcceptedOperation = DataPackageOperation.Copy;
        }

        private void List2_Drop(object sender, DragEventArgs e)
        {

            var scrollViewer = VisualTreeHelper.GetChild(VisualTreeHelper.GetChild(List2, 0), 0) as ScrollViewer;
            var position = e.GetPosition((ListView)sender);
            var positionY = scrollViewer.VerticalOffset + position.Y;
            var index = GetItemIndex(positionY, List2);



            dropListView = sender as ListView;
            if (dropListView != null)
            {
                dropCollection = dropListView.ItemsSource as ObservableCollection<Info>;
                //if (dragedItem != null)
                //{
                    //if (!dropCollection.Contains(dragedItem))
                    //{
                        try
                        {
                            //if (_selection.Count >= 2)
                            //{
                            //    _selection.RemoveAt(index);
                            //}
                            //dropCollection.Insert(index, dragedItem as Info);

                            if (index == 0)
                            {
                                if(!(RadTwo.Text == (dragedItem as Info).name))
                                    {
                                        RadOne.Text = (dragedItem as Info).name;
                                        bitmapImageOne.UriSource = new Uri(this.BaseUri, (dragedItem as Info).image);
                                        ImagOne.Source = bitmapImageOne;                      
                                    }                             
                            }
                            else
                            {
                                if (!(RadOne.Text == (dragedItem as Info).name))
                                    {
                                       RadTwo.Text = (dragedItem as Info).name;
                                       bitmapImageTwo.UriSource = new Uri(this.BaseUri, (dragedItem as Info).image);
                                       ImagTwo.Source = bitmapImageTwo;
                                    }
                        
                            }

                        }
                        catch (Exception)
                        {
                            return;
                        }
                    //}
                    //If you need to delete the draged item in the source ListView, then use the following code
                    //dragCollection.Remove(dragedItem as Info);
                    //dragedItem = null;
                //}
            }

        }


        private void List1_Drop(object sender, DragEventArgs e)
        {

            var scrollViewer = VisualTreeHelper.GetChild(VisualTreeHelper.GetChild(List1, 0), 0) as ScrollViewer;
            var position = e.GetPosition((ListView)sender);
            var positionY = scrollViewer.VerticalOffset + position.Y;
            var index = GetItemIndex(positionY, List1);

            dropListView = sender as ListView;
            if (dropListView != null)
            {
                dropCollection = dropListView.ItemsSource as ObservableCollection<Info>;
                if (dragedItem != null)
                {              
                        try
                        {
                            _reference.Remove(dragedItem as Info);                            
                            dropCollection.Insert(index, dragedItem as Info);
                        }
                        catch (Exception)
                        {
                            return;
                        }                 
                    //If you need to delete the draged item in the source ListView, then use the following code
                    //dragCollection.Remove(dragedItem as Info);
                }
            }
        }

        private void List1_DragEnter(object sender, DragEventArgs e)
        {
            e.AcceptedOperation = (e.DataView.Contains(StandardDataFormats.Text) ? DataPackageOperation.Copy : DataPackageOperation.None);
        }

        private void List1_DropCompleted(UIElement sender, DropCompletedEventArgs args)
        {
            var listView = sender as ListView;
            if (listView != null)
            {
                dropListView = listView;
                dropCollection = listView.ItemsSource as ObservableCollection<Info>;

                if (dropListView == dragListView)
                {
                    return;
                }
            }
        }

        int GetItemIndex(double positionY, ListView targetListView)
        {
            var index = 0;
            double height = 0;

            foreach (var item in targetListView.Items)
            {
                height += GetRowHeight(item, targetListView);
                if (height > positionY) return index;
                index++;
            }

            return index;
        }

        double GetRowHeight(object listItem, ListView targetListView)
        {
            var listItemContainer = targetListView.ContainerFromItem(listItem) as ListViewItem;
            var height = listItemContainer.ActualHeight;
            var marginTop = listItemContainer.Margin.Top;
            return marginTop + height;
        }

        private void ToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            

            if (Tog.IsOn)
            {

                if (check1)
                {
                    One.IsChecked = true;
                }
                else if (check2)
                {
                    Two.IsChecked = true;
                }
                else if(check3)
                {
                    Three.IsChecked = true;
                }
            }
            else
            {
                if (check4)
                {
                    One.IsChecked = true;
                }
                else if (check5)
                {
                    Two.IsChecked = true;
                }
                else if(check6)
                {
                    Three.IsChecked = true;
                }
            }
        }

        //private void Two_Checked(object sender, RoutedEventArgs e)
        //{
        //    if (Tog.IsOn)
        //    {
        //        check1 = false;
        //        check2 = true;
        //        check3 = false;
        //    }
        //    else
        //    {
        //        check4 = false;
        //        check5 = true;
        //        check6 = false;
        //    }
        //}

        //private void One_Checked(object sender, RoutedEventArgs e)
        //{
        //    if (Tog.IsOn)
        //    {
        //        check1 = true;
        //        check2 = false;
        //        check3 = false;
        //    }
        //    else
        //    {
        //        check4 = true;
        //        check5 = false;
        //        check6 = false;
        //    }
        //}

        //private void Three_Checked(object sender, RoutedEventArgs e)
        //{
        //    if (Tog.IsOn)
        //    {
        //        check1 = false;
        //        check2 = false;
        //        check3 = true;
        //    }
        //    else
        //    {
        //        check4 = false;
        //        check5 = false;
        //        check6 = true;
        //    }
        //}


        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

            RadioButton rb = sender as RadioButton;

            if (rb != null)
            {
                string btnName = rb.Tag.ToString();                
                switch (btnName)
                {
                    case "One":

                   
                        (Application.Current.Resources["AppTheme"] as SolidColorBrush).Color = Color.FromArgb(255, 255, 54, 0);

                        if (Tog.IsOn)
                        {
                            check1 = true;
                            check2 = false;
                            check3 = false;
                        }
                        else
                        {
                            check4 = true;
                            check5 = false;
                            check6 = false;
                        }
                        break;
                    case "Two":
                        
                        (Application.Current.Resources["AppTheme"] as SolidColorBrush).Color = Colors.Green;

                        if (Tog.IsOn)
                        {
                            check1 = false;
                            check2 = true;
                            check3 = false;
                        }
                        else
                        {
                            check4 = false;
                            check5 = true;
                            check6 = false;
                        }
                        break;
                    case "Three":

                        (Application.Current.Resources["AppTheme"] as SolidColorBrush).Color = Colors.Yellow;


                        if (Tog.IsOn)
                        {
                            check1 = false;
                            check2 = false;
                            check3 = true;
                        }
                        else
                        {
                            check4 = false;
                            check5 = false;
                            check6 = true;
                        }
                        break;
                }
            }
        }

        private void uri_Click(object sender, RoutedEventArgs e)
        {

            //Windows.System.Launcher.LaunchUriAsync API

            Launch();

            async void Launch()
            {
                string uriToLaunch = @"http://www.google.com";
                Uri uri = new Uri(uriToLaunch);

                var success = await Windows.System.Launcher.LaunchUriAsync(uri);

                if (success)
                {
                    // URI launched
                }
                else
                {
                    // URI launch failed
                }
            }
        }

        private void List2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (List2.SelectedIndex == 0)
            {
                BtnOne.IsChecked = true;
                ActOne.Text = "Mix 1 - Active";
                ActTwo.Text = "Mix 2 - Inactive";
                ActOne.Foreground = (SolidColorBrush)Application.Current.Resources["AppTheme"];
                ActTwo.Foreground = new SolidColorBrush(Colors.Gray);

            }
            else
            {
                BtnTwo.IsChecked = true;   
                ActOne.Text = "Mix 1 - Inactive";
                ActTwo.Text = "Mix 2 - Active";
                ActTwo.Foreground = (SolidColorBrush)Application.Current.Resources["AppTheme"];
                ActOne.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void BtnOne_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb != null)
            {
                string btnName = rb.Name.ToString();
                switch (btnName)
                {
                    case "BtnOne":
                        List2.SelectedItem = Item1;

                        break;
                    case "BtnTwo":
                        List2.SelectedItem = Item2;
                        break;
                 }
            }
        }
    }


}
