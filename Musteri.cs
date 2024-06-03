using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeslekiProje
{
    public partial class Musteri : Form
    {
        public Musteri()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            panel.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Kullanici kul = new Kullanici();
            kul.Show();
            this.Close();
        }

        private void btnkuladi_Click(object sender, EventArgs e)
        {
            string ad, soyad, kuladi;
            ad = txtad.Text;
            soyad = txtsoyad.Text;
            kuladi = ad + soyad;
            txtkuladi.Text = kuladi.ToString();
        }

        private void btnsifreuret_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int sifre = rastgele.Next(100000, 99999999);
            txtsifre.Text = sifre.ToString();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            string ad, soyad, adres, mail, telefon, kuladi, sifre;
            ad = txtad.Text;
            soyad = txtsoyad.Text;
            adres = txtadres.Text;
            mail = txtmail.Text;
            telefon = txttel.Text;
            kuladi = txtkuladi.Text;
            sifre = txtsifre.Text;
        }
    }
}
