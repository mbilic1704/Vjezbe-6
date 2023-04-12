using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventura
{
    public partial class Form1 : Form
    {
        InventoryList list = new InventoryList();
        public Form1()
        {
            InitializeComponent();
            InventoryList list = new InventoryList();
        }

        private void btReport_Click(object sender, EventArgs e)
        {
            PrintReport(list.Inventory);
        }

        public void PrintReport(List<InventoryItem> lista)
        {
            richTextBox1.Text += "INVENTORY LIST: " + Environment.NewLine;
            richTextBox1.Text += "---------------------------" + Environment.NewLine;

            foreach(InventoryItem i in lista)
            {
                string print = "ID: " + i.ID + ", Name: " + i.Name + ", Count: " + i.Count + Environment.NewLine;
                richTextBox1.Text += print;
            }
        }
    }
}
