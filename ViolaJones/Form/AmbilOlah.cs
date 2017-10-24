using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Data.OleDb;
using Microsoft.Win32;
using System.Threading;
using System.Security.Principal;


namespace ViolaJones
{
    public partial class AmbilOlah : Form
    {
        Image<Bgr, Byte> frameByte;
        Capture ambilGambar = new Capture();
		HaarCascade muka = new HaarCascade(Application.StartupPath+"\\haarcascade_mukadepan.xml");
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        Image<Gray, byte> result=null, TrainedFace = null, gray = null;
		List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>(5);

        OleDbConnection koneksiDB = new OleDbConnection(KendaliParameter.urlDatabase);
		OleDbDataAdapter dBAdapter;

        public string str, myqry, hasilPerintahShell;
		public bool deteksi, lockWorksation;
		int iterasiTombolPengaturKunci;


        public AmbilOlah()
        {
            InitializeComponent();
			
        }
		public void AturListView()
        {
	        var _with1 = LV.Columns;
	        _with1.Add("Nama", LV.Size.Width-5, HorizontalAlignment.Left);
        }
	    public void IsiListView()
	   {
			LV.Items.Clear();
			dBAdapter = new OleDbDataAdapter("SELECT nama from Akun", koneksiDB);
			OleDbCommandBuilder CommandBuilder = new OleDbCommandBuilder(dBAdapter);
			DataTable TSSame = new DataTable();


			dBAdapter.Fill(TSSame);
			foreach (DataRow row in TSSame.Rows)
			{
					ListViewItem item = new ListViewItem(row[0].ToString());
					LV.Items.Add(item);
			}
			SorotLV();
		}

		private void SorotLV()
		{
			for (int i = 0; i < LV.Items.Count; i++)
			{
				if (LV.Items[i].Text == KendaliParameter.akunAktif)
				{
					LV.Items[i].Selected = true;
					LV.Select();
					break;
				}
			}
		}

        public void KondisiAwalData()
        {
	        btnAdd.Enabled = true;
	        btnEdit.Enabled = true;
	        btnDelete.Enabled = true;
	        btnExit.Enabled = true;
	        btnSave.Enabled = false;
	        btnCancel.Enabled = false;
            txtnama.Enabled = false;
            txtPWD.Enabled = false;
	        LV.Enabled = true;
        }
        public void KondisiTambahData()
        {
	        btnAdd.Enabled = false;
	        btnEdit.Enabled = false;
	        btnDelete.Enabled = false;
	        btnExit.Enabled = false;
	        btnSave.Enabled = true;
	        btnCancel.Enabled = true;
            txtnama.Enabled = true;
            txtPWD.Enabled = true;

	        LV.Enabled = false;
        }
        public void SembunyiKotakGbr(bool bol)
        {
			pictureBox1.Image = null;
			pictureBox2.Image = null;
			pictureBox3.Image = null;
			pictureBox4.Image = null;
			pictureBox5.Image = null;
            pictureBox1.Visible = !bol;
            pictureBox2.Visible = !bol;
            pictureBox3.Visible = !bol;
            pictureBox4.Visible = !bol;
			pictureBox5.Visible = !bol;
        }
        private void kosongkan()
        {
            txtPWD.Clear();
            txtnama.Clear();
			trainingImages.Clear();
        }


        private void Pengguna_Load(object sender, EventArgs e)
        {
			process.StartInfo.WorkingDirectory = KendaliParameter.system;
			koneksiDB.Open();
            AturListView();
            IsiListView();
            KondisiAwalData();
			InisialisasiKamera(false, false);
			CekSbgLockWindows();
        }

		
        private void btnKeluarClick(object sender, EventArgs e)
        {
			selesai();
			
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
			InisialisasiKamera(false, false);
			
			KondisiAwalData();
            kosongkan();
            btnAmbil.Enabled = false;
			txtpict.Enabled = false;
            SembunyiKotakGbr(true);
			LV_SelectedIndexChanged(sender, e);
            
        }
        private void btnTambah_Click(object sender, EventArgs e)
        {
			
			str = "add";
			txtpict.Value = 1;
            KondisiTambahData();
            kosongkan();
            btnAmbil.Enabled = true;
			txtpict.Enabled = false;
			btnSave.Enabled = false;
			for (int i = 0; i <=5; i++)
			{
				trainingImages.Add(new Image<Gray, byte>(100,100, new Gray(100)));
			}
			RefreshGambar();
			InisialisasiKamera(true, true);
			SembunyiKotakGbr(false);
        }
        private void btnUbah_Click(object sender, EventArgs e)
        {
			txtpict.Value = 1;
			if (string.IsNullOrEmpty(txtnama.Text))
            {
                MessageBox.Show("Silakan pilih akun untuk mengubahnya", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
				
                str = "edit";
                KondisiTambahData();
				InisialisasiKamera(true, true);
             
                btnAmbil.Enabled = true;
				txtpict.Enabled = true;
				SembunyiKotakGbr(false);
				for (int i = 1; i <= 5; i++)
				{
					if (File.Exists(Application.StartupPath + "/gambar/" + txtnama.Text + i + ".bmp"))
					{
						TrainedFace = new Image<Gray, byte>(Application.StartupPath + "/gambar/" + txtnama.Text + i + ".bmp");
						trainingImages.Add(TrainedFace);
					}
					else {
						trainingImages.Add(new Image<Gray, byte>(100,100, new Gray(100)));
					}
					
				}
            }
			RefreshGambar();
        }
        private void btnHapus_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtnama.Text))
            {
                MessageBox.Show("Silakan pilih akun untuk menghapusnya", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                DialogResult dialogResult = MessageBox.Show("Apakah yakin akan menghapus akun?", "Hapus", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
					try
					{
						koneksiDB.Open();
					}
					catch { }
                    myqry = "DELETE FROM Akun WHERE nama = '" + txtnama.Text + "'";
					OleDbCommand insert = new OleDbCommand(myqry, koneksiDB);
                    insert.ExecuteNonQuery();

                    for (int i = 1; i <=5 ; i++)
                    {
                        string curFile = Application.StartupPath + "/gambar/" + txtnama.Text+ i + ".bmp";
                        if (File.Exists(curFile))
                        {
							try
							{
								File.Delete(curFile);
							}
							catch { MessageBox.Show("Maaf, aplikasi gagal menghapus simpanan gambarnya."); }
                          
                        }
                    }

                    IsiListView();
                    kosongkan();
					InisialisasiKamera(false, false);
                    btnAmbil.Enabled = false;
                }
                else if (dialogResult == DialogResult.No)
                {
                    IsiListView();
                    kosongkan();
					InisialisasiKamera(false, false);
                    btnAmbil.Enabled = false;
                    
                }
				CekSbgLockWindows();
                
            }
        }

		public void InisialisasiKamera(bool kondisi, bool detektor)
		{
			deteksi = detektor;
			if (kondisi)
			{
				if (ambilGambar!=null)
				{
					ambilGambar.Dispose();
				}
				
				ambilGambar = new Capture();
				Application.Idle -= new EventHandler(StreamFrameKamera);
				Application.Idle += new EventHandler(StreamFrameKamera);
			}
			else {
				if (ambilGambar!=null)
				{
					ambilGambar.Dispose();
					CamImageBox.Image = null;
					Application.Idle -= new EventHandler(StreamFrameKamera);
				}
				
			}

			

			
		}

        private int totalAkun(string ns)
        {

			dBAdapter = new OleDbDataAdapter("select nama from Akun where nama='" + ns + "' ", koneksiDB);
			OleDbCommandBuilder CommandBuilder = new OleDbCommandBuilder(dBAdapter);
            DataTable TSSame = new DataTable();
            dBAdapter.Fill(TSSame);
           
			return TSSame.Rows.Count;

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (str == "add")
            {
                ///tambah record
                if (string.IsNullOrEmpty(txtnama.Text) | string.IsNullOrEmpty(txtPWD.Text))
                {
                    MessageBox.Show("Silakan lengkapi kotak isian", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int akun =  totalAkun(txtnama.Text);
                    if (akun !=0)
                    {
                        MessageBox.Show("Nama akun telah terpakai", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
						try
						{
							koneksiDB.Open();
						}
						catch { }
						
						myqry = "INSERT INTO Akun (nama, passkode) VALUES('" + txtnama.Text + "','" + txtPWD.Text + "')";
						
						OleDbCommand insert = new OleDbCommand(myqry, koneksiDB);
					
						int rowsAffected = insert.ExecuteNonQuery();

					    simpan();
                        KondisiAwalData();
						SembunyiKotakGbr(true);
						InisialisasiKamera(false, false);
                    }
                    
                }

            }
            else
            {
                ///perbarui record
                if (string.IsNullOrEmpty(txtPWD.Text) | string.IsNullOrEmpty(txtnama.Text))
                {
					MessageBox.Show("Silakan lengkapi kotak isian", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    myqry = "UPDATE Akun SET ";
                    myqry = myqry + " passkode = '" + txtPWD.Text + "', nama='"+ txtnama.Text + "'";
                    myqry = myqry + " WHERE ";
                    myqry = myqry + " nama = '" + txtnama.Text + "'";

					OleDbCommand insert = new OleDbCommand(myqry, koneksiDB);
					int rowsAffected = insert.ExecuteNonQuery();
					simpan();
                    KondisiAwalData();
					SembunyiKotakGbr(true);
					InisialisasiKamera(false, false);
                }
            }
            IsiListView();
            kosongkan();
            txtnama.Enabled = true;
            btnAmbil.Enabled = false;
			txtpict.Enabled = false;
			SorotLV();
			LV_SelectedIndexChanged(sender, e);
        }

		private void simpan()
		{
			Directory.CreateDirectory(Application.StartupPath + "\\gambar");
			try
			{
				for (int i = 1; i <= 5; i++)
				{
					string file = Application.StartupPath + "/gambar/" + txtnama.Text + i + ".bmp";
					if (File.Exists(file))
					{

						File.Delete(file);
					}
					trainingImages.ToArray()[i - 1].Save(file);
				}

			}
			catch { }
			
		}

        private void LV_SelectedIndexChanged(object sender, EventArgs e)
        {
			
			if (LV.SelectedItems.Count > 0)
				{
				
					ListViewItem item = LV.SelectedItems[0];

					dBAdapter = new OleDbDataAdapter("select passkode from Akun where nama='" + item.SubItems[0].Text + "' ", koneksiDB);
					OleDbCommandBuilder CommandBuilder = new OleDbCommandBuilder(dBAdapter);
					DataTable TSSame = new DataTable();
					dBAdapter.Fill(TSSame);
				    verifikasi(item.SubItems[0].Text);
					KendaliParameter.akunTmp = item.SubItems[0].Text;
					
					if (!KendaliParameter.verifikasi)
					{
						VerifikasiPwd pwd = new VerifikasiPwd();
						btnEdit.Enabled = false;
						btnDelete.Enabled = false;
						pwd.ShowDialog();
						Refresh();

					}

					if (KendaliParameter.verifikasi)
					{
						
						txtPWD.Text = TSSame.Rows[0]["passkode"].ToString();
						txtnama.Text = item.SubItems[0].Text;
						btnEdit.Enabled = true;
						btnDelete.Enabled = true;
						KendaliParameter.akunAktif = KendaliParameter.akunTmp;

					}
				}
			else
				{
					txtnama.Text = string.Empty;
					txtPWD.Text = string.Empty;
				}

			
            
        }

        void StreamFrameKamera(object sender, EventArgs e)
        {
            //ambil frame dari peranfkat kamera
			
			if (Process.GetProcessesByName("logonUI.exe").Length==0)
			{
				try
				{
					frameByte = ambilGambar.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

					if (deteksi)
					{
						//Grayscaling
						gray = frameByte.Convert<Gray, Byte>();

						//deteksimuka
						MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
							muka,
							1.2,
							10,
							Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
							new Size(20, 20));

						//aksi untuk setiap elemen muka yang terdeteksi
						foreach (MCvAvgComp f in facesDetected[0])
						{
							result = frameByte.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
							//kotak indikator deteksian
							frameByte.Draw(f.rect, new Bgr(Color.Red), 2);
						}
					}

					CamImageBox.Image = frameByte.Flip(FLIP.HORIZONTAL);
					frameByte = null;
				}
				catch (Exception)
				{
				}
			}
			else {
				InisialisasiKamera(false, false);
			}
			
            

        }
        private void btnTangkapGambar_Click(object sender, EventArgs e)
        {
			try
			{
				gray = ambilGambar.QueryGrayFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
				MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
				muka,
				1.2,
				10,
				Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
				new Size(20, 20));
				foreach (MCvAvgComp f in facesDetected[0])
				{
					result = gray.Copy(f.rect).Convert<Gray, byte>();
					break;
				}
                //croop
                TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC).Flip(FLIP.HORIZONTAL);
				if (txtpict.Value == 1)
				{
					trainingImages[0] = TrainedFace;
					txtpict.Value += 1;
                }
				else if (txtpict.Value == 2)
                {
					trainingImages[1] = TrainedFace;
					txtpict.Value += 1;
				}
				else if (txtpict.Value == 3)
                {
					trainingImages[2] = TrainedFace;
					txtpict.Value += 1;                    
                }
				else if (txtpict.Value == 4)
                {
					trainingImages[3] = TrainedFace;
					txtpict.Value += 1;                    
                }
				else if (txtpict.Value == 5)
                {
					trainingImages[4] = TrainedFace;
					txtpict.Value = 1;
				}
				if (txtpict.Value==1)
				{
					txtpict.Enabled = true;
					btnSave.Enabled = true;
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Tidak mendeteksi wajah. Silakan coba ulangi lagi. ", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			finally
			{

				result = null;
				RefreshGambar();
			}
        }

		private void RefreshGambar()
		{
			try
			{
			pictureBox1.Image = trainingImages[0].Bitmap;
			pictureBox2.Image = trainingImages[1].Bitmap;
			pictureBox3.Image = trainingImages[2].Bitmap;
			pictureBox4.Image = trainingImages[3].Bitmap;
			pictureBox5.Image = trainingImages[4].Bitmap;
			}
			catch (Exception)
			{
				
			}
			
		}

		public static void verifikasi(string akun)
		{
			if (akun == KendaliParameter.akunAktif)
			{
				KendaliParameter.verifikasi = true;
			}
			else
			{
				KendaliParameter.verifikasi = false;
			}
		}

		private void FormPengguna_X(object sender, FormClosedEventArgs e)
		{
			selesai();
		}
		private void selesai()
		{
			ambilGambar.Dispose();
			InisialisasiKamera(false, false);
			this.Close();
		}

		private bool IsAdmin() {
			bool jjjjj = false;
			try
			{
				WindowsIdentity user = WindowsIdentity.GetCurrent();
				WindowsPrincipal prinsipal = new WindowsPrincipal(user);
				jjjjj = prinsipal.IsInRole(WindowsBuiltInRole.Administrator);
			}
			catch
			{
				jjjjj = false;
			}
			return jjjjj;
		}

		private void btnImplLogin_Click(object sender, EventArgs e)
		{
			if (IsAdmin())
			{
				koneksiDB.Close();
				if (KendaliParameter.databaseTidakKosong())
				{
					switch (iterasiTombolPengaturKunci)
					{
						case 1:
							{
								KendaliParameter.setPengunci(KendaliParameter.PerintahPengunci.PengunciAktif);
								break;
							}
						case 2:
							{
								KendaliParameter.setPengunci(KendaliParameter.PerintahPengunci.PengunciAktif);
								KendaliParameter.setRegistry(KendaliParameter.wLogon, "ForceUnlockLogon", "0", RegistryValueKind.DWord, KendaliParameter.modeSetRegistry.UbahDataValue);
								break;
							}
						case 3:
							{
								KendaliParameter.setPengunci(KendaliParameter.PerintahPengunci.PengunciMati);
								KendaliParameter.setRegistry(KendaliParameter.wLogon, "ForceUnlockLogon", "1", RegistryValueKind.DWord, KendaliParameter.modeSetRegistry.UbahDataValue);
								break;
							}
					}
					CekSbgLockWindows();

				}
				else { MessageBox.Show("Database kosong... \nOperasi pemasangan kunci dibatalkan."); }


			}
			else {
				MessageBox.Show("Pengubahan pengaturan pengunci tidak dapat dilaksanakan,\nSilakan jalankan ulang program ini dalam mode Administrator.");
			}
			

		}

		private void CekSbgLockWindows()
		{
			KendaliParameter.PerintahPengunci p= KendaliParameter.cekPengunci();
			if (p==KendaliParameter.PerintahPengunci.PengaturanPengunciTidakTerpasang) //tidak terpasang
			{
				btnPin.Enabled = false;
				btnPin.Visible = false;
				iterasiTombolPengaturKunci = 1;
				btnImplLogin.Text = "Pengunci belum terpasang";
				toolTip.SetToolTip((Control)btnImplLogin, "Pengunci belum terpasang.\nKlik tombol untuk memasang");
				btnImplLogin.Image = Properties.Resources.unlocked;
			}
			else
				if (p == KendaliParameter.PerintahPengunci.PengunciAktif) //aktif
				{
					btnPin.Enabled = true;
					btnPin.Visible = true;
					iterasiTombolPengaturKunci = 3;
					btnImplLogin.Text="Pengunci aktif";
					toolTip.SetToolTip((Control)btnImplLogin, "Pengunci dalam kondisi aktif.\nKlik tombol untuk mematikan");

					btnImplLogin.Image=Properties.Resources._lock;
					lockWorksation = true;

				}
				else if (p==KendaliParameter.PerintahPengunci.PengunciMati){ //tidak aktif
					btnPin.Enabled = true;
					btnPin.Visible = true;
					iterasiTombolPengaturKunci = 2;
					btnImplLogin.Text="Pengunci tidak aktif";
					toolTip.SetToolTip((Control)btnImplLogin, "Pengunci dalam kondisi tidak aktif.\nKlik tombol untuk mengaktifkan");
					btnImplLogin.Image = Properties.Resources.unlocked;
			
			}


		}

		private void btnPin_Click(object sender, EventArgs e)
		{
			if (IsAdmin())
			{
				KendaliParameter.setPengunci(KendaliParameter.PerintahPengunci.PengaturanPengunciTidakTerpasang);
				btnPin.Enabled = false;
				btnPin.Visible = false;
				CekSbgLockWindows();
			}
			else {
				MessageBox.Show("Pengubahan pengaturan pengunci tidak dapat dilaksanakan,\nSilakan jalankan ulang program ini dalam mode Administrator.");
			}
			
		}

    }
}
