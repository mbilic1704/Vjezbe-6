using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Konverzija_valuta
{
    public class Currency
    {
        public  string Name { get; set; }
        public  double ExchangeRate { get; set; }

        public Currency(string name, double exchangeRate)
        {
            Name = name;
            ExchangeRate = exchangeRate;
        }

        public static double ConvertTo(double currency1,double currency2, double amount)
        {
            double convertedAmount = 0;

            convertedAmount = amount * (currency1 / currency2);

            return convertedAmount; 
        }

        public override string ToString()
        {
            return this.Name;
        }
        
        
    }
}
