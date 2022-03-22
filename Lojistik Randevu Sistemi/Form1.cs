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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-0NEP572;Initial Catalog=LRS;Integrated Security=True");
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM KULLANICILAR WHERE KADI=@P1 AND SIFRE=@P2",baglanti);
            komut.Parameters.AddWithValue("@P1", txtKadi.Text);
            komut.Parameters.AddWithValue("@P2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                if (dr["ROL"].ToString()=="A")
                {
                    Yonetici frm1 = new Yonetici();
                    frm1.Show();
                    this.Hide();
                }
                else if (dr["ROL"].ToString() == "B")
                {
                    Musteri frm2 = new Musteri();
                    frm2.Show();
                }
                else if (dr["ROL"].ToString() == "C")
                {
                    Tedarikci frm3 = new Tedarikci();
                    frm3.Show();
                }
                else if (dr["ROL"].ToString() == "D")
                {
                    Operasyon frm4 = new Operasyon();
                    frm4.Show();
                }
             
            }
            else
            {
                MessageBox.Show("Kullanıcı bilgileri yanlış.");
            }
            baglanti.Close();
      
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
