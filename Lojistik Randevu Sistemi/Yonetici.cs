using Bunifu.Framework.UI;
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
    public partial class Yonetici : Form
    {
        public Yonetici()
        {
            InitializeComponent();
        }
        private Form activeForm;
        private BunifuTileButton currentButton;
        private void OpenChildForm(Form childform, object btnSender)
        {

            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childform;
            childform.TopLevel = false;
            ActivateButton(btnSender);
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.dashboard.Controls.Add(childform);
            this.dashboard.Tag = childform;
            childform.BringToFront();
            childform.Show();
            LblBaslik.Text = childform.Text;

        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (BunifuTileButton)btnSender)
                {
                    DisableButton();

                    currentButton = (BunifuTileButton)btnSender;
                    currentButton.color = Color.FromArgb(39, 39, 120);

                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(BunifuTileButton))
                {

                    previousBtn.BackColor = Color.FromArgb(51, 51, 153);
                    previousBtn.ForeColor = Color.Gainsboro;
                   
                }
            }
        }


        private void Yonetici_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

            OpenChildForm(new Dashboard(), sender);


        }

        private void btnYoneticiler_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Yoneticiler(), sender);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Musteriler(), sender);
        }

        private void btnMusteriler_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Musteriler(), sender);
        }

        private void btnOperasyon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Operasyonlar(), sender);
        }

        private void btnTedarikciler_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Tedarikciler(), sender);
        }
    }
}
