
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
            this.components = new System.ComponentModel.Container();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.tc_Usuario = new System.Windows.Forms.TabControl();
            this.Usuarios = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbRolAU = new System.Windows.Forms.ComboBox();
            this.cbDocumento = new System.Windows.Forms.ComboBox();
            this.btnGuardarAU = new System.Windows.Forms.Button();
            this.txtApellidoAU = new System.Windows.Forms.TextBox();
            this.txtNombreAU = new System.Windows.Forms.TextBox();
            this.txtDocumentoAU = new System.Windows.Forms.TextBox();
            this.Propietario = new System.Windows.Forms.TabPage();
            this.Equipo = new System.Windows.Forms.TabPage();
            this.Control = new System.Windows.Forms.TabPage();
            this.gb_Registro_C_U = new System.Windows.Forms.GroupBox();
            this.btnBuscar_ControlA = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.txtBienAC = new System.Windows.Forms.TextBox();
            this.txtNombreAC = new System.Windows.Forms.TextBox();
            this.txtDocumentoAC = new System.Windows.Forms.TextBox();
            this.txtIdBienAC = new System.Windows.Forms.TextBox();
            this.DGVControl_U = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T_Bien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H_Ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H_Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscar_verU = new System.Windows.Forms.Button();
            this.dgv_VerU = new System.Windows.Forms.DataGridView();
            this.TipoDoc_VerU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ndocumento_VerU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N_VerU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_VerU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programa_VerU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo_VerU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion_VerU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono_VerU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscar_VerU = new System.Windows.Forms.TextBox();
            this.btnModificar_VerU = new System.Windows.Forms.Button();
            this.btnEliminar_VerU = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBuscar_EquipoU = new System.Windows.Forms.Button();
            this.txtDoc_Equipo = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_horaSistem_U = new System.Windows.Forms.Label();
            this.lbl_horaAdmin = new System.Windows.Forms.Label();
            this.timerAdmin = new System.Windows.Forms.Timer(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txtNSerieE = new System.Windows.Forms.TextBox();
            this.txtMarcaE = new System.Windows.Forms.TextBox();
            this.txtTipodeBienE = new System.Windows.Forms.TextBox();
            this.txtCargador = new System.Windows.Forms.TextBox();
            this.codigoEq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoBien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaBien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nSerieBien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargadorBien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nDocumentoDuenoBien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDuenoBien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDuenoBien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc_Usuario.SuspendLayout();
            this.Usuarios.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Equipo.SuspendLayout();
            this.Control.SuspendLayout();
            this.gb_Registro_C_U.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVControl_U)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VerU)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox6.SuspendLayout();
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
            this.Usuarios.Controls.Add(this.groupBox2);
            this.Usuarios.Controls.Add(this.groupBox1);
            this.Usuarios.Location = new System.Drawing.Point(4, 22);
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Padding = new System.Windows.Forms.Padding(3);
            this.Usuarios.Size = new System.Drawing.Size(750, 387);
            this.Usuarios.TabIndex = 0;
            this.Usuarios.Text = "Usuarios";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbRolAU);
            this.groupBox1.Controls.Add(this.cbDocumento);
            this.groupBox1.Controls.Add(this.btnGuardarAU);
            this.groupBox1.Controls.Add(this.txtApellidoAU);
            this.groupBox1.Controls.Add(this.txtNombreAU);
            this.groupBox1.Controls.Add(this.txtDocumentoAU);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 80);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar";
            // 
            // cbRolAU
            // 
            this.cbRolAU.FormattingEnabled = true;
            this.cbRolAU.Items.AddRange(new object[] {
            "Administrador",
            "Vigilante"});
            this.cbRolAU.Location = new System.Drawing.Point(226, 22);
            this.cbRolAU.Name = "cbRolAU";
            this.cbRolAU.Size = new System.Drawing.Size(100, 21);
            this.cbRolAU.TabIndex = 13;
            this.cbRolAU.Text = "Administrador";
            // 
            // cbDocumento
            // 
            this.cbDocumento.FormattingEnabled = true;
            this.cbDocumento.Items.AddRange(new object[] {
            "CC",
            "TI",
            "CE",
            "PS"});
            this.cbDocumento.Location = new System.Drawing.Point(21, 24);
            this.cbDocumento.Name = "cbDocumento";
            this.cbDocumento.Size = new System.Drawing.Size(68, 21);
            this.cbDocumento.TabIndex = 12;
            this.cbDocumento.Text = "CC";
            // 
            // btnGuardarAU
            // 
            this.btnGuardarAU.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGuardarAU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarAU.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGuardarAU.FlatAppearance.BorderSize = 0;
            this.btnGuardarAU.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnGuardarAU.Location = new System.Drawing.Point(602, 19);
            this.btnGuardarAU.Name = "btnGuardarAU";
            this.btnGuardarAU.Size = new System.Drawing.Size(104, 48);
            this.btnGuardarAU.TabIndex = 0;
            this.btnGuardarAU.Text = "Guardar";
            this.btnGuardarAU.UseVisualStyleBackColor = false;
            // 
            // txtApellidoAU
            // 
            this.txtApellidoAU.Location = new System.Drawing.Point(458, 23);
            this.txtApellidoAU.Name = "txtApellidoAU";
            this.txtApellidoAU.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoAU.TabIndex = 4;
            this.txtApellidoAU.Text = "Apellido:";
            // 
            // txtNombreAU
            // 
            this.txtNombreAU.Location = new System.Drawing.Point(342, 22);
            this.txtNombreAU.Name = "txtNombreAU";
            this.txtNombreAU.Size = new System.Drawing.Size(100, 20);
            this.txtNombreAU.TabIndex = 5;
            this.txtNombreAU.Text = "Nombre: ";
            // 
            // txtDocumentoAU
            // 
            this.txtDocumentoAU.Location = new System.Drawing.Point(106, 23);
            this.txtDocumentoAU.Name = "txtDocumentoAU";
            this.txtDocumentoAU.Size = new System.Drawing.Size(100, 20);
            this.txtDocumentoAU.TabIndex = 3;
            this.txtDocumentoAU.Text = "N Documento: ";
            this.txtDocumentoAU.Enter += new System.EventHandler(this.txtDocumentoAU_Enter);
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
            this.Equipo.Controls.Add(this.groupBox6);
            this.Equipo.Controls.Add(this.groupBox5);
            this.Equipo.Controls.Add(this.groupBox3);
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
            this.Control.Controls.Add(this.groupBox4);
            this.Control.Controls.Add(this.gb_Registro_C_U);
            this.Control.Controls.Add(this.DGVControl_U);
            this.Control.Location = new System.Drawing.Point(4, 22);
            this.Control.Name = "Control";
            this.Control.Padding = new System.Windows.Forms.Padding(3);
            this.Control.Size = new System.Drawing.Size(750, 387);
            this.Control.TabIndex = 3;
            this.Control.Text = "Control";
            // 
            // gb_Registro_C_U
            // 
            this.gb_Registro_C_U.Controls.Add(this.btnBuscar_ControlA);
            this.gb_Registro_C_U.Controls.Add(this.btnSalida);
            this.gb_Registro_C_U.Controls.Add(this.btnIngreso);
            this.gb_Registro_C_U.Controls.Add(this.txtBienAC);
            this.gb_Registro_C_U.Controls.Add(this.txtNombreAC);
            this.gb_Registro_C_U.Controls.Add(this.txtDocumentoAC);
            this.gb_Registro_C_U.Controls.Add(this.txtIdBienAC);
            this.gb_Registro_C_U.Location = new System.Drawing.Point(3, 15);
            this.gb_Registro_C_U.Name = "gb_Registro_C_U";
            this.gb_Registro_C_U.Size = new System.Drawing.Size(744, 106);
            this.gb_Registro_C_U.TabIndex = 10;
            this.gb_Registro_C_U.TabStop = false;
            this.gb_Registro_C_U.Text = "Registro";
            // 
            // btnBuscar_ControlA
            // 
            this.btnBuscar_ControlA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBuscar_ControlA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar_ControlA.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBuscar_ControlA.Location = new System.Drawing.Point(269, 19);
            this.btnBuscar_ControlA.Name = "btnBuscar_ControlA";
            this.btnBuscar_ControlA.Size = new System.Drawing.Size(42, 29);
            this.btnBuscar_ControlA.TabIndex = 6;
            this.btnBuscar_ControlA.Text = "O";
            this.btnBuscar_ControlA.UseVisualStyleBackColor = false;
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
            // txtBienAC
            // 
            this.txtBienAC.Location = new System.Drawing.Point(147, 62);
            this.txtBienAC.Name = "txtBienAC";
            this.txtBienAC.Size = new System.Drawing.Size(100, 20);
            this.txtBienAC.TabIndex = 4;
            this.txtBienAC.Text = "Bien:";
            this.txtBienAC.Enter += new System.EventHandler(this.txtEquipo_Enter);
            // 
            // txtNombreAC
            // 
            this.txtNombreAC.Location = new System.Drawing.Point(21, 62);
            this.txtNombreAC.Name = "txtNombreAC";
            this.txtNombreAC.Size = new System.Drawing.Size(100, 20);
            this.txtNombreAC.TabIndex = 5;
            this.txtNombreAC.Text = "Nombre: ";
            this.txtNombreAC.Enter += new System.EventHandler(this.txtNombre_Enter);
            // 
            // txtDocumentoAC
            // 
            this.txtDocumentoAC.Location = new System.Drawing.Point(147, 23);
            this.txtDocumentoAC.Name = "txtDocumentoAC";
            this.txtDocumentoAC.Size = new System.Drawing.Size(100, 20);
            this.txtDocumentoAC.TabIndex = 3;
            this.txtDocumentoAC.Text = "Documento: ";
            this.txtDocumentoAC.Enter += new System.EventHandler(this.txtDocumento_Enter);
            // 
            // txtIdBienAC
            // 
            this.txtIdBienAC.Location = new System.Drawing.Point(21, 24);
            this.txtIdBienAC.Name = "txtIdBienAC";
            this.txtIdBienAC.Size = new System.Drawing.Size(100, 20);
            this.txtIdBienAC.TabIndex = 2;
            this.txtIdBienAC.Text = "ID Bien:";
            this.txtIdBienAC.Enter += new System.EventHandler(this.txtIdEquipo_Enter);
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
            this.DGVControl_U.Size = new System.Drawing.Size(745, 157);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminar_VerU);
            this.groupBox2.Controls.Add(this.btnModificar_VerU);
            this.groupBox2.Controls.Add(this.txtBuscar_VerU);
            this.groupBox2.Controls.Add(this.dgv_VerU);
            this.groupBox2.Controls.Add(this.btnBuscar_verU);
            this.groupBox2.Location = new System.Drawing.Point(11, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(728, 263);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ver";
            // 
            // btnBuscar_verU
            // 
            this.btnBuscar_verU.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBuscar_verU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar_verU.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBuscar_verU.FlatAppearance.BorderSize = 0;
            this.btnBuscar_verU.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBuscar_verU.Location = new System.Drawing.Point(200, 19);
            this.btnBuscar_verU.Name = "btnBuscar_verU";
            this.btnBuscar_verU.Size = new System.Drawing.Size(104, 41);
            this.btnBuscar_verU.TabIndex = 0;
            this.btnBuscar_verU.Text = "Buscar";
            this.btnBuscar_verU.UseVisualStyleBackColor = false;
            // 
            // dgv_VerU
            // 
            this.dgv_VerU.AllowUserToAddRows = false;
            this.dgv_VerU.AllowUserToDeleteRows = false;
            this.dgv_VerU.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_VerU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_VerU.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoDoc_VerU,
            this.Ndocumento_VerU,
            this.N_VerU,
            this.apellido_VerU,
            this.programa_VerU,
            this.correo_VerU,
            this.direccion_VerU,
            this.telefono_VerU});
            this.dgv_VerU.Location = new System.Drawing.Point(16, 84);
            this.dgv_VerU.Name = "dgv_VerU";
            this.dgv_VerU.ReadOnly = true;
            this.dgv_VerU.Size = new System.Drawing.Size(692, 173);
            this.dgv_VerU.TabIndex = 9;
            // 
            // TipoDoc_VerU
            // 
            this.TipoDoc_VerU.HeaderText = "Tipo de documento";
            this.TipoDoc_VerU.Name = "TipoDoc_VerU";
            this.TipoDoc_VerU.ReadOnly = true;
            // 
            // Ndocumento_VerU
            // 
            this.Ndocumento_VerU.HeaderText = "Número de documento";
            this.Ndocumento_VerU.Name = "Ndocumento_VerU";
            this.Ndocumento_VerU.ReadOnly = true;
            // 
            // N_VerU
            // 
            this.N_VerU.HeaderText = "Nombre";
            this.N_VerU.Name = "N_VerU";
            this.N_VerU.ReadOnly = true;
            // 
            // apellido_VerU
            // 
            this.apellido_VerU.HeaderText = "Apellido";
            this.apellido_VerU.Name = "apellido_VerU";
            this.apellido_VerU.ReadOnly = true;
            // 
            // programa_VerU
            // 
            this.programa_VerU.HeaderText = "Programa";
            this.programa_VerU.Name = "programa_VerU";
            this.programa_VerU.ReadOnly = true;
            // 
            // correo_VerU
            // 
            this.correo_VerU.HeaderText = "Correo";
            this.correo_VerU.Name = "correo_VerU";
            this.correo_VerU.ReadOnly = true;
            // 
            // direccion_VerU
            // 
            this.direccion_VerU.HeaderText = "Dirección";
            this.direccion_VerU.Name = "direccion_VerU";
            this.direccion_VerU.ReadOnly = true;
            // 
            // telefono_VerU
            // 
            this.telefono_VerU.HeaderText = "Teléfono";
            this.telefono_VerU.Name = "telefono_VerU";
            this.telefono_VerU.ReadOnly = true;
            // 
            // txtBuscar_VerU
            // 
            this.txtBuscar_VerU.Location = new System.Drawing.Point(16, 30);
            this.txtBuscar_VerU.Name = "txtBuscar_VerU";
            this.txtBuscar_VerU.Size = new System.Drawing.Size(159, 20);
            this.txtBuscar_VerU.TabIndex = 10;
            // 
            // btnModificar_VerU
            // 
            this.btnModificar_VerU.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnModificar_VerU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar_VerU.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnModificar_VerU.FlatAppearance.BorderSize = 0;
            this.btnModificar_VerU.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnModificar_VerU.Location = new System.Drawing.Point(477, 19);
            this.btnModificar_VerU.Name = "btnModificar_VerU";
            this.btnModificar_VerU.Size = new System.Drawing.Size(104, 41);
            this.btnModificar_VerU.TabIndex = 11;
            this.btnModificar_VerU.Text = "Modificar";
            this.btnModificar_VerU.UseVisualStyleBackColor = false;
            // 
            // btnEliminar_VerU
            // 
            this.btnEliminar_VerU.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEliminar_VerU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar_VerU.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEliminar_VerU.FlatAppearance.BorderSize = 0;
            this.btnEliminar_VerU.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEliminar_VerU.Location = new System.Drawing.Point(604, 19);
            this.btnEliminar_VerU.Name = "btnEliminar_VerU";
            this.btnEliminar_VerU.Size = new System.Drawing.Size(104, 41);
            this.btnEliminar_VerU.TabIndex = 12;
            this.btnEliminar_VerU.Text = "Eliminar";
            this.btnEliminar_VerU.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBuscar_EquipoU);
            this.groupBox3.Controls.Add(this.txtDoc_Equipo);
            this.groupBox3.Location = new System.Drawing.Point(6, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(158, 91);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Usuario";
            // 
            // btnBuscar_EquipoU
            // 
            this.btnBuscar_EquipoU.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBuscar_EquipoU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar_EquipoU.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBuscar_EquipoU.FlatAppearance.BorderSize = 0;
            this.btnBuscar_EquipoU.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBuscar_EquipoU.Location = new System.Drawing.Point(17, 47);
            this.btnBuscar_EquipoU.Name = "btnBuscar_EquipoU";
            this.btnBuscar_EquipoU.Size = new System.Drawing.Size(104, 38);
            this.btnBuscar_EquipoU.TabIndex = 0;
            this.btnBuscar_EquipoU.Text = "Buscar";
            this.btnBuscar_EquipoU.UseVisualStyleBackColor = false;
            this.btnBuscar_EquipoU.Click += new System.EventHandler(this.btnBuscar_EquipoU_Click);
            // 
            // txtDoc_Equipo
            // 
            this.txtDoc_Equipo.Location = new System.Drawing.Point(17, 23);
            this.txtDoc_Equipo.Name = "txtDoc_Equipo";
            this.txtDoc_Equipo.Size = new System.Drawing.Size(111, 20);
            this.txtDoc_Equipo.TabIndex = 3;
            this.txtDoc_Equipo.Text = "N Documento: ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_horaSistem_U);
            this.groupBox4.Controls.Add(this.lbl_horaAdmin);
            this.groupBox4.Location = new System.Drawing.Point(3, 306);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(744, 75);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            // 
            // lbl_horaSistem_U
            // 
            this.lbl_horaSistem_U.AutoSize = true;
            this.lbl_horaSistem_U.Font = new System.Drawing.Font("MS Reference Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_horaSistem_U.Location = new System.Drawing.Point(6, 16);
            this.lbl_horaSistem_U.Name = "lbl_horaSistem_U";
            this.lbl_horaSistem_U.Size = new System.Drawing.Size(330, 44);
            this.lbl_horaSistem_U.TabIndex = 0;
            this.lbl_horaSistem_U.Text = "Hora del sistema:";
            // 
            // lbl_horaAdmin
            // 
            this.lbl_horaAdmin.AutoSize = true;
            this.lbl_horaAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_horaAdmin.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_horaAdmin.Location = new System.Drawing.Point(430, 16);
            this.lbl_horaAdmin.Name = "lbl_horaAdmin";
            this.lbl_horaAdmin.Size = new System.Drawing.Size(212, 55);
            this.lbl_horaAdmin.TabIndex = 1;
            this.lbl_horaAdmin.Text = "00:00:00";
            // 
            // timerAdmin
            // 
            this.timerAdmin.Enabled = true;
            this.timerAdmin.Tick += new System.EventHandler(this.timerAdmin_Tick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.dataGridView1);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Location = new System.Drawing.Point(6, 118);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(728, 263);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ver";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(604, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(477, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 41);
            this.button2.TabIndex = 11;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoEq,
            this.tipoBien,
            this.marcaBien,
            this.nSerieBien,
            this.cargadorBien,
            this.nDocumentoDuenoBien,
            this.nombreDuenoBien,
            this.apellidosDuenoBien});
            this.dataGridView1.Location = new System.Drawing.Point(16, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(692, 173);
            this.dataGridView1.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button3.Location = new System.Drawing.Point(200, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 41);
            this.button3.TabIndex = 0;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtCargador);
            this.groupBox6.Controls.Add(this.button4);
            this.groupBox6.Controls.Add(this.txtNSerieE);
            this.groupBox6.Controls.Add(this.txtMarcaE);
            this.groupBox6.Controls.Add(this.txtTipodeBienE);
            this.groupBox6.Location = new System.Drawing.Point(176, 21);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(558, 91);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Agregar";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button4.Location = new System.Drawing.Point(434, 23);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 48);
            this.button4.TabIndex = 0;
            this.button4.Text = "Guardar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // txtNSerieE
            // 
            this.txtNSerieE.Location = new System.Drawing.Point(239, 23);
            this.txtNSerieE.Name = "txtNSerieE";
            this.txtNSerieE.Size = new System.Drawing.Size(100, 20);
            this.txtNSerieE.TabIndex = 4;
            this.txtNSerieE.Text = "N de serie:";
            // 
            // txtMarcaE
            // 
            this.txtMarcaE.Location = new System.Drawing.Point(121, 23);
            this.txtMarcaE.Name = "txtMarcaE";
            this.txtMarcaE.Size = new System.Drawing.Size(100, 20);
            this.txtMarcaE.TabIndex = 5;
            this.txtMarcaE.Text = "Marca:";
            // 
            // txtTipodeBienE
            // 
            this.txtTipodeBienE.Location = new System.Drawing.Point(6, 23);
            this.txtTipodeBienE.Name = "txtTipodeBienE";
            this.txtTipodeBienE.Size = new System.Drawing.Size(100, 20);
            this.txtTipodeBienE.TabIndex = 3;
            this.txtTipodeBienE.Text = "Tipo de bien:";
            // 
            // txtCargador
            // 
            this.txtCargador.Location = new System.Drawing.Point(6, 57);
            this.txtCargador.Name = "txtCargador";
            this.txtCargador.Size = new System.Drawing.Size(100, 20);
            this.txtCargador.TabIndex = 6;
            this.txtCargador.Text = "Cargador:";
            // 
            // codigoEq
            // 
            this.codigoEq.HeaderText = "Código";
            this.codigoEq.Name = "codigoEq";
            this.codigoEq.ReadOnly = true;
            // 
            // tipoBien
            // 
            this.tipoBien.HeaderText = "Tipo de bien";
            this.tipoBien.Name = "tipoBien";
            this.tipoBien.ReadOnly = true;
            // 
            // marcaBien
            // 
            this.marcaBien.HeaderText = "Marca";
            this.marcaBien.Name = "marcaBien";
            this.marcaBien.ReadOnly = true;
            // 
            // nSerieBien
            // 
            this.nSerieBien.HeaderText = "N de serie";
            this.nSerieBien.Name = "nSerieBien";
            this.nSerieBien.ReadOnly = true;
            // 
            // cargadorBien
            // 
            this.cargadorBien.HeaderText = "Cargador";
            this.cargadorBien.Name = "cargadorBien";
            this.cargadorBien.ReadOnly = true;
            // 
            // nDocumentoDuenoBien
            // 
            this.nDocumentoDuenoBien.HeaderText = "N de Documento";
            this.nDocumentoDuenoBien.Name = "nDocumentoDuenoBien";
            this.nDocumentoDuenoBien.ReadOnly = true;
            // 
            // nombreDuenoBien
            // 
            this.nombreDuenoBien.HeaderText = "Nombre";
            this.nombreDuenoBien.Name = "nombreDuenoBien";
            this.nombreDuenoBien.ReadOnly = true;
            // 
            // apellidosDuenoBien
            // 
            this.apellidosDuenoBien.HeaderText = "Apellidos";
            this.apellidosDuenoBien.Name = "apellidosDuenoBien";
            this.apellidosDuenoBien.ReadOnly = true;
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
            this.Usuarios.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Equipo.ResumeLayout(false);
            this.Control.ResumeLayout(false);
            this.gb_Registro_C_U.ResumeLayout(false);
            this.gb_Registro_C_U.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVControl_U)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VerU)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnIngreso;
		private System.Windows.Forms.TabControl tc_Usuario;
		private System.Windows.Forms.TabPage Usuarios;
		private System.Windows.Forms.TabPage Propietario;
		private System.Windows.Forms.TabPage Equipo;
		private System.Windows.Forms.TabPage Control;
		private System.Windows.Forms.TextBox txtNombreAC;
		private System.Windows.Forms.TextBox txtBienAC;
		private System.Windows.Forms.TextBox txtDocumentoAC;
		private System.Windows.Forms.TextBox txtIdBienAC;
		private System.Windows.Forms.Button btnSalida;
		private System.Windows.Forms.Button btnBuscar_ControlA;
		private System.Windows.Forms.DataGridView DGVControl_U;
		private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn T_Bien;
		private System.Windows.Forms.DataGridViewTextBoxColumn F_registro;
		private System.Windows.Forms.DataGridViewTextBoxColumn H_Ingreso;
		private System.Windows.Forms.DataGridViewTextBoxColumn H_Salida;
		private System.Windows.Forms.DataGridViewTextBoxColumn Observaacion;
		private System.Windows.Forms.GroupBox gb_Registro_C_U;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnGuardarAU;
		private System.Windows.Forms.TextBox txtApellidoAU;
		private System.Windows.Forms.TextBox txtNombreAU;
		private System.Windows.Forms.TextBox txtDocumentoAU;
		private System.Windows.Forms.ComboBox cbDocumento;
		private System.Windows.Forms.ComboBox cbRolAU;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_VerU;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDoc_VerU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ndocumento_VerU;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_VerU;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido_VerU;
        private System.Windows.Forms.DataGridViewTextBoxColumn programa_VerU;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo_VerU;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion_VerU;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono_VerU;
        private System.Windows.Forms.Button btnBuscar_verU;
        private System.Windows.Forms.Button btnEliminar_VerU;
        private System.Windows.Forms.Button btnModificar_VerU;
        private System.Windows.Forms.TextBox txtBuscar_VerU;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBuscar_EquipoU;
        private System.Windows.Forms.TextBox txtDoc_Equipo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbl_horaSistem_U;
        private System.Windows.Forms.Label lbl_horaAdmin;
        private System.Windows.Forms.Timer timerAdmin;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtCargador;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtNSerieE;
        private System.Windows.Forms.TextBox txtMarcaE;
        private System.Windows.Forms.TextBox txtTipodeBienE;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEq;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoBien;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaBien;
        private System.Windows.Forms.DataGridViewTextBoxColumn nSerieBien;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargadorBien;
        private System.Windows.Forms.DataGridViewTextBoxColumn nDocumentoDuenoBien;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDuenoBien;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDuenoBien;
        private System.Windows.Forms.Button button3;
    }
}

