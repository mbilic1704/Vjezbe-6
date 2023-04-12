using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glasanje
{
    public partial class Form1 : Form
    {
        public static int za;
        public static int protiv;
        public static int suzdrzan;

        Glasanje glasanje = new Glasanje();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbOpcija.Items.Add("ZA");
            cbOpcija.Items.Add("PROTIV");
            cbOpcija.Items.Add("SUZDRZAN");

            

        }

        public void OsvjeziRezultate()
        {
                lbZa.Text = za.ToString();
                lbProtiv.Text = protiv.ToString();
                lbSuzdrzan.Text = suzdrzan.ToString();  
            
        }

        private void btGlasaj_Click(object sender, EventArgs e)
        {
            try
            {
                string oib = tbOIB.Text;
                string opcija = cbOpcija.SelectedItem as string;
                glasanje.Glasaj(oib, opcija);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            OsvjeziRezultate();
        }
    }
}
