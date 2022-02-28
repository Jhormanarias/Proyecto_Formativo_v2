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
		public static string cadena = "Data Source =localhost\\SQLEXPRESS;Initial Catalog=BD_PROYECTO;User ID=ADSI;Password=2144539";
		public void Func_Login(string documento, string contrasena)
		{
			SqlConnection conexion = new SqlConnection(cadena);
			try
			{
				
				conexion.Open();
				SqlCommand cmd = new SqlCommand("SELECT id_usuario, nom_user, apellido, rol, contrasena FROM USUARIO WHERE documento = @documento AND contrasena = @contrasena", conexion);
                cmd.Parameters.AddWithValue("documento", documento);
                cmd.Parameters.AddWithValue("contrasena", contrasena);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
				DataTable tabla = new DataTable();
				adap.Fill(tabla);

				

				if (tabla.Rows.Count > 0)
				{
					ClaseControlFrmVigilante.idusuario = Convert.ToInt64(tabla.Rows[0][0]);
					ClaseControlFrmVigilante.usuario = tabla.Rows[0][1].ToString() + " " + tabla.Rows[0][2].ToString();
					ClaseControlFrmVigilante.rol = tabla.Rows[0][3].ToString();

					ClaseControlAdmin.idusuario = Convert.ToInt64(tabla.Rows[0][0]);
					ClaseControlAdmin.usuario = tabla.Rows[0][1].ToString() + " " + tabla.Rows[0][2].ToString();
					ClaseControlAdmin.rol = tabla.Rows[0][3].ToString();

					this.Hide();
					if (tabla.Rows[0][3].ToString() == "Administrador")
					{
						new FrmControlAdmin().Show();
					}
					else if (tabla.Rows[0][3].ToString() == "Vigilante")
					{
						new FrmControlVigi().Show();
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
				Application.Exit();
		}

		private void btnMinimizar_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void BtnIngresar_Click(object sender, EventArgs e)
		{
            if (txtUsusario.Text == "Documento" && txtContrasena.Text == "Contraseña" || txtUsusario.Text == "" && txtContrasena.Text == "")
            {
                MessageBox.Show("Por favor llene los campos");
            }
            else
            {
                Func_Login(this.txtUsusario.Text, this.txtContrasena.Text);
            }
        }

        private void txtUsusario_KeyPress(object sender, KeyPressEventArgs e)
        {
			if (e.KeyChar == (char)13)
			{
				BtnIngresar_Click(sender, e);
			}
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
			if (e.KeyChar == (char)13)
			{
				BtnIngresar_Click(sender, e);
			}
		}
    }
}
