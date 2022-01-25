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
		ClaseControlFrmVigilante objp = new ClaseControlFrmVigilante();
		DataSet dsTabla;
		int PagInicio = 1, Indice = 0, NumFilas = 10, PagFinal, control = 0;
		DateTime fechaR;
		long doc = 0;
		private int n = 0;
		public FrmControlVigi()
		{
			InitializeComponent();
			PagFinal = NumFilas;
			CargarDG();
		}

		private void CargarDG()
        {
			objp.Inicio1 = PagInicio;
			objp.Final1 = PagFinal;
			dsTabla = objp.Func_Reportes();
			DGVReportes.DataSource = dsTabla.Tables[1];
			//DGVReportes.Columns[0].Visible = false;

			int cantidad = Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) / NumFilas;

			if (Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) % NumFilas > 0) cantidad++;

			txt_Cantidad.Text = cantidad.ToString();
			combox_pag.Items.Clear();

			for (int x = 1; x <= cantidad; x++)
            {
				combox_pag.Items.Add(x.ToString());
			}
			
			combox_pag.SelectedIndex = Indice;

			control = 0;
		}

		private void CargarDGFiltrarC()
		{
			objp.Inicio1 = PagInicio;
			objp.Final1 = PagFinal;
			dsTabla = objp.Func_FiltrarDoc(doc);
			DGVReportes.DataSource = dsTabla.Tables[1];
			//DGVReportes.Columns[0].Visible = false;

			int cantidad = Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) / NumFilas;

			if (Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) % NumFilas > 0) cantidad++;

			txt_Cantidad.Text = cantidad.ToString();
			combox_pag.Items.Clear();

			for (int x = 1; x <= cantidad; x++)
			{
				combox_pag.Items.Add(x.ToString());
			}

			combox_pag.SelectedIndex = Indice-1;

			control = 1;
		}

		private void CargarDGFiltrarCx()
		{
			objp.Inicio1 = 1;
			objp.Final1 = 10;
			dsTabla = objp.Func_FiltrarDoc(doc);
			DGVReportes.DataSource = dsTabla.Tables[1];
			//DGVReportes.Columns[0].Visible = false;

			int cantidad = Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) / NumFilas;

			if (Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) % NumFilas > 0) cantidad++;

			txt_Cantidad.Text = cantidad.ToString();
			combox_pag.Items.Clear();

			for (int x = 1; x <= cantidad; x++)
			{
				combox_pag.Items.Add(x.ToString());
			}

			combox_pag.SelectedIndex = 0;

			control = 1;
		}
		private void CargarDGFiltrarF()
		{
			objp.Inicio1 = PagInicio;
			objp.Final1 = PagFinal;
			dsTabla = objp.Func_FiltrarFe(fechaR);
			DGVReportes.DataSource = dsTabla.Tables[1];
			//DGVReportes.Columns[0].Visible = false;

			int cantidad = Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) / NumFilas;

			if (Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) % NumFilas > 0) cantidad++;

			txt_Cantidad.Text = cantidad.ToString();
			combox_pag.Items.Clear();

			for (int x = 1; x <= cantidad; x++)
			{
				combox_pag.Items.Add(x.ToString());
			}

			combox_pag.SelectedIndex = 0;

			control = 2;
		}
		private void CargarDGFiltrarFx()
		{
			objp.Inicio1 = 1;
			objp.Final1 = 10;
			dsTabla = objp.Func_FiltrarFe(fechaR);
			DGVReportes.DataSource = dsTabla.Tables[1];
			//DGVReportes.Columns[0].Visible = false;

			int cantidad = Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) / NumFilas;

			if (Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) % NumFilas > 0) cantidad++;

			txt_Cantidad.Text = cantidad.ToString();
			combox_pag.Items.Clear();

			for (int x = 1; x <= cantidad; x++)
			{
				combox_pag.Items.Add(x.ToString());
			}

			combox_pag.SelectedIndex = 0;

			control = 2;
		}

		private void CargarDGFiltrarDF()
		{
			objp.Inicio1 = PagInicio;
			objp.Final1 = PagFinal;
			dsTabla = objp.Func_Filtrar(fechaR, doc);
			DGVReportes.DataSource = dsTabla.Tables[1];
			//DGVReportes.Columns[0].Visible = false;

			int cantidad = Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) / NumFilas;

			if (Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) % NumFilas > 0) cantidad++;

			txt_Cantidad.Text = cantidad.ToString();
			combox_pag.Items.Clear();

			for (int x = 1; x <= cantidad; x++)
			{
				combox_pag.Items.Add(x.ToString());
			}

			combox_pag.SelectedIndex = 0;

			control = 3;
		}

		private void CargarDGFiltrarDFx()
		{
			objp.Inicio1 = 1;
			objp.Final1 = 10;
			dsTabla = objp.Func_Filtrar(fechaR, doc);
			DGVReportes.DataSource = dsTabla.Tables[1];
			//DGVReportes.Columns[0].Visible = false;

			int cantidad = Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) / NumFilas;

			if (Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) % NumFilas > 0) cantidad++;

			txt_Cantidad.Text = cantidad.ToString();
			combox_pag.Items.Clear();

			for (int x = 1; x <= cantidad; x++)
			{
				combox_pag.Items.Add(x.ToString());
			}

			combox_pag.SelectedIndex = 0;

			control = 3;
		}

		//accion para cambiar de paginas en la tabla
		private void combox_pag_SelectionChangeCommitted(object sender, EventArgs e)
		{
			int pagina = Convert.ToInt32(combox_pag.SelectedItem.ToString());
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

		//Limpio la tabla y las cajas de texto y desavilito los botones entrada y salida
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
				//FrmControlVigi_Load(sender, e);
				combox_pag_SelectionChangeCommitted(sender, e);
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
				//FrmControlVigi_Load(sender, e);
				combox_pag_SelectionChangeCommitted(sender, e);
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
			if (e.KeyChar == (char)13)
			{
				btn_Busrcar_R_U_Click(sender, e);
			}

			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		//Selecciono fila para dara ingrso o salida
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

		//Recargo nuevanmentela tabla reporte cuando no este filtrando por documento
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
				//DGVReportes.DataSource = ClaseControlFrmVigilante.Func_Reportes();
				CargarDG();
				btn_Feltar.Enabled = false;
			}
		}

		//Recargo nuevanmentela tabla reporte cuando no este filtrando por fecha
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
				//DGVReportes.DataSource = ClaseControlFrmVigilante.Func_Reportes();
				CargarDG();
				btn_Feltar.Enabled = false;
			}
		}

		//Coloreo filas que esten vacias en el campo Salida
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

		//Muestro nombre de usuario y tipo de rol
		private void FrmControlVigi_Load(object sender, EventArgs e)
		{
			lbl_Nom_User.Visible = true;
			lbl_Rol.Visible = true;
			lbl_Nom_User.Text = ClaseControlFrmVigilante.usuario;
			lbl_Rol.Text = ClaseControlFrmVigilante.rol;
			//DGVReportes.DataSource = ClaseControlFrmVigilante.Func_Reportes();
			
		}

		//Coloreo celda bacia
        private void DGVReportes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.DGVReportes.Columns[e.ColumnIndex].HeaderText == "Hora S.")
            {
                if (e.Value.GetType() == typeof(System.DBNull))
                {
                    e.CellStyle.BackColor = System.Drawing.Color.Yellow;
                }
            }
        }

		//filtrar por busqueda en la tabla reporte 
        private void btn_Feltar_Click(object sender, EventArgs e)
        {
			fechaR = dt_Fecha_R.Value;
			//filtro por documento
			if (this.cb_Documento_R.Checked == true && this.cb_Fecha_R.Checked == false)
            {
				if (txt_filtrarReporteDoc.Text == "Documento" || txt_filtrarReporteDoc.Text == "")
				{
					MessageBox.Show("Ingrese un documento");
				}
				else
				{
					doc = Convert.ToInt64(txt_filtrarReporteDoc.Text);
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
						DataTable dt = (DataTable)DGVReportes.DataSource;
						if (dt == null)
						{
							//DGVReportes.DataSource = ClaseControlFrmVigilante.Func_Reportes();
							CargarDG();
						}
					}
				}
			}
			
			//Filtro por fecha
			if (this.cb_Fecha_R.Checked == true && this.cb_Documento_R.Checked == false)
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
					DataTable dt = (DataTable)DGVReportes.DataSource;
					if (dt == null)
					{
						//DGVReportes.DataSource = ClaseControlFrmVigilante.Func_Reportes();
						CargarDG();
					}
				}
				
			}
			
			//Filtro por fecha y documendo
			if(this.cb_Documento_R.Checked == true & this.cb_Fecha_R.Checked == true)
            {
				if (txt_filtrarReporteDoc.Text == "Documento" || txt_filtrarReporteDoc.Text == "")
				{
					MessageBox.Show("Ingrese un documento");
				}
				else
				{
					doc = Convert.ToInt64(txt_filtrarReporteDoc.Text);
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
						DataTable dt = (DataTable)DGVReportes.DataSource;
						if (dt == null)
						{
							//DGVReportes.DataSource = ClaseControlFrmVigilante.Func_Reportes();
							CargarDG();
						}
					}
					
				}
			}
				
		}

		//Permitir solo la entrada numerica y ejecutar evento con la tecla enter (tabla reporte)
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
