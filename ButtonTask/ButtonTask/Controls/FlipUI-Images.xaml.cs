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
using ButtonTask;
using System.Collections.ObjectModel;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace ButtonTask.Controls
{
    public sealed partial class FlipUI_Images : UserControl
    {
        public ObservableCollection<FlipItems> sampleList { get; set; }

        public FlipUI_Images()
        {
            this.InitializeComponent();
            sampleList = new ObservableCollection<FlipItems>();
            sampleList.Add(new FlipItems() { Image = "/Assets/Images/Astro_Carina 2.png" });
            sampleList.Add(new FlipItems() { Image = "/Assets/Images/Ellipse.png" });
            sampleList.Add(new FlipItems() { Image = "/Assets/Images/Square Grid.png" });
            sampleList.Add(new FlipItems() { Image = "/Assets/Images/Frame.png" });
            sampleList.Add(new FlipItems() { Image = "/Assets/Images/Frame (1).png" });
            sampleList.Add(new FlipItems() { Image = "/Assets/Images/Frame (2).png" });
            sampleList.Add(new FlipItems() { Image = "/Assets/Images/Square Grid (1).png" });
        }
    }
}
