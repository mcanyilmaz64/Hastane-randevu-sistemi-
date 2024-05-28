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
    public partial class Frm_SekreterDetay : Form
    {
        public Frm_SekreterDetay()
        {
            InitializeComponent();
        }
        public string tc;
        Sqlbaglantisi bgl = new Sqlbaglantisi();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Frm_SekreterDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = tc;
            //ad soyad
            SqlCommand komut = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreter where SekreterTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())

            {
                LblAdSoyad.Text = dr[0].ToString();

            }

            bgl.baglanti().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select BransAd from Tbl_Branslar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            //doktorları listeye aktarma 

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd + ' ' + DoktorSoyad )as 'Doktorlar 'From Tbl_Doktorlar",bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Branşı Kombobaxa aktarma

            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar",bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();



        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat, RandevuBrans, RandevuDoktor) values (@r1,@r2,@r3,@r4)",bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1",MskTarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2",MskSaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3",CmbBrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4",CmbDoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu OLUŞTURULDU ");
        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();

            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@p1 ", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1",CmbBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();

            while (dr3.Read())
            {
                
                    CmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);
                
            }

            bgl.baglanti().Close();
        }

        private void BtnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (duyuru) values (@d1)",bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", RchDuyuru.Text );
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show(  "Duyuru oluşturuldu ");

        }

        private void BtnDoktorPanel_Click(object sender, EventArgs e)
        {
            Frm_DoktorPaneli fr = new Frm_DoktorPaneli();
            fr.Show();
           
        }

        private void BtnBransPanel_Click(object sender, EventArgs e)
        {
            Frm_Brans frm = new Frm_Brans();
            frm.Show();
        }

        private void BtnListe_Click(object sender, EventArgs e)
        {
            Frm_RandevuListesi fr  = new Frm_RandevuListesi();
            fr.Show();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnDuyuru_Click(object sender, EventArgs e)
        {
            Frm_Duyurular fr = new Frm_Duyurular(); 
            fr.Show();  
        }

        private void RchRandevular_Enter(object sender, EventArgs e)
        {

        }
    }
}
