using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ViolaJones
{
		public class KendaliParameter {

			public static string wLogon="SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon";
			public static string RegViolaJones = "KunciViolaJones";
			public static string RegViolaJonesState = "KunciViolaJonesState";

			public static string windir = Environment.GetEnvironmentVariable("windir");
			public static string system = system32();

			public static string system32(){
				string redirect = string.Empty;
				if (Environment.Is64BitOperatingSystem)
				{
					redirect = windir + "\\Sysnative";
				}
				else { redirect = windir + "\\System32"; }

				return redirect;
			}
			public static string akunAktif //untuk menyimpan akun yg sedang login
			{
				get;
				set;
			}
			public static string urlDatabase //lokasi penyimpanan database 
			{
				get;
				set;
			}
			public static bool verifikasi //kondisi kondisi pass dan nama apakah sesuai, kondisi untuk pindah akun
			{
				get;
				set;
			}


			public static string akunTmp //untuk menyimpan akun yang akan diakses
			{
				get;
				set;
			}

			public static bool lockArgs //untuk menyimpan kondisi dari argumen, tujuan mempercepat proses, sbg pengganti string argumen
			{
				get;
				set;
			}
			public static string ArgS
			{
				get;
				set;
			}

			public static PerintahPengunci cekPengunci() {

				bool logonUI=false, KunciVJ=false, FileIndukVJ=false, KunciVJState=false, DB=false, serviceH=false;
				PerintahPengunci Kembalian= PerintahPengunci.PengaturanPengunciTidakTerpasang;
				string induk = bacaRegistry(wLogon, RegViolaJones);
				string state = bacaRegistry(wLogon, RegViolaJonesState);
				
				//=====================cek LogonUI
				try
				{
					if (cekUkuranFile(system+"\\LogonUI.exe") == Properties.Resources.LogonUI.Length)
					{
						logonUI = true;
					}
				}
				catch { }
				//===================== cek alamat pengunci
				if (induk != null)
				{
					KunciVJ = true;
					//====================== verifikasi alamat
					FileIndukVJ = induk==Application.StartupPath+"\\ViolaJones.exe";
					
				}

				//======================
				KunciVJState = state!="2";
				
				//======================
				DB = databaseTidakKosong();
				try
				{
					Process p = new Process();
					p.StartInfo.Arguments = "query ViolaJonesHandler";
					p.StartInfo.FileName = "SC.exe";
					p.StartInfo.RedirectStandardOutput = true;
					p.StartInfo.UseShellExecute = false;
					p.StartInfo.CreateNoWindow = true;
					p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					p.Start();
					String pp = p.StandardOutput.ReadToEnd();
					serviceH = pp.Contains("4  RUNNING");
					
				}
				catch { }


				if (logonUI && KunciVJ && FileIndukVJ && KunciVJState && DB && serviceH)
				{
					Kembalian = PerintahPengunci.PengunciAktif;
				}
				else if (logonUI && KunciVJ && FileIndukVJ && !KunciVJState && DB)
				{
					Kembalian = PerintahPengunci.PengunciMati; 
				}
				else {
					Kembalian = PerintahPengunci.PengaturanPengunciTidakTerpasang;
				}
				return Kembalian;
			}

			public static long cekUkuranFile(string alamat)
			{
				long kembalian = 0;
				try
				{
					FileStream file = new FileStream(alamat, FileMode.Open);
					kembalian = file.Length;
					file.Close();
				}
				catch { }
				
				return kembalian;
			}

			public enum PerintahPengunci : int { 
				PengaturanPengunciTidakTerpasang=0, 
				PengunciAktif=1, 
				PengunciMati=2
			}




			public static void setPengunci(PerintahPengunci p){
				try
				{
					bool FileLogonUIAsli = File.Exists(system + "\\LogonUIWindow.exe");
					bool FileLogonUI = File.Exists(system + "\\LogonUI.exe");
					bool cekLogonUIVJ = cekUkuranFile(system + "\\LogonUI.exe") == Properties.Resources.LogonUI.Length;
					switch (p)
					{
						case PerintahPengunci.PengaturanPengunciTidakTerpasang: //
							{

								if (FileLogonUIAsli && FileLogonUI && cekLogonUIVJ)
								{
									try
									{
										File.Delete(system + "\\LogonUI.exe");
										File.Move(system + "\\LogonUIWindow.exe", system + "\\LogonUI.exe");
										
										
									}
									catch { }
									
								}
								try
								{
									Process ppp=Process.Start(Application.StartupPath + "\\ViolaJonesHandler.exe", "/u");
									ppp.WaitForExit();
									File.Delete(Application.StartupPath + "\\ViolaJonesHandler.InstallLog");
								}
								catch { }
								setRegistry(wLogon, RegViolaJones, "", RegistryValueKind.String, modeSetRegistry.HapusValue);
								setRegistry(wLogon, RegViolaJonesState, "", RegistryValueKind.DWord, modeSetRegistry.HapusValue);
								break;
							}
						case PerintahPengunci.PengunciAktif:
							{
								if (FileLogonUIAsli && FileLogonUI && cekLogonUIVJ)
								{
									setRegistry(wLogon, RegViolaJonesState, "1", RegistryValueKind.DWord, modeSetRegistry.UbahDataValue);
									setRegistry(wLogon, RegViolaJones, Application.StartupPath + "\\ViolaJones.exe", RegistryValueKind.String, modeSetRegistry.UbahDataValue);
								
								
								}
								else
								{
									try
									{
										File.Move(system + "\\LogonUI.exe", system + "\\LogonUIWindow.exe");
										File.WriteAllBytes(system + "\\LogonUI.exe", Properties.Resources.LogonUI);
										File.WriteAllBytes(Application.StartupPath + "\\ViolaJonesHandler.exe", Properties.Resources.ViolaJonesHandler);
										Process ppp=Process.Start(Application.StartupPath + "\\ViolaJonesHandler.exe", "/i");
										ppp.WaitForExit();
										Process pppp=Process.Start("Sc.exe", "start ViolaJonesHandler");
										pppp.WaitForExit();
									}
									catch { }
									setRegistry(wLogon, RegViolaJonesState, "1", RegistryValueKind.DWord, modeSetRegistry.UbahDataValue);
									setRegistry(wLogon, RegViolaJones, Application.StartupPath + "\\ViolaJones.exe", RegistryValueKind.String, modeSetRegistry.UbahDataValue);
								}
								break;
							}
						case PerintahPengunci.PengunciMati:
							{
								if (FileLogonUIAsli && FileLogonUI && cekLogonUIVJ)
								{
									setRegistry(wLogon, RegViolaJonesState, "2", RegistryValueKind.DWord, modeSetRegistry.UbahDataValue);
									setRegistry(wLogon, RegViolaJones, Application.StartupPath + "\\ViolaJones.exe", RegistryValueKind.String, modeSetRegistry.UbahDataValue);
								}
								break;
							}
						default:
							break;
					}
				}
				catch { }
			}
			public static bool databaseTidakKosong() {
				bool kembalian = false;
				OleDbConnection KoneksiDB = new OleDbConnection(KendaliParameter.urlDatabase);
				OleDbDataAdapter DataAdapter;
				DataTable DataTabel = new DataTable();
				try
				{

					KoneksiDB.Open();
					DataAdapter = new OleDbDataAdapter("SELECT * from akun", KoneksiDB);
					OleDbCommandBuilder CommandBuilder = new OleDbCommandBuilder(DataAdapter);


					DataAdapter.Fill(DataTabel);
					if (DataTabel.Rows.Count != 0)
					{
						kembalian = true;
					}
				}
				catch (Exception)
				{
					kembalian = false;
					setPengunci(PerintahPengunci.PengaturanPengunciTidakTerpasang);
				}
				finally
				{
					DataTabel.Clear();
					KoneksiDB.Close();
				}
				return kembalian;
			}
			public static void cekFilePendukung()
			{
				if (!File.Exists(Application.StartupPath + "\\opencv_core220.dll"))
				{
					File.WriteAllBytes(Application.StartupPath + "\\opencv_highgui220.dll", Properties.Resources.opencv_highgui220);
					File.WriteAllBytes(Application.StartupPath + "\\opencv_contrib220.dll", Properties.Resources.opencv_contrib220);
					File.WriteAllBytes(Application.StartupPath + "\\opencv_video220.dll", Properties.Resources.opencv_video220);
					File.WriteAllBytes(Application.StartupPath + "\\opencv_gpu220.dll", Properties.Resources.opencv_gpu220);
					File.WriteAllBytes(Application.StartupPath + "\\opencv_calib3d220.dll", Properties.Resources.opencv_calib3d220);
					File.WriteAllBytes(Application.StartupPath + "\\haarcascade_mukadepan.xml", Properties.Resources.haarcascade_mukadepan);//\\//
					File.WriteAllBytes(Application.StartupPath + "\\opencv_objdetect220.dll", Properties.Resources.opencv_objdetect220);
					File.WriteAllBytes(Application.StartupPath + "\\opencv_flann220.dll", Properties.Resources.opencv_flann220);
					File.WriteAllBytes(Application.StartupPath + "\\highgui110.dll", Properties.Resources.highgui110);
					File.WriteAllBytes(Application.StartupPath + "\\cv110.dll", Properties.Resources.cv110);
					File.WriteAllBytes(Application.StartupPath + "\\opencv_core220.dll", Properties.Resources.opencv_core220);
					File.WriteAllBytes(Application.StartupPath + "\\opencv_imgproc220.dll", Properties.Resources.opencv_imgproc220);
					File.WriteAllBytes(Application.StartupPath + "\\cvaux110.dll", Properties.Resources.cvaux110);
					File.WriteAllBytes(Application.StartupPath + "\\opencv_features2d220.dll", Properties.Resources.opencv_features2d220);
					File.WriteAllBytes(Application.StartupPath + "\\opencv_legacy220.dll", Properties.Resources.opencv_legacy220);
					File.WriteAllBytes(Application.StartupPath + "\\cvextern.dll", Properties.Resources.cvextern);
					File.WriteAllBytes(Application.StartupPath + "\\opencv_ffmpeg220.dll", Properties.Resources.opencv_ffmpeg220);
					File.WriteAllBytes(Application.StartupPath + "\\opencv_ml220.dll", Properties.Resources.opencv_ml220);
					File.WriteAllBytes(Application.StartupPath + "\\cxcore110.dll", Properties.Resources.cxcore110);

				}
			}
			public enum modeSetRegistry : int
			{
				UbahDataValue=1,
				HapusValue=0

			}
			public static void setRegistry(string Registry, string value, string data, RegistryValueKind vk, modeSetRegistry mode)//set registry
			{
				RegistryKey registry;
				if (Environment.Is64BitOperatingSystem)
				{
					registry = RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, RegistryView.Registry64);
				}
				else
				{
					registry = RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, RegistryView.Registry32);
				}
				try
				{	
					RegistryKey regk = registry.CreateSubKey(Registry);
					switch (mode)
					{
						case modeSetRegistry.UbahDataValue:
							{
								regk.SetValue(value, data, vk);
								break;
							}
						case modeSetRegistry.HapusValue:
							{
								regk.DeleteValue(value);
								break;
							}
						default:
							break;
					}
					regk.Close();
				}
				catch { }

			}

			public static string bacaRegistry(string Registry, string value)//baca registry
			{
				string a;
				RegistryKey registry;
				if (Environment.Is64BitOperatingSystem)
				{
					registry = RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, RegistryView.Registry64);
				}
				else
				{
					registry = RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, RegistryView.Registry32);
				}
				try
				{
					RegistryKey regk = registry.OpenSubKey(Registry, true);
					a = regk.GetValue(value, null, RegistryValueOptions.None).ToString();
					regk.Close();
				}
				catch { a = null; }
				return a;

			}



		}

	
}
