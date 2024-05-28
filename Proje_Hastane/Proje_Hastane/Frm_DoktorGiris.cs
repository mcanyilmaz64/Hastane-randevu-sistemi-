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
using System.Data.SqlClient;

namespace Proje_Hastane
{
    public partial class Frm_DoktorGiris : Form
    {
        public Frm_DoktorGiris()
        {
            InitializeComponent();
        }
        

        private void LnkUyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        Sqlbaglantisi bgl  = new Sqlbaglantisi();
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTC=@p1 and DoktorSifre=@p2", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", MskTC.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader da = cmd.ExecuteReader();
            if( da.Read()    )
            {

                Frm_DoktorDetay fr = new Frm_DoktorDetay();
                fr.tc=MskTC.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");
            }


            bgl.baglanti().Close();


        }

      

        private void Frm_DoktorGiris_Load(object sender, EventArgs e)
        {
         
           
        }
    }
}
