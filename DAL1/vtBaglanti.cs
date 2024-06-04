using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class vtBaglanti
    {
        public SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-0F4P134\\SQLEXPRESS;Initial Catalog=Kargodb;Integrated Security=True");

        public void baglantiac()
        {
            if (baglan.State == System.Data.ConnectionState.Closed)
            {
                baglan.Open();
            }
        }
        public void baglantikapa()
        {
            if (baglan.State == System.Data.ConnectionState.Open)
            {
                baglan.Close();
            }
        }
        public int DMLIslemiYap(SqlCommand komut)
        {
            int etkilenenkayit = -1;
            baglantiac();
            etkilenenkayit = komut.ExecuteNonQuery();
            baglantikapa();
            return etkilenenkayit;
        }
        public string okumaIslemiYap(SqlCommand komut)
        {
            string kayit;
            baglantiac();
            SqlDataReader okuyucu = komut.ExecuteReader();
            okuyucu.Read();
            kayit = okuyucu[0].ToString();
            baglantikapa();
            return kayit;
        }


    }
}
