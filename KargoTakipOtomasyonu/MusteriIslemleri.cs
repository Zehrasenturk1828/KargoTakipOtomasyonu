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
    public partial class MusteriIslemleri : Form
    {

        Bilgiler bilg = new Bilgiler();
        Islemler Islemler = new Islemler();
        vtBaglanti dbBaglanti = new vtBaglanti();
        public MusteriIslemleri()
        {
            InitializeComponent();
        }


        private void MusteriIslemleri_Load(object sender, EventArgs e)
        {

        }

        private void musteriekle_Click(object sender, EventArgs e)
        {

            string secilencins = kulcins.SelectedItem.ToString();
            string yetki1 = yetki.Checked.ToString();
            Random rastgele = new Random();
            string harfler = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZabcçdefgğhıijklmnoöprsştuüvyz1234567890";
            string uret = "";
            for (int i = 0; i < 6; i++)
            {
                uret += harfler[rastgele.Next(harfler.Length)];
            }
            bilg.kuladi = musadi.Text;
            bilg.kulsadi = mussadi.Text;
            bilg.kuladres = musadres.Text;
            bilg.kultelefon = mustelefon.Text;
            bilg.kulmail = musmail.Text;
            bilg.kul_kuladi = uret;
            bilg.kul_kulsifre = uret;
            if (secilencins == "KADIN")
            {
                bilg.cinsiyet = true;
            }
            else
            {
                bilg.cinsiyet = false;
            }

            if (yetki.Checked)
            {
                bilg.yetki = true;
            }
            else
            {
                bilg.yetki = false;
            }
            int kayit = Islemler.MusteriEkle(bilg);
            if (kayit > 0)
            {
                MessageBox.Show("KAYIT EKLENDİ!");
            }


        }
        private void paneledon_Click_1(object sender, EventArgs e)
        {
            YetkiliPanel yetkili = new YetkiliPanel();
            yetkili.Show();
            this.Hide();


        }

        private void kulcins_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void verilistele_Click(object sender, EventArgs e)
        {
            dbBaglanti.baglantiac();
            SqlCommand komut = new SqlCommand("Select [Kullanici_id],[Kullanici_adi],[Kullanici_soyadi],[Kullanici_adres],[Kullanici_telefon],[Kullanici_mail],[Kullanici_kadi],[Kullanici_sifre],[Kullanici_cinsiyet]from [dbo].[Kullanici]", dbBaglanti.baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem item = new ListViewItem(oku["Kullanici_id"].ToString());
                item.SubItems.Add(oku["Kullanici_adi"].ToString());
                item.SubItems.Add(oku["Kullanici_soyadi"].ToString());
                item.SubItems.Add(oku["Kullanici_adres"].ToString());
                item.SubItems.Add(oku["Kullanici_telefon"].ToString());
                item.SubItems.Add(oku["Kullanici_mail"].ToString());
                item.SubItems.Add(oku["Kullanici_kadi"].ToString());
                item.SubItems.Add(oku["Kullanici_sifre"].ToString());
                if (oku["Kullanici_cinsiyet"].ToString()=="True")
                {
                    item.SubItems.Add("KADIN");
                }
                else
                {
                    item.SubItems.Add("ERKEK");
                }
                musteriler.Items.Add(item);
            }
            dbBaglanti.baglantikapa();
        }

        private void mussil_Click(object sender, EventArgs e)
        {
            dbBaglanti.baglantiac();
            if (musteriler.SelectedItems.Count > 0)
            {
                dbBaglanti.baglantiac();
                SqlCommand komut = new SqlCommand("Delete from Kullanici", dbBaglanti.baglan);
                komut.ExecuteNonQuery();
                MessageBox.Show("SİLME GERÇEKLEŞTİ..");
                dbBaglanti.baglantikapa();
                musteriler.Items.Remove(musteriler.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Listeden bir seçim yapmalısınız.");
            }
        }
    }
}



        

      




