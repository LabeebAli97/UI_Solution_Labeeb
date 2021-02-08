using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelativePanelStudy.Model
{
    public class BikeDetails
    {

        public string Brand { get; set; }
        public int Price { get; set; }
        public string Model { get; set; }
        public string Image { get; set; }

        public static ObservableCollection<BikeDetails> BikeList()
        {
            ObservableCollection<BikeDetails> Bikes = new ObservableCollection<BikeDetails>()
            {
                new BikeDetails()
                {
                    Brand="Royal Enfield",
                    Price=200000,
                    Model="Classic 350",
                    Image="/Assets/Images/bike1.png"
                },
                new BikeDetails()
                {
                    Brand="Jawa",
                    Price=180000,
                    Model="Java 42",
                    Image="/Assets/Images/bike2.png"
                },
                new BikeDetails()
                {
                    Brand="Honda",
                    Price=215000,
                    Model="Hness CB350",
                    Image="/Assets/Images/bike3.png"
                },
                new BikeDetails()
                {
                    Brand="Jawa",
                    Price=230000,
                    Model="Java Perak",
                    Image="/Assets/Images/bike4.png"
                },
                new BikeDetails()
                {
                    Brand="Benelli",
                    Price=205000,
                    Model="Imperiale 400",
                    Image="/Assets/Images/bike5.png"
                }
            };

            return Bikes;
        }
    }
}
