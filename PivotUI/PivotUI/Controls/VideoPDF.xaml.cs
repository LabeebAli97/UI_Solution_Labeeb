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
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using PivotUI.Converter;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace PivotUI.Controls
{
    public sealed partial class VideoPDF : UserControl
    {
        public VideoPDF()
        {
            this.InitializeComponent();

            //var a =pdfToImage.LoadImages();
            Load();
            
            ////System.Threading.Tasks.Task<BitmapImage> task = PdfToImage.LoadImages();
            //ImageAero.Source = a;
        }

        private async void Load()
        {
            PdfToImage pdfToImage = new PdfToImage();
            ImageAero.Source = await pdfToImage.LoadImages("image 3.pdf");
        }

        //public async void LoadImages()
        //{
        //    StorageFile f = await
        //        StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:////Assets/PDFImages/image 3.pdf"));
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

        //    ImageAero.Source = image;
        //}
    }
}
