using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    public partial class Frm_DoktorBilgiDuzenle : Form
    {
        public Frm_DoktorBilgiDuzenle()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        public string tc;
        private void Frm_DoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            MskTC.Text = tc;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",MskTC.Text);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                TxtAd.Text = reader[1].ToString();
                TxtSoyad.Text = reader[2].ToString();
                CmbBrans.Text = reader[3].ToString();
                TxtSifre.Text = reader[5].ToString();
            }
            bgl.baglanti().Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@p1 , DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTC=@p5 ", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut2.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", CmbBrans.Text);
            komut2.Parameters.AddWithValue("@p4", TxtSifre.Text);
            komut2.Parameters.AddWithValue("@p5", MskTC.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
