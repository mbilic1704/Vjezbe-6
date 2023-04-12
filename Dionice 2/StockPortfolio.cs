using StocksLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dionice_2
{
    public class StockPortfolio
    {
        public List<Stock> GetMyStocks()
        {
            List<Stock> myStocks = new List<Stock>();
            List<string> dataInString = StockExchangeAPI.GetOwnedStocksData();
            string name = "";
            double amount = 0;
            double price = 0;

            foreach(string s in dataInString)
            {
                string[] split = s.Split(';');
                name = split[0];
                amount = double.Parse(split[1]);
                price = StockExchangeAPI.GetStockPrice(name);

                myStocks.Add(new Stock(name, amount, price));

            }

            return myStocks;

  
            
        }

       
    }
}
