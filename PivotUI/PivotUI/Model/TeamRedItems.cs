using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PivotUI.Model
{
    public class TeamRedItems
    {
        public string Name { get; set; }
        public string Status { get; set; }


        public TeamRedItems(string name,string status)
        {
            Name = name;
            Status = status;
        }

        //public class FlyoutItems
        //{
        //    public string ChainStatus { get; set; }


        //    public static ObservableCollection<FlyoutItems> FlyList()
        //    {
        //        ObservableCollection<FlyoutItems> flyout = new ObservableCollection<FlyoutItems>()
        //    {
        //        new FlyoutItems()
        //        {
        //           ChainStatus = "Mute User"
        //        },
        //        new FlyoutItems()
        //        {
        //            ChainStatus = "Block From Chain"

        //         },
        //        new FlyoutItems()
        //        {
        //             ChainStatus = "Make Host"

        //         }
        //     };

        //        return flyout;
        //    }
        //}
    }

    
}
