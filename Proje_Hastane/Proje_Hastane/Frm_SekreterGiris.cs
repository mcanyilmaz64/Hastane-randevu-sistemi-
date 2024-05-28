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
    public partial class Frm_SekreterGiris : Form
    {
        public Frm_SekreterGiris()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Sekreter where SekreterTC=@P1 and SekreterSifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",MskTC.Text);
            komut.Parameters.AddWithValue("@p2",TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
               Frm_SekreterDetay frs = new Frm_SekreterDetay();
                frs.tc =MskTC.Text;
                frs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Tc Ya Da Şifre");
            }
            bgl.baglanti().Close();
        }
    }
}
