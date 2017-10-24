namespace ViolaJones
{
	partial class VerifikasiPwd
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
			this.txtPWD = new System.Windows.Forms.TextBox();
			this.btnMasuk = new System.Windows.Forms.Button();
			this.btnBatal = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtPWD
			// 
			this.txtPWD.Location = new System.Drawing.Point(46, 52);
			this.txtPWD.Name = "txtPWD";
			this.txtPWD.Size = new System.Drawing.Size(241, 20);
			this.txtPWD.TabIndex = 0;
			this.txtPWD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKey);
			// 
			// btnMasuk
			// 
			this.btnMasuk.Location = new System.Drawing.Point(109, 92);
			this.btnMasuk.Name = "btnMasuk";
			this.btnMasuk.Size = new System.Drawing.Size(87, 38);
			this.btnMasuk.TabIndex = 1;
			this.btnMasuk.Text = "Masuk";
			this.btnMasuk.UseVisualStyleBackColor = true;
			this.btnMasuk.Click += new System.EventHandler(this.btnMasuk_Click);
			// 
			// btnBatal
			// 
			this.btnBatal.Location = new System.Drawing.Point(202, 92);
			this.btnBatal.Name = "btnBatal";
			this.btnBatal.Size = new System.Drawing.Size(85, 38);
			this.btnBatal.TabIndex = 2;
			this.btnBatal.Text = "Batal";
			this.btnBatal.UseVisualStyleBackColor = true;
			this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(43, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(115, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Masukkan Kode Kunci";
			// 
			// VerifikasiPwd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(335, 142);
			this.ControlBox = false;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnBatal);
			this.Controls.Add(this.btnMasuk);
			this.Controls.Add(this.txtPWD);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "VerifikasiPwd";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Verifikasi Kode Kunci";
			this.Load += new System.EventHandler(this.VerifikasiPwd_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtPWD;
		private System.Windows.Forms.Button btnMasuk;
		private System.Windows.Forms.Button btnBatal;
		private System.Windows.Forms.Label label1;

	}
}