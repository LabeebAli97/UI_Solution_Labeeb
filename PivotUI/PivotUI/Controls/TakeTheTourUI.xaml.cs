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

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace PivotUI.Controls
{
    public sealed partial class TakeTheTourUI : UserControl
    {
        public ObservableCollection<TakeTheTourItems> sampleList { get; set; }


        public TakeTheTourUI()
        {
            this.InitializeComponent();

            sampleList = new ObservableCollection<TakeTheTourItems>();
            sampleList.Add(new TakeTheTourItems()
            {
                Image = "/Assets/Images/Astro_Carina 2.png",
                TextHeading = "WELCOME",
                TextContent = "Welcome to the Astro Mobile Command Center App. Here you will be able to customize and control your Astro Mixamp experience"
            });
            sampleList.Add(new TakeTheTourItems()
            {
                Image = "/Assets/Images/Ellipse.png",
                TextHeading = "SOURCE SELECTION",
                TextContent = "Your Astro Mixamp has the ability to connect to three sources at one time. You can connect to a device using the 3.5mm jack, a USB-C cable, and using Bluetooth"
            });
            sampleList.Add(new TakeTheTourItems()
            {
                Image = "/Assets/Images/Square Grid.png",
                TextHeading = "MIXING SOURCES",
                TextContent = "Once you have selected your sources use the Mixing section to balance between them. Adding volume to one source will decrease the volume of the other source"
            });
            sampleList.Add(new TakeTheTourItems()
            {
                Image = "/Assets/Images/Frame.png",
                TextHeading = "MICROPHONES",
                TextContent = "Welcome to the Astro Mobile Command Center App. Here you will be able to customize and control your Astro Mixamp experience"
            });
            sampleList.Add(new TakeTheTourItems()
            {
                Image = "/Assets/Images/Frame (1).png",
                TextHeading = "EQ PROFILES",
                TextContent = "Welcome to the Astro Mobile Command Center App. Here you will be able to customize and control your Astro Mixamp experience"
            });
            sampleList.Add(new TakeTheTourItems()
            {
                Image = "/Assets/Images/Frame (2).png",
                TextHeading = "PHANTOM POWER",
                TextContent = "Welcome to the Astro Mobile Command Center App. Here you will be able to customize and control your Astro Mixamp experience"
            });
            sampleList.Add(new TakeTheTourItems()
            {
                Image = "/Assets/Images/Square Grid (1).png",
                TextHeading = "MODULES",
                TextContent = "Welcome to the Astro Mobile Command Center App. Here you will be able to customize and control your Astro Mixamp experience"
            });
        }
         private void Next_Click(object sender, RoutedEventArgs e)
        {


            if (GalleryIndicator.SelectedIndex < sampleList.Count-1)
            {
               
                GalleryIndicator.SelectedIndex = GalleryIndicator.SelectedIndex + 1;
                btn.Content = "NEXT";
            }                   
            else
            {
                Frame parentFrame = Window.Current.Content as Frame;
                parentFrame.Navigate(typeof(AstroMainPage));

            }
            if (GalleryIndicator.SelectedIndex == sampleList.Count-1)
            {
                btn.Content = "COMPLETE";
            }



        }

        private void GalleryIndicator_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (GalleryIndicator.SelectedIndex < sampleList.Count-1)
            {
                btn.Content = "NEXT";
            }

            if (GalleryIndicator.SelectedIndex == sampleList.Count-1)
            {
                btn.Content = "COMPLETE";
            }
        }

        private void btnSkip_Click(object sender, RoutedEventArgs e)
        {
            Frame parentFrame = Window.Current.Content as Frame;
            parentFrame.Navigate(typeof(AstroMainPage));
        }
    }
}
