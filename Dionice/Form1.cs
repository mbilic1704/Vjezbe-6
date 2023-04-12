using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dionice
{
    public partial class Form1 : Form
    {
        StockManager manager = new StockManager();
        public Form1()
        {
            InitializeComponent();
        }

        private void btShowResults_Click(object sender, EventArgs e)
        {
            List<Stock> data = manager.GetStocks();

            dtgStocks.DataSource = data;
        }
    }
}
