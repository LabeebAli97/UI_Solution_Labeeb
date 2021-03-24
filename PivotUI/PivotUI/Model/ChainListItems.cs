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

        public ChainListItems(string name,string connection)
        {
            Name = name;
            Connection = connection;
            
        }

    }
}
