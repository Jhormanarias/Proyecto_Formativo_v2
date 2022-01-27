﻿using System;
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
		//Vaiables para paginacion de las tablas
		ClaseControlAdmin objp = new ClaseControlAdmin();
		DataSet dsTabla;
		int PagInicio = 1, Indice = 0, NumFilas = 10, PagFinal, control = 0;
		DateTime fechaR;
		long doc = 0;

		//variables modulo control
		private int n = 0;

		//variables formulario equipo
		private string id_visitante = "";
		private string serialBien = "";

		public FrmControlAdmin()
		{
			InitializeComponent();
			MostrarColores();
			PagFinal = NumFilas;
			CargarDG();
			CargarDGBienes();
		}

        private void timerAdmin_Tick(object sender, EventArgs e)
        {
			lbl_horaAdmin.Text = DateTime.Now.ToString("hh:mm:ss tt", CultureInfo.InvariantCulture);
			lbl_horaRAdminReporte.Text = DateTime.Now.ToString("hh:mm:ss tt", CultureInfo.InvariantCulture);
		}

		//Lista de colores para el combobox
        public enum KnownColorNew
        {
            Black = 1,
            Blue = 2,
            Fuchsia = 3,
            Gray = 4,
            Green = 5,
            Maroon = 6,
            Orange = 7,
            Pink = 8,
            Purple = 9,
            Red = 10,
            Silver = 11,
            Violet = 12,
            White = 13,
			Yellow = 14,
			Multicolor = 15
		}
		public enum KnownColorNewEs
		{
			Negro = 1,
			Azul = 2,
			Fucsia = 3,
			Gris = 4,
			Verde = 5,
			Marrón = 6,
			Naranja = 7,
			Rosa = 8,
			Púrpura = 9,
			Rojo = 10,
			Plata = 11,
			Violeta = 12,
			Blanco = 13,
			Amarillo = 14,
			Multicolor = 15
		}

		//Funcion para cargar los colores al combobox
		private void MostrarColores()
		{
			cb_Color.Items.Clear();
			string[] colores = Enum.GetNames(typeof(KnownColorNewEs));
			cb_Color.Items.AddRange(colores);
        }

		//Dibujo los items en el combobox
        private void cb_Color_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
				e.DrawBackground();
				string[] textoEs = Enum.GetNames(typeof(KnownColorNewEs));
				string[] texto = Enum.GetNames(typeof(KnownColorNew));
				Brush borde = new SolidBrush(e.ForeColor);
				Color color = System.Drawing.Color.FromName(texto[e.Index]);
				Brush pincel = new SolidBrush(color);
				Pen boli = new Pen(e.ForeColor);

				e.Graphics.DrawRectangle(boli, new Rectangle(e.Bounds.Left + 2, e.Bounds.Top + 2, 20, e.Bounds.Height - 4));
				e.Graphics.FillRectangle(pincel, new Rectangle(e.Bounds.Left + 3, e.Bounds.Top + 3, 18, e.Bounds.Height - 6));
				e.Graphics.DrawString(textoEs[e.Index], e.Font, borde, e.Bounds.Left + 25, e.Bounds.Top + 2);

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

			//formulario control
			btnIngresoAdmin.BackColor = System.Drawing.SystemColors.ButtonFace;
			btnIngresoAdmin.ForeColor = System.Drawing.SystemColors.ControlLight;
			btnSalidaAdmin.BackColor = System.Drawing.SystemColors.ButtonFace;
			btnSalidaAdmin.ForeColor = System.Drawing.SystemColors.ControlLight;

			//formulario reportes
			btnFiltarR.BackColor = System.Drawing.SystemColors.ButtonFace;
			btnFiltarR.ForeColor = System.Drawing.SystemColors.ControlLight;

			//formulario equipos
			btnGuardarE.BackColor = System.Drawing.SystemColors.ButtonFace;
			btnGuardarE.ForeColor = System.Drawing.SystemColors.ControlLight;
			btnModificarBien.BackColor = System.Drawing.SystemColors.ButtonFace;
			btnModificarBien.ForeColor = System.Drawing.SystemColors.ControlLight;
			btnEliminarBien.BackColor = System.Drawing.SystemColors.ButtonFace;
			btnEliminarBien.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.txtDoc_Equipo.ForeColor = System.Drawing.Color.DimGray;
			this.txtTipodeBienE.ForeColor = System.Drawing.Color.DimGray;
			this.txtMarcaE.ForeColor = System.Drawing.Color.DimGray;
			this.txtNSerieE.ForeColor = System.Drawing.Color.DimGray;
			this.txtCargadorE.ForeColor = System.Drawing.Color.DimGray;
		}

		//----------------------------------------------------- MODULO CONTROL ---------------------------------------------------------//
		private void btnBuscar_ControlA_Click(object sender, EventArgs e)
        {
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

				DataTable dt = (DataTable)DGVReportesAdmin.DataSource;
				if (dt.Rows.Count > 0)
				{
					combox_pagAdmin_SelectionChangeCommitted(sender, e);
                }
                else
                {
					CargarDG();
                }
			}
		}

		private void btnSalidaAdmin_Click(object sender, EventArgs e)
        {
			long idbien = Convert.ToInt64(DGVControl_Admin.CurrentRow.Cells[0].Value.ToString());
			if (ClaseControlFrmVigilante.Fun_ControlBien(idbien))
			{
				MessageBox.Show("Salida registrada", "Felicidades!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btn_cancelarAdmin_Click(sender, e);

				DataTable dt = (DataTable)DGVReportesAdmin.DataSource;
				if (dt.Rows.Count > 0)
				{
					combox_pagAdmin_SelectionChangeCommitted(sender, e);
				}
				else
				{
					CargarDG();
				}
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
					dsTabla = objp.Func_FiltrarDocx(doc);
					DataTable Tabla = dsTabla.Tables[1];

					if (Tabla.Rows.Count > 0)
					{
						CargarDGFiltrarCx();
					}
					else
					{
						MessageBox.Show("Sin reportes", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
						DataTable dt = (DataTable)DGVReportesAdmin.DataSource;
						if (dt == null)
						{
							CargarDG();
						}
					}
				}
			}

			//Filtro por fecha
			if (this.cb_Fecha_RAdmin.Checked == true && this.cb_Documento_RAdmin.Checked == false)
			{
				dsTabla = objp.Func_FiltrarFex(fechaR);
				DataTable Tabla = dsTabla.Tables[1];
				if (Tabla.Rows.Count > 0)
				{
					CargarDGFiltrarFx();
				}
				else
				{
					MessageBox.Show("Sin reportes", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
					DataTable dt = (DataTable)DGVReportesAdmin.DataSource;
					if (dt == null)
					{
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
					dsTabla = objp.Func_Filtrarx(fechaR, doc);
					DataTable Tabla = dsTabla.Tables[1];
					if (Tabla.Rows.Count > 0)
					{
						CargarDGFiltrarDFx();
					}
					else
					{
						MessageBox.Show("Sin reportes", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
						DataTable dt = (DataTable)DGVReportesAdmin.DataSource;
						if (dt == null)
						{
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

			int cantidad = Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) / NumFilas;

			if (Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) % NumFilas > 0) cantidad++;

			txt_CantidadAdmin.Text = cantidad.ToString();
			combox_pagAdmin.Items.Clear();

			for (int x = 1; x <= cantidad; x++)
			{
				combox_pagAdmin.Items.Add(x.ToString());
			}

			DataTable dt = (DataTable)DGVReportesAdmin.DataSource;
			if (dt.Rows.Count > 0)
			{
				combox_pagAdmin.SelectedIndex = Indice;
			}

			control = 0;
		}

		private void CargarDGFiltrarC()
		{
			objp.Inicio1 = PagInicio;
			objp.Final1 = PagFinal;
			dsTabla = objp.Func_FiltrarDoc(doc);
			DGVReportesAdmin.DataSource = dsTabla.Tables[1];

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

		private void combox_pagAdmin_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
			{
				int pagina = Convert.ToInt32(combox_pagAdmin.Text.ToString());

				if (pagina <= combox_pagAdmin.Items.Count)
                {
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
			}
		}

		private void DGVReportesAdmin_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (this.DGVReportesAdmin.Columns[e.ColumnIndex].HeaderText == "Hora S.")
			{
				if (e.Value.GetType() == typeof(System.DBNull))
				{
					e.CellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(201, 188, 54);
					e.CellStyle.BackColor = System.Drawing.Color.Yellow;
				}
			}
		}

		//------------------------------------------------- FIN MODULO REPORTES --------------------------------------------------

		//---------------------------------------------------- MODULO EQUIPOS ----------------------------------------------------

		private void btnSalirE_Click(object sender, EventArgs e)
		{
			DialogResult rpta = new DialogResult();
			rpta = MessageBox.Show("¿Desea Salir?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (rpta == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

        private void txtDoc_Equipo_Enter(object sender, EventArgs e)
		{
			if (txtDoc_Equipo.Text == "N Documento: ")
			{
				txtDoc_Equipo.Text = "";
				this.txtDoc_Equipo.ForeColor = System.Drawing.Color.Black;
			}
		}

        private void txtDoc_Equipo_Leave(object sender, EventArgs e)
		{
			if (txtDoc_Equipo.Text == "")
			{
				txtDoc_Equipo.Text = "N Documento: ";
				this.txtDoc_Equipo.ForeColor = System.Drawing.Color.DimGray;
			}
		}

        private void txtDoc_Equipo_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
			{
				btnBuscar_EquipoU_Click(sender, e);
			}
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

        private void txtTipodeBienE_Enter(object sender, EventArgs e)
		{
			if (txtTipodeBienE.Text == "Tipo de bien: (*)")
			{
				txtTipodeBienE.Text = "";
				this.txtTipodeBienE.ForeColor = System.Drawing.Color.Black;
			}
		}

        private void txtTipodeBienE_Leave(object sender, EventArgs e)
		{
			if (txtTipodeBienE.Text == "")
			{
				txtTipodeBienE.Text = "Tipo de bien: (*)";
				this.txtTipodeBienE.ForeColor = System.Drawing.Color.DimGray;
			}
		}

        private void txtMarcaE_Enter(object sender, EventArgs e)
		{
			if (txtMarcaE.Text == "Marca: (*)")
			{
				txtMarcaE.Text = "";
				this.txtMarcaE.ForeColor = System.Drawing.Color.Black;
			}
		}

        private void txtMarcaE_Leave(object sender, EventArgs e)
		{
			if (txtMarcaE.Text == "")
			{
				txtMarcaE.Text = "Marca: (*)";
				this.txtMarcaE.ForeColor = System.Drawing.Color.DimGray;
			}
		}

        private void txtNSerieE_Enter(object sender, EventArgs e)
		{
			if (txtNSerieE.Text == "N de serie: (*)")
			{
				txtNSerieE.Text = "";
				this.txtNSerieE.ForeColor = System.Drawing.Color.Black;
			}
		}

        private void txtNSerieE_Leave(object sender, EventArgs e)
		{
			if (txtNSerieE.Text == "")
			{
				txtNSerieE.Text = "N de serie: (*)";
				this.txtNSerieE.ForeColor = System.Drawing.Color.DimGray;
			}
		}

        private void txtCargadorE_Enter(object sender, EventArgs e)
		{
			if (txtCargadorE.Text == "Cargador:")
			{
				txtCargadorE.Text = "";
				this.txtCargadorE.ForeColor = System.Drawing.Color.Black;
			}
		}

        private void txtCargadorE_Leave(object sender, EventArgs e)
		{
			if (txtCargadorE.Text == "")
			{
				txtCargadorE.Text = "Cargador:";
				this.txtCargadorE.ForeColor = System.Drawing.Color.DimGray;
			}
		}

        private void btnBuscar_EquipoU_Click(object sender, EventArgs e)
		{
			if (cb_Color.Text != "Color")
            {
				cb_Color.SelectedIndex = -1;
				cb_Color.Text = "Color";
            }

			txtTipodeBienE.Text = "Tipo de bien: (*)";
			this.txtTipodeBienE.ForeColor = System.Drawing.Color.DimGray;
			txtMarcaE.Text = "Marca: (*)";
			this.txtMarcaE.ForeColor = System.Drawing.Color.DimGray;
			txtNSerieE.Text = "N de serie: (*)";
			this.txtNSerieE.ForeColor = System.Drawing.Color.DimGray;
			txtCargadorE.Text = "Cargador:";
			this.txtCargadorE.ForeColor = System.Drawing.Color.DimGray;


			if (txtDoc_Equipo.Text == "N Documento: " || txtDoc_Equipo.Text == "")
            {
				MessageBox.Show("Por favor ingrese un documento");
            }
            else
            {
				DataTable tabla = ClaseControlAdmin.Func_BuscarVistante(Convert.ToInt64(txtDoc_Equipo.Text));

                if (tabla.Rows.Count > 0)
                {
					id_visitante = tabla.Rows[0][0].ToString();
					txtDocET.Text = tabla.Rows[0][3].ToString();
					txtNomET.Text = tabla.Rows[0][1].ToString() + ' ' + tabla.Rows[0][2].ToString();
					txtTipodeBienE.Enabled = true;
					txtMarcaE.Enabled = true;
					txtNSerieE.Enabled = true;
					txtCargadorE.Enabled = true;
					cb_Color.Enabled = true;
					btnCancelarE.Enabled = true;
					btnGuardarE.Enabled = true;
					btnGuardarE.BackColor = System.Drawing.SystemColors.MenuHighlight;
					btnGuardarE.ForeColor = System.Drawing.SystemColors.HighlightText;
					txtDoc_Equipo.Text = "N Documento: ";
					this.txtDoc_Equipo.ForeColor = System.Drawing.Color.DimGray;
				}
                else
                {
					txtDocET.Text = "Documento";
					txtNomET.Text = "Nombre";
					MessageBox.Show("Visitante no registrado, por favor verifique el documento", "Advertencia!");
				}
			}
			
		}

        private void btnCancelarE_Click(object sender, EventArgs e)
		{
			txtTipodeBienE.Text = "Tipo de bien: (*)";
			this.txtTipodeBienE.ForeColor = System.Drawing.Color.DimGray;
			txtMarcaE.Text = "Marca: (*)";
			this.txtMarcaE.ForeColor = System.Drawing.Color.DimGray;
			txtNSerieE.Text = "N de serie: (*)";
			this.txtNSerieE.ForeColor = System.Drawing.Color.DimGray;
			txtCargadorE.Text = "Cargador:";
			this.txtCargadorE.ForeColor = System.Drawing.Color.DimGray;
			txtDocET.Text = "Documento";
			txtNomET.Text = "Nombre";
			txtTipodeBienE.Enabled = false;
			txtMarcaE.Enabled = false;
			txtNSerieE.Enabled = false;
			txtCargadorE.Enabled = false;
			cb_Color.Enabled = false;
			btnGuardarE.BackColor = System.Drawing.SystemColors.ButtonFace;
			btnGuardarE.ForeColor = System.Drawing.SystemColors.ControlLight;
			btnGuardarE.Enabled = false;
			btnCancelarE.Enabled = false;
		}

        private void btnGuardarE_Click(object sender, EventArgs e)
		{
			if ((txtTipodeBienE.Text == "Tipo de bien: (*)" || txtTipodeBienE.Text == "") || (txtMarcaE.Text == "Marca: (*)" || txtMarcaE.Text == "") || (txtNSerieE.Text == "N de serie: (*)" || txtNSerieE.Text == ""))
            {
				MessageBox.Show("Favor de llenar todos los campos obligatorios (*).");
            }
            else
            {
				string comboboxtext = cb_Color.Text;
				int combobox1 = cb_Color.SelectedIndex;
				if (comboboxtext == "Color" || combobox1 == -1)
				{
					MessageBox.Show("Favor de agregar un color");
                }
                else
                {

					if (cb_Color.Text != "Color")
					{
						cb_Color.SelectedIndex = -1;
						cb_Color.Text = "Color";
					}

					DataTable tabla = ClaseControlAdmin.Func_BusVisitanteBien(txtNSerieE.Text);

					if (tabla.Rows.Count > 0)
                    {
						MessageBox.Show("Este bien ya se encuentra registrado con el mismo serial");
                    }
                    else
                    {
						if (txtCargadorE.Text == "Cargador:" || txtCargadorE.Text == "")
                        {
							txtCargadorE.Text = "";
						}
                        if (ClaseControlAdmin.Func_insertarBien(txtNSerieE.Text, txtTipodeBienE.Text, txtMarcaE.Text, comboboxtext, txtCargadorE.Text, Convert.ToInt64(id_visitante)))
                        {
							MessageBox.Show("Bien registrado Exitosamente", "Felicidades!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
							btnCancelarE_Click(sender, e);

							DataTable dt = (DataTable)DGVBienes.DataSource;
							if (dt.Rows.Count > 0)
							{
								comboBoxPagBienes_SelectionChangeCommitted(sender, e);
							}
                            else
                            {
								CargarDGBienes();
							}
						}
                    }
				}
			}
		}

		private void CargarDGBienes()
		{
			objp.Inicio1 = PagInicio;
			objp.Final1 = PagFinal;
			dsTabla = objp.Func_Bienes();
			DGVBienes.DataSource = dsTabla.Tables[1];

			int cantidad = Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) / NumFilas;

			if (Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) % NumFilas > 0) cantidad++;

			txtPagBienes.Text = cantidad.ToString();
			comboBoxPagBienes.Items.Clear();

			for (int x = 1; x <= cantidad; x++)
			{
				comboBoxPagBienes.Items.Add(x.ToString());
			}

			DataTable dt = (DataTable)DGVBienes.DataSource;
			if (dt.Rows.Count > 0)
			{
				comboBoxPagBienes.SelectedIndex = Indice;
			}

			control = 0;
		}

		private void comboBoxPagBienes_SelectionChangeCommitted(object sender, EventArgs e)
		{
			int pagina = Convert.ToInt32(comboBoxPagBienes.SelectedItem.ToString());

			Indice = pagina - 1;
			PagInicio = (pagina - 1) * NumFilas + 1;
			PagFinal = pagina * NumFilas;

			if (control == 0)
			{
				CargarDGBienes();
			}
			
			//if (control == 1)
			//{
			//	CargarDGFiltrarC();
			//}
			//if (control == 2)
			//{
			//	CargarDGFiltrarF();
			//}
			//if (control == 3)
			//{
			//	CargarDGFiltrarDF();
			//}
		}

		//activo los botones modificar y eliminar al dar click en una celda
		private void DGVBienes_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			n = e.RowIndex;

			if (n != -1)
			{
				//capturo el serial del datagrid
				serialBien = DGVBienes.Rows[n].Cells[4].Value.ToString();
				btnModificarBien.Enabled = true;
				btnEliminarBien.Enabled = true;
				btnModificarBien.BackColor = System.Drawing.SystemColors.MenuHighlight;
				btnModificarBien.ForeColor = System.Drawing.SystemColors.HighlightText;
				btnEliminarBien.BackColor = System.Drawing.SystemColors.MenuHighlight;
				btnEliminarBien.ForeColor = System.Drawing.SystemColors.HighlightText;
			}
		}
		private void btnEliminarBien_Click(object sender, EventArgs e)
		{
			//capturo el id del datagrid
			//string ced = DGVBienes.CurrentRow.Cells[0].Value.ToString();
			long idbien = Convert.ToInt64(DGVBienes.Rows[n].Cells[0].Value);
			DialogResult rpta = new DialogResult();
			rpta = MessageBox.Show("Desea Eliminar el bien N. : " + idbien.ToString(), "Advertencia!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (rpta == DialogResult.OK)
			{
				if (ClaseControlAdmin.Func_EliminarBien(serialBien) == true)
                {
					MessageBox.Show("Bien eliminado", "Felicidades!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					comboBoxPagBienes_SelectionChangeCommitted(sender, e);
					DataTable dt = (DataTable)DGVReportesAdmin.DataSource;
					if (dt.Rows.Count > 0)
					{
						combox_pagAdmin_SelectionChangeCommitted(sender, e);
					}
					else
					{
						CargarDG();
						btnModificarBien.Enabled = false;
						btnEliminarBien.Enabled = false;
						btnModificarBien.BackColor = System.Drawing.SystemColors.ButtonFace;
						btnModificarBien.ForeColor = System.Drawing.SystemColors.ControlLight;
						btnEliminarBien.BackColor = System.Drawing.SystemColors.ButtonFace;
						btnEliminarBien.ForeColor = System.Drawing.SystemColors.ControlLight;
						comboBoxPagBienes.ResetText();
					}
				}
                else
                {
					MessageBox.Show("No se elimino", "Atencion!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}
	}
} 