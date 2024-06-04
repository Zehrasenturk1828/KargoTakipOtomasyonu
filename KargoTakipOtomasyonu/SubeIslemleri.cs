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
    public partial class SubeIslemleri : Form
    {
        Bilgiler bilgiler = new Bilgiler();
        vtBaglanti baglanti = new vtBaglanti();
        Islemler islemler = new Islemler();
        public SubeIslemleri()
        {
            InitializeComponent();
        }

        private void SubeIslemleri_Load(object sender, EventArgs e)
        {
        }

        private void paneledon_Click(object sender, EventArgs e)
        {
            YetkiliPanel yetkiliPanel = new YetkiliPanel();
            yetkiliPanel.Show();
            this.Hide();
        }

        private void subegoster_Click(object sender, EventArgs e)
        {
            baglanti.baglantiac();
            SqlCommand komut = new SqlCommand("Select Sube_id,Sube_adi,Sube_adres,Sube_telefon from Subeler where Sube_adi like '%"+txtsubeadi.Text.ToString()+"%'", baglanti.baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem item = new ListViewItem(oku["Sube_id"].ToString());
                item.SubItems.Add(oku["Sube_adi"].ToString());
                item.SubItems.Add(oku["Sube_adres"].ToString());
                item.SubItems.Add(oku["Sube_telefon"].ToString());
                subeler.Items.Add(item);
            }
            baglanti.baglantikapa();

        }
    }

}

