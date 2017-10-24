namespace ViolaJones
{
	partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.TxtUname = new System.Windows.Forms.TextBox();
            this.Txtpwd = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.BtnBatal = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnMasuk = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtUname
            // 
            this.TxtUname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUname.Location = new System.Drawing.Point(181, 48);
            this.TxtUname.Name = "TxtUname";
            this.TxtUname.Size = new System.Drawing.Size(143, 24);
            this.TxtUname.TabIndex = 1;
            this.TxtUname.Text = "testlagi";
            this.TxtUname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKey);
            // 
            // Txtpwd
            // 
            this.Txtpwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtpwd.Location = new System.Drawing.Point(181, 116);
            this.Txtpwd.Name = "Txtpwd";
            this.Txtpwd.PasswordChar = '●';
            this.Txtpwd.Size = new System.Drawing.Size(143, 26);
            this.Txtpwd.TabIndex = 2;
            this.Txtpwd.Text = "12345";
            this.Txtpwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKey);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Navy;
            this.Label1.Location = new System.Drawing.Point(180, 93);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(89, 20);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Kode Kunci";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnBatal
            // 
            this.BtnBatal.Location = new System.Drawing.Point(202, 179);
            this.BtnBatal.Name = "BtnBatal";
            this.BtnBatal.Size = new System.Drawing.Size(108, 36);
            this.BtnBatal.TabIndex = 4;
            this.BtnBatal.Text = "&Batal";
            this.BtnBatal.UseVisualStyleBackColor = true;
            this.BtnBatal.Click += new System.EventHandler(this.BtnBatal_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.GroupBox1.Controls.Add(this.PictureBox1);
            this.GroupBox1.Controls.Add(this.BtnMasuk);
            this.GroupBox1.Controls.Add(this.BtnBatal);
            this.GroupBox1.Controls.Add(this.TxtUname);
            this.GroupBox1.Controls.Add(this.Txtpwd);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(401, 243);
            this.GroupBox1.TabIndex = 6;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Login";
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(74, 25);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(91, 122);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 28;
            this.PictureBox1.TabStop = false;
            // 
            // BtnMasuk
            // 
            this.BtnMasuk.Location = new System.Drawing.Point(85, 179);
            this.BtnMasuk.Name = "BtnMasuk";
            this.BtnMasuk.Size = new System.Drawing.Size(111, 36);
            this.BtnMasuk.TabIndex = 3;
            this.BtnMasuk.Text = "&Masuk";
            this.BtnMasuk.UseVisualStyleBackColor = true;
            this.BtnMasuk.Click += new System.EventHandler(this.BtnMasuk_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Navy;
            this.Label2.Location = new System.Drawing.Point(180, 25);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(128, 20);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Nama Pengguna";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(427, 267);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKey);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		internal System.Windows.Forms.PictureBox PictureBox1;
		internal System.Windows.Forms.TextBox TxtUname;
		internal System.Windows.Forms.TextBox Txtpwd;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Button BtnBatal;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Button BtnMasuk;
		internal System.Windows.Forms.Label Label2;
	}
}