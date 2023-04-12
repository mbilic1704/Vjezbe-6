using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecajnaLista
{
    public partial class Form1 : Form
    {
        Exchange exchange = new Exchange();
        public Form1()
        {
            InitializeComponent();
        }

        private void btShowRates_Click(object sender, EventArgs e)
        {
            List<ExchangeRate> rates = new List<ExchangeRate>();

            rates = exchange.GetExchangeRates();

            dtgRates.DataSource = rates;
        }
    }
}
