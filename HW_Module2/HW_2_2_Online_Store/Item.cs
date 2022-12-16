using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_2_Online_Store
{
    public class Item
    {
        public string NameOfItem { get; set; }
        public double PriceOfItem { get; set; }
        public Item(string nameofitem, double priceofitem)
        {
            NameOfItem = nameofitem;
            PriceOfItem = priceofitem;
        }   
    }
}
