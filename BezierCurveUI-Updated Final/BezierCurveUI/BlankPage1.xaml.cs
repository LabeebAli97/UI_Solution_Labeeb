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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace BezierCurveUI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage1 : Page
    {
        public BlankPage1()
        {
            this.InitializeComponent();
        }

        private void Previous_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }


      //  Attempt 1
      
        private void MySlider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {

                MyCurve1.Point1 = new Point(50, (250-(e.NewValue*2.27)) );
                MyCurve1.Point2 = new Point(100, (250 - (e.NewValue * 2.27)));
                MyCurve1.Point3 = new Point(150, (250 - (e.NewValue * 2.27)));
                MyCurve2.Point1 = new Point(225, (250 - (e.NewValue * 2.27)));
            

        }

        private void MySlider2_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {

                MyCurve2.Point2 = new Point(225, (250 - (e.NewValue * 2.27)));
                MyCurve2.Point3 = new Point(300, (250 - (e.NewValue * 2.27)));
                MyCurve3.Point1 = new Point(375, (250 - (e.NewValue * 2.27)));
   
         }
        
        private void MySlider3_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {

                MyCurve3.Point2 = new Point(375, (250 - (e.NewValue * 2.27)));
                MyCurve3.Point3 = new Point(450, (250 - (e.NewValue * 2.27)));
                MyCurve4.Point1 = new Point(525, (250 - (e.NewValue * 2.27)));
            
        }

        private void MySlider4_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
 
                MyCurve4.Point2 = new Point(525, (250 - (e.NewValue * 2.27)));
                MyCurve4.Point3 = new Point(600, (250 - (e.NewValue * 2.27)));
                MyCurve5.Point1 = new Point(675, (250 - (e.NewValue * 2.27)));
   
        }

        private void MySlider5_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
                    
                MyCurve5.Point3 = new Point(750, (250 - (e.NewValue * 2.27)));
                MyCurve6.Point1 = new Point(800, (250 - (e.NewValue * 2.27)));
                MyCurve6.Point2 = new Point(850, (250 - (e.NewValue * 2.27)));
                MyCurve5.Point2 = new Point(675, (250 - (e.NewValue * 2.27)));

        }
        
        //  Attempt 1


        //  Attempt 2
        /*
        private void MySlider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            if (e.NewValue == 0)
            {
                MyCurve1.Point1 = new Point(50, 250);
                MyCurve1.Point2 = new Point(100, 250);
                MyCurve1.Point3 = new Point(150, 250);
                MyCurve2.Point1 = new Point(200, 250);
            }
            else
            {
                MyCurve1.Point1 = new Point(50, (250 - (e.NewValue * 2.27)));
                MyCurve1.Point2 = new Point(100, (250 - (e.NewValue * 2.27)));
                MyCurve1.Point3 = new Point(150, (250 - (e.NewValue * 2.27)));
                MyCurve2.Point1 = new Point(200, (250 - (e.NewValue * 2.27)));
            }

        }

        private void MySlider2_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            if (e.NewValue == 0)
            {
                MyCurve2.Point2 = new Point(250, 250);
                MyCurve2.Point3 = new Point(300, 250);
                MyCurve3.Point1 = new Point(350, 250);

            }
            else
            {
                MyCurve2.Point2 = new Point(250, (250 - (e.NewValue * 2.27)));
                MyCurve2.Point3 = new Point(300, (250 - (e.NewValue * 2.27)));
                MyCurve3.Point1 = new Point(350, (250 - (e.NewValue * 2.27)));
            }
        }

        private void MySlider3_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            if (e.NewValue == 0)
            {
                MyCurve3.Point2 = new Point(400, 250);
                MyCurve3.Point3 = new Point(450, 250);
                MyCurve4.Point1 = new Point(500, 250);

            }
            else
            {
                MyCurve3.Point2 = new Point(400, (250 - (e.NewValue * 2.27)));
                MyCurve3.Point3 = new Point(450, (250 - (e.NewValue * 2.27)));
                MyCurve4.Point1 = new Point(500, (250 - (e.NewValue * 2.27)));
            }
        }

        private void MySlider4_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            if (e.NewValue == 0)
            {
                MyCurve4.Point2 = new Point(550, 250);
                MyCurve4.Point3 = new Point(600, 250);
                MyCurve5.Point1 = new Point(650, 250);

            }
            else
            {
                MyCurve4.Point2 = new Point(550, (250 - (e.NewValue * 2.27)));
                MyCurve4.Point3 = new Point(600, (250 - (e.NewValue * 2.27)));
                MyCurve5.Point1 = new Point(650, (250 - (e.NewValue * 2.27)));
            }
        }

        private void MySlider5_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            if (e.NewValue == 0)
            {
                MyCurve5.Point3 = new Point(750, 250);
                MyCurve6.Point1 = new Point(800, 250);
                MyCurve6.Point2 = new Point(850, 250);
                MyCurve5.Point2 = new Point(700, 250);
            }
            else
            {
                MyCurve5.Point3 = new Point(750, (250 - (e.NewValue * 2.27)));
                MyCurve6.Point1 = new Point(800, (250 - (e.NewValue * 2.27)));
                MyCurve6.Point2 = new Point(850, (250 - (e.NewValue * 2.27)));
                MyCurve5.Point2 = new Point(700, (250 - (e.NewValue * 2.27)));
            }
        }
        */
        //  Attempt 2
    }
}
