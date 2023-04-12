using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankLib;

namespace TecajnaLista
{
    public static class ExchangeParser
    {
        public static ExchangeRate ParseRate(string item)
        {
            List<string> data = BankAPI.GetExchangeData();
            ExchangeRate exRate;

            string[] split = item.Split(';');
            string currencyName = split[0];
            split[1] = split[1].Replace(",", ".");
            double rate = double.Parse(split[1]);

            exRate = new ExchangeRate(currencyName, rate);
            return exRate;

            

           
        }
    }
}
