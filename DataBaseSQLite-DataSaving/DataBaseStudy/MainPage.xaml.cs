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
using DataBaseLibrary;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DataBaseStudy
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            UserView.ItemsSource = DataBaseLibraryAccess.GetData();
        }

        private void AddUser_Button_Click(object sender, RoutedEventArgs e)
        {
            DataBaseLibraryAccess.AddData(Email_Text.Text,Name_Text.Text,Convert.ToInt32(Age_Text.Text));
            UserView.ItemsSource = DataBaseLibraryAccess.GetData();
        }

        private void DeleteAll_Button_Click(object sender, RoutedEventArgs e)
        {
            DataBaseLibraryAccess.DeleteAll();
            UserView.ItemsSource = DataBaseLibraryAccess.GetData();
        }

        private void ViewAll_Button_Click(object sender, RoutedEventArgs e)
        {
            UserView.ItemsSource = DataBaseLibraryAccess.GetData();
        }

        private void DeleteName_Button_Click(object sender, RoutedEventArgs e)
        {
            DataBaseLibraryAccess.DeleteByName(Name_Text.Text);
            UserView.ItemsSource = DataBaseLibraryAccess.GetData();
        }

        private void DeleteEmail_Button_Click(object sender, RoutedEventArgs e)
        {
            DataBaseLibraryAccess.DeleteByEmail(Email_Text.Text);
            UserView.ItemsSource = DataBaseLibraryAccess.GetData();
        }

        private void NewTable_Button_Click(object sender, RoutedEventArgs e)
        {
            DataBaseLibraryAccess.InitializeDatabaseAgain(NewName_Text.Text);
            UserView.ItemsSource = DataBaseLibraryAccess.GetNewData(NewName_Text.Text);
        }

        private void UpdateName_Button_Click(object sender, RoutedEventArgs e)
        {
            DataBaseLibraryAccess.UpdateName(Name_Text.Text, NewName_Text.Text);
            UserView.ItemsSource = DataBaseLibraryAccess.GetData();
        }

        private void UpdateNameByEmail_Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void NewDatabase_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(NewPage));
        }
    }
}
