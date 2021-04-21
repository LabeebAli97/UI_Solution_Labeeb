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

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace PivotUI.Controls
{
    public sealed partial class EqualizerUI : UserControl
    {
        public EqualizerUI()
        {
            this.InitializeComponent();
        }

        private void MySlider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {

            MyCurve1.Point1 = new Point(40, (200 - (e.NewValue * 1.77)));
            MyCurve1.Point2 = new Point(70, (200 - (e.NewValue * 1.77)));
            MyCurve1.Point3 = new Point(100, (200 - (e.NewValue * 1.77)));
            MyCurve2.Point1 = new Point(150, (200 - (e.NewValue * 1.77)));


        }

        private void MySlider2_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {

            MyCurve2.Point2 = new Point(150, (200 - (e.NewValue * 1.77)));
            MyCurve2.Point3 = new Point(200, (200 - (e.NewValue * 1.77)));
            MyCurve3.Point1 = new Point(250, (200 - (e.NewValue * 1.77)));

        }

        private void MySlider3_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {

            MyCurve3.Point2 = new Point(250, (200 - (e.NewValue * 1.77)));
            MyCurve3.Point3 = new Point(300, (200 - (e.NewValue * 1.77)));
            MyCurve4.Point1 = new Point(350, (200 - (e.NewValue * 1.77)));

        }

        private void MySlider4_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {

            MyCurve4.Point2 = new Point(350, (200 - (e.NewValue * 1.77)));
            MyCurve4.Point3 = new Point(400, (200 - (e.NewValue * 1.77)));
            MyCurve5.Point1 = new Point(450, (200 - (e.NewValue * 1.77)));

        }

        private void MySlider5_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {

            MyCurve5.Point3 = new Point(500, (200 - (e.NewValue * 1.77)));
            MyCurve6.Point1 = new Point(530, (200 - (e.NewValue * 1.77)));
            MyCurve6.Point2 = new Point(560, (200 - (e.NewValue * 1.77)));
            MyCurve5.Point2 = new Point(450, (200 - (e.NewValue * 1.77)));

        }

        //private void Edit_Click(object sender, RoutedEventArgs e)
        //{
        //    MySlider.IsHitTestVisible = true;
        //    MySlider2.IsHitTestVisible = true;
        //    MySlider3.IsHitTestVisible = true;
        //    MySlider4.IsHitTestVisible = true;
        //    MySlider5.IsHitTestVisible = true;
        //}

        //private void Save_Click(object sender, RoutedEventArgs e)
        //{
        //    MySlider.IsHitTestVisible = false;
        //    MySlider2.IsHitTestVisible = false;
        //    MySlider3.IsHitTestVisible = false;
        //    MySlider4.IsHitTestVisible = false;
        //    MySlider5.IsHitTestVisible = false;

        //}
    }
}
