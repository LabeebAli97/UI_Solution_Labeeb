using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Data.Pdf;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace test
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

          
            Window.Current.SizeChanged += OnWindowSizeChanged;



            //OpenLocal();
            //var qualifierValues = Windows.ApplicationModel.Resources.Core.ResourceContext.GetForCurrentView().QualifierValues;
            //qualifierValues.MapChanged += new Windows.Foundation.Collections.MapChangedEventHandler<string, string>(QualifierValues_MapChanged);
        }

        void OnWindowSizeChanged(object sender, WindowSizeChangedEventArgs e)
        {
            //UpdateContent();
        }

        private void img_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            var sou = img.Source;
        }



        //private async void QualifierValues_MapChanged(IObservableMap<string, string> sender, IMapChangedEventArgs<string> @event)
        //{
        //    var dispatcher = this.img.Dispatcher;
        //    if (dispatcher.HasThreadAccess)
        //    {
        //        this.RefreshUIImages();
        //    }
        //    else
        //    {
        //        await dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () => this.RefreshUIImages());
        //    }
        //}

        //private void RefreshUIImages()
        //{
        //    var namedResource = Windows.ApplicationModel.Resources.Core.ResourceManager.Current.MainResourceMap[@"Files/Assets/Carina/Astro_Carina 2.png"];
        //    this.img.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(namedResource.Uri);
        //}


        //public async void OpenLocal()
        //{
        //    StorageFile f = await
        //        StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///Assets/Images/Astro_Carina 2.pdf"));
        //    PdfDocument doc = await PdfDocument.LoadFromFileAsync(f);

        //    BitmapImage image = new BitmapImage();

        //    var page = doc.GetPage(0);

        //    var trimBackground = new PdfPageRenderOptions();
        //    trimBackground.BackgroundColor = Windows.UI.Colors.Transparent;

        //    using (InMemoryRandomAccessStream stream = new InMemoryRandomAccessStream())
        //    {
        //        await page.RenderToStreamAsync(stream, trimBackground);
        //        await image.SetSourceAsync(stream);
        //    }

        //    img.Source = image;

        //}




    }
}



