using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Globalization;
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
    public sealed partial class LanguageSelectPage : Page
    {
        public LanguageSelectPage()
        {
            this.InitializeComponent();
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(IntroPage));
        }

        private void English_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)English.IsChecked)
            {
                ApplicationLanguages.PrimaryLanguageOverride = "en-US";
                
            }
            else if ((bool)Chinese.IsChecked)
            {
                ApplicationLanguages.PrimaryLanguageOverride = "zh-CN";
            }
            else if ((bool)Arabic.IsChecked)
            {
                ApplicationLanguages.PrimaryLanguageOverride = "ar-SA";
            }

            //Windows.ApplicationModel.Resources.Core.ResourceContext.GetForCurrentView().Reset();
            //Windows.ApplicationModel.Resources.Core.ResourceContext.GetForViewIndependentUse().Reset();
            //if (Frame != null)
            //{
            //    //Frame.CacheSize = 0;

            //    Frame.Navigate(this.GetType());
            //}
        }
    }
}
