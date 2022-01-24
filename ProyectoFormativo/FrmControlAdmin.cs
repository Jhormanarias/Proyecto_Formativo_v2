using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Collections;
using Controllers;

namespace ProyectoFormativo
{
	public partial class FrmControlAdmin : Form
	{
		//Vaiables modulo reportes
		ClaseControlAdmin objp = new ClaseControlAdmin();
		DataSet dsTabla;
		int PagInicio = 1, Indice = 0, NumFilas = 10, PagFinal, control = 0;
		DateTime fechaR;
		long doc = 0;

		//variables modulo control
		private int n = 0;

		public FrmControlAdmin()
		{
			InitializeComponent();
			MostrarColores();
			PagFinal = NumFilas;
			CargarDG();
		}

        private void timerAdmin_Tick(object sender, EventArgs e)
        {
			lbl_horaAdmin.Text = DateTime.Now.ToString("hh:mm:ss tt", CultureInfo.InvariantCulture);
			lbl_horaRAdminReporte.Text = DateTime.Now.ToString("hh:mm:ss tt", CultureInfo.InvariantCulture);
		}

		//Lista de colores para el bombobox
        public enum KnownColorNew
        {
            Black = 35,
            Blue = 37,
            Fuchsia = 73,
            Gray = 78,
            Green = 79,
            Maroon = 108,
            Orange = 127,
            Pink = 137,
            Purple = 140,
            Red = 141,
            Silver = 150,
            Violet = 162,
            White = 164,
			Yellow = 166,
		}

		//Funcion para cargar los colores al combobox
        private void MostrarColores()
		{
			cb_Color.Items.Clear();
			string[] colores = Enum.GetNames(typeof(KnownColorNew));
			cb_Color.Items.AddRange(colores);
        }

		//Dibujo los items en el combobox
        private void cb_Color_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
				e.DrawBackground();
				string texto = cb_Color.Items[e.Index].ToString();
				Brush borde = new SolidBrush(e.ForeColor);
				Color color = System.Drawing.Color.FromName(texto);
				Brush pincel = new SolidBrush(color);
				Pen boli = new Pen(e.ForeColor);

				e.Graphics.DrawRectangle(boli, new Rectangle(e.Bounds.Left + 2, e.Bounds.Top + 2, 20, e.Bounds.Height - 4));
				e.Graphics.FillRectangle(pincel, new Rectangle(e.Bounds.Left + 3, e.Bounds.Top + 3, 18, e.Bounds.Height - 6));
				e.Graphics.DrawString(texto, e.Font, borde, e.Bounds.Left + 25, e.Bounds.Top + 2);

				e.DrawFocusRectangle();
            }
            catch (Exception ex)
            {
				MessageBox.Show(ex.Message);
            }
        }

		private void FrmControlAdmin_Load(object sender, EventArgs e)
		{
			lbl_Nom_User.Visible = true;
			lbl_Rol.Visible = true;
			lbl_Nom_User.Text = ClaseControlFrmVigilante.usuario;
			lbl_Rol.Text = ClaseControlFrmVigilante.rol;

			btnIngresoAdmin.BackColor = System.Drawing.SystemColors.ButtonFace;
			btnIngresoAdmin.ForeColor = System.Drawing.SystemColors.ControlLight;
			btnSalidaAdmin.BackColor = System.Drawing.SystemColors.ButtonFace;
			btnSalidaAdmin.ForeColor = System.Drawing.SystemColors.ControlLight;

			btnFiltarR.BackColor = System.Drawing.SystemColors.ButtonFace;
			btnFiltarR.ForeColor = System.Drawing.SystemColors.ControlLight;
		}

		//----------------------------------------------------- MODULO CONTROL ---------------------------------------------------------//
		private void btnBuscar_ControlA_Click(object sender, EventArgs e)
        {
			//DGVControl_U.ColumnHeadersVisible = false;
			if (txt_Documento_C_Admin.Text == "" & txt_BuscarBien_C_Admin.Text == "")
			{
				MessageBox.Show("Llene un campo", "Adertencia!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				//buscar en la base de datos el visitante o bien
				if (txt_Documento_C_Admin.Text != "")
				{
					txt_nombre_R_Admin.Text = ClaseControlAdmin.Func_TraeNomVisitante(Convert.ToInt64(txt_Documento_C_Admin.Text));
					DGVControl_Admin.DataSource = ClaseControlAdmin.Func_BusVisitante(Convert.ToInt64(txt_Documento_C_Admin.Text));
				}
				else if (txt_BuscarBien_C_Admin.Text != "")
				{
					txt_nombre_R_Admin.Text = ClaseControlAdmin.Func_TraeNomVisitanteS(txt_BuscarBien_C_Admin.Text);
					DGVControl_Admin.DataSource = ClaseControlAdmin.Func_BusVisitanteBien(txt_BuscarBien_C_Admin.Text);
				}

				if (txt_nombre_R_Admin.Text == "")
				{
					MessageBox.Show("Visitante o bien no registrado", "Adertencia!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{

					long idbien = Convert.ToInt64(DGVControl_Admin.CurrentRow.Cells[0].Value);
					DataTable tabla = ClaseControlAdmin.Fun_ValidarBien(idbien);
					if (tabla.Rows.Count > 1)
					{
						btnIngresoAdmin.Enabled = false;
						btnSalidaAdmin.Enabled = true;
						btnSalidaAdmin.BackColor = System.Drawing.SystemColors.MenuHighlight;
						btnSalidaAdmin.ForeColor = System.Drawing.SystemColors.HighlightText;
						btnIngresoAdmin.BackColor = System.Drawing.SystemColors.ButtonFace;
						btnIngresoAdmin.ForeColor = System.Drawing.SystemColors.ControlLight;
					}
					else
					{
						btnSalidaAdmin.Enabled = false;
						btnIngresoAdmin.Enabled = true;
						btnIngresoAdmin.BackColor = System.Drawing.SystemColors.MenuHighlight;
						btnIngresoAdmin.ForeColor = System.Drawing.SystemColors.HighlightText;
						btnSalidaAdmin.BackColor = System.Drawing.SystemColors.ButtonFace;
						btnSalidaAdmin.ForeColor = System.Drawing.SystemColors.ControlLight;
					}
				}
			}
		}

        private void btn_cancelarAdmin_Click(object sender, EventArgs e)
        {
			txt_nombre_R_Admin.Clear();
			btnIngresoAdmin.Enabled = false;
			btnSalidaAdmin.Enabled = false;
			txt_Documento_C_Admin.Clear();
			txt_BuscarBien_C_Admin.Clear();
			btnIngresoAdmin.BackColor = System.Drawing.SystemColors.ButtonFace;
			btnIngresoAdmin.ForeColor = System.Drawing.SystemColors.ControlLight;
			btnSalidaAdmin.BackColor = System.Drawing.SystemColors.ButtonFace;
			btnSalidaAdmin.ForeColor = System.Drawing.SystemColors.ControlLight;
			DataTable dt = (DataTable)DGVControl_Admin.DataSource;
			if (dt != null)
			{
				dt.Clear();
			}
		}

		private void btnIngresoAdmin_Click(object sender, EventArgs e)
		{
			//captura ID del bien
			long idbien = Convert.ToInt64(DGVControl_Admin.CurrentRow.Cells[0].Value.ToString());
			if (ClaseControlFrmVigilante.Fun_ControlBien(idbien))
			{
				MessageBox.Show("Ingreso registrado", "Felicidades!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btn_cancelarAdmin_Click(sender, e);
				FrmControlAdmin_Load(sender, e);
				//combox_pag_SelectionChangeCommitted(sender, e);
			}
		}

		private void btnSalidaAdmin_Click(object sender, EventArgs e)
        {
			long idbien = Convert.ToInt64(DGVControl_Admin.CurrentRow.Cells[0].Value.ToString());
			if (ClaseControlFrmVigilante.Fun_ControlBien(idbien))
			{
				MessageBox.Show("Salida registrada", "Felicidades!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btn_cancelarAdmin_Click(sender, e);
				//combox_pag_SelectionChangeCommitted(sender, e);
			}
		}

        private void txt_BuscarBien_C_Admin_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
			{
				btnBuscar_ControlA_Click(sender, e);
			}
		}

        private void txt_Documento_C_Admin_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
			{
				btnBuscar_ControlA_Click(sender, e);
			}

			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

        private void btnSalirControl_Click(object sender, EventArgs e)
        {
			DialogResult rpta = new DialogResult();
			rpta = MessageBox.Show("¿Desea Salir?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (rpta == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

        private void DGVControl_Admin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
			n = e.RowIndex;

			if (n != -1)
			{
				long idbien = Convert.ToInt64(DGVControl_Admin.CurrentRow.Cells[0].Value);
				DataTable tabla = ClaseControlFrmVigilante.Fun_ValidarBien(idbien);

				if (tabla.Rows.Count > 1)
				{
					btnIngresoAdmin.Enabled = false;
					btnSalidaAdmin.Enabled = true;
					btnSalidaAdmin.BackColor = System.Drawing.SystemColors.MenuHighlight;
					btnSalidaAdmin.ForeColor = System.Drawing.SystemColors.HighlightText;
					btnIngresoAdmin.BackColor = System.Drawing.SystemColors.ButtonFace;
					btnIngresoAdmin.ForeColor = System.Drawing.SystemColors.ControlLight;
				}
				else
				{
					btnSalidaAdmin.Enabled = false;
					btnIngresoAdmin.Enabled = true;
					btnIngresoAdmin.BackColor = System.Drawing.SystemColors.MenuHighlight;
					btnIngresoAdmin.ForeColor = System.Drawing.SystemColors.HighlightText;
					btnSalidaAdmin.BackColor = System.Drawing.SystemColors.ButtonFace;
					btnSalidaAdmin.ForeColor = System.Drawing.SystemColors.ControlLight;
				}
			}
		}

        //--------------------------------------------------- FIN MODULO CONTROL ----------------------------------------------------


        //---------------------------------------------------- MODULO REPORTES ------------------------------------------------------

        private void btn_salirReportes_Click(object sender, EventArgs e)
		{
			DialogResult rpta = new DialogResult();
			rpta = MessageBox.Show("¿Desea Salir?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (rpta == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void txt_filtrarReporteDocAdmin_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
			{
				btnFiltarR_Click(sender, e);
			}
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void txt_filtrarReporteDocAdmin_Enter(object sender, EventArgs e)
		{
			if (txt_filtrarReporteDocAdmin.Text == "Documento")
			{
				txt_filtrarReporteDocAdmin.Text = "";
				this.txt_filtrarReporteDocAdmin.ForeColor = System.Drawing.Color.Black;
			}
		}

		private void txt_filtrarReporteDocAdmin_Leave(object sender, EventArgs e)
		{
			if (txt_filtrarReporteDocAdmin.Text == "")
			{
				txt_filtrarReporteDocAdmin.Text = "Documento";
				this.txt_filtrarReporteDocAdmin.ForeColor = System.Drawing.Color.DimGray;
			}
		}

		private void cb_Fecha_RAdmin_CheckedChanged(object sender, EventArgs e)
		{
			dt_Fecha_RAdmin.Enabled = true;
			btnFiltarR.Enabled = true;
			btnFiltarR.BackColor = System.Drawing.SystemColors.MenuHighlight;
			btnFiltarR.ForeColor = System.Drawing.SystemColors.HighlightText;

			if (this.dt_Fecha_RAdmin.Checked == false)
			{
				dt_Fecha_RAdmin.Enabled = false;
			}
			if (this.cb_Fecha_RAdmin.Checked == false && this.cb_Documento_RAdmin.Checked == false)
			{
				//DGVReportes.DataSource = ClaseControlFrmVigilante.Func_Reportes();
				CargarDG();
				btnFiltarR.Enabled = false;
				btnFiltarR.BackColor = System.Drawing.SystemColors.ButtonFace;
				btnFiltarR.ForeColor = System.Drawing.SystemColors.ControlLight;
			}
		}

		private void cb_Documento_RAdmin_CheckedChanged(object sender, EventArgs e)
		{
			txt_filtrarReporteDocAdmin.Enabled = true;
			btnFiltarR.Enabled = true;
			btnFiltarR.BackColor = System.Drawing.SystemColors.MenuHighlight;
			btnFiltarR.ForeColor = System.Drawing.SystemColors.HighlightText;

			if (this.cb_Documento_RAdmin.Checked == false)
			{
				txt_filtrarReporteDocAdmin.Enabled = false;
				txt_filtrarReporteDocAdmin.Text = "Documento";
				txt_filtrarReporteDocAdmin.ForeColor = System.Drawing.Color.Silver;
			}
			if (this.cb_Fecha_RAdmin.Checked == false && this.cb_Documento_RAdmin.Checked == false)
			{
				CargarDG();
				btnFiltarR.Enabled = false;
				btnFiltarR.BackColor = System.Drawing.SystemColors.ButtonFace;
				btnFiltarR.ForeColor = System.Drawing.SystemColors.ControlLight;
			}
		}

		private void btnFiltarR_Click(object sender, EventArgs e)
		{
			fechaR = dt_Fecha_RAdmin.Value;
			//filtro por documento
			if (this.cb_Documento_RAdmin.Checked == true && this.cb_Fecha_RAdmin.Checked == false)
			{
				if (txt_filtrarReporteDocAdmin.Text == "Documento" || txt_filtrarReporteDocAdmin.Text == "")
				{
					MessageBox.Show("Ingrese un documento");
				}
				else
				{
					doc = Convert.ToInt64(txt_filtrarReporteDocAdmin.Text);
					//DataTable tabla = ClaseControlFrmVigilante.Func_FiltrarDoc(doc);
					dsTabla = objp.Func_FiltrarDocx(doc);
					DataTable Tabla = dsTabla.Tables[1];

					if (Tabla.Rows.Count > 0)
					{
						//DGVReportes.DataSource = ClaseControlFrmVigilante.Func_FiltrarDoc(doc);
						CargarDGFiltrarCx();
					}
					else
					{
						MessageBox.Show("Sin reportes", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
						DataTable dt = (DataTable)DGVReportesAdmin.DataSource;
						if (dt == null)
						{
							//DGVReportes.DataSource = ClaseControlFrmVigilante.Func_Reportes();
							CargarDG();
						}
					}
				}
			}

			//Filtro por fecha
			if (this.cb_Fecha_RAdmin.Checked == true && this.cb_Documento_RAdmin.Checked == false)
			{
				//DataTable tabla = ClaseControlFrmVigilante.Func_FiltrarFe(fechaR);
				dsTabla = objp.Func_FiltrarFex(fechaR);
				DataTable Tabla = dsTabla.Tables[1];
				if (Tabla.Rows.Count > 0)
				{
					//DGVReportes.DataSource = ClaseControlFrmVigilante.Func_FiltrarFe(fechaR);
					CargarDGFiltrarFx();
				}
				else
				{
					MessageBox.Show("Sin reportes", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
					DataTable dt = (DataTable)DGVReportesAdmin.DataSource;
					if (dt == null)
					{
						//DGVReportes.DataSource = ClaseControlFrmVigilante.Func_Reportes();
						CargarDG();
					}
				}

			}

			//Filtro por fecha y documendo
			if (this.cb_Documento_RAdmin.Checked == true & this.cb_Fecha_RAdmin.Checked == true)
			{
				if (txt_filtrarReporteDocAdmin.Text == "Documento" || txt_filtrarReporteDocAdmin.Text == "")
				{
					MessageBox.Show("Ingrese un documento");
				}
				else
				{
					doc = Convert.ToInt64(txt_filtrarReporteDocAdmin.Text);
					//DataTable tabla = ClaseControlFrmVigilante.Func_Filtrar(fechaR, doc);
					dsTabla = objp.Func_Filtrarx(fechaR, doc);
					DataTable Tabla = dsTabla.Tables[1];
					if (Tabla.Rows.Count > 0)
					{
						//DGVReportes.DataSource = ClaseControlFrmVigilante.Func_Filtrar(fechaR, doc);
						CargarDGFiltrarDFx();
					}
					else
					{
						MessageBox.Show("Sin reportes", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
						DataTable dt = (DataTable)DGVReportesAdmin.DataSource;
						if (dt == null)
						{
							//DGVReportes.DataSource = ClaseControlFrmVigilante.Func_Reportes();
							CargarDG();
						}
					}

				}
			}
		}

		private void CargarDG()
		{
			objp.Inicio1 = PagInicio;
			objp.Final1 = PagFinal;
			dsTabla = objp.Func_Reportes();
			DGVReportesAdmin.DataSource = dsTabla.Tables[1];
			//DGVReportes.Columns[0].Visible = false;

			int cantidad = Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) / NumFilas;

			if (Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) % NumFilas > 0) cantidad++;

			txt_CantidadAdmin.Text = cantidad.ToString();
			combox_pagAdmin.Items.Clear();

			for (int x = 1; x <= cantidad; x++)
			{
				combox_pagAdmin.Items.Add(x.ToString());
			}

			combox_pagAdmin.SelectedIndex = Indice;

			control = 0;
		}

		private void CargarDGFiltrarC()
		{
			objp.Inicio1 = PagInicio;
			objp.Final1 = PagFinal;
			dsTabla = objp.Func_FiltrarDoc(doc);
			DGVReportesAdmin.DataSource = dsTabla.Tables[1];
			//DGVReportes.Columns[0].Visible = false;

			int cantidad = Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) / NumFilas;

			if (Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) % NumFilas > 0) cantidad++;

			txt_CantidadAdmin.Text = cantidad.ToString();
			combox_pagAdmin.Items.Clear();

			for (int x = 1; x <= cantidad; x++)
			{
				combox_pagAdmin.Items.Add(x.ToString());
			}

			combox_pagAdmin.SelectedIndex = Indice - 1;

			control = 1;
		}

		private void CargarDGFiltrarCx()
		{
			objp.Inicio1 = 1;
			objp.Final1 = 10;
			dsTabla = objp.Func_FiltrarDoc(doc);
			DGVReportesAdmin.DataSource = dsTabla.Tables[1];
			//DGVReportes.Columns[0].Visible = false;

			int cantidad = Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) / NumFilas;

			if (Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) % NumFilas > 0) cantidad++;

			txt_CantidadAdmin.Text = cantidad.ToString();
			combox_pagAdmin.Items.Clear();

			for (int x = 1; x <= cantidad; x++)
			{
				combox_pagAdmin.Items.Add(x.ToString());
			}

			combox_pagAdmin.SelectedIndex = 0;

			control = 1;
		}
		private void CargarDGFiltrarF()
		{
			objp.Inicio1 = PagInicio;
			objp.Final1 = PagFinal;
			dsTabla = objp.Func_FiltrarFe(fechaR);
			DGVReportesAdmin.DataSource = dsTabla.Tables[1];
			//DGVReportes.Columns[0].Visible = false;

			int cantidad = Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) / NumFilas;

			if (Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) % NumFilas > 0) cantidad++;

			txt_CantidadAdmin.Text = cantidad.ToString();
			combox_pagAdmin.Items.Clear();

			for (int x = 1; x <= cantidad; x++)
			{
				combox_pagAdmin.Items.Add(x.ToString());
			}

			combox_pagAdmin.SelectedIndex = 0;

			control = 2;
		}

        private void CargarDGFiltrarFx()
		{
			objp.Inicio1 = 1;
			objp.Final1 = 10;
			dsTabla = objp.Func_FiltrarFe(fechaR);
			DGVReportesAdmin.DataSource = dsTabla.Tables[1];
			//DGVReportes.Columns[0].Visible = false;

			int cantidad = Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) / NumFilas;

			if (Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) % NumFilas > 0) cantidad++;

			txt_CantidadAdmin.Text = cantidad.ToString();
			combox_pagAdmin.Items.Clear();

			for (int x = 1; x <= cantidad; x++)
			{
				combox_pagAdmin.Items.Add(x.ToString());
			}

			combox_pagAdmin.SelectedIndex = 0;

			control = 2;
		}

		private void CargarDGFiltrarDF()
		{
			objp.Inicio1 = PagInicio;
			objp.Final1 = PagFinal;
			dsTabla = objp.Func_Filtrar(fechaR, doc);
			DGVReportesAdmin.DataSource = dsTabla.Tables[1];
			//DGVReportes.Columns[0].Visible = false;

			int cantidad = Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) / NumFilas;

			if (Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) % NumFilas > 0) cantidad++;

			txt_CantidadAdmin.Text = cantidad.ToString();
			combox_pagAdmin.Items.Clear();

			for (int x = 1; x <= cantidad; x++)
			{
				combox_pagAdmin.Items.Add(x.ToString());
			}

			combox_pagAdmin.SelectedIndex = 0;

			control = 3;
		}

		private void CargarDGFiltrarDFx()
		{
			objp.Inicio1 = 1;
			objp.Final1 = 10;
			dsTabla = objp.Func_Filtrar(fechaR, doc);
			DGVReportesAdmin.DataSource = dsTabla.Tables[1];
			//DGVReportes.Columns[0].Visible = false;

			int cantidad = Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) / NumFilas;

			if (Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) % NumFilas > 0) cantidad++;

			txt_CantidadAdmin.Text = cantidad.ToString();
			combox_pagAdmin.Items.Clear();

			for (int x = 1; x <= cantidad; x++)
			{
				combox_pagAdmin.Items.Add(x.ToString());
			}

			combox_pagAdmin.SelectedIndex = 0;

			control = 3;
		}

		//accion para cambiar de paginas en la tabla
		private void combox_pagAdmin_SelectionChangeCommitted(object sender, EventArgs e)
		{
			int pagina = Convert.ToInt32(combox_pagAdmin.SelectedItem.ToString());
			Indice = pagina - 1;
			PagInicio = (pagina - 1) * NumFilas + 1;
			PagFinal = pagina * NumFilas;

			if (control == 0)
			{
				CargarDG();
			}
			if (control == 1)
			{
				CargarDGFiltrarC();
			}
			if (control == 2)
			{
				CargarDGFiltrarF();
			}
			if (control == 3)
			{
				CargarDGFiltrarDF();
			}
		}

		private void DGVReportesAdmin_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (this.DGVReportesAdmin.Columns[e.ColumnIndex].HeaderText == "Hora S.")
			{
				if (e.Value.GetType() == typeof(System.DBNull))
				{
					e.CellStyle.BackColor = System.Drawing.Color.Yellow;
				}
			}
		}

		//------------------------------------------------- FIN MODULO REPORTES --------------------------------------------------
	}
} 