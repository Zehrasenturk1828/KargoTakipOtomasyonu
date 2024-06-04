using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KargoTakipOtomasyonu
{
    public partial class KullaniciPanel : Form
    {
        public KullaniciPanel()
        {
            InitializeComponent();
        }

        private void kargodurumsorgula_Click(object sender, EventArgs e)
        {
            KullaniciKargoDurumuSorgulama sorgula = new KullaniciKargoDurumuSorgulama();
            sorgula.Show();
            this.Hide();

        }

        private void cikisyap_Click(object sender, EventArgs e)
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();
            this.Hide();
        }
    }
}
