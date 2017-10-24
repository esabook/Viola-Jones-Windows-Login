using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Reflection;

namespace ViolaJones
{
	public partial class Splash : Form
	{
		public Splash()
		{
			InitializeComponent();
			this.timerSplash.Enabled = true;
		}


		private void timerSplash_Tick(object sender, EventArgs e)
		{

			if (ProgresSplash.Value < 100)
			{
				ProgresSplash.Value += 2;
				Lbelsplash.Text = "Sedang Memuat... (" + ProgresSplash.Value + "%)";
			}
			if (ProgresSplash.Value == 100)
			{
				timerSplash.Dispose();

				this.Hide();
				Login login = new Login();
				login.Show();
			}
		}

		private void Keluar_Click(object sender, EventArgs e)
		{
			Application.ExitThread();
		}

	}
}
