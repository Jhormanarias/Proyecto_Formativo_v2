using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Controllers;
using System.Data.SqlClient;


namespace ProyectoFormativo
{
	public partial class login : Form
	{
		public login()
		{
			InitializeComponent();
		}
		public static string cadena = "Data Source = .;Initial Catalog=controlbienes;User ID=ADSI;Password=2144539";
		public void Func_Login(string documento, string contrasena)
		{
			SqlConnection conexion = new SqlConnection(cadena);
			try
			{
				
				conexion.Open();
				SqlCommand cmd = new SqlCommand("SELECT rol, contrasena FROM Usuario WHERE  documento = @documento  AND contrasena = @contrasena", conexion);
				cmd.Parameters.AddWithValue("documento", documento);
				cmd.Parameters.AddWithValue("contrasena", contrasena);
				SqlDataAdapter adap = new SqlDataAdapter(cmd);
				DataTable tabla = new DataTable();
				adap.Fill(tabla);

				if (tabla.Rows.Count > 0)
				{
					this.Hide();
					if (tabla.Rows[0][0].ToString() == "Administrador")
					{
						MessageBox.Show("admi");
						new FrmControlAdmin().Show();
					}
					else if (tabla.Rows[0][0].ToString() == "Vigilante")
					{
						new FrmControl().Show();
						MessageBox.Show("vigi");
					}
				}
				else
				{
					MessageBox.Show("Documento Y/O contraseña son incorrectos");
				}

			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
			finally
			{
				conexion.Close();
			}

		}
		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hwmd, int wmsw, int wparam, int lparam);

		private void txtUsusario_Enter(object sender, EventArgs e)
		{
			if (txtUsusario.Text == "Documento")
			{
				txtUsusario.Text = "";
				txtUsusario.ForeColor = Color.LightGray;
			}
		}

		private void txtUsusario_Leave(object sender, EventArgs e)
		{
			if (txtUsusario.Text == "")
			{
				txtUsusario.Text = "Documento";
				txtUsusario.ForeColor = Color.DimGray;
			}
		}

		private void txtContrasena_Leave(object sender, EventArgs e)
		{
			if (txtContrasena.Text == "")
			{
				txtContrasena.Text = "Contraseña";
				txtContrasena.ForeColor = Color.DimGray;
				txtContrasena.UseSystemPasswordChar = false;
			}
		}

		private void txtContrasena_Enter(object sender, EventArgs e)
		{
			if (txtContrasena.Text == "Contraseña")
			{
				txtContrasena.Text = "";
				txtContrasena.ForeColor = Color.LightGray;
				txtContrasena.UseSystemPasswordChar = true;
			}
		}

		private void txtContrasena_TextChanged(object sender, EventArgs e)
		{

		}

		private void login_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void btnCerrar_Click(object sender, EventArgs e)
		{
			DialogResult rpt = new DialogResult();
			rpt = MessageBox.Show("Desea Salir?", "Informacion!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (rpt == DialogResult.OK)
			{
				Application.Exit();
			}


		}

		private void btnMinimizar_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void BtnIngresar_Click(object sender, EventArgs e)
		{
			Func_Login(this.txtUsusario.Text, this.txtContrasena.Text);
		}
	}
}
