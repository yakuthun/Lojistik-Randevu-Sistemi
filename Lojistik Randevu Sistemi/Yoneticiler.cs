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
using System.IO;

namespace Lojistik_Randevu_Sistemi
{
    public partial class Yoneticiler : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-0NEP572;Initial Catalog=LRS;Integrated Security=True");
        string resimyol;
        void listele()
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT KULLANICILAR.KULLANICIID as ID,AD as Adı,SOYAD as Soyadı,KULLANICILAR.KADI as KullanıcıAdı,KULLANICILAR.SIFRE as Şifre,KULLANICILAR.TEL as Telefon,GORSEL as Görsel FROM YONETICILER INNER JOIN KULLANICILAR ON YONETICILER.KULLANICIID= KULLANICILAR.KULLANICIID", baglanti);
            da2.Fill(dt2);
            bunifuDataGridView1.DataSource = dt2;
        }
        void temizle()
        {
            txtAd.Text = "";
            txtKadi.Text = "";
            txtSifre.Text = "";
            txtSoyad.Text = "";
            txtTel.Text = "";
            lblid.Text = "";
            
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
            bool exists = false;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO KULLANICILAR (KADI, SIFRE, TEL, ROL) VALUES (@d1,@d2,@d3,@d4) INSERT INTO YONETICILER (GORSEL,AD, SOYAD,KULLANICIID) VALUES (@g1,@d5,@d6,scope_identity())", baglanti );
            
            using (SqlCommand dogrula = baglanti.CreateCommand())
            {
                dogrula.CommandText = "SELECT COUNT(*) FROM KULLANICILAR WHERE KADI = @P1";
                dogrula.Parameters.AddWithValue("@P1", txtKadi.Text);
                exists = (int)dogrula.ExecuteScalar() > 0;
            }

            if (exists)
            {
                MessageBox.Show("Bu kullanıcı adı kullanılıyor", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                komut.Parameters.AddWithValue("@d1", txtKadi.Text);
                komut.Parameters.AddWithValue("@d2", txtSifre.Text);
                komut.Parameters.AddWithValue("@d3", txtTel.Text);
                komut.Parameters.AddWithValue("@d4", "A");
                komut.Parameters.AddWithValue("@d5", txtAd.Text);
                komut.Parameters.AddWithValue("@d6", txtSoyad.Text);
                komut.Parameters.AddWithValue("@g1", resimyol);
                komut.ExecuteNonQuery();
                MessageBox.Show("Yönetici Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
            baglanti.Close();
           
            listele();
        }

        private void bunifuDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            int secilen = bunifuDataGridView1.SelectedCells[0].RowIndex;
            lblid.Text = bunifuDataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = bunifuDataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = bunifuDataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtKadi.Text = bunifuDataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtSifre.Text = bunifuDataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtTel.Text = bunifuDataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtGorsel.Text = bunifuDataGridView1.Rows[secilen].Cells[6].Value.ToString();
            bunifuPictureBox1.ImageLocation = Application.StartupPath + bunifuDataGridView1.Rows[secilen].Cells[6].ToString();
            bunifuPictureBox1.Image = Image.FromFile(txtGorsel.Text);

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
           
            SqlCommand komut = new SqlCommand("DELETE FROM YONETICILER WHERE KULLANICIID=@z1", baglanti);
            komut.Parameters.AddWithValue("@z1",lblid.Text);
            komut.ExecuteNonQuery();
            SqlCommand komut2 = new SqlCommand("DELETE FROM KULLANICILAR WHERE KULLANICIID=@z1", baglanti);
            komut2.Parameters.AddWithValue("@z1", lblid.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            listele();
            temizle();
            MessageBox.Show("Kayıt Silindi","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            bool exists = false;
            baglanti.Open();
            //SqlCommand komut = new SqlCommand("INSERT INTO KULLANICILAR (KADI, SIFRE, TEL, ROL) VALUES (@d1,@d2,@d3,@d4) INSERT INTO YONETICILER (AD, SOYAD,KULLANICIID) VALUES (@d5,@d6,scope_identity())", baglanti);
            SqlCommand komut = new SqlCommand("UPDATE YONETICILER SET AD=@d5, SOYAD=@d6 WHERE KULLANICIID=@z1 UPDATE  KULLANICILAR SET  SIFRE=@d2, TEL=@d3, ROL=@d4 WHERE  KULLANICIID=@z1", baglanti);

                komut.Parameters.AddWithValue("@z1", lblid.Text);
                komut.Parameters.AddWithValue("@d2", txtSifre.Text);
                komut.Parameters.AddWithValue("@d3", txtTel.Text);
                komut.Parameters.AddWithValue("@d4", "A");
                komut.Parameters.AddWithValue("@d5", txtAd.Text);
                komut.Parameters.AddWithValue("@d6", txtSoyad.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı adı güncellenmedi.", "Yönetici Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

            baglanti.Close();
            listele();
            temizle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
      
        private void btnGorselSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Resim Dosyası | *.jpg;*.bmp;*.png | Tüm Dosyalar | *.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bunifuPictureBox1.ImageLocation = openFileDialog1.FileName;
                string kaynak = openFileDialog1.FileName;
                string hedef = Application.StartupPath +  @"\images\";
                string yeniad = Guid.NewGuid() + ".jpg"; //benzersiz isim
                File.Copy(kaynak, hedef + yeniad);
                resimyol = @"\images\" + yeniad;
               
            }
        }
    }
    }

