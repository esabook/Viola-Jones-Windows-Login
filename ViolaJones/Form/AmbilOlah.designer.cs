namespace ViolaJones
{
    partial class AmbilOlah
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AmbilOlah));
			this.LV = new System.Windows.Forms.ListView();
			this.txtPWD = new System.Windows.Forms.TextBox();
			this.LbelNama = new System.Windows.Forms.Label();
			this.txtnama = new System.Windows.Forms.TextBox();
			this.LbelPwd = new System.Windows.Forms.Label();
			this.LbelImg = new System.Windows.Forms.Label();
			this.btnAmbil = new System.Windows.Forms.Button();
			this.txtpict = new System.Windows.Forms.NumericUpDown();
			this.process = new System.Diagnostics.Process();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnPin = new System.Windows.Forms.Button();
			this.btnImplLogin = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.CamImageBox = new Emgu.CV.UI.ImageBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.txtpict)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CamImageBox)).BeginInit();
			this.SuspendLayout();
			// 
			// LV
			// 
			this.LV.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.LV.FullRowSelect = true;
			this.LV.GridLines = true;
			this.LV.Location = new System.Drawing.Point(617, 39);
			this.LV.MultiSelect = false;
			this.LV.Name = "LV";
			this.LV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.LV.Size = new System.Drawing.Size(193, 225);
			this.LV.TabIndex = 71;
			this.LV.UseCompatibleStateImageBehavior = false;
			this.LV.View = System.Windows.Forms.View.Details;
			this.LV.SelectedIndexChanged += new System.EventHandler(this.LV_SelectedIndexChanged);
			this.LV.Click += new System.EventHandler(this.LV_SelectedIndexChanged);
			// 
			// txtPWD
			// 
			this.txtPWD.Location = new System.Drawing.Point(422, 66);
			this.txtPWD.Name = "txtPWD";
			this.txtPWD.PasswordChar = '*';
			this.txtPWD.Size = new System.Drawing.Size(189, 20);
			this.txtPWD.TabIndex = 64;
			// 
			// LbelNama
			// 
			this.LbelNama.AutoSize = true;
			this.LbelNama.Location = new System.Drawing.Point(336, 43);
			this.LbelNama.Name = "LbelNama";
			this.LbelNama.Size = new System.Drawing.Size(87, 13);
			this.LbelNama.TabIndex = 63;
			this.LbelNama.Text = "Nama Pengguna";
			// 
			// txtnama
			// 
			this.txtnama.Location = new System.Drawing.Point(422, 40);
			this.txtnama.Name = "txtnama";
			this.txtnama.Size = new System.Drawing.Size(189, 20);
			this.txtnama.TabIndex = 62;
			// 
			// LbelPwd
			// 
			this.LbelPwd.AutoSize = true;
			this.LbelPwd.Location = new System.Drawing.Point(336, 69);
			this.LbelPwd.Name = "LbelPwd";
			this.LbelPwd.Size = new System.Drawing.Size(62, 13);
			this.LbelPwd.TabIndex = 72;
			this.LbelPwd.Text = "Kode Kunci";
			// 
			// LbelImg
			// 
			this.LbelImg.AutoSize = true;
			this.LbelImg.Location = new System.Drawing.Point(354, 225);
			this.LbelImg.Name = "LbelImg";
			this.LbelImg.Size = new System.Drawing.Size(68, 13);
			this.LbelImg.TabIndex = 78;
			this.LbelImg.Text = "No. gambar :";
			// 
			// btnAmbil
			// 
			this.btnAmbil.Enabled = false;
			this.btnAmbil.Location = new System.Drawing.Point(448, 225);
			this.btnAmbil.Name = "btnAmbil";
			this.btnAmbil.Size = new System.Drawing.Size(163, 39);
			this.btnAmbil.TabIndex = 75;
			this.btnAmbil.Text = "&Tangkap gambar";
			this.btnAmbil.UseVisualStyleBackColor = true;
			this.btnAmbil.Click += new System.EventHandler(this.btnTangkapGambar_Click);
			// 
			// txtpict
			// 
			this.txtpict.Enabled = false;
			this.txtpict.Location = new System.Drawing.Point(357, 241);
			this.txtpict.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.txtpict.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.txtpict.Name = "txtpict";
			this.txtpict.Size = new System.Drawing.Size(82, 20);
			this.txtpict.TabIndex = 90;
			this.txtpict.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// process
			// 
			this.process.StartInfo.CreateNoWindow = true;
			this.process.StartInfo.Domain = "";
			this.process.StartInfo.FileName = "cmd.exe";
			this.process.StartInfo.LoadUserProfile = false;
			this.process.StartInfo.Password = null;
			this.process.StartInfo.RedirectStandardOutput = true;
			this.process.StartInfo.StandardErrorEncoding = null;
			this.process.StartInfo.StandardOutputEncoding = null;
			this.process.StartInfo.UserName = "";
			this.process.StartInfo.UseShellExecute = false;
			this.process.StartInfo.Verb = "runas";
			this.process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
			this.process.SynchronizingObject = this;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel1.Controls.Add(this.btnPin);
			this.panel1.Controls.Add(this.btnImplLogin);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.pictureBox3);
			this.panel1.Controls.Add(this.pictureBox5);
			this.panel1.Controls.Add(this.pictureBox4);
			this.panel1.Location = new System.Drawing.Point(-4, 309);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(822, 128);
			this.panel1.TabIndex = 92;
			// 
			// btnPin
			// 
			this.btnPin.BackColor = System.Drawing.Color.Transparent;
			this.btnPin.Enabled = false;
			this.btnPin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
			this.btnPin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnPin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPin.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnPin.Image = global::ViolaJones.Properties.Resources.unpin;
			this.btnPin.Location = new System.Drawing.Point(622, 5);
			this.btnPin.Name = "btnPin";
			this.btnPin.Size = new System.Drawing.Size(42, 39);
			this.btnPin.TabIndex = 93;
			this.toolTip.SetToolTip(this.btnPin, "Untuk menyabut program ini dari struktur sistem. \r\nDapat digunakan apabila hendak" +
        " menghapus program ini");
			this.btnPin.UseVisualStyleBackColor = true;
			this.btnPin.Visible = false;
			this.btnPin.Click += new System.EventHandler(this.btnPin_Click);
			// 
			// btnImplLogin
			// 
			this.btnImplLogin.Image = global::ViolaJones.Properties.Resources._lock;
			this.btnImplLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnImplLogin.Location = new System.Drawing.Point(621, 45);
			this.btnImplLogin.Name = "btnImplLogin";
			this.btnImplLogin.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.btnImplLogin.Size = new System.Drawing.Size(193, 39);
			this.btnImplLogin.TabIndex = 91;
			this.btnImplLogin.Text = "Pengunci aktif";
			this.btnImplLogin.UseVisualStyleBackColor = true;
			this.btnImplLogin.Click += new System.EventHandler(this.btnImplLogin_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.ErrorImage = null;
			this.pictureBox1.Location = new System.Drawing.Point(16, 14);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 100);
			this.pictureBox1.TabIndex = 85;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Visible = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox2.ErrorImage = null;
			this.pictureBox2.Location = new System.Drawing.Point(134, 14);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(100, 100);
			this.pictureBox2.TabIndex = 86;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Visible = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox3.ErrorImage = null;
			this.pictureBox3.Location = new System.Drawing.Point(251, 14);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(100, 100);
			this.pictureBox3.TabIndex = 87;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Visible = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox5.ErrorImage = null;
			this.pictureBox5.Location = new System.Drawing.Point(485, 14);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(100, 100);
			this.pictureBox5.TabIndex = 89;
			this.pictureBox5.TabStop = false;
			this.pictureBox5.Visible = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox4.ErrorImage = null;
			this.pictureBox4.Location = new System.Drawing.Point(368, 14);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(100, 100);
			this.pictureBox4.TabIndex = 88;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Visible = false;
			// 
			// CamImageBox
			// 
			this.CamImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.CamImageBox.Enabled = false;
			this.CamImageBox.Location = new System.Drawing.Point(11, 39);
			this.CamImageBox.Margin = new System.Windows.Forms.Padding(2);
			this.CamImageBox.Name = "CamImageBox";
			this.CamImageBox.Size = new System.Drawing.Size(320, 240);
			this.CamImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.CamImageBox.TabIndex = 74;
			this.CamImageBox.TabStop = false;
			// 
			// btnExit
			// 
			this.btnExit.Image = global::ViolaJones.Properties.Resources.info;
			this.btnExit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnExit.Location = new System.Drawing.Point(533, 148);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(78, 39);
			this.btnExit.TabIndex = 70;
			this.btnExit.Text = "&Keluar";
			this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnKeluarClick);
			// 
			// btnCancel
			// 
			this.btnCancel.Image = global::ViolaJones.Properties.Resources.cancel;
			this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnCancel.Location = new System.Drawing.Point(445, 148);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(82, 39);
			this.btnCancel.TabIndex = 69;
			this.btnCancel.Text = "&Batal";
			this.btnCancel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Image = global::ViolaJones.Properties.Resources.save;
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnSave.Location = new System.Drawing.Point(354, 148);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(85, 39);
			this.btnSave.TabIndex = 68;
			this.btnSave.Text = "&Simpan";
			this.btnSave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSimpan_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Image = global::ViolaJones.Properties.Resources.warning;
			this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnDelete.Location = new System.Drawing.Point(533, 102);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(78, 40);
			this.btnDelete.TabIndex = 67;
			this.btnDelete.Text = "&Hapus";
			this.btnDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnHapus_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Image = global::ViolaJones.Properties.Resources.lup;
			this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnEdit.Location = new System.Drawing.Point(445, 102);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(82, 40);
			this.btnEdit.TabIndex = 66;
			this.btnEdit.Text = "&Ubah";
			this.btnEdit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.btnUbah_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Image = global::ViolaJones.Properties.Resources.add;
			this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnAdd.Location = new System.Drawing.Point(354, 102);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(85, 40);
			this.btnAdd.TabIndex = 65;
			this.btnAdd.Text = "&Tambah";
			this.btnAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnTambah_Click);
			// 
			// toolTip
			// 
			this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.toolTip.ToolTipTitle = "Info";
			// 
			// AmbilOlah
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ClientSize = new System.Drawing.Size(814, 449);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.txtpict);
			this.Controls.Add(this.LbelImg);
			this.Controls.Add(this.btnAmbil);
			this.Controls.Add(this.CamImageBox);
			this.Controls.Add(this.LbelPwd);
			this.Controls.Add(this.LV);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtPWD);
			this.Controls.Add(this.LbelNama);
			this.Controls.Add(this.txtnama);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "AmbilOlah";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ambil-Olah";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPengguna_X);
			this.Load += new System.EventHandler(this.Pengguna_Load);
			((System.ComponentModel.ISupportInitialize)(this.txtpict)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CamImageBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ListView LV;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnEdit;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.TextBox txtPWD;
        internal System.Windows.Forms.Label LbelNama;
		internal System.Windows.Forms.TextBox txtnama;
        internal System.Windows.Forms.Label LbelPwd;
		private System.Windows.Forms.Label LbelImg;
        private System.Windows.Forms.Button btnAmbil;
		private Emgu.CV.UI.ImageBox CamImageBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.NumericUpDown txtpict;
		private System.Windows.Forms.Button btnImplLogin;
		private System.Diagnostics.Process process;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnPin;
		private System.Windows.Forms.ToolTip toolTip;

    }
}