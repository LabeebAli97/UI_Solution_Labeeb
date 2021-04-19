using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Data.Pdf;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Media.Imaging;

namespace PivotUI.Converter
{
    public class PdfToImage
    {
        

        public async Task<BitmapImage> LoadImages(string s)
        {
            StorageFile f = await
                StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:////Assets/PDFImages/"+s));
            PdfDocument doc = await PdfDocument.LoadFromFileAsync(f);

            BitmapImage image = new BitmapImage();

            var page = doc.GetPage(0);

            var trimBackground = new PdfPageRenderOptions();
            trimBackground.BackgroundColor = Windows.UI.Colors.Transparent;

            using (InMemoryRandomAccessStream stream = new InMemoryRandomAccessStream())
            {
                await page.RenderToStreamAsync(stream, trimBackground);
                await image.SetSourceAsync(stream);
            }

            return image;
        }
    }
}
