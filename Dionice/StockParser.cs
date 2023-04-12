using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dionice
{
    public static class StockParser
    {
        public static Stock ParseStock(string item)
        {
            string[] razdijeli = item.Split(';');
            string name = razdijeli[0];

            razdijeli[1].Replace(",", ".");
            double currentPrice = double.Parse(razdijeli[1]);
            
            razdijeli[2].Replace(",",".");
            double previousPrice = double.Parse(razdijeli[2]);
            

            Stock newStock = new Stock(name, currentPrice, previousPrice);

            return newStock;
        }
    }
}
