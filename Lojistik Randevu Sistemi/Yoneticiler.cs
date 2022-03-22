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

namespace Lojistik_Randevu_Sistemi
{
    public partial class Yoneticiler : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-0NEP572;Initial Catalog=LRS;Integrated Security=True");

        void listele()
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT KULLANICILAR.KULLANICIID as ID,AD as Adı,SOYAD as Soyadı,KULLANICILAR.KADI as KullanıcıAdı,KULLANICILAR.SIFRE as Şifre,KULLANICILAR.TEL as Telefon FROM YONETICILER INNER JOIN KULLANICILAR ON YONETICILER.KULLANICIID= KULLANICILAR.KULLANICIID", baglanti);
            da2.Fill(dt2);
            bunifuDataGridView1.DataSource = dt2;
        }
        public Yoneticiler()
        {
            InitializeComponent();
            listele();
        }
      
        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO KULLANICILAR (KADI, SIFRE, TEL, ROL) VALUES (@d1,@d2,@d3,@d4) INSERT INTO YONETICILER (AD, SOYAD,KULLANICIID) VALUES (@d5,@d6,scope_identity())", baglanti );
            
            komut.Parameters.AddWithValue("@d1", txtKadi.Text);
            komut.Parameters.AddWithValue("@d2", txtSifre.Text);
            komut.Parameters.AddWithValue("@d3", txtTel.Text);
            komut.Parameters.AddWithValue("@d4", "A");
            komut.Parameters.AddWithValue("@d5",txtAd.Text);
            komut.Parameters.AddWithValue("@d6",txtSoyad.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yönetici Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void bunifuDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = bunifuDataGridView1.SelectedCells[0].RowIndex;

            txtAd.Text = bunifuDataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = bunifuDataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtKadi.Text = bunifuDataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtSifre.Text = bunifuDataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtTel.Text = bunifuDataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }
    }
}
