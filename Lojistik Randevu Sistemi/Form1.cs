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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            if (bunifuTextBox1.Text == "1")
            {
                Yonetici frm1 = new Yonetici();
                frm1.Show();
            }
            if (bunifuTextBox1.Text == "2")
            {
                Musteri frm2 = new Musteri();
                frm2.Show();
            }
            if (bunifuTextBox1.Text == "3")
            {
                Tedarikci frm3 = new Tedarikci();
                frm3.Show();
            }
            else
            {
                MessageBox.Show("asd");
            }
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
