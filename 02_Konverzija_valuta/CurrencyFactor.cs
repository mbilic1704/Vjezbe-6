using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Konverzija_valuta
{
    public class CurrencyFactor
    {
        public List<Currency> Currencies=new List<Currency>();

        public CurrencyFactor()
        {
   
            Currencies.Add(new Currency("HRK", 1));
            Currencies.Add(new Currency("EUR", 7.4));
            Currencies.Add(new Currency("USD", 6.5));
            Currencies.Add(new Currency("GBP", 8.5));
            Currencies.Add(new Currency("CAD", 4.9));

        }

        public List<Currency> GetCurrencies()
        {
            return Currencies;
        }
        public Currency GetCurrency(string name)
        {
            foreach (Currency c in Currencies)
            {
                if (c.Name == name)
                {
                    return c;
                }
            }
            return null;
        }
    }
}
