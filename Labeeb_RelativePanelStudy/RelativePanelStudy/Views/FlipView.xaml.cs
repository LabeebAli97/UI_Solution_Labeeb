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
using RelativePanelStudy.Model;
using System.Collections.ObjectModel;



namespace RelativePanelStudy.Views
{
   
    public sealed partial class FlipView : Page
    {
        public ObservableCollection<SampleItem> sampleList { get; set; }

        public FlipView()
        {
            this.InitializeComponent();
            sampleList = new ObservableCollection<SampleItem>();
            sampleList.Add(new SampleItem() { Name = "Food", Image = "/Assets/Images/pic1.png" });
            sampleList.Add(new SampleItem() { Name = "Nature", Image = "/Assets/Images/pic2.png" });
            sampleList.Add(new SampleItem() { Name = "Buildings", Image = "/Assets/Images/pic3.png" });           
            
        }

        

        private void BackToRelativeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Main));
        }

        private void SplitViewBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SplitViewExample));
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            sampleList.Add(new SampleItem() { Name = "NewItem", Image = "/Assets/Images/image 3.png" });
            
        }
    }
}
