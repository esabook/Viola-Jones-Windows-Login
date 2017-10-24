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
using Microsoft.Win32;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using Dotnetrix.Controls;
using ProcessUtil;


namespace ViolaJones
{
    public partial class DeteksiWajah : Form
    {
		int ambang = 1000;
        Image<Bgr, Byte> frameByte;
        Capture ambilGambar;
        HaarCascade muka;
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        Image<Gray, byte> hasilTemp;
        Image<Gray, byte> gray = null;
        List<Image<Gray, byte>> gambarSimpanan = new List<Image<Gray, byte>>();
        List<string> namaGambar = new List<string>();
        List<string> namaPemilikGambar = new List<string>();
        int possGambar, nomorNamaGbr, t;
        string name, names = null;
        string textname = null;
        string textimage = null;
		string TasMgr = @"/q /c reg add HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System /v DisableTaskMgr /t REG_DWORD /d ";
		bool kondisi = false, stream=false, state=true, DBtermuat=false, LUIOnSuspend=false;
		byte pewaktuPematiKamera=0;

		Timer timerFG = new Timer();
		OleDbConnection Connection = new OleDbConnection(KendaliParameter.urlDatabase);
		OleDbDataAdapter DataCount;
		DataTable TSTable = new DataTable();
		private string p;



		public DeteksiWajah()
		{
			InitializeComponent();
			ProsesShell.StartInfo.WorkingDirectory = Environment.GetEnvironmentVariable("windir");
		}

		public DeteksiWajah(string p)
		{
			this.p = p;
			InitializeComponent();
			ProsesShell.StartInfo.WorkingDirectory = Environment.GetEnvironmentVariable("windir");
		}
		private void FaceRecognition_Load(object sender, EventArgs e)
		{
			kendaliSystemWindows(true); 
			this.timer.Enabled = true;
			


		}

		private void kendaliSystemWindows(bool	mulaiProgram)
		{

			if (mulaiProgram)
			{
				if (KendaliParameter.lockArgs)
				{
					if (p=="Lock")
					{
						timerSuspenderLUI.Enabled=true;
					}
					if (p == "BootUP")
					{
						this.Cursor = new Cursor(Properties.Resources.cua.Handle);
						Cursor.Show();
						timerSuspenderLUI.Enabled = true;
					}

					PerintahShell(TasMgr + "1 /f");
				}
				else
				{
					Keluar.Enabled = true;
					Keluar.Visible = true;
					this.TopMost = false;
					state = false;
				}
			}
			else
			{
				if (KendaliParameter.lockArgs)
					PerintahShell(TasMgr + "0 /f");
				if (p == "Lock")
				{
					LUIResumer();
					

				}
				if (p == "BootUP")
				{
					KendaliParameter.setRegistry(KendaliParameter.wLogon, "KunciViolaJonesInfo", "Unlock", RegistryValueKind.DWord, KendaliParameter.modeSetRegistry.UbahDataValue);
					LUIResumer();
					KendaliParameter.setRegistry(KendaliParameter.wLogon, KendaliParameter.RegViolaJonesState, "1", RegistryValueKind.DWord, KendaliParameter.modeSetRegistry.UbahDataValue);
				}
			}
		}

		private void LUIResumer()
		{
			if (LUIOnSuspend)
			{
				try
				{
					var param = ProcessArgs(new string[] { "-r", "LogonUIWindow" });
					ExecuteOption(param);
				}
				catch { }
			}
		}
		private void PerintahShell(string perintah)
		{
			ProsesShell.StartInfo.Arguments = perintah;
			ProsesShell.Start();
		}


		private void timer1_Tick(object sender, EventArgs e)
		{
			if (!kondisi)
			{
				if (progressBar.Value < 100)
				{
					progressBar.Value += 20;
				}
				if (progressBar.Value == 100)
				{
					timer.Dispose();

					//InisialisasiKamera(true);
					if (!DBtermuat)
					{
						Connection.Open();
						label1.Visible = false;
						DBtermuat = true;
						progressBar.Value = 0;
						progressBar.Visible = false;
					}

					kondisi = true;

				}
				else
				{
					label1.Visible = true;
					label1.Text = "Sedang memuat ... (" + progressBar.Value + "%)";
				}
			}
			else {
				if (progressBar.Value < 100)
				{
					progressBar.Value += 20;
				}
				if (progressBar.Value == 100)
				{
					Refresh();
					timer.Dispose();
					state = false;
					this.Close();

				}
			}
		}
		public void InisialisasiKamera(bool kondisi)
		{
			if (kondisi)
			{
				try
				{
					
					ambilGambar = new Capture();
									
					progressBar.Value = 0;
					progressBar.Visible = false;

					ambilGambar.QueryFrame();
					kondisi = true;
					loaddata();

					timerFG.Interval = 33;
					timerFG.Tick -= FrameGrabber;
					timerFG.Tick += FrameGrabber;
					timerFG.Enabled = true;
				}
				catch (Exception ex) {
					if (DBtermuat)
					{
						MessageBox.Show("Gagal pada ... \n" + ex.ToString());
					}
					else
					{
						MessageBox.Show("Gagal memuat ... " + ex.ToString());
					}
				}
				
			}
			else
			{
				
				imageBoxFrameGrabber.Image = null;
				timerFG.Tick -= FrameGrabber;
				try
				{
					ambilGambar.Dispose();
				}
				catch { }
			}
		}

		void FrameGrabber(object sender, EventArgs e)
		{
			if (pewaktuPematiKamera < 130)
			{
				if (!stream)
				{
					try
					{
						stream = true;
						pewaktuPematiKamera += 1;

						namaPemilikGambar.Add("");
						frameByte = ambilGambar.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC).Flip(FLIP.HORIZONTAL);
						gray = frameByte.Convert<Gray, Byte>();
						MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
							muka,
							1.2,
							10,
							Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
							new Size(20, 20));
						foreach (MCvAvgComp f in facesDetected[0])
						{
							t = t + 1;
							hasilTemp = frameByte.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
							frameByte.Draw(f.rect, new Bgr(Color.Green), 2);

							if (gambarSimpanan.ToArray().Length != 0)
							{
								pewaktuPematiKamera = 0;
								MCvTermCriteria termCrit = new MCvTermCriteria(possGambar, 0.001);

								//Eigen
								EigenObjectRecognize recognizer = new EigenObjectRecognize(
								   gambarSimpanan.ToArray(),
								   namaGambar.ToArray(),
								   ambang,
								   ref termCrit);
								   name = recognizer.Recognize(hasilTemp);
								   frameByte.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.LightGreen));
							}
                            
							namaPemilikGambar[t - 1] = name;
							namaPemilikGambar.Add("");
						}
						t = 0;

						//kumpulan nama akun
						string namaAkun = null;
						for (int nnn = 0; nnn < facesDetected[0].Length; nnn++)
						{
							names = names + namaPemilikGambar[nnn] + ", ";
							namaAkun = namaPemilikGambar[0];
						}
						//tampilkan muka yang dikenali
						imageBoxFrameGrabber.Image = frameByte;
						pictureBox1.Image = null;
						
						if (namaAkun != "")
						{
							datamhs(namaAkun);
						}
						else
						{
							pictureBox1.Image = null;
						}

						names = "";
						namaPemilikGambar.Clear();

						stream = false;
					}
					catch (Exception ex) { MessageBox.Show(ex.Message); }
					
				}
			}
			else {
				InisialisasiKamera(false);
				button3.Visible = true;
				button3.Enabled = true;
			}
			
			
		}

		private void loaddata()
        {
                string ns = datacount();
                muka = new HaarCascade(Application.StartupPath+"\\haarcascade_mukadepan.xml");
				try
				{

					textname = datacount();
					textimage = dataimage();

					string[] Labels = textname.Split('%');
					nomorNamaGbr = Convert.ToInt16(Labels[0]);
					possGambar = nomorNamaGbr;

					string[] ImgName = textimage.Split('%');
					string LoadFaces;
					for (int tf = 1; tf < nomorNamaGbr + 1; tf++)
					{
						LoadFaces = ImgName[tf] + ".bmp";
						if (gambarSimpanan.Count == nomorNamaGbr)
						{
							gambarSimpanan[tf - 1] = new Image<Gray, byte>(Application.StartupPath + "/gambar/" + LoadFaces);
							namaGambar[tf - 1] = Labels[tf];
						}
						else
						{
							gambarSimpanan.Add(new Image<Gray, byte>(Application.StartupPath + "/gambar/" + LoadFaces));
							namaGambar.Add(Labels[tf]);
						}

					}

				}
				catch { }
            }

		private void datamhs(string nhs)
		{

			string namaAkn = null;
			DataCount = new OleDbDataAdapter("select *  from Akun where nama='" + nhs + "'", Connection);
			OleDbCommandBuilder CommandBuilder = new OleDbCommandBuilder(DataCount);
			DataTable TSSames = new DataTable();
			DataCount.Fill(TSSames);
			if (TSSames.Rows.Count > 0)
			{

				namaAkn = TSSames.Rows[0]["nama"].ToString();
				groupBox1.Visible = true;
				pictureBox1.ImageLocation = Application.StartupPath + "/gambar/" + namaAkn + "1.bmp";
				//pictureBox1.Image = Image.FromFile(Application.StartupPath + "/gambar/" + namaAkn + "1.bmp");
				progressBar.Visible = true;
				this.timer.Enabled = true;

			}
		}

            
        

        private string datacount()
        {
            string dups = "";
            int cnt = 0;
            int clm = 0;
            string namep = "";
            string txt = "";
			DataCount = new OleDbDataAdapter("select *  from Akun order by nama asc ", Connection);
            OleDbCommandBuilder CommandBuilder = new OleDbCommandBuilder(DataCount);
            dups ="";
            DataTable TSSames = new DataTable();
            DataCount.Fill(TSSames);
            if (TSSames.Rows.Count > 0)
            {
                cnt = TSSames.Rows.Count * 5;
                clm = TSSames.Rows.Count - 1;

                int np = 0;
                foreach (DataRow row in TSSames.Rows)
                {
                    namep = TSSames.Rows[np]["nama"].ToString();
                    for (int i = 1; i < 6; i++)
                    {
                        txt = txt + namep + "%";
                    }
                    np=np+1;
                }
                dups = cnt.ToString() + "%" + txt ;
            }

            return dups;
        }

        private string dataimage()
        {
            string dups = "";
            int cnt = 0;
            int clm = 0;
            string namep = "";
            string txt = "";
            DataCount = new OleDbDataAdapter("select * from Akun order by nama asc ", Connection);
            OleDbCommandBuilder CommandBuilder = new OleDbCommandBuilder(DataCount);
            dups = "";
            DataTable TSSames = new DataTable();
            DataCount.Fill(TSSames);
            if (TSSames.Rows.Count > 0)
            {
                cnt = TSSames.Rows.Count * 5;
                clm = TSSames.Rows.Count - 1;
                int np = 0;
                foreach (DataRow row in TSSames.Rows)
                {
                    namep = TSSames.Rows[np]["nama"].ToString();
                    for (int i = 1; i < 6; i++)
                    {
                        string curFile = Application.StartupPath + "/gambar/" + namep + i + ".bmp";
                        if (File.Exists(curFile))
                        {
                            txt = txt + namep + i + "%";
                        }
                        else
                        {
                            txt = txt + namep + "1%";
                        }
                    }
                    np = np + 1; 
                }


                dups = cnt.ToString() + "%" + txt;
            }
            return dups;

        }

		private void FormKeluar(object sender, FormClosedEventArgs e)
		{
			if (KendaliParameter.bacaRegistry(KendaliParameter.wLogon, KendaliParameter.RegViolaJonesState)!="2")
			{
					KendaliParameter.setRegistry(KendaliParameter.wLogon, KendaliParameter.RegViolaJonesState, "1", RegistryValueKind.DWord,KendaliParameter.modeSetRegistry.UbahDataValue);
			}
			timerFG.Dispose();
			kendaliSystemWindows(false);
			InisialisasiKamera(false);
		}


		private void Keluar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void FormMauKlr(object sender, FormClosingEventArgs e)
		{
			if (state)
			{
				e.Cancel = state;
				base.OnClosing(e);
			}
		}


		private void keyBClick(object sender, EventArgs e)
		{
			LUIResumer();
			Process p = new Process();
			if (Process.GetProcessesByName("LogonUI").Length!=0)
			{
				p=Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\utilman.exe");
			}
			else
			{
				p=Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\osk.exe");
			}
		}

		private void power_Click(object sender, EventArgs e)
		{

		}

		private void bSwitch_Click(object sender, EventArgs e)
		{
			if (tabC.SelectedIndex == 0)
			{
				
				tabC.SelectTab(1);
				InisialisasiKamera(false);
				bSwitch.Image = Properties.Resources.sright;
				

			}
			else {
				tabC.SelectTab(0);
				button3.Enabled = true;
				button3.Visible = true;
				bSwitch.Image = Properties.Resources.sleft;
				
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{

			
			button3.Visible = false;
			button3.Enabled = false;
			pewaktuPematiKamera = 0;
			InisialisasiKamera(true);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			labelGagal.Text = "";
			OleDbDataAdapter DataAdapter = new OleDbDataAdapter("SELECT * from Akun where nama='" + textNama.Text + "' and passkode='" + textPwd.Text + "'", Connection);
			OleDbCommandBuilder CommandBuilder = new OleDbCommandBuilder(DataAdapter);
			DataTable DataTabel = new DataTable();
			try
			{
				DataAdapter.Fill(DataTabel);
				if (DataTabel.Rows.Count == 1)
				{
					Connection.Close();
					Form Utama = new Utama();
					
					if (state)
					{
						state = false;
						this.Close();
					}
					else { Keluar.PerformClick(); }
				}
				else {
					labelGagal.Text = "Kombinasi tidak tepat.";
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
			finally
			{
				DataTabel.Clear();
				Connection.Close();
			}
		}
		private void EnterKey(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				BtnMasuk.PerformClick();
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (textPwd.PasswordChar == '●')
			{
				textPwd.PasswordChar='\0';
			}
			else
			{
				textPwd.PasswordChar = '●';
			}
		}

		 private static void ExecuteOption(Param param)
        {
            if (param.PId != 0)
            {
                var process = Process.GetProcessById(param.PId);
                ExecuteOption(param, process);
                return;
            }
            if (param.Expression != null)
            {
                var list = Process.GetProcesses().Where(x => x.ProcessName.IndexOf(param.Expression,StringComparison.OrdinalIgnoreCase)>=0);
                foreach (var process in list)
                    ExecuteOption(param, process);
                return;
            }

        }

        private static void ExecuteOption(Param param, Process process)
        {
            Options option = param.Option;
            switch (option)
            {
                case Options.List:
                    process.Print();
                    break;
                case Options.Kill:
                    process.Kill();
                    break;
                case Options.Suspend:
                    process.Suspend();
                    break;
                case Options.Resume:
                    process.Resume();
                    break;
                default:
                    throw new ArgumentException("");
            }
        }
        
        public static Param ProcessArgs(string[] args)
        {
            Param param;
            string commandLineParam2;
            if(args.Length < 1)
                throw new ArgumentException("");
            var option = ProcessOption(args[0]);
            if(option != Options.List && args.Length < 2)
                throw new ArgumentException("");
            if (args.Length < 2)
                commandLineParam2 = string.Empty;
            else
                commandLineParam2 = args[1];
            param = ProcessParam(commandLineParam2);
            param.Option =option;
            return param;
        }
        public static Param ProcessParam(string rawParam)
        {
            int result;
            var param = new Param();
            if (int.TryParse(rawParam, out result))
            {
                param.PId = result;
            }
            else
            {
                param.PId = 0;
                param.Expression = rawParam;
            }
            return param;
        }
        public static Options ProcessOption(string option)
        {
            Options progOptions;
            switch(option)
            {
                case "-l":
                    progOptions = Options.List;
                break;
                case "-k":
                progOptions = Options.Kill;
                break;
                case "-s":
                progOptions = Options.Suspend;
                break;
                case "-r":
                progOptions = Options.Resume;
                break;
                default:
                    throw new ArgumentException("");
            }
            return progOptions;
        }


		private void LUISuspender(object sender, EventArgs e)
		{
			if (!LUIOnSuspend)
			{
				if (Process.GetProcessesByName("LogonUIWindow").Length != 0)
				{
					try
					{
						var param = ProcessArgs(new string[] { "-s", "LogonUIWindow" });
						ExecuteOption(param);
						LUIOnSuspend = true;
					}
					catch { LUIOnSuspend = false; }
				}
			}
			else {
				timerSuspenderLUI.Enabled = false;
				timerSuspenderLUI.Dispose();
			}
		}


    }
}
