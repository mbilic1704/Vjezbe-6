using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dionice
{
    public class Stock
    {
        public string Name { get; set; }
        public double CurrentPrice { get; set; }

        public double PreviousPrice { get; set; }

        public double difference{ get; set; }

        public Stock(string name, double currentPrice, double previousPrice)
        {
            Name = name;
            CurrentPrice = currentPrice;
            PreviousPrice = previousPrice;
            difference = GetDifference();
            
        }

        public double GetDifference()
        {
            double difference = (((this.CurrentPrice - this.PreviousPrice) / this.PreviousPrice) * 100);
            Math.Round(difference);
            return difference;
        }
    }
}
