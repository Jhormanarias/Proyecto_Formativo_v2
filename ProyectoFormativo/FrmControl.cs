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
using Controllers;

namespace ProyectoFormativo
{
	public partial class FrmControl : Form
	{
		public FrmControl()
		{
			InitializeComponent();
		}
		
		private int n = 0;
		private void relog_Tick(object sender, EventArgs e)
		{
			lbl_hora.Text = DateTime.Now.ToString("hh:mm:ss tt", CultureInfo.InvariantCulture);
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

        private void btn_Busrcar_R_U_Click(object sender, EventArgs e)
        {
			if (txt_Documento_C_U.Text == "" & txt_BuscarBien_C_U.Text == "")
			{
				MessageBox.Show("Llene un campo", "Adertencia!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				//buscar en la base de datos el visitante o bien
				if (txt_Documento_C_U.Text != "")
                {
					txt_nombre_R_U.Text = ClaseControlFrmVigilante.Func_TraeNomVisitante(Convert.ToInt64(txt_Documento_C_U.Text));
					DGVControl_U.DataSource = ClaseControlFrmVigilante.Func_BusVisitante(Convert.ToInt64(txt_Documento_C_U.Text));

				}
                else
                {
					txt_nombre_R_U.Text = ClaseControlFrmVigilante.Func_TraeNomVisitanteS(txt_BuscarBien_C_U.Text);
					DGVControl_U.DataSource = ClaseControlFrmVigilante.Func_BusVisitanteBien(txt_BuscarBien_C_U.Text);
				}
				
				if (txt_nombre_R_U.Text == "")
				{
					MessageBox.Show("Visitante o bien no registrado", "Adertencia!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				//else
				//{
				//	btn_Ingreso_U.Enabled = true;
				//	btn_Salida_U.Enabled = true;
				//}

			}
		}

        private void btn_cancelar_C_U_Click(object sender, EventArgs e)
        {
			txt_nombre_R_U.Clear();
			btn_Ingreso_U.Enabled = false;
			btn_Salida_U.Enabled = false;
			txt_Documento_C_U.Clear();
			txt_BuscarBien_C_U.Clear();
			DataTable dt = (DataTable)DGVControl_U.DataSource;
			dt.Clear();

		}

        private void cb_FechaFiltrar_U_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_Ingreso_U_Click(object sender, EventArgs e)
        {
			//captura ID del bien
			long idbien = Convert.ToInt64(DGVControl_U.CurrentRow.Cells[0].Value.ToString());
			if (ClaseControlFrmVigilante.Fun_ControlBien(idbien))
			{
				MessageBox.Show("Bien ingresado satisfactoriamente");
				btn_cancelar_C_U_Click(sender, e);
			}
		}

        private void relogR_Tick(object sender, EventArgs e)
        {
			lbl_horaR.Text = DateTime.Now.ToString("hh:mm:ss tt", CultureInfo.InvariantCulture);
		}

        private void button1_Click(object sender, EventArgs e)
        {
			DialogResult rpta = new DialogResult();
			rpta = MessageBox.Show("¿Desea Salir?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (rpta == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void btn_Salida_U_Click(object sender, EventArgs e)
		{
			long idbien = Convert.ToInt64(DGVControl_U.CurrentRow.Cells[0].Value.ToString());
			if (ClaseControlFrmVigilante.Fun_ControlBien(idbien))
			{
				MessageBox.Show("Vuelva pronto");
				btn_cancelar_C_U_Click(sender, e);
			}
		}

		private void txt_BuscarBien_C_U_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
			{
				btn_Busrcar_R_U_Click(sender, e);
			}
		}

		private void txt_Documento_C_U_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

        private void DGVControl_U_CellClick(object sender, DataGridViewCellEventArgs e)
        {
			n = e.RowIndex;

			
				long idbien = Convert.ToInt64(DGVControl_U.CurrentRow.Cells[0].Value);
				DataTable tabla = ClaseControlFrmVigilante.Fun_ValidarBien(idbien);
				if (tabla.Rows.Count > 1)
				{
					btn_Ingreso_U.Enabled = false;
					btn_Salida_U.Enabled = true;
				}
                else
                {
					btn_Salida_U.Enabled = false;
					btn_Ingreso_U.Enabled = true;
				}
            
        }

        private void FrmControl_Activated(object sender, EventArgs e)
        {

        }
    }
}
