using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StocksLib;

namespace Dionice
{
    public class StockManager
    {
        public List<Stock> GetStocks()
        {
            List<string> dataInString = StockExchangeAPI.GetStocksData();
            List<Stock> dataInStock = new List<Stock>();
            
            foreach(string s in dataInString)
            {
                Stock newStock = StockParser.ParseStock(s);
                dataInStock.Add(newStock);
            }

            return dataInStock;
        }
    }
}
