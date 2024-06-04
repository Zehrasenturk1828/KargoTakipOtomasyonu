using BAL1;
using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KargoTakipOtomasyonu
{

    public partial class GirisEkrani : Form
    {
        Islemler ıslemler = new Islemler();
        Bilgiler bilg = new Bilgiler();
        vtBaglanti baglanti = new vtBaglanti();
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void uyeol_click(object sender, EventArgs e)
        {
        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {

        }

        private void girisyap_Click_1(object sender, EventArgs e)
        {
            baglanti.baglantiac();
                SqlCommand komut = new SqlCommand("Select [Kullanici_kadi],[Kullanici_sifre],[K_yetkitürü] from [dbo].[Kullanici] where [Kullanici_kadi]=@kadi AND [Kullanici_sifre]=@sifre", baglanti.baglan);
                komut.Parameters.AddWithValue("@kadi",kadi.Text);
                komut.Parameters.AddWithValue("@sifre", sifre.Text);
            SqlDataReader giriskontrolu = komut.ExecuteReader();

            if (giriskontrolu.Read())
            {
                MessageBox.Show("GİRİŞ BAŞARILI");
                if (giriskontrolu["K_yetkitürü"].ToString()=="KARGO PERSONELİ")
                {
                    YetkiliPanel yetkiliPanel = new YetkiliPanel();
                    yetkiliPanel.Show();
                    this.Hide();
                }
                else if (giriskontrolu["K_yetkitürü"].ToString() == "ŞUBE MÜDÜRÜ")
                {
                    YetkiliPanel yetkiliPanel = new YetkiliPanel();
                    yetkiliPanel.Show();
                    this.Hide();
                }
                else
                {
                    KullaniciPanel kullaniciPanel = new KullaniciPanel();
                    kullaniciPanel.Show();
                    this.Hide();
                }

            }
            else
            {
                baglanti.baglantikapa();
                MessageBox.Show("Böyle bir kullanıcı bulunmamaktadır.!");

            }





        }

        private void uyeol_Click_1(object sender, EventArgs e)
        {
            UyeOl uye = new UyeOl();
            uye.Show();
            this.Hide();

        }
    }
}
