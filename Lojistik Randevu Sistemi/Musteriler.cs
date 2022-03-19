using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lojistik_Randevu_Sistemi
{
    public partial class Musteriler : Form
    {

        
        public Musteriler()
        {
            InitializeComponent();
            
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminMusteriDuzenle frm = new AdminMusteriDuzenle();
           
            frm.Show();
        }
     
        private void bunifuButton2_Click_1(object sender, EventArgs e)
        {
            AdminMusteriEkle frm = new AdminMusteriEkle();
            
            frm.Show();
            
          
        }
    }
}
