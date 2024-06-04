using BEL;
using DAL;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BAL1
{
    public class Islemler
    {
        public vtBaglanti dbbaglanti = new vtBaglanti();
        public Bilgiler bilgiler = new Bilgiler();


        public int MusteriEkle(Bilgiler bilgiler)
        {
            dbbaglanti.baglantiac();
            SqlCommand komut = new SqlCommand("insert into [dbo].[Kullanici] ([Kullanici_adi],[Kullanici_soyadi],[Kullanici_adres],[Kullanici_telefon],[Kullanici_mail],[Kullanici_kadi],[Kullanici_sifre],[Kullanici_cinsiyet],[Kullanici_yetki]) VALUES (@Kullanici_adi,@Kullanici_soyadi,@Kullanici_adres,@Kullanici_telefon,@Kullanici_mail,@K_kuladi,@K_kulsifre,@Kullanici_cinsiyet,@Kullanici_yetki)", dbbaglanti.baglan);
            komut.Parameters.AddWithValue("@Kullanici_adi", bilgiler.kuladi);
            komut.Parameters.AddWithValue("@Kullanici_soyadi", bilgiler.kulsadi);
            komut.Parameters.AddWithValue("@Kullanici_adres", bilgiler.kuladres);
            komut.Parameters.AddWithValue("@Kullanici_telefon", bilgiler.kultelefon);
            komut.Parameters.AddWithValue("@Kullanici_mail", bilgiler.kulmail);
            komut.Parameters.AddWithValue("@K_kuladi", bilgiler.kul_kuladi);
            komut.Parameters.AddWithValue("@K_kulsifre", bilgiler.kul_kulsifre);
            komut.Parameters.AddWithValue("@Kullanici_cinsiyet", bilgiler.cinsiyet);
            komut.Parameters.AddWithValue("@Kullanici_yetki", bilgiler.yetki);
            dbbaglanti.baglantikapa();
            return dbbaglanti.DMLIslemiYap(komut);


            }
        public int Uyelik(Bilgiler bilgiler)
        {
            dbbaglanti.baglantiac();
            SqlCommand komut = new SqlCommand("insert into [dbo].[Kullanici] ([Kullanici_adi],[Kullanici_soyadi],[Kullanici_adres],[Kullanici_telefon],[Kullanici_mail],[Kullanici_kadi],[Kullanici_sifre],[Kullanici_cinsiyet],[Kullanici_yetki]) VALUES (@Kullanici_adi,@Kullanici_soyadi,@Kullanici_adres,@Kullanici_telefon,@Kullanici_mail,@K_kuladi,@K_kulsifre,@Kullanici_cinsiyet,@Kullanici_yetki)", dbbaglanti.baglan);
            komut.Parameters.AddWithValue("@Kullanici_adi", bilgiler.kuladi);
            komut.Parameters.AddWithValue("@Kullanici_soyadi", bilgiler.kulsadi);
            komut.Parameters.AddWithValue("@Kullanici_adres", bilgiler.kuladres);
            komut.Parameters.AddWithValue("@Kullanici_telefon", bilgiler.kultelefon);
            komut.Parameters.AddWithValue("@Kullanici_mail", bilgiler.kulmail);
            komut.Parameters.AddWithValue("@K_kuladi", bilgiler.kul_kuladi);
            komut.Parameters.AddWithValue("@K_kulsifre", bilgiler.kul_kulsifre);
            komut.Parameters.AddWithValue("@Kullanici_cinsiyet", bilgiler.cinsiyet);
            komut.Parameters.AddWithValue("@Kullanici_yetki", bilgiler.yetki);
            dbbaglanti.baglantikapa();
            return dbbaglanti.DMLIslemiYap(komut);
        }

        public int gonderiEkle(Bilgiler bilgiler)
        {
            dbbaglanti.baglantiac();
            SqlCommand komut = new SqlCommand("insert into [dbo].[Gonderi]([Gonderi_kodu],[Gonderi_en],[Gonderi_boy],[Gonderi_yukseklik],[Gonderi_agirlik],[Gonderi_tip],[Gonderi_fiyat],[Gonderi_durum],[Gonderen_adi],[Gonderen_soyadi],[Gonderen_adres],[Gonderen_telefon],[Gonderen_mail],[Alici_adi],[Alici_soyadi],[Alici_adres],[Alici_telefon],[Alici_mail],[Gonderi_tarih]) VALUES (@gonderikodu,@gonderien,@gonderiboy,@gonderiyukseklik,@gonderiagirlik,@gonderitip,@gonderifiyat,@gonderidurum,@gonderenadi,@gonderensadi,@gonderenadres,@gonderentelefon,@gonderenmail,@aliciadi,@alicisadi,@aliciadres,@alicitelefon,@alicimail,@gonderitarih)", dbbaglanti.baglan);
            komut.Parameters.AddWithValue("@gonderikodu",bilgiler.gonderikodu);
            komut.Parameters.AddWithValue("@gonderien", bilgiler.gonderien);
            komut.Parameters.AddWithValue("@gonderiboy", bilgiler.gonderiboy);
            komut.Parameters.AddWithValue("@gonderiyukseklik", bilgiler.gonderiyukseklik);
            komut.Parameters.AddWithValue("@gonderiagirlik", bilgiler.gonderiagirlik);
            komut.Parameters.AddWithValue("@gonderitip", bilgiler.gonderitip);
            komut.Parameters.AddWithValue("@gonderifiyat", bilgiler.gonderifiyat);
            komut.Parameters.AddWithValue("@gonderidurum", bilgiler.gonderidurum);
            komut.Parameters.AddWithValue("@gonderenadi", bilgiler.gonderenad);
            komut.Parameters.AddWithValue("@gonderensadi", bilgiler.gonderensoyad);
            komut.Parameters.AddWithValue("@gonderenadres", bilgiler.gonderenadres);
            komut.Parameters.AddWithValue("@gonderentelefon", bilgiler.gonderentelefon);
            komut.Parameters.AddWithValue("@gonderenmail", bilgiler.gonderenmail);
            komut.Parameters.AddWithValue("@aliciadi", bilgiler.aliciad);
            komut.Parameters.AddWithValue("@alicisadi", bilgiler.alicisoyad);
            komut.Parameters.AddWithValue("@aliciadres", bilgiler.aliciadres);
            komut.Parameters.AddWithValue("@alicitelefon", bilgiler.alicitelefon);
            komut.Parameters.AddWithValue("@alicimail", bilgiler.alicimail);
            komut.Parameters.AddWithValue("@gonderitarih", bilgiler.tarih);
            dbbaglanti.baglantikapa();
            return dbbaglanti.DMLIslemiYap(komut);
        }
        public void kontrol(Bilgiler bilgiler)
        {
            dbbaglanti.baglantiac();
            SqlCommand komut = new SqlCommand("Select [K_yetkitürü] from [dbo].[Kullanici] where [K_yetkitürü]=@kyetkituru");
            komut.Parameters.AddWithValue("@kyetkituru",bilgiler.yetkidurumu);
            SqlDataReader oku = komut.ExecuteReader();
            dbbaglanti.baglantikapa();
            dbbaglanti.DMLIslemiYap(komut);

        }
       
    }

}

