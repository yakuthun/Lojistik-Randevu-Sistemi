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
    public partial class Tedarikciler : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-0NEP572;Initial Catalog=LRS;Integrated Security=True");
        public Tedarikciler()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT TEDARIKCILER.ADSOYAD as AdSoyad,TEDARIKCILER.PLAKA as Plaka,KULLANICILAR.KADI as KullanıcıAdı, KULLANICILAR.SIFRE as Şifre,KULLANICILAR.TEL as Telefon FROM TEDARIKCILER INNER JOIN KULLANICILAR ON TEDARIKCILER.KULLANICIID = KULLANICILAR.KULLANICIID",baglanti);
            da.Fill(dt);
            bunifuDataGridView1.DataSource = dt;
        }
    }
}
