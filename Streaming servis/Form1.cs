using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Streaming_servis
{
    public partial class Form1 : Form
    {
        StreamingServis servis = new StreamingServis();
        public Form1()
        {
            InitializeComponent();
        }

        private void btOsvjezi_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = servis.DohvatiNepogledaneFilmove().ToList();
        }

        private void btPogledaj_Click(object sender, EventArgs e)
        {
            Film odabraniFilm = dataGridView1.CurrentRow.DataBoundItem as Film;

            servis.PogledajFilm(odabraniFilm);
        }
    }
}
