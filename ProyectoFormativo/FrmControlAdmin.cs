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
			txtIdEquipo.ForeColor = Color.Gray;
			txtDocumento.ForeColor = Color.Gray;
			txtNombre.ForeColor = Color.Gray;
			txtEquipo.ForeColor = Color.Gray;
		}

		private void txtIdEquipo_Enter(object sender, EventArgs e)
		{
			txtIdEquipo.Text = "";
			txtIdEquipo.ForeColor = Color.Black;
		}

		private void txtDocumento_Enter(object sender, EventArgs e)
		{
			txtDocumento.Text = "";
			txtDocumento.ForeColor = Color.Black;
		}

		private void txtNombre_Enter(object sender, EventArgs e)
		{
			txtNombre.Text = "";
			txtNombre.ForeColor = Color.Black;
		}

		private void txtEquipo_Enter(object sender, EventArgs e)
		{
			txtEquipo.Text = "";
			txtEquipo.ForeColor = Color.Black;
		}
	}
}
