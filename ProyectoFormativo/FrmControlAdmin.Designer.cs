
namespace ProyectoFormativo
{
	partial class FrmControlAdmin
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnIngreso = new System.Windows.Forms.Button();
			this.tc_Usuario = new System.Windows.Forms.TabControl();
			this.Usuarios = new System.Windows.Forms.TabPage();
			this.Propietario = new System.Windows.Forms.TabPage();
			this.Equipo = new System.Windows.Forms.TabPage();
			this.Control = new System.Windows.Forms.TabPage();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtEquipo = new System.Windows.Forms.TextBox();
			this.txtDocumento = new System.Windows.Forms.TextBox();
			this.txtIdEquipo = new System.Windows.Forms.TextBox();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnSalida = new System.Windows.Forms.Button();
			this.DGVControl_U = new System.Windows.Forms.DataGridView();
			this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.T_Bien = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.F_registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.H_Ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.H_Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Observaacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gb_Registro_C_U = new System.Windows.Forms.GroupBox();
			this.tc_Usuario.SuspendLayout();
			this.Control.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DGVControl_U)).BeginInit();
			this.gb_Registro_C_U.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnIngreso
			// 
			this.btnIngreso.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnIngreso.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnIngreso.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnIngreso.FlatAppearance.BorderSize = 0;
			this.btnIngreso.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btnIngreso.Location = new System.Drawing.Point(414, 19);
			this.btnIngreso.Name = "btnIngreso";
			this.btnIngreso.Size = new System.Drawing.Size(104, 73);
			this.btnIngreso.TabIndex = 0;
			this.btnIngreso.Text = "Ingreso";
			this.btnIngreso.UseVisualStyleBackColor = false;
			this.btnIngreso.Click += new System.EventHandler(this.button1_Click);
			// 
			// tc_Usuario
			// 
			this.tc_Usuario.Controls.Add(this.Usuarios);
			this.tc_Usuario.Controls.Add(this.Propietario);
			this.tc_Usuario.Controls.Add(this.Equipo);
			this.tc_Usuario.Controls.Add(this.Control);
			this.tc_Usuario.Location = new System.Drawing.Point(21, 12);
			this.tc_Usuario.Name = "tc_Usuario";
			this.tc_Usuario.SelectedIndex = 0;
			this.tc_Usuario.Size = new System.Drawing.Size(758, 413);
			this.tc_Usuario.TabIndex = 1;
			// 
			// Usuarios
			// 
			this.Usuarios.BackColor = System.Drawing.SystemColors.Control;
			this.Usuarios.Location = new System.Drawing.Point(4, 22);
			this.Usuarios.Name = "Usuarios";
			this.Usuarios.Padding = new System.Windows.Forms.Padding(3);
			this.Usuarios.Size = new System.Drawing.Size(750, 387);
			this.Usuarios.TabIndex = 0;
			this.Usuarios.Text = "Usuarios";
			// 
			// Propietario
			// 
			this.Propietario.BackColor = System.Drawing.SystemColors.Control;
			this.Propietario.Location = new System.Drawing.Point(4, 22);
			this.Propietario.Name = "Propietario";
			this.Propietario.Padding = new System.Windows.Forms.Padding(3);
			this.Propietario.Size = new System.Drawing.Size(750, 387);
			this.Propietario.TabIndex = 1;
			this.Propietario.Text = "Propietario";
			// 
			// Equipo
			// 
			this.Equipo.BackColor = System.Drawing.SystemColors.Control;
			this.Equipo.Location = new System.Drawing.Point(4, 22);
			this.Equipo.Name = "Equipo";
			this.Equipo.Padding = new System.Windows.Forms.Padding(3);
			this.Equipo.Size = new System.Drawing.Size(750, 387);
			this.Equipo.TabIndex = 2;
			this.Equipo.Text = "Equipo";
			// 
			// Control
			// 
			this.Control.BackColor = System.Drawing.SystemColors.Control;
			this.Control.Controls.Add(this.gb_Registro_C_U);
			this.Control.Controls.Add(this.DGVControl_U);
			this.Control.Location = new System.Drawing.Point(4, 22);
			this.Control.Name = "Control";
			this.Control.Padding = new System.Windows.Forms.Padding(3);
			this.Control.Size = new System.Drawing.Size(750, 387);
			this.Control.TabIndex = 3;
			this.Control.Text = "Control";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(21, 62);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(100, 20);
			this.txtNombre.TabIndex = 5;
			this.txtNombre.Text = "Nombre: ";
			this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
			// 
			// txtEquipo
			// 
			this.txtEquipo.Location = new System.Drawing.Point(147, 62);
			this.txtEquipo.Name = "txtEquipo";
			this.txtEquipo.Size = new System.Drawing.Size(100, 20);
			this.txtEquipo.TabIndex = 4;
			this.txtEquipo.Text = "Equipo: ";
			this.txtEquipo.Enter += new System.EventHandler(this.txtEquipo_Enter);
			// 
			// txtDocumento
			// 
			this.txtDocumento.Location = new System.Drawing.Point(147, 23);
			this.txtDocumento.Name = "txtDocumento";
			this.txtDocumento.Size = new System.Drawing.Size(100, 20);
			this.txtDocumento.TabIndex = 3;
			this.txtDocumento.Text = "Documento: ";
			this.txtDocumento.Enter += new System.EventHandler(this.txtDocumento_Enter);
			// 
			// txtIdEquipo
			// 
			this.txtIdEquipo.Location = new System.Drawing.Point(21, 24);
			this.txtIdEquipo.Name = "txtIdEquipo";
			this.txtIdEquipo.Size = new System.Drawing.Size(100, 20);
			this.txtIdEquipo.TabIndex = 2;
			this.txtIdEquipo.Text = "ID Equipo:";
			this.txtIdEquipo.Enter += new System.EventHandler(this.txtIdEquipo_Enter);
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(269, 19);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(42, 29);
			this.btnBuscar.TabIndex = 6;
			this.btnBuscar.Text = "O";
			this.btnBuscar.UseVisualStyleBackColor = true;
			// 
			// btnSalida
			// 
			this.btnSalida.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnSalida.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSalida.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnSalida.FlatAppearance.BorderSize = 0;
			this.btnSalida.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btnSalida.Location = new System.Drawing.Point(561, 19);
			this.btnSalida.Name = "btnSalida";
			this.btnSalida.Size = new System.Drawing.Size(107, 73);
			this.btnSalida.TabIndex = 7;
			this.btnSalida.Text = "Salida";
			this.btnSalida.UseVisualStyleBackColor = false;
			// 
			// DGVControl_U
			// 
			this.DGVControl_U.AllowUserToAddRows = false;
			this.DGVControl_U.AllowUserToDeleteRows = false;
			this.DGVControl_U.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DGVControl_U.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGVControl_U.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.T_Bien,
            this.F_registro,
            this.H_Ingreso,
            this.H_Salida,
            this.Observaacion});
			this.DGVControl_U.Location = new System.Drawing.Point(2, 143);
			this.DGVControl_U.Name = "DGVControl_U";
			this.DGVControl_U.ReadOnly = true;
			this.DGVControl_U.Size = new System.Drawing.Size(745, 147);
			this.DGVControl_U.TabIndex = 8;
			// 
			// Codigo
			// 
			this.Codigo.HeaderText = "Codigo";
			this.Codigo.Name = "Codigo";
			this.Codigo.ReadOnly = true;
			// 
			// Nombre
			// 
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			this.Nombre.ReadOnly = true;
			// 
			// T_Bien
			// 
			this.T_Bien.HeaderText = "T. Bien";
			this.T_Bien.Name = "T_Bien";
			this.T_Bien.ReadOnly = true;
			// 
			// F_registro
			// 
			this.F_registro.HeaderText = "F. Registro";
			this.F_registro.Name = "F_registro";
			this.F_registro.ReadOnly = true;
			// 
			// H_Ingreso
			// 
			this.H_Ingreso.HeaderText = "H. Ingreso";
			this.H_Ingreso.Name = "H_Ingreso";
			this.H_Ingreso.ReadOnly = true;
			// 
			// H_Salida
			// 
			this.H_Salida.HeaderText = "H. Salida";
			this.H_Salida.Name = "H_Salida";
			this.H_Salida.ReadOnly = true;
			// 
			// Observaacion
			// 
			this.Observaacion.HeaderText = "Observacion";
			this.Observaacion.Name = "Observaacion";
			this.Observaacion.ReadOnly = true;
			// 
			// gb_Registro_C_U
			// 
			this.gb_Registro_C_U.Controls.Add(this.btnBuscar);
			this.gb_Registro_C_U.Controls.Add(this.btnSalida);
			this.gb_Registro_C_U.Controls.Add(this.btnIngreso);
			this.gb_Registro_C_U.Controls.Add(this.txtEquipo);
			this.gb_Registro_C_U.Controls.Add(this.txtNombre);
			this.gb_Registro_C_U.Controls.Add(this.txtDocumento);
			this.gb_Registro_C_U.Controls.Add(this.txtIdEquipo);
			this.gb_Registro_C_U.Location = new System.Drawing.Point(3, 15);
			this.gb_Registro_C_U.Name = "gb_Registro_C_U";
			this.gb_Registro_C_U.Size = new System.Drawing.Size(744, 106);
			this.gb_Registro_C_U.TabIndex = 10;
			this.gb_Registro_C_U.TabStop = false;
			this.gb_Registro_C_U.Text = "Registro";
			// 
			// FrmControlAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tc_Usuario);
			this.Name = "FrmControlAdmin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Control";
			this.Load += new System.EventHandler(this.FrmControlAdmin_Load);
			this.tc_Usuario.ResumeLayout(false);
			this.Control.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DGVControl_U)).EndInit();
			this.gb_Registro_C_U.ResumeLayout(false);
			this.gb_Registro_C_U.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnIngreso;
		private System.Windows.Forms.TabControl tc_Usuario;
		private System.Windows.Forms.TabPage Usuarios;
		private System.Windows.Forms.TabPage Propietario;
		private System.Windows.Forms.TabPage Equipo;
		private System.Windows.Forms.TabPage Control;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtEquipo;
		private System.Windows.Forms.TextBox txtDocumento;
		private System.Windows.Forms.TextBox txtIdEquipo;
		private System.Windows.Forms.Button btnSalida;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.DataGridView DGVControl_U;
		private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn T_Bien;
		private System.Windows.Forms.DataGridViewTextBoxColumn F_registro;
		private System.Windows.Forms.DataGridViewTextBoxColumn H_Ingreso;
		private System.Windows.Forms.DataGridViewTextBoxColumn H_Salida;
		private System.Windows.Forms.DataGridViewTextBoxColumn Observaacion;
		private System.Windows.Forms.GroupBox gb_Registro_C_U;
	}
}

