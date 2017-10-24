using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ViolaJones
{
	public partial class VerifikasiPwd : Form
	{
		OleDbConnection KoneksiDB = new OleDbConnection(KendaliParameter.urlDatabase);
		OleDbDataAdapter DataAdapter;
		DataTable DataTabel = new DataTable();

		public VerifikasiPwd()
		{
			InitializeComponent();
		}

		private void btnBatal_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnMasuk_Click(object sender, EventArgs e)
		{
			try
				{
					KoneksiDB.Open();
					DataAdapter = new OleDbDataAdapter("SELECT * from Akun where nama='" + KendaliParameter.akunTmp + "' and passkode='" + txtPWD.Text + "' ", KoneksiDB);
					OleDbCommandBuilder CommandBuilder = new OleDbCommandBuilder(DataAdapter);
					DataAdapter.Fill(DataTabel);
					if (DataTabel.Rows.Count == 1)
					{
						KendaliParameter.akunAktif = KendaliParameter.akunTmp;
							KendaliParameter.verifikasi=true;
							Close();
					}
					else
					{
						KendaliParameter.verifikasi=false;
						MessageBox.Show("Kode Kunci tidak sesuai.");
					}
				}
				catch (Exception)
				{
				}
				finally
				{
					KoneksiDB.Close();
				}

			}

		private void VerifikasiPwd_Load(object sender, EventArgs e)
		{
			Text += " akun : "+KendaliParameter.akunTmp+"";
		}

		private void EnterKey(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnMasuk.PerformClick();
			}
			if (e.KeyCode == Keys.Escape)
			{
				btnBatal.PerformClick();
			}
		}
		}
	
}
