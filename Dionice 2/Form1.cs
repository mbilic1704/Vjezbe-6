using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Dionice_2
{
    public partial class Form1 : Form
    {
        StockPortfolio portfolio = new StockPortfolio();
        public Form1()
        {
            InitializeComponent();
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            tbTotal.Text = GetTotalWorth().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtgStocks.DataSource = portfolio.GetMyStocks().ToList();
        }

        private double GetTotalWorth()
        {
            List<Stock> myStocks = portfolio.GetMyStocks();
            double total = 0;

            foreach (Stock s in myStocks)
            {
                total += s.Worth;
            }

            return total;
        }
    }
}
