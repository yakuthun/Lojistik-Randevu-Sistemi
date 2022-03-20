
namespace Lojistik_Randevu_Sistemi
{
    partial class Tedarikci
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tedarikci));
            this.dashboard = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRandevuAl = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnReddedilenler = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnOnayBekleyen = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnOnaylananlar = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnDashboard = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.LblBaslik = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashboard
            // 
            this.dashboard.BackColor = System.Drawing.Color.White;
            this.dashboard.Controls.Add(this.pictureBox1);
            this.dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dashboard.Location = new System.Drawing.Point(224, 37);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(803, 546);
            this.dashboard.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 600);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnRandevuAl);
            this.panel1.Controls.Add(this.btnReddedilenler);
            this.panel1.Controls.Add(this.btnOnayBekleyen);
            this.panel1.Controls.Add(this.btnOnaylananlar);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 585);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(79)))), ((int)(((byte)(244)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(224, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btnRandevuAl
            // 
            this.btnRandevuAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            this.btnRandevuAl.color = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            this.btnRandevuAl.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.btnRandevuAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRandevuAl.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnRandevuAl.ForeColor = System.Drawing.Color.White;
            this.btnRandevuAl.Image = ((System.Drawing.Image)(resources.GetObject("btnRandevuAl.Image")));
            this.btnRandevuAl.ImagePosition = 0;
            this.btnRandevuAl.ImageZoom = 25;
            this.btnRandevuAl.LabelPosition = 41;
            this.btnRandevuAl.LabelText = "Randevu Al";
            this.btnRandevuAl.Location = new System.Drawing.Point(0, 200);
            this.btnRandevuAl.Margin = new System.Windows.Forms.Padding(6);
            this.btnRandevuAl.Name = "btnRandevuAl";
            this.btnRandevuAl.Size = new System.Drawing.Size(224, 86);
            this.btnRandevuAl.TabIndex = 10;
            this.btnRandevuAl.Click += new System.EventHandler(this.btnRandevuAl_Click);
            // 
            // btnReddedilenler
            // 
            this.btnReddedilenler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            this.btnReddedilenler.color = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            this.btnReddedilenler.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.btnReddedilenler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReddedilenler.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnReddedilenler.ForeColor = System.Drawing.Color.White;
            this.btnReddedilenler.Image = ((System.Drawing.Image)(resources.GetObject("btnReddedilenler.Image")));
            this.btnReddedilenler.ImagePosition = 0;
            this.btnReddedilenler.ImageZoom = 25;
            this.btnReddedilenler.LabelPosition = 41;
            this.btnReddedilenler.LabelText = "Reddedilenler";
            this.btnReddedilenler.Location = new System.Drawing.Point(0, 484);
            this.btnReddedilenler.Margin = new System.Windows.Forms.Padding(6);
            this.btnReddedilenler.Name = "btnReddedilenler";
            this.btnReddedilenler.Size = new System.Drawing.Size(224, 86);
            this.btnReddedilenler.TabIndex = 9;
            // 
            // btnOnayBekleyen
            // 
            this.btnOnayBekleyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            this.btnOnayBekleyen.color = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            this.btnOnayBekleyen.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.btnOnayBekleyen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOnayBekleyen.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnOnayBekleyen.ForeColor = System.Drawing.Color.White;
            this.btnOnayBekleyen.Image = ((System.Drawing.Image)(resources.GetObject("btnOnayBekleyen.Image")));
            this.btnOnayBekleyen.ImagePosition = 0;
            this.btnOnayBekleyen.ImageZoom = 25;
            this.btnOnayBekleyen.LabelPosition = 41;
            this.btnOnayBekleyen.LabelText = "Onay Bekleyen";
            this.btnOnayBekleyen.Location = new System.Drawing.Point(0, 298);
            this.btnOnayBekleyen.Margin = new System.Windows.Forms.Padding(6);
            this.btnOnayBekleyen.Name = "btnOnayBekleyen";
            this.btnOnayBekleyen.Size = new System.Drawing.Size(224, 86);
            this.btnOnayBekleyen.TabIndex = 8;
            // 
            // btnOnaylananlar
            // 
            this.btnOnaylananlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            this.btnOnaylananlar.color = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            this.btnOnaylananlar.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.btnOnaylananlar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOnaylananlar.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnOnaylananlar.ForeColor = System.Drawing.Color.White;
            this.btnOnaylananlar.Image = ((System.Drawing.Image)(resources.GetObject("btnOnaylananlar.Image")));
            this.btnOnaylananlar.ImagePosition = 1;
            this.btnOnaylananlar.ImageZoom = 25;
            this.btnOnaylananlar.LabelPosition = 41;
            this.btnOnaylananlar.LabelText = "Onaylananlar";
            this.btnOnaylananlar.Location = new System.Drawing.Point(0, 396);
            this.btnOnaylananlar.Margin = new System.Windows.Forms.Padding(6);
            this.btnOnaylananlar.Name = "btnOnaylananlar";
            this.btnOnaylananlar.Size = new System.Drawing.Size(224, 86);
            this.btnOnaylananlar.TabIndex = 7;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            this.btnDashboard.color = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            this.btnDashboard.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImagePosition = 5;
            this.btnDashboard.ImageZoom = 17;
            this.btnDashboard.LabelPosition = 41;
            this.btnDashboard.LabelText = "Dashboard";
            this.btnDashboard.Location = new System.Drawing.Point(0, 102);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(6);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(224, 86);
            this.btnDashboard.TabIndex = 6;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowToggling = false;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.AllowZoomingOnFocus = false;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 0;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(29, 29);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(30, 30);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(778, 7);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(30, 30);
            this.bunifuImageButton1.TabIndex = 9;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 0;
            this.bunifuImageButton1.ZoomSpeed = 10;
            // 
            // LblBaslik
            // 
            this.LblBaslik.AutoSize = true;
            this.LblBaslik.Font = new System.Drawing.Font("Netflix Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBaslik.ForeColor = System.Drawing.Color.White;
            this.LblBaslik.Location = new System.Drawing.Point(20, 11);
            this.LblBaslik.Name = "LblBaslik";
            this.LblBaslik.Size = new System.Drawing.Size(152, 24);
            this.LblBaslik.TabIndex = 8;
            this.LblBaslik.Text = "Tedarikçi Paneli";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(101)))), ((int)(((byte)(175)))));
            this.panel2.Controls.Add(this.bunifuImageButton1);
            this.panel2.Controls.Add(this.LblBaslik);
            this.panel2.Location = new System.Drawing.Point(207, -4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(826, 41);
            this.panel2.TabIndex = 7;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel2;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Tedarikci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 585);
            this.Controls.Add(this.dashboard);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tedarikci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tedarikci";
            this.dashboard.ResumeLayout(false);
            this.dashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuTileButton btnRandevuAl;
        private Bunifu.Framework.UI.BunifuTileButton btnReddedilenler;
        private Bunifu.Framework.UI.BunifuTileButton btnOnayBekleyen;
        private Bunifu.Framework.UI.BunifuTileButton btnOnaylananlar;
        private Bunifu.Framework.UI.BunifuTileButton btnDashboard;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label LblBaslik;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}