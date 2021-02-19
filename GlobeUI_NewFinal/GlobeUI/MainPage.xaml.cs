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

namespace GlobeUI
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

        private void Grid_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            var grid = sender as Grid;
            var angle = GetAngle(e.Position, grid.RenderSize);
            (this.DataContext as ViewModel).Angle = angle;
        }

        public enum Quadrants : int { nw = 2, ne = 1, sw = 4, se = 3 }

        private double GetAngle(Point touchPoint, Size circleSize)
        {
            var _X = touchPoint.X - (circleSize.Width / 2d);
            var _Y = circleSize.Height - touchPoint.Y - (circleSize.Height / 2d);
            var _Hypot = Math.Sqrt(_X * _X + _Y * _Y);
            var _Value = Math.Asin(_Y / _Hypot) * 180 / Math.PI;
            var _Quadrant = (_X >= 0) ?
                (_Y >= 0) ? Quadrants.ne : Quadrants.se :
                (_Y >= 0) ? Quadrants.nw : Quadrants.sw;
            switch (_Quadrant)
            {
                case Quadrants.ne: _Value = 90 - _Value; break;
                case Quadrants.nw: _Value = 270 + _Value; break;
                case Quadrants.se: _Value = 90 - _Value; break;
                case Quadrants.sw: _Value = 270 + _Value; break;
            }
            return _Value;
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(NewPage));
        }

      
    }

    public class ViewModel : System.ComponentModel.INotifyPropertyChanged
    {

        public ViewModel()
        {
            SetProperty(ref m_Value1, 100);
           

            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            {
                Angle = 0;               
            }
        }

        double m_Angle = default(double);
        public double Angle
        {
            get { return m_Angle; }
            set
            {

                if (value < 223)
                {
                    SetProperty(ref m_Angle, value);
                    if (value >= 220)
                    {
                        Value = 100;
                    }
                    else if(value < 220)
                    {
                        Value = (int)(value / 2.2);

                        
                    }
                }    
            }
        }

        int m_Value = default(int);
        public int Value
        { 
            get { return m_Value; } 
            set 
            { 
                SetProperty(ref m_Value, value);
                //  Angle = (double)(value * 2.8);
                Value1 = (int)(100 - value);
               

            }
        }
        int m_Value1 = default(int);
        public int Value1
        {
            get { return m_Value1; }
            set
            {
                SetProperty(ref m_Value1, value);
            }
        }

        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected void SetProperty<T>(ref T storage, T value, [System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            if (!object.Equals(storage, value))
            {
                storage = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));

            }
        }
        protected void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }
}
