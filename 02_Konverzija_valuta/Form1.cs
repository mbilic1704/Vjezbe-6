using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Konverzija_valuta
{
    public partial class Form1 : Form
    {
        CurrencyFactor CurrencyFactor = new CurrencyFactor();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbCurrency1.DataSource = CurrencyFactor.GetCurrencies().ToList();
            cbCurrency2.DataSource = CurrencyFactor.GetCurrencies().ToList();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowResult();


        }

        private void ShowResult()
        {
            string c1Name = cbCurrency1.SelectedItem.ToString();
            string c2Name = cbCurrency2.SelectedItem.ToString();

            Currency c1 = CurrencyFactor.GetCurrency(c1Name);
            Currency c2 = CurrencyFactor.GetCurrency(c2Name);

            double amount = double.Parse(tbAmount.Text);
            double convertedAmount = Currency.ConvertTo(c1.ExchangeRate, c2.ExchangeRate, amount);

            tbConverted.Text = convertedAmount.ToString();

        }
    }
}
