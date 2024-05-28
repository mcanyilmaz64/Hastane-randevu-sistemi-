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
    public partial class Frm_DoktorDetay : Form
    {
        public Frm_DoktorDetay()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        public string tc;
        private void Frm_DoktorDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = tc;
            //Doktor ad soyad

            SqlCommand cmd = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorTC =@p1",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1",LblTC.Text);
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                LblAdSoyad.Text = dataReader[0] + " " + dataReader[1];
            }
            bgl.baglanti().Close();

            //Randevu Listesi Çekme
            
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuDoktor='"+LblAdSoyad.Text+"'",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();


        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            Frm_DoktorBilgiDuzenle fr =new Frm_DoktorBilgiDuzenle();
            fr.tc = LblTC.Text;
            fr.Show();
        }

        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            Frm_Duyurular fr = new Frm_Duyurular();
            fr.Show();





        }

        private void BtnÇıkış_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            RchSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
