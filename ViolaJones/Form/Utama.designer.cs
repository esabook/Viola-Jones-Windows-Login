namespace ViolaJones
{
    partial class Utama
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Utama));
			this.PenggunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuOlahDataWajah = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuUjiDeteksiWajah = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.MenuKeluar = new System.Windows.Forms.ToolStripMenuItem();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.MenuStr = new System.Windows.Forms.MenuStrip();
			this.MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItemAODW = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuUDW = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.MenuKlr = new System.Windows.Forms.ToolStripMenuItem();
			this.PictureBox3 = new System.Windows.Forms.PictureBox();
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.MenuStr.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// PenggunaToolStripMenuItem
			// 
			this.PenggunaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuOlahDataWajah,
            this.MenuUjiDeteksiWajah,
            this.toolStripSeparator1,
            this.MenuKeluar});
			this.PenggunaToolStripMenuItem.Name = "PenggunaToolStripMenuItem";
			this.PenggunaToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
			this.PenggunaToolStripMenuItem.Text = "Menu";
			// 
			// MenuOlahDataWajah
			// 
			this.MenuOlahDataWajah.Name = "MenuOlahDataWajah";
			this.MenuOlahDataWajah.Size = new System.Drawing.Size(214, 22);
			this.MenuOlahDataWajah.Text = "Ambil dan Olah data wajah";
			this.MenuOlahDataWajah.Click += new System.EventHandler(this.ambilOlahWajah_Click);
			// 
			// MenuUjiDeteksiWajah
			// 
			this.MenuUjiDeteksiWajah.Name = "MenuUjiDeteksiWajah";
			this.MenuUjiDeteksiWajah.Size = new System.Drawing.Size(214, 22);
			this.MenuUjiDeteksiWajah.Text = "Uji deteksi wajah";
			this.MenuUjiDeteksiWajah.Click += new System.EventHandler(this.detesiWajah_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(211, 6);
			// 
			// MenuKeluar
			// 
			this.MenuKeluar.Name = "MenuKeluar";
			this.MenuKeluar.Size = new System.Drawing.Size(214, 22);
			this.MenuKeluar.Text = "Keluar";
			this.MenuKeluar.Click += new System.EventHandler(this.menukeluar_Click);
			// 
			// Label1
			// 
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label1.ForeColor = System.Drawing.Color.Maroon;
			this.Label1.Location = new System.Drawing.Point(0, 92);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(963, 29);
			this.Label1.TabIndex = 32;
			this.Label1.Text = "Identifikasi Wajah Menggunakan Metode Viola Jones";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Label2
			// 
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label2.ForeColor = System.Drawing.Color.Maroon;
			this.Label2.Location = new System.Drawing.Point(0, 62);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(963, 29);
			this.Label2.TabIndex = 31;
			this.Label2.Text = "Selamat Datang di Halaman Utama";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// MenuStr
			// 
			this.MenuStr.BackColor = System.Drawing.Color.SlateGray;
			this.MenuStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MenuStr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem});
			this.MenuStr.Location = new System.Drawing.Point(0, 0);
			this.MenuStr.Name = "MenuStr";
			this.MenuStr.Size = new System.Drawing.Size(963, 24);
			this.MenuStr.TabIndex = 33;
			this.MenuStr.Text = "Menu";
			// 
			// MenuItem
			// 
			this.MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAODW,
            this.MenuUDW,
            this.toolStripSeparator2,
            this.MenuKlr});
			this.MenuItem.ImageTransparentColor = System.Drawing.Color.Silver;
			this.MenuItem.Name = "MenuItem";
			this.MenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
			this.MenuItem.Size = new System.Drawing.Size(46, 20);
			this.MenuItem.Text = "Menu";
			// 
			// MenuItemAODW
			// 
			this.MenuItemAODW.BackColor = System.Drawing.Color.Transparent;
			this.MenuItemAODW.Name = "MenuItemAODW";
			this.MenuItemAODW.Size = new System.Drawing.Size(198, 22);
			this.MenuItemAODW.Text = "Ambil dan olah data wajah";
			this.MenuItemAODW.ToolTipText = "Klik untuk membuka halaman pengolahan database dan pengaturan pengunci";
			this.MenuItemAODW.Click += new System.EventHandler(this.ambilOlahWajah_Click);
			// 
			// MenuUDW
			// 
			this.MenuUDW.BackColor = System.Drawing.Color.Transparent;
			this.MenuUDW.Name = "MenuUDW";
			this.MenuUDW.Size = new System.Drawing.Size(198, 22);
			this.MenuUDW.Text = "Uji deteksi wajah";
			this.MenuUDW.ToolTipText = "Klik untuk melihat pratinjau tampilan pengunci";
			this.MenuUDW.Click += new System.EventHandler(this.detesiWajah_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.BackColor = System.Drawing.Color.SlateGray;
			this.toolStripSeparator2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(195, 6);
			// 
			// MenuKlr
			// 
			this.MenuKlr.BackColor = System.Drawing.Color.Transparent;
			this.MenuKlr.Name = "MenuKlr";
			this.MenuKlr.Size = new System.Drawing.Size(198, 22);
			this.MenuKlr.Text = "Keluar";
			this.MenuKlr.Click += new System.EventHandler(this.menukeluar_Click);
			// 
			// PictureBox3
			// 
			this.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox3.Image")));
			this.PictureBox3.Location = new System.Drawing.Point(667, 199);
			this.PictureBox3.Name = "PictureBox3";
			this.PictureBox3.Size = new System.Drawing.Size(312, 293);
			this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBox3.TabIndex = 35;
			this.PictureBox3.TabStop = false;
			// 
			// PictureBox1
			// 
			this.PictureBox1.BackColor = System.Drawing.SystemColors.Info;
			this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
			this.PictureBox1.Location = new System.Drawing.Point(0, 199);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(661, 293);
			this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PictureBox1.TabIndex = 34;
			this.PictureBox1.TabStop = false;
			// 
			// Utama
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ClientSize = new System.Drawing.Size(963, 491);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.PictureBox3);
			this.Controls.Add(this.MenuStr);
			this.Controls.Add(this.PictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.MenuStr;
			this.MaximizeBox = false;
			this.Name = "Utama";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Utama";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formKeluar);
			this.MenuStr.ResumeLayout(false);
			this.MenuStr.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStripMenuItem PenggunaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem MenuOlahDataWajah;
        private System.Windows.Forms.ToolStripMenuItem MenuUjiDeteksiWajah;
        private System.Windows.Forms.ToolStripMenuItem MenuKeluar;
        internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.PictureBox PictureBox3;
        internal System.Windows.Forms.MenuStrip MenuStr;
		internal System.Windows.Forms.PictureBox PictureBox1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem MenuItem;
		private System.Windows.Forms.ToolStripMenuItem MenuItemAODW;
		private System.Windows.Forms.ToolStripMenuItem MenuUDW;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem MenuKlr;
    }
}