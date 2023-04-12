using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankLib;

namespace TecajnaLista
{
    public class Exchange
    {
        public List<ExchangeRate> GetExchangeRates()
        {
            List<string> data = BankAPI.GetExchangeData();
            List<ExchangeRate> rates = new List<ExchangeRate>();

            foreach(string item in data)
            {
                ExchangeRate rate = ExchangeParser.ParseRate(item);
                rates.Add(rate);    

                
            }

            return rates;
        }
    }
}
