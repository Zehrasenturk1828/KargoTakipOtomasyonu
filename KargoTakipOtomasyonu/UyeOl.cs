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

    public partial class UyeOl : Form
    {
        vtBaglanti baglanti = new vtBaglanti();
        Bilgiler bilg = new Bilgiler();
        Islemler islem = new Islemler();

        public UyeOl()
        {
            InitializeComponent();
        }

       
        private void UyeOl_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                baglanti.baglantiac();
                string secilencins = cmbcinsiyet.SelectedItem.ToString();
                bilg.kuladi = txtadi.Text;
                bilg.kulsadi = txtsadi.Text;
                bilg.kuladres = txtadres.Text;
                bilg.kultelefon = txttelefon.Text;
                bilg.kulmail = txtmail.Text;
                bilg.kul_kuladi = txtkuladi.Text;
                bilg.kul_kulsifre = txtsifre.Text;
                if (secilencins == "KADIN")
                {
                    bilg.cinsiyet = true;
                }
                else
                {
                    bilg.cinsiyet = false;
                }
                bilg.yetki = false;
                int kayit = islem.Uyelik(bilg);
                if (kayit > 0)
                {
                    MessageBox.Show("KAYIT BAŞARILI.!");
                    girisedon.Enabled = true;
                }
                else
                {
                    MessageBox.Show("KAYIT BAŞARISIZ.!");
                    girisedon.Enabled = true;
                }

            




        }

    }
}
