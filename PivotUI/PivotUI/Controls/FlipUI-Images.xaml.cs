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
using PivotUI.Controls;
using PivotUI.Views;
using PivotUI.Model;
using System.Collections.ObjectModel;
using Windows.UI.ViewManagement;
using Windows.Graphics.Display;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace PivotUI.Controls
{
    public sealed partial class FlipUI_Images : UserControl
    {
        public ObservableCollection<FlipItems> sampleList { get; set; }

        public FlipUI_Images()
        {
            this.InitializeComponent();
            sampleList = new ObservableCollection<FlipItems>();
            sampleList.Add(new FlipItems() { Image = "/Assets/Images/A50.png", Name = "A50" });
            sampleList.Add(new FlipItems() { Image = "/Assets/Images/Astro_Carina 2.png", Name = "Carina2" });
            sampleList.Add(new FlipItems() { Image = "/Assets/Images/Image.png", Name = "Image" });
            sampleList.Add(new FlipItems() { Image = "/Assets/Images/Astro_Carina.png", Name = "Carina" });

            Size ScreenSize = this.GetScreenResolution();
            double ScreenHeight = this.GetScreenHeight(ScreenSize);
            Load(ScreenHeight);           
        }


        private void Load(double ScreenHeight)
        {
            if (ScreenHeight < 768)
            {
                Imag.Height = 400;               
                WideScreen.Setters.Add(new Setter
                {
                    Target = new TargetPropertyPath
                    {
                        Path = new PropertyPath("(Image.Width)"),
                        Target = Imag
                    },
                    Value = 450
                });

                WidestScreen.Setters.Add(new Setter
                {
                    Target = new TargetPropertyPath
                    {
                        Path = new PropertyPath("(Image.Width)"),
                        Target = Imag
                    },
                    Value = 700
                });

                NarrowScreen.Setters.Add(new Setter
                {
                    Target = new TargetPropertyPath
                    {
                        Path = new PropertyPath("(Image.Width)"),
                        Target = Imag
                    },
                    Value = 300
                });
            }
            else if (ScreenHeight > 768)
            {
                Imag.Height = 600;
                WideScreen.Setters.Add(new Setter
                {
                    Target = new TargetPropertyPath
                    {
                        Path = new PropertyPath("(Image.Width)"),
                        Target = Imag
                    },
                    Value = 700
                });

                WidestScreen.Setters.Add(new Setter
                {
                    Target = new TargetPropertyPath
                    {
                        Path = new PropertyPath("(Image.Width)"),
                        Target = Imag
                    },
                    Value = 1000
                });

                NarrowScreen.Setters.Add(new Setter
                {
                    Target = new TargetPropertyPath
                    {
                        Path = new PropertyPath("(Image.Width)"),
                        Target = Imag
                    },
                    Value = 500
                });
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
        //private void Button_Click(object sender, RoutedEventArgs e)
        //{

        //}
    }
}
