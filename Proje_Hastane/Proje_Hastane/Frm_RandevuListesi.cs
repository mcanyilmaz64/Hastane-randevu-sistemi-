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
    public partial class Frm_RandevuListesi : Form
    {
        public Frm_RandevuListesi()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();

        private void Frm_RandevuListesi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From Tbl_Randevular",bgl.baglanti());
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             
             


        }
    }
}
