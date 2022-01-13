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
using System.Runtime.InteropServices;

namespace ProyectoFormativo
{
	public partial class FrmControlVigi : Form
	{
		public FrmControlVigi()
		{
			InitializeComponent();
		}
		
		private int n = 0;
		private void relog_Tick(object sender, EventArgs e)
		{
			lbl_hora.Text = DateTime.Now.ToString("hh:mm:ss tt", CultureInfo.InvariantCulture);
		}
		//private void FrmControl_Load(object sender, EventArgs e)
		//{
		//	dataGridView1.AutoGenerateColumns = false;
		//}

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
			//DGVControl_U.ColumnHeadersVisible = false;
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
				else if (txt_BuscarBien_C_U.Text != "")
				{
					txt_nombre_R_U.Text = ClaseControlFrmVigilante.Func_TraeNomVisitanteS(txt_BuscarBien_C_U.Text);
					DGVControl_U.DataSource = ClaseControlFrmVigilante.Func_BusVisitanteBien(txt_BuscarBien_C_U.Text);
				}

				if (txt_nombre_R_U.Text == "")
				{
					MessageBox.Show("Visitante o bien no registrado", "Adertencia!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
                else
                {
					
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
			if (dt != null)
            {
				dt.Clear();
			}
		}


        private void btn_Ingreso_U_Click(object sender, EventArgs e)
        {
			//captura ID del bien
			long idbien = Convert.ToInt64(DGVControl_U.CurrentRow.Cells[0].Value.ToString());
			if (ClaseControlFrmVigilante.Fun_ControlBien(idbien))
			{
				MessageBox.Show("Ingreso registrado", "Felicidades!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btn_cancelar_C_U_Click(sender, e);
				FrmControlVigi_Load(sender, e);
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
				MessageBox.Show("Salida registrada", "Felicidades!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btn_cancelar_C_U_Click(sender, e);
				FrmControlVigi_Load(sender, e);
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

			if (n != -1)
            {
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
        }

		private void txt_filtrarReporteDoc_Enter(object sender, EventArgs e)
		{

			if (txt_filtrarReporteDoc.Text == "Documento")
			{
				txt_filtrarReporteDoc.Text = "";
				this.txt_filtrarReporteDoc.ForeColor = System.Drawing.Color.Black;
			}
		}

        private void txt_filtrarReporteDoc_Leave(object sender, EventArgs e)
        {
			if (txt_filtrarReporteDoc.Text == "")
			{
				txt_filtrarReporteDoc.Text = "Documento";
				this.txt_filtrarReporteDoc.ForeColor = System.Drawing.Color.DimGray;
			}
		}

        private void cb_Documento_R_CheckedChanged(object sender, EventArgs e)
        {
			txt_filtrarReporteDoc.Enabled = true;
			btn_Feltar.Enabled = true;
			if (this.cb_Documento_R.Checked == false)
            {
				txt_filtrarReporteDoc.Enabled = false;
				txt_filtrarReporteDoc.Text = "Documento";
				txt_filtrarReporteDoc.ForeColor = System.Drawing.Color.Silver;
			}
			if (this.cb_Fecha_R.Checked == false && this.cb_Documento_R.Checked == false)
			{
				DGVReportes.DataSource = ClaseControlFrmVigilante.Func_Reportes();
				btn_Feltar.Enabled = false;
			}
		}

        private void cb_Fecha_R_CheckedChanged(object sender, EventArgs e)
        {
			dt_Fecha_R.Enabled = true;
			btn_Feltar.Enabled = true;
			if (this.cb_Fecha_R.Checked == false)
			{
				dt_Fecha_R.Enabled = false;
			}
			if (this.cb_Fecha_R.Checked == false && this.cb_Documento_R.Checked == false)
            {
				DGVReportes.DataSource = ClaseControlFrmVigilante.Func_Reportes();
				btn_Feltar.Enabled = false;
			}
		}

        private void FrmControlVigi_Activated(object sender, EventArgs e)
        {
			//lbl_Nom_User.Visible = true;
			//lbl_Nom_User.Text = ClaseControlFrmVigilante.usuario;
			//DGVReportes.DataSource = ClaseControlFrmVigilante.Func_Reportes();

			//int c = DGVReportes.Rows.Count;
			//if (c > 0)
			//{
			//	for (int i = 0; i < c; i++)
			//	{
			//		if (DGVReportes.Rows[i].Cells[5].Value.GetType() == typeof(System.DBNull))
			//		{
			//			DGVReportes.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Yellow;

			//		}
			//	}
			//}
		}

		private void FrmControlVigi_Load(object sender, EventArgs e)
		{
			lbl_Nom_User.Visible = true;
			lbl_Nom_User.Text = ClaseControlFrmVigilante.usuario;
			DGVReportes.DataSource = ClaseControlFrmVigilante.Func_Reportes();
		}

		private void DGVReportes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.DGVReportes.Columns[e.ColumnIndex].HeaderText == "H. Salida")
            {
                if (e.Value.GetType() == typeof(System.DBNull))
                {
                    e.CellStyle.BackColor = System.Drawing.Color.Yellow;
                }
            }
        }

        private void btn_Feltar_Click(object sender, EventArgs e)
        {
			DateTime fechaR = dt_Fecha_R.Value;
			long doc = 0;
			if (this.cb_Documento_R.Checked == true && this.cb_Fecha_R.Checked == false)
            {
				if (txt_filtrarReporteDoc.Text == "Documento" || txt_filtrarReporteDoc.Text == "")
				{
					MessageBox.Show("Ingrese un documento");
				}
				else
				{
					doc = Convert.ToInt64(txt_filtrarReporteDoc.Text);
					DataTable tabla = ClaseControlFrmVigilante.Func_FiltrarDoc(doc);
					if (tabla.Rows.Count > 0)
                    {
						DGVReportes.DataSource = ClaseControlFrmVigilante.Func_FiltrarDoc(doc);
					}
                    else
                    {
						MessageBox.Show("Sin reportes", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
						DataTable dt = (DataTable)DGVReportes.DataSource;
						if (dt == null)
						{
							DGVReportes.DataSource = ClaseControlFrmVigilante.Func_Reportes();
						}
					}
				}
			}
			
			if (this.cb_Fecha_R.Checked == true && this.cb_Documento_R.Checked == false)
            {
				DataTable tabla = ClaseControlFrmVigilante.Func_FiltrarFe(fechaR);
				if (tabla.Rows.Count > 0)
				{

					DGVReportes.DataSource = ClaseControlFrmVigilante.Func_FiltrarFe(fechaR);
				}
				else
				{
					MessageBox.Show("Sin reportes", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
					DataTable dt = (DataTable)DGVReportes.DataSource;
					if (dt == null)
					{
						DGVReportes.DataSource = ClaseControlFrmVigilante.Func_Reportes();
					}
				}
				
			}

			if(this.cb_Documento_R.Checked == true & this.cb_Fecha_R.Checked == true)
            {
				if (txt_filtrarReporteDoc.Text == "Documento" || txt_filtrarReporteDoc.Text == "")
				{
					MessageBox.Show("Ingrese un documento");
				}
				else
				{
					doc = Convert.ToInt64(txt_filtrarReporteDoc.Text);
					DataTable tabla = ClaseControlFrmVigilante.Func_Filtrar(fechaR, doc);
					if (tabla.Rows.Count > 0)
					{
						DGVReportes.DataSource = ClaseControlFrmVigilante.Func_Filtrar(fechaR, doc);
					}
					else
					{
						MessageBox.Show("Sin reportes", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
						DataTable dt = (DataTable)DGVReportes.DataSource;
						if (dt == null)
						{
							DGVReportes.DataSource = ClaseControlFrmVigilante.Func_Reportes();
						}
					}
					
				}
			}
				
		}

        private void txt_filtrarReporteDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
			if (e.KeyChar == (char)13)
			{
				btn_Feltar_Click(sender, e);
			}
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}
    }
}
