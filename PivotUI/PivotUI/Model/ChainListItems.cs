using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PivotUI.Model
{
    public class ChainListItems
    {
        public string Name { get; set; }
        public string Connection { get; set; }
        public string Colour { get; set; }
        public string RectOpacity { get; set; }


        public ChainListItems(string name,string connection,string colour,string opacity)
        {
            Name = name;
            Connection = connection;
            Colour = colour;
            RectOpacity = opacity;

        }

    }
}
