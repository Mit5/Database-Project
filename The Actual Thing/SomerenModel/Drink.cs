using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Drink
    {
        public int DrinkNumber { get; set; }
        public string DrinkName { get; set; }
        public double Price { get; set; }
        public double SellingPrice { get; set; }
        public bool DrinkType { get; set; } //can be either 1 - alcoholic, or 0 - non-alcoholic
        public int StockAmount { get; set; }
        public int TimesOrdered { get; set; }
    }
}
