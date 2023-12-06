using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            double Toplama= Convert.ToDouble(sayi1.Text) + Convert.ToDouble(sayi2.Text);
            sonuc2.Text = Convert.ToString(Toplama);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();        
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            double Cikarma= Convert.ToDouble(sayi1.Text) - Convert.ToDouble(sayi2.Text);
            sonuc2.Text = Convert.ToString(Cikarma);
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            double Carpma = Convert.ToDouble(sayi1.Text) * Convert.ToDouble(sayi2.Text);
            sonuc2.Text = Convert.ToString(Carpma);
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            double Bolme = Convert.ToDouble(sayi1.Text) / Convert.ToDouble(sayi2.Text);
            sonuc2.Text = Convert.ToString(Bolme);
        }

        private void btnModAl_Click(object sender, EventArgs e)
        {
            double ModAlma= Convert.ToDouble(sayi1.Text) % Convert.ToDouble(sayi2.Text);
            sonuc2.Text = Convert.ToString(ModAlma);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
