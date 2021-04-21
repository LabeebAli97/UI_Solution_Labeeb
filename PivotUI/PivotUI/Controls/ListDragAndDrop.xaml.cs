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
using Windows.UI.Xaml.Media.Imaging;
using Windows.ApplicationModel.DataTransfer;
using Windows.UI;
// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace PivotUI.Controls
{
    public sealed partial class ListDragAndDrop : UserControl
    {
        ObservableCollection<DragDropList> _reference;
        private ObservableCollection<DragDropList> dropCollection;
        private ObservableCollection<DragDropList> dragCollection;
        private object dragedItem;
        private ListView dragListView;
        private ListView dropListView;
        BitmapImage bitmapImageOne = new BitmapImage();
        BitmapImage bitmapImageTwo = new BitmapImage();


        public ListDragAndDrop()
        {
            this.InitializeComponent();

            _reference = GetSampleData();

            List1.ItemsSource = _reference;
        }

        private ObservableCollection<DragDropList> GetSampleData()
        {
            return new ObservableCollection<DragDropList>
            {
                new DragDropList(){Name="Alecs Iphone",Image="/Assets/Images/Profile.png",Check=true},
                new DragDropList(){Name="Wireless",Image="/Assets/Images/slowicon.png",Check=false},
                new DragDropList(){Name="3.5mm",Image="/Assets/StoreLogo.png",Check=false},
                new DragDropList(){Name="Element 4",Image="/Assets/Images/Profile.png",Check=false}
            };
        }

        private void List1_DragItemsStarting(object sender, DragItemsStartingEventArgs e)
        {

            var listView = sender as ListView;
            if (listView != null)
            {
                dragListView = listView;
                dragCollection = listView.ItemsSource as ObservableCollection<DragDropList>;

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
                dropCollection = dropListView.ItemsSource as ObservableCollection<DragDropList>;
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
                        if (!(RadTwo.Text == (dragedItem as DragDropList).Name))
                        {
                            RadOne.Text = (dragedItem as DragDropList).Name;
                            bitmapImageOne.UriSource = new Uri(this.BaseUri, (dragedItem as DragDropList).Image);
                            ImagOne.Source = bitmapImageOne;
                        }
                    }
                    else
                    {
                        if (!(RadOne.Text == (dragedItem as DragDropList).Name))
                        {
                            RadTwo.Text = (dragedItem as DragDropList).Name;
                            bitmapImageTwo.UriSource = new Uri(this.BaseUri, (dragedItem as DragDropList).Image);
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
                dropCollection = dropListView.ItemsSource as ObservableCollection<DragDropList>;
                if (dragedItem != null)
                {
                    try
                    {
                        _reference.Remove(dragedItem as DragDropList);
                        dropCollection.Insert(index, dragedItem as DragDropList);
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
                dropCollection = listView.ItemsSource as ObservableCollection<DragDropList>;

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

        private void List2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (List2.SelectedIndex == 0)
            {
                BtnOne.IsChecked = true;
                ActOne.Text = "Mix 1 - Active";
                ActTwo.Text = "Mix 2 - Inactive";
                ActOne.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 54, 0));
                ActTwo.Foreground = new SolidColorBrush(Colors.Gray);

            }
            else
            {
                BtnTwo.IsChecked = true;
                ActOne.Text = "Mix 1 - Inactive";
                ActTwo.Text = "Mix 2 - Active";
                ActTwo.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 54, 0));
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
