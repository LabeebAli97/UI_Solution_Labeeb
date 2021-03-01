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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BezierCurveUI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            
            this.Frame.Navigate(typeof(BlankPage1));
           

        }

        private void MySlider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            MyCurve.Point2 = new Point(300, -1 * (Convert.ToDouble(e.NewValue)));
           /* Curve2.StartPoint = new Point(0, -1 * (Convert.ToDouble(e.NewValue)));
            MyCurve2.Point2 = new Point(300, -1 * (Convert.ToDouble(MySlider2.Value)));*/

        }

        private void MySlider2_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            MyCurve.Point2 = new Point(300, -1 * (Convert.ToDouble(MySlider.Value)));
          /*  Curve2.StartPoint = new Point(0, -1 * (Convert.ToDouble(MySlider.Value)));
            MyCurve2.Point2 = new Point(300, -1 * (Convert.ToDouble(e.NewValue)));*/
        }

        private void MySlider1_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            MyCurve.Point1 = new Point(150, -1 * (Convert.ToDouble(MySlider1.Value)));
        }
    }
}
