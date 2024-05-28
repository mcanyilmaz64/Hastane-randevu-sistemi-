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
    public partial class Frm_DoktorPaneli : Form
    {
        public Frm_DoktorPaneli()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        private void LblTC_Click(object sender, EventArgs e)
        {

        }

        private void Frm_DoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * From Tbl_Doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;

            //

            SqlCommand komut = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                CmbBrans.Items.Add(reader[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values (@p1,@p2,@p3,@p4,@p5)",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1",TxtAd.Text);
            cmd.Parameters.AddWithValue("@p2",TxtSoyad.Text);
            cmd.Parameters.AddWithValue("@p3",CmbBrans.Text);
            cmd.Parameters.AddWithValue("@p4",TxtTC.Text);
            cmd.Parameters.AddWithValue("p5",TxtSifre.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Eklendi ! ");


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtTC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Delete From Tbl_Doktorlar where DoktorTC= '" + TxtTC.Text + "'",bgl.baglanti());
           // sqlCommand.Parameters.AddWithValue("@p1",TxtTC.Text);
            sqlCommand.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Silindi");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Tbl_Doktorlar SET DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p5 where DoktorTC=@p4", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", TxtAd.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", CmbBrans.Text);
            cmd.Parameters.AddWithValue("@p4", TxtTC.Text);
            cmd.Parameters.AddWithValue("p5", TxtSifre.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
