using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ViolaJones
{
    public partial class Utama : Form
    {
        public Utama()
        {
            InitializeComponent();
        }

        public void keluar()
        {
			Application.ExitThread();
        }

        private void ambilOlahWajah_Click(object sender, EventArgs e)
        {
			KendaliParameter.cekFilePendukung();
			AmbilOlah train = new AmbilOlah();
			train.ShowDialog();
        }

        private void detesiWajah_Click(object sender, EventArgs e)
        {
			KendaliParameter.cekFilePendukung();
            DeteksiWajah train = new DeteksiWajah();
			train.ShowDialog();
        }

        private void menukeluar_Click(object sender, EventArgs e)
        {
			keluar();
        }

		private void formKeluar(object sender, FormClosedEventArgs e)
		{
			
			keluar();
		}

    }
}
