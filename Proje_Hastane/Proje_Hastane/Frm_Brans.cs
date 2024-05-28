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
    public partial class Frm_Brans : Form
    {
        public Frm_Brans()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Tbl_Branslar set BransAd=@p2 where Bransid=@p1 ", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p2",TxtBrans.Text);
            cmd.Parameters.AddWithValue("@p1",TxtId.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Brans Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Frm_Brans_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da  = new SqlDataAdapter("Select * From Tbl_Branslar ",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Branslar (BransAd) values (@b2)",bgl.baglanti());
          //  cmd.Parameters.AddWithValue("@b1",TxtId.Text);
            cmd.Parameters.AddWithValue("@b2", TxtBrans.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Brans Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete  From Tbl_Branslar where Bransid=@b1" , bgl.baglanti());
            cmd.Parameters.AddWithValue("@b1",TxtId.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti() .Close();
            MessageBox.Show("Brans Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtBrans.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }
    }
}
