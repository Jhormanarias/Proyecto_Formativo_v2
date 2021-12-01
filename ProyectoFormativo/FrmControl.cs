using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFormativo
{
	public partial class FrmControl : Form
	{
		public FrmControl()
		{
			InitializeComponent();
		}

		private void txt_Documento_U_Enter(object sender, EventArgs e)
		{
			if (txt_Documento_U.Text == "Documento")
			{
				txt_Documento_U.Text = "";
				txt_Documento_U.ForeColor = Color.Black;
			}
		}

		private void txt_Documento_U_Leave(object sender, EventArgs e)
		{
			if (txt_Documento_U.Text == "")
			{
				txt_Documento_U.Text = "Documento";
				txt_Documento_U.ForeColor = Color.Silver;
			}
		}

		private void relog_Tick(object sender, EventArgs e)
		{
			lbl_hora.Text = DateTime.Now.ToString("hh:mm:ss tt", CultureInfo.InvariantCulture);
		}

		private void txt_Documento_C_U_Enter(object sender, EventArgs e)
		{
			if (txt_Documento_U.Text == "Documento")
			{
				txt_Documento_C_U.Text = "";
				txt_Documento_C_U.ForeColor = Color.Black;
			}
		}

		private void txt_Documento_C_U_Leave(object sender, EventArgs e)
		{
			if (txt_Documento_C_U.Text == "")
			{
				txt_Documento_C_U.Text = "Documento";
				txt_Documento_C_U.ForeColor = Color.Silver;
			}
		}

		private void txt_BuscarBein_C_U_Enter(object sender, EventArgs e)
		{
			if (txt_BuscarBein_C_U.Text == "ID Bien:")
			{
				txt_BuscarBein_C_U.Text = "";
				txt_BuscarBein_C_U.ForeColor = Color.Black;
			}
		}

		private void txt_BuscarBein_C_U_Leave(object sender, EventArgs e)
		{
			if (txt_BuscarBein_C_U.Text == "")
			{
				txt_BuscarBein_C_U.Text = "ID Bien:";
				txt_BuscarBein_C_U.ForeColor = Color.Silver;
			}
		}

		private void btn_salir_C_U_Click(object sender, EventArgs e)
		{
			DialogResult rpta = new DialogResult();
			rpta = MessageBox.Show("¿Desea Salir?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (rpta == DialogResult.Yes)
			{
				Application.Exit();
			}
		}
	}
}
