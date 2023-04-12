using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dionice_2
{
    public class Stock
    {
        public string Name { get; set; }
        public double Amount { get; set; }
        public double Price { get; set; }
        public double Worth { get; set; }

        public Stock(string name, double amount, double price)
        {
            Name = name;
            Amount = amount;
            Price = price;
            Worth = GetWorth();

        }

        public double GetWorth()
        {
            double worth = 0;

            worth = this.Amount * this.Price;

            return worth;
        }

        
    }
}
