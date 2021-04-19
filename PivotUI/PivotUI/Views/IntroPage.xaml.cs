using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace PivotUI.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class IntroPage : Page
    {
        public IntroPage()
        {
            this.InitializeComponent();
            Size ScreenSize = this.GetScreenResolution();
            double ScreenHeight = this.GetScreenHeight(ScreenSize);
            double ScreenWidth = this.GetScreenWidth(ScreenSize);
            Load(ScreenHeight);
            
        }

        private void Load(double ScreenHeight)
        {
            if (ScreenHeight < 768)
            {
                var Flipview = Flip.FindName("Gallery") as FlipView;
                var item = Flipview.FindName("Item") as DataTemplate;

                Flipview.MaxHeight = 400;
                
            }
        }

        private Size GetScreenResolution()
        {
            var bounds = ApplicationView.GetForCurrentView().VisibleBounds;
            var scaleFactor = DisplayInformation.GetForCurrentView().RawPixelsPerViewPixel;
            Size size = new Size(bounds.Width * scaleFactor, bounds.Height * scaleFactor);
            return size;
        }

        private double GetScreenHeight(Size size)
        {
            return size.Height;
        }

        private double GetScreenWidth(Size size)
        {
            return size.Width;
        }
    }
}
