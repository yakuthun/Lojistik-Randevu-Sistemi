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
    public partial class Tedarikci : Form
    {
        public Tedarikci()
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
                    currentButton.color = Color.FromArgb(35, 35, 38);

                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(BunifuTileButton))
                {

                    previousBtn.BackColor = Color.FromArgb(52, 53, 57);
                    //previousBtn.ForeColor = Color.Gainsboro;

                }
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dashboard(), sender);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TedarikciRandevuAl(), sender);
        }

        private void btnOnaylananlar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TedarikciOnaylananlar(), sender);
        }

        private void btnReddedilenler_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TedarikciReddedilenler(), sender);
        }

        private void btnOnayBekleyen_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TedarikciOnayBekleyen(), sender);
        }
    }

}
