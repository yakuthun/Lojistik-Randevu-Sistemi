
namespace Lojistik_Randevu_Sistemi
{
    partial class Musteri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Musteri));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnTedarikciler = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnReddedilenler = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnOnayBekleyen = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnOnaylananlar = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnDashboard = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dashboard = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.LblBaslik = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.dashboard.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(113, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(599, 445);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnTedarikciler);
            this.panel1.Controls.Add(this.btnReddedilenler);
            this.panel1.Controls.Add(this.btnOnayBekleyen);
            this.panel1.Controls.Add(this.btnOnaylananlar);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 585);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(224, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btnTedarikciler
            // 
            this.btnTedarikciler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnTedarikciler.color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnTedarikciler.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(180)))), ((int)(((byte)(85)))));
            this.btnTedarikciler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTedarikciler.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnTedarikciler.ForeColor = System.Drawing.Color.White;
            this.btnTedarikciler.Image = ((System.Drawing.Image)(resources.GetObject("btnTedarikciler.Image")));
            this.btnTedarikciler.ImagePosition = 5;
            this.btnTedarikciler.ImageZoom = 20;
            this.btnTedarikciler.LabelPosition = 41;
            this.btnTedarikciler.LabelText = "Tedarikçi Girişi";
            this.btnTedarikciler.Location = new System.Drawing.Point(0, 200);
            this.btnTedarikciler.Margin = new System.Windows.Forms.Padding(6);
            this.btnTedarikciler.Name = "btnTedarikciler";
            this.btnTedarikciler.Size = new System.Drawing.Size(224, 86);
            this.btnTedarikciler.TabIndex = 10;
            this.btnTedarikciler.Click += new System.EventHandler(this.btnTedarikciler_Click);
            // 
            // btnReddedilenler
            // 
            this.btnReddedilenler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnReddedilenler.color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnReddedilenler.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(180)))), ((int)(((byte)(85)))));
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
            this.btnReddedilenler.Click += new System.EventHandler(this.btnReddedilenler_Click);
            // 
            // btnOnayBekleyen
            // 
            this.btnOnayBekleyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnOnayBekleyen.color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnOnayBekleyen.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(180)))), ((int)(((byte)(85)))));
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
            this.btnOnayBekleyen.Click += new System.EventHandler(this.btnOnayBekleyen_Click);
            // 
            // btnOnaylananlar
            // 
            this.btnOnaylananlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnOnaylananlar.color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnOnaylananlar.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(180)))), ((int)(((byte)(85)))));
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
            this.btnOnaylananlar.Click += new System.EventHandler(this.btnOnaylananlar_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnDashboard.color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnDashboard.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(180)))), ((int)(((byte)(85)))));
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
            // dashboard
            // 
            this.dashboard.BackColor = System.Drawing.Color.White;
            this.dashboard.Controls.Add(this.pictureBox1);
            this.dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dashboard.Location = new System.Drawing.Point(224, 39);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(803, 546);
            this.dashboard.TabIndex = 5;
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
            this.bunifuImageButton1.Location = new System.Drawing.Point(768, 4);
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
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // LblBaslik
            // 
            this.LblBaslik.AutoSize = true;
            this.LblBaslik.Font = new System.Drawing.Font("Netflix Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBaslik.ForeColor = System.Drawing.Color.White;
            this.LblBaslik.Location = new System.Drawing.Point(8, 8);
            this.LblBaslik.Name = "LblBaslik";
            this.LblBaslik.Size = new System.Drawing.Size(138, 24);
            this.LblBaslik.TabIndex = 8;
            this.LblBaslik.Text = "Müşteri Paneli";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel2.Controls.Add(this.bunifuImageButton1);
            this.panel2.Controls.Add(this.LblBaslik);
            this.panel2.Location = new System.Drawing.Point(224, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(803, 41);
            this.panel2.TabIndex = 4;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel2;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Musteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 585);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dashboard);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Musteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musteri";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.dashboard.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuTileButton btnTedarikciler;
        private Bunifu.Framework.UI.BunifuTileButton btnReddedilenler;
        private Bunifu.Framework.UI.BunifuTileButton btnOnayBekleyen;
        private Bunifu.Framework.UI.BunifuTileButton btnOnaylananlar;
        private Bunifu.Framework.UI.BunifuTileButton btnDashboard;
        private System.Windows.Forms.Panel dashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label LblBaslik;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}