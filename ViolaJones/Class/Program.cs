using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ViolaJones
{
	static class Program
	{
		[STAThread]
		[DllImport("User32.dll")]
		private static extern bool SetForegroundWindow(IntPtr hWnd);
		[DllImport("User32.dll")]
		private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);
		[DllImport("User32.dll")]
		private static extern bool IsIconic(IntPtr hWnd);

		private const int SW_Hide = 0;
		private const int SW_SNORMAL = 1;
		private const int SW_SMINIMIZED = 2;
		private const int SW_SMAXIMIZED = 3;
		private const int SW_NOACTIVATED = 4;
		private const int SW_RESTORE = 9;
		private const int SW_SDEFAULT = 10;
		
		static void Main()
		{
			string proc = Process.GetCurrentProcess().ProcessName;
			Process[] procs = Process.GetProcessesByName(proc);

			if (procs.Length > 1)
			{
				Process p = Process.GetCurrentProcess();
				int n = 0;
				if (procs[0].Id == p.Id)
				{
					n = 1;
				}
				IntPtr hWnd = procs[n].MainWindowHandle;
				if (IsIconic(hWnd))
				{
					ShowWindowAsync(hWnd, SW_RESTORE);
				}
				SetForegroundWindow(hWnd);
				return;
			}
			
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			KendaliParameter.urlDatabase = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Application.StartupPath+"\\DB.mdb";
			Run();
		}

		private static void Run()
		{
			string a = "";
			string[] args = Environment.GetCommandLineArgs();
			//sambung argumen
			for (int i = 1; i < args.Length; i++)
			{

				a = a + " " + args[i];
			}

			
			//simpan di kendali parameter
			KendaliParameter.ArgS=a;
			//jika mengandung argumen
			if (a.Length != 0)
			{
				//mengandung /, mode zero
				if (args[args.Length-1]=="BootUP")
				{
					
					KendaliParameter.lockArgs = true;
					Application.Run(new DeteksiWajah("BootUP"));
				}
				else
					//mengandung /, mode lock
					if (args[args.Length - 1] == "Lock")
					{
						KendaliParameter.lockArgs = true;
						Application.Run(new DeteksiWajah("Lock"));
					}
					else
						//mengandung /, mode lock2
						if (args[args.Length - 1] == "Lock2")
						{
							KendaliParameter.lockArgs = true;
							Application.Run(new DeteksiWajah("Lock2"));
						}
			}
			else {
				//mode desktop
				if ((!Environment.UserName.Contains("SYSTEM"))||
					(!Environment.UserName.Contains("LOCAL SERVICE"))||
					(!Environment.UserName.Contains("DWM"))||
					(!Environment.UserName.Contains("SERVICE")))
				{
					Application.Run(new Splash());
				}
				//mode tidak diketahui
				else{
					KendaliParameter.lockArgs = true;
					Application.Run(new DeteksiWajah());
				}
			}
			
		}

	}
}
