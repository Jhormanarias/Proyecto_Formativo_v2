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

namespace ProyectoFormativo
{
	public partial class FrmControlAdmin : Form
	{
		public FrmControlAdmin()
		{
			InitializeComponent();
		}

		
		private void button1_Click(object sender, EventArgs e)
		{

		}


		private void FrmControlAdmin_Load(object sender, EventArgs e)
		{
			txtIdBienAC.ForeColor = Color.Gray;
			txtDocumentoAC.ForeColor = Color.Gray;
			txtNombreAC.ForeColor = Color.Gray;
			txtBienAC.ForeColor = Color.Gray;
			txtDocumentoAU.ForeColor = Color.Gray;
			txtNombreAU.ForeColor = Color.Gray;
			txtApellidoAU.ForeColor = Color.Gray;
		}

		private void txtIdEquipo_Enter(object sender, EventArgs e)
		{
			txtIdBienAC.Text = "";
			txtIdBienAC.ForeColor = Color.Black;
		}

		private void txtDocumento_Enter(object sender, EventArgs e)
		{
			txtDocumentoAC.Text = "";
			txtDocumentoAC.ForeColor = Color.Black;
		}

		private void txtNombre_Enter(object sender, EventArgs e)
		{
			txtNombreAC.Text = "";
			txtNombreAC.ForeColor = Color.Black;
		}

		private void txtEquipo_Enter(object sender, EventArgs e)
		{
			txtBienAC.Text = "";
			txtBienAC.ForeColor = Color.Black;
		}

		private void txtDocumentoAU_Enter(object sender, EventArgs e)
		{
			txtDocumentoAC.Text = "";
			txtDocumentoAC.ForeColor = Color.Black;
		}

		private void txtNombreAU_Enter(object sender, EventArgs e)
		{
			txtNombreAU.Text = "";
			txtNombreAU.ForeColor = Color.Black;
		}

		private void txtApellidoAU_Enter(object sender, EventArgs e)
		{
			txtApellidoAU.Text = "";
			txtApellidoAU.ForeColor = Color.Black;
		}

        private void btnBuscar_EquipoU_Click(object sender, EventArgs e)
        {
			MessageBox.Show("Prueba del botón", "SIIIUUUU", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void timerAdmin_Tick(object sender, EventArgs e)
        {
			lbl_horaAdmin.Text = DateTime.Now.ToString("hh:mm:ss tt", CultureInfo.InvariantCulture);
		}
    }
}
