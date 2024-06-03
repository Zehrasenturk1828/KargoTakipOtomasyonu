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
    public partial class Kullanici : Form
    {
        public Kullanici()
        {
            InitializeComponent();

        }


        private void Kullanici_Load(object sender, EventArgs e)
        {
            
        }

        private void btnuyeol_Click(object sender, EventArgs e)
        {
            this.Size= new Size(963, 790);
            groupBox3.Visible = true;
        }

        private void cbsifre_CheckedChanged(object sender, EventArgs e)
        {
            if(cbsifre.CheckState == CheckState.Checked)
            {
                txtsifre.UseSystemPasswordChar = true;
            }

            else if (cbsifre.CheckState == CheckState.Unchecked)
            {
                txtsifre.UseSystemPasswordChar = false;
            }
        }

        private void cbsifrekayit_CheckedChanged(object sender, EventArgs e)
        {
            if (cbsifrekayit.CheckState == CheckState.Checked)
            {
                txtsifrekayit.UseSystemPasswordChar = true;
                txtsifretekrar.UseSystemPasswordChar = true;
            }

            else if (cbsifrekayit.CheckState == CheckState.Unchecked)
            {
                txtsifrekayit.UseSystemPasswordChar = false;
                txtsifretekrar.UseSystemPasswordChar = false;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btngonderi_Click(object sender, EventArgs e)
        {
            Gonderi gonderi = new Gonderi();
            gonderi.Show();
            this.Hide();
        }

        private void btnsube_Click(object sender, EventArgs e)
        {
            Subeler sube = new Subeler();
            sube.Show();
            this.Hide();
        }

        private void btnkayitol_Click(object sender, EventArgs e)
        {

        }
    }
}
