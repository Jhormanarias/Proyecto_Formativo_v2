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
		private int controladd = 0;
		private long idbien = 0;
		private string serialdoc = "";
		private long Nbien = 0;
		// variables del formulario usuario
		private long id_user = 0;

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
			//formulario de usuarios
			btnCancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
			btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLight;
			btnGuardarAU.BackColor = System.Drawing.SystemColors.ButtonFace;
			btnGuardarAU.ForeColor = System.Drawing.SystemColors.ControlLight;
			btnModificar_VerU.BackColor = System.Drawing.SystemColors.ButtonFace;
			btnModificar_VerU.ForeColor = System.Drawing.SystemColors.ControlLight;
			btnEliminar_VerU.BackColor = System.Drawing.SystemColors.ButtonFace;
			btnEliminar_VerU.ForeColor = System.Drawing.SystemColors.ControlLight;
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
			controladd = 0;

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
			btn_LimpiarBusq_Click(sender, e);
		}

        private void btnGuardarE_Click(object sender, EventArgs e)
		{
			if (controladd == 0)
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
								if (cb_Color.Text != "Color")
								{
									cb_Color.SelectedIndex = -1;
									cb_Color.Text = "Color";
								}
								btnCancelarE_Click(sender, e);
								btn_LimpiarBusq_Click(sender, e);

								DataTable dt = (DataTable)DGVBienes.DataSource;
								if (dt.Rows.Count > 0)
								{
									comboBoxPagBienes_SelectionChangeCommitted(sender, e);
									btn_LimpiarBusq_Click(sender, e);
								}
								else
								{
									CargarDGBienes();
									btn_LimpiarBusq_Click(sender, e);
								}
							}
						}
					}
				}
			}

			if(controladd == 1)
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
						//compruebo nuevo serial para validar que no este repetido
						if (txtNSerieE.Text != serialBien)
						{
							DataTable tabla2 = ClaseControlAdmin.Func_BusVisitanteBien(txtNSerieE.Text);

							if (tabla2.Rows.Count > 0)
							{
								MessageBox.Show("Este bien ya se encuentra registrado con el mismo serial");
							}
							else
							{
								if (txtCargadorE.Text == "Cargador:" || txtCargadorE.Text == "")
								{
									txtCargadorE.Text = "";
								}
								if (ClaseControlAdmin.Func_EditarBien(idbien, txtNSerieE.Text, txtTipodeBienE.Text, txtMarcaE.Text, comboboxtext, txtCargadorE.Text))
								{
									MessageBox.Show("Bien Modificado Exitosamente", "Felicidades!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
									if (cb_Color.Text != "Color")
									{
										cb_Color.SelectedIndex = -1;
										cb_Color.Text = "Color";
									}
									btnCancelarE_Click(sender, e);
									btn_LimpiarBusq_Click(sender, e);

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
						else
						{
							if (txtCargadorE.Text == "Cargador:" || txtCargadorE.Text == "")
							{
								txtCargadorE.Text = "";
							}
							if (ClaseControlAdmin.Func_EditarBien(idbien, txtNSerieE.Text, txtTipodeBienE.Text, txtMarcaE.Text, comboboxtext, txtCargadorE.Text))
							{
								MessageBox.Show("Bien Modificado Exitosamente", "Felicidades!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
			
		}

        private void CargarDGBienes()
		{
			objp.Inicio1 = PagInicio;
			objp.Final1 = PagFinal;
			dsTabla = objp.Func_Bienes();
			DGVBienes.DataSource = dsTabla.Tables[1];
			DGVBienes.ClearSelection();

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

		private void CargarDGBuscarBienes()
		{
			objp.Inicio1 = PagInicio;
			objp.Final1 = PagFinal;
			dsTabla = objp.Func_BuscarBienes(serialdoc);
			DGVBienes.DataSource = dsTabla.Tables[1];
			DGVBienes.ClearSelection();

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

			control = 1;
		}

		private void CargarDGBuscarBienesx()
		{
			objp.Inicio1 = 1;
			objp.Final1 = 10;
			dsTabla = objp.Func_BuscarBienes(serialdoc);
			DGVBienes.DataSource = dsTabla.Tables[1];
			DGVBienes.ClearSelection();

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

			control = 1;
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

            if (control == 1)
            {
				CargarDGBuscarBienes();
            }
        }

        //activo los botones modificar y eliminar al dar click en una celda
        private void DGVBienes_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			n = e.RowIndex;

			if (n != -1)
			{
				//capturo el serial del datagrid
				serialBien = DGVBienes.Rows[n].Cells[4].Value.ToString();
				DataTable tablabien = ClaseControlAdmin.Func_BusVisitanteBien(serialBien);
				idbien = Convert.ToInt64(tablabien.Rows[0][0]);
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
			long NbienE = Convert.ToInt64(DGVBienes.Rows[n].Cells[0].Value);
			DialogResult rpta = new DialogResult();
			rpta = MessageBox.Show("Desea Eliminar el bien N. : " + NbienE.ToString(), "Advertencia!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (rpta == DialogResult.OK)
			{
				if (ClaseControlAdmin.Func_EliminarBien(serialBien) == true)
                {
					MessageBox.Show("Bien eliminado", "Felicidades!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					comboBoxPagBienes_SelectionChangeCommitted(sender, e);

					DGVBienes.ClearSelection();
					btnModificarBien.Enabled = false;
					btnEliminarBien.Enabled = false;
					btnModificarBien.BackColor = System.Drawing.SystemColors.ButtonFace;
					btnModificarBien.ForeColor = System.Drawing.SystemColors.ControlLight;
					btnEliminarBien.BackColor = System.Drawing.SystemColors.ButtonFace;
					btnEliminarBien.ForeColor = System.Drawing.SystemColors.ControlLight;

					if (Nbien == NbienE)
                    {
						btnCancelarE_Click(sender, e);

					}

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

		private void btnModificarBien_Click(object sender, EventArgs e)
		{
			controladd = 1;

			Nbien = Convert.ToInt64(DGVBienes.Rows[n].Cells[0].Value);
			DialogResult rpta = new DialogResult();
			rpta = MessageBox.Show("Desea Modificar el bien N. : " + Nbien.ToString(), "Advertencia!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (rpta == DialogResult.OK)
            {
				txtDocET.Text = DGVBienes.CurrentRow.Cells[6].Value.ToString();
				txtNomET.Text = DGVBienes.CurrentRow.Cells[7].Value.ToString();
				txtTipodeBienE.Text = DGVBienes.CurrentRow.Cells[1].Value.ToString();
				this.txtTipodeBienE.ForeColor = System.Drawing.Color.Black;
				txtMarcaE.Text = DGVBienes.CurrentRow.Cells[2].Value.ToString();
				this.txtMarcaE.ForeColor = System.Drawing.Color.Black;
				txtNSerieE.Text = DGVBienes.CurrentRow.Cells[4].Value.ToString();
				this.txtNSerieE.ForeColor = System.Drawing.Color.Black;

				//DGVBienes.ClearSelection();
				btnModificarBien.Enabled = false;
				btnEliminarBien.Enabled = false;
				btnModificarBien.BackColor = System.Drawing.SystemColors.ButtonFace;
				btnModificarBien.ForeColor = System.Drawing.SystemColors.ControlLight;
				btnEliminarBien.BackColor = System.Drawing.SystemColors.ButtonFace;
				btnEliminarBien.ForeColor = System.Drawing.SystemColors.ControlLight;

				if ((txtCargadorE.Text = DGVBienes.CurrentRow.Cells[5].Value.ToString()) == "")
                {
					txtCargadorE.Text = "Cargador:";
				}
                else
                {
					txtCargadorE.Text = DGVBienes.CurrentRow.Cells[5].Value.ToString();
					this.txtCargadorE.ForeColor = System.Drawing.Color.Black;
				}

				cb_Color.Text = DGVBienes.CurrentRow.Cells[3].Value.ToString();

				txtTipodeBienE.Enabled = true;
				txtMarcaE.Enabled = true;
				txtNSerieE.Enabled = true;
				txtCargadorE.Enabled = true;
				cb_Color.Enabled = true;
				btnCancelarE.Enabled = true;
				btnGuardarE.Enabled = true;
				btnGuardarE.BackColor = System.Drawing.SystemColors.MenuHighlight;
				btnGuardarE.ForeColor = System.Drawing.SystemColors.HighlightText;
			}
		}

		private void btnBuscarBien_Click(object sender, EventArgs e)
		{
			if (txtBuscarBien.Text == "")
			{
				MessageBox.Show("Ingrese un N. de Serie o Documento");
			}
			else
			{
				serialdoc = txtBuscarBien.Text.ToString();
				//DataTable tabla = ClaseControlFrmVigilante.Func_FiltrarDoc(doc);
				dsTabla = objp.Func_BuscarBienesx(serialdoc);
				DataTable Tabla = dsTabla.Tables[1];

				if (Tabla.Rows.Count > 0)
				{
					CargarDGBuscarBienesx();
					btn_LimpiarBusq_Click(sender, e);
				}
				else
				{
					MessageBox.Show("No hay registro de este bien", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
					DataTable dt = (DataTable)DGVBienes.DataSource;
					if (dt == null)
					{
						CargarDGBienes();
						btn_LimpiarBusq_Click(sender, e);
					}
				}
			}
		}

		private void btn_LimpiarBusq_Click(object sender, EventArgs e)
		{
			txtBuscarBien.Text = "";
			CargarDGBienes();
			DGVBienes.ClearSelection();
			btnModificarBien.Enabled = false;
			btnEliminarBien.Enabled = false;
			btnModificarBien.BackColor = System.Drawing.SystemColors.ButtonFace;
			btnModificarBien.ForeColor = System.Drawing.SystemColors.ControlLight;
			btnEliminarBien.BackColor = System.Drawing.SystemColors.ButtonFace;
			btnEliminarBien.ForeColor = System.Drawing.SystemColors.ControlLight;
		}

		//--------------------------------------------------- FIN MODULO BIENES -------------------------------------------------------
		private void txtDocumentoAU_Enter(object sender, EventArgs e)
		{
			if (txtDocumentoAU.Text == "N Documento: ")
			{
				txtDocumentoAU.Text = "";
			}
		}

		private void txtDocumentoAU_Leave(object sender, EventArgs e)
		{
			if (txtDocumentoAU.Text == "")
			{
				txtDocumentoAU.Text = "N Documento: ";
			}
		}

		private void txtNombreAU_Enter(object sender, EventArgs e)
		{
			if (txtNombreAU.Text == "Nombre: ")
			{
				txtNombreAU.Text = "";
			}
		}

		private void txtNombreAU_Leave(object sender, EventArgs e)
		{
			if (txtNombreAU.Text == "")
			{
				txtNombreAU.Text = "Nombre: ";
			}
		}

		private void txtApellidoAU_Enter(object sender, EventArgs e)
		{
			if (txtApellidoAU.Text == "Apellido:")
			{
				txtApellidoAU.Text = "";
			}
		}

		private void txtApellidoAU_Leave(object sender, EventArgs e)
		{
			if (txtApellidoAU.Text == "")
			{
				txtApellidoAU.Text = "Apellido:";
			}
		}

		private void txtContrasena_Enter(object sender, EventArgs e)
		{
			if (txtContrasena.Text == "Contraseña:")
			{
				txtContrasena.Text = "";
			}
		}

		private void txtContrasena_Leave(object sender, EventArgs e)
		{
			if (txtContrasena.Text == "")
			{
				txtContrasena.Text = "Contraseña:";
			}
		}

		private void txtCorreo_Enter(object sender, EventArgs e)
		{
			if (txtCorreo.Text == "Correo:")
			{
				txtCorreo.Text = "";
			}
		}

		private void txtCorreo_Leave(object sender, EventArgs e)
		{
			if (txtCorreo.Text == "")
			{
				txtCorreo.Text = "Correo:";
			}
		}

		private void btnBuscar_verU_Click(object sender, EventArgs e)
		{

			if (txtBuscar_VerU.Text == "")
			{
				MessageBox.Show("Por favor llene el campo", "Advertencia!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				if (txtBuscar_VerU.Text != "")
				{
					//DGVUsuario.Rows.Add(ClaseControlAdmin.Func_TraerUsuario(Convert.ToInt64(txtBuscar_VerU.Text)));
					DataTable talaU = (ClaseControlAdmin.Func_TraerUsuario(Convert.ToInt64(txtBuscar_VerU.Text)));
					DGVUsuario.DataSource = talaU;
					if(talaU.Rows.Count == 0)
					{
						MessageBox.Show("Este Usuario no Existe", "Advertencia!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}
		}
		private void btnNuevoU_Click(object sender, EventArgs e)
		{
			cbDocumento.Enabled = true;
			txtDocumentoAU.Enabled = true;
			cbRolAU.Enabled = true;
			txtNombreAU.Enabled = true;
			txtApellidoAU.Enabled = true;
			btnGuardarAU.Enabled = true;
			btnCancelar.Enabled = true;
			txtCorreo.Enabled = true;
			txtContrasena.Enabled = true;
			//---------------------------
			btnNuevoU.Enabled = false;
			btnModificar_VerU.Enabled = false;
			btnEliminar_VerU.Enabled = false;
			btnGuardarAU.BackColor = System.Drawing.SystemColors.MenuHighlight;
			btnGuardarAU.ForeColor = System.Drawing.SystemColors.HighlightText;
			btnCancelar.BackColor = System.Drawing.SystemColors.MenuHighlight;
			btnCancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
		}

		private void DGVUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			n = e.RowIndex;
			if(n != -1)
			{
				long doc = Convert.ToInt64(DGVUsuario.Rows[n].Cells[3].Value);
				DataTable tablabien = ClaseControlAdmin.Func_TraerUsuario(doc);
				id_user = Convert.ToInt64(tablabien.Rows[0][0]);
				btnModificar_VerU.Enabled = true;
				btnEliminar_VerU.Enabled = true;
			}
		}

		private void btnEliminar_VerU_Click(object sender, EventArgs e)
		{
			DialogResult rpt = new DialogResult();
			rpt = MessageBox.Show("Esta seguro de que quieres eliminar a este usuario?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (rpt == DialogResult.OK)
			{
				if (ClaseControlAdmin.Func_EliminarUsuario(id_user))
				{
					MessageBox.Show("Ha sido eliminado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				txtBuscar_VerU.Text = "";
				DGVUsuario.Rows.RemoveAt(DGVUsuario.CurrentRow.Index);
				btnModificar_VerU.Enabled = false;
				btnEliminar_VerU.Enabled = false;
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			txtCorreo.Text = "Correo:";
			txtDocumentoAU.Text = "N Documento: ";
			txtContrasena.Text = "Contraseña:";
			txtNombreAU.Text = "Nombre: ";
			txtApellidoAU.Text = "Apellido:";
			cbRolAU.SelectedIndex = 0;
			cbDocumento.Enabled = false;
			txtDocumentoAU.Enabled = false;
			cbRolAU.Enabled = false;
			txtNombreAU.Enabled = false;
			txtApellidoAU.Enabled = false;
			btnGuardarAU.Enabled = false;
			btnCancelar.Enabled = false;
			txtCorreo.Enabled = false;
			txtContrasena.Enabled = false;
			//---------------------------
			btnNuevoU.Enabled = true;
			btnNuevoU.BackColor = System.Drawing.SystemColors.MenuHighlight;
			btnNuevoU.ForeColor = System.Drawing.SystemColors.HighlightText;
		}
		private void btnSalir_Click(object sender, EventArgs e)
		{
			DialogResult rpta = new DialogResult();
			rpta = MessageBox.Show("¿Desea Salir?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (rpta == DialogResult.Yes)
			{
				Application.Exit();
			}
		}
		private void btnGuardarAU_Click(object sender, EventArgs e)
		{
			if(controladd == 0)
			{
				if (txtDocumentoAU.Text == "N Documento: " || txtNombreAU.Text == "Nombre: " || txtApellidoAU.Text == "Apellido:" || txtContrasena.Text == "Contraseña:" || txtCorreo.Text == "Correo:")
				{
					MessageBox.Show("Por favor llene el campo", "Advertencia!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					string combobox1 = cbRolAU.Text;
					string combobox2 = cbDocumento.Text;
					DataTable tabla = ClaseControlAdmin.Func_TraerUsuario(Convert.ToInt64(txtDocumentoAU.Text));
					if (tabla.Rows.Count > 0)
					{
						MessageBox.Show(" Este Usuario ya Existe", "Advertencia!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						if (ClaseControlAdmin.Func_InsertUsuario(txtNombreAU.Text, txtApellidoAU.Text, txtDocumentoAU.Text, txtContrasena.Text, txtCorreo.Text, combobox1, combobox2))
						{
							MessageBox.Show("Usuario insertado correctamente", "Insertado!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
							btnCancelar_Click(sender, e);
							btnModificar_VerU.Enabled = false;
							btnEliminar_VerU.Enabled = false;
						}
					}
				}
			}
			if(controladd == 1)
			{
				if (txtDocumentoAU.Text == "N Documento: " || txtNombreAU.Text == "Nombre: " || txtApellidoAU.Text == "Apellido:" || txtContrasena.Text == "Contraseña:" || txtCorreo.Text == "Correo:")
				{
					MessageBox.Show("Por favor llene el campo", "Advertencia!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					string combobox1 = cbRolAU.Text;
					string combobox2 = cbDocumento.Text;
					if (ClaseControlAdmin.Func_ActualizarUser(id_user, txtNombreAU.Text, txtApellidoAU.Text, txtDocumentoAU.Text, txtContrasena.Text, txtCorreo.Text, combobox1, combobox2))
					{
						MessageBox.Show("Usuario Actualizado correctamente", "Insertado!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
						btnCancelar_Click(sender, e);
						btnModificar_VerU.Enabled = false;
						btnEliminar_VerU.Enabled = false;
						DGVUsuario.Rows.RemoveAt(DGVUsuario.CurrentRow.Index);
						//this.DGVUsuario.DataSource = null;
						//this.DGVUsuario.Rows.Clear();
						txtBuscar_VerU.Text = "";
					}
				}
			}
		}

		private void btnModificar_VerU_Click(object sender, EventArgs e)
		{
			controladd = 1;
			string nom = DGVUsuario.Rows[n].Cells[1].Value.ToString();
			DialogResult rpt = new DialogResult();
			rpt = MessageBox.Show("Esta seguro que quiere modificar este usuario? "  +nom.ToString(), "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if(rpt == DialogResult.OK)
			{
				txtApellidoAU.Text = DGVUsuario.CurrentRow.Cells[2].Value.ToString();
				txtNombreAU.Text = DGVUsuario.CurrentRow.Cells[1].Value.ToString();
				txtDocumentoAU.Text = DGVUsuario.CurrentRow.Cells[3].Value.ToString();
				txtContrasena.Text = DGVUsuario.CurrentRow.Cells[4].Value.ToString();
				txtCorreo.Text = DGVUsuario.CurrentRow.Cells[5].Value.ToString();
				btnModificar_VerU.Enabled = false;
				btnEliminar_VerU.Enabled = false;
				btnCancelar.Enabled = true;
				// Activo los texbox
				cbDocumento.Enabled = true;
				cbRolAU.Enabled = true;
				txtNombreAU.Enabled = true;
				txtApellidoAU.Enabled = true;
				btnGuardarAU.Enabled = true;
				btnCancelar.Enabled = true;
				txtCorreo.Enabled = true;
				txtContrasena.Enabled = true;
			}
		}
	}
} 