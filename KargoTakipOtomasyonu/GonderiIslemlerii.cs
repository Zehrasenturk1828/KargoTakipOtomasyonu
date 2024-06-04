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
    public partial class GonderiIslemlerii : Form
    {
        Bilgiler bilg = new Bilgiler();
        Islemler Islemler = new Islemler();
        vtBaglanti dbBaglanti = new vtBaglanti();

        public GonderiIslemlerii()
        {
            InitializeComponent();
        }

        private void gonderiOlustur_Click(object sender, EventArgs e)
        {
            //fiyat hesaplama
            double fiyat1, fiyat2, agirlik, yukseklik, en, boy;
            double a = 0.000003;
            int b = 5;
            en = double.Parse(gonen.Text);
            boy = double.Parse(gonboy.Text);
            yukseklik = double.Parse(gonyukseklik.Text);
            agirlik = double.Parse(gonagirlik.Text);
            fiyat1 = en * boy * yukseklik * agirlik * a + b;
            fiyat2 = en * boy * agirlik * a + b;
            string gonderitip = gonkargotip.SelectedItem.ToString();
            Random rnd = new Random();
            int kod = rnd.Next(500000000);
            bilg.gonderikodu = kod;
            bilg.gonderien = gonen.Text;
            bilg.gonderiboy = gonboy.Text;
            bilg.gonderiyukseklik = gonyukseklik.Text;
            bilg.gonderiagirlik = gonagirlik.Text;
           
                if (gonderitip == "KÜÇÜK KOLİ")
                {
                    bilg.gonderitip = "KÜÇÜK KOLİ";
                }
                else if (gonderitip == "BÜYÜK KOLİ")
                {
                    bilg.gonderitip = "BÜYÜK KOLİ";
                }
                else if (gonderitip=="POŞET")
                {
                    bilg.gonderitip = "POŞET";
                }
                else
                {
                MessageBox.Show("Lütfen Bir Kargo Tip Seçimi Yapınız..!");
                }

                if (gonderitip == "KÜÇÜK KOLİ" || gonderitip == "BÜYÜK KOLİ")
                {
                    bilg.gonderifiyat = Convert.ToString(fiyat1);
                }
                else if (gonderitip == "POŞET")
                {
                bilg.gonderifiyat = Convert.ToString(fiyat2);
                }
                else
                {
                MessageBox.Show("Fiyat Hesaplanabilmesi İçin Kargo Tip Seçimi Yapınız..!");
                }
                bilg.gonderidurum = "GÖNDERİNİZ ALINDI";
            bilg.gonderenad = gonadi.Text;
            bilg.gonderensoyad = gonsadi.Text;
            bilg.gonderenadres = gonadres.Text;
            bilg.gonderentelefon = gontelefon.Text;
            bilg.gonderenmail = gonmail.Text;
            bilg.aliciad = aladi.Text;
            bilg.alicisoyad = alsadi.Text;
            bilg.aliciadres = aladres.Text;
            bilg.alicitelefon = altelefon.Text;
            bilg.alicimail = almail.Text;
            bilg.tarih = goneklemetarih.Value;



            int kayit = Islemler.gonderiEkle(bilg);
            if (kayit > 0)
            {
                MessageBox.Show("KAYIT EKLENDİ.!"+"\n"+"KARGO TAKİP NUMARASI:"+kod+"\n");
            }





        }

        private void gonlistele_Click(object sender, EventArgs e)
        {
            dbBaglanti.baglantiac();
            SqlCommand komut = new SqlCommand("Select [Gonderi_kodu],[Gonderi_en],[Gonderi_boy],[Gonderi_yukseklik],[Gonderi_agirlik],[Gonderi_tip],[Gonderi_fiyat],[Gonderi_durum],[Gonderen_adi],[Gonderen_soyadi],[Gonderen_adres],[Gonderen_telefon],[Gonderen_mail],[Alici_adi],[Alici_soyadi],[Alici_adres],[Alici_telefon],[Alici_mail],[Gonderi_tarih] from [dbo].[Gonderi]", dbBaglanti.baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem item = new ListViewItem(oku["Gonderi_kodu"].ToString());
                item.SubItems.Add(oku["Gonderi_fiyat"].ToString());
                item.SubItems.Add(oku["Gonderi_durum"].ToString());
                item.SubItems.Add(oku["Gonderi_tip"].ToString());
                item.SubItems.Add(oku["Gonderi_tarih"].ToString());
                item.SubItems.Add(oku["Gonderen_adi"].ToString());
                item.SubItems.Add(oku["Gonderen_soyadi"].ToString());
                item.SubItems.Add(oku["Gonderen_adres"].ToString());
                item.SubItems.Add(oku["Gonderen_mail"].ToString());
                item.SubItems.Add(oku["Gonderen_telefon"].ToString());
                item.SubItems.Add(oku["Alici_adi"].ToString());
                item.SubItems.Add(oku["Alici_soyadi"].ToString());
                item.SubItems.Add(oku["Alici_adres"].ToString());
                item.SubItems.Add(oku["Alici_telefon"].ToString());
                item.SubItems.Add(oku["Alici_mail"].ToString());
                gonderibilgileri.Items.Add(item);
            }
            dbBaglanti.baglantikapa();

        }

        private void gonderisil_Click(object sender, EventArgs e)
        {
            dbBaglanti.baglantiac();
            if (gonderibilgileri.SelectedItems.Count > 0)
            {
                dbBaglanti.baglantiac();
                SqlCommand komut = new SqlCommand("Delete from Gonderi", dbBaglanti.baglan);
                komut.ExecuteNonQuery();
                dbBaglanti.baglantikapa();
                MessageBox.Show("GÖNDERİ SİLİNDİ..");
                gonderibilgileri.Items.Remove(gonderibilgileri.SelectedItems[0]);

            }
            else
            {
                MessageBox.Show("SİLME İŞLEMİ İÇİN BİR SATIR SEÇMELİSİNİZ..!");
            }
        }

        private void paneledon_Click(object sender, EventArgs e)
        {
            YetkiliPanel yetkiliPanel = new YetkiliPanel();
            yetkiliPanel.Show();
            this.Hide(); 
        }

        private void gonderiguncelle_Click(object sender, EventArgs e)
        {

        }

       
    }
}
