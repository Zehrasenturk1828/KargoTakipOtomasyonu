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
    public partial class YetkiliPanel : Form
    {
        public YetkiliPanel()
        {
            InitializeComponent();
        }

        private void gonderiolustur_Click(object sender, EventArgs e)
        {
            GonderiIslemlerii gonderi = new GonderiIslemlerii();
            gonderi.Show();
            this.Hide();
        }

        private void subeolustur_Click(object sender, EventArgs e)
        {
            SubeIslemleri sube = new SubeIslemleri();
            sube.Show();
            this.Hide();

        }

        private void musteriolustur_Click(object sender, EventArgs e)
        {
            MusteriIslemleri musteri = new MusteriIslemleri();
            musteri.Show();
            this.Hide();


        }

        private void gdurumguncelle_Click(object sender, EventArgs e)
        {

            GonderiDurumGuncelle gonderi = new GonderiDurumGuncelle();
            gonderi.Show();
            this.Hide();

        }

        private void gdurumsorgula_Click(object sender, EventArgs e)
        {
            GonderiDurumSorgula durumSorgula = new GonderiDurumSorgula();
            durumSorgula.Show();
            this.Hide();

        }

        private void cikis_Click(object sender, EventArgs e)
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();
            this.Hide();

        }

        private void YetkiliPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
