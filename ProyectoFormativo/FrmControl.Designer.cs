namespace ProyectoFormativo
{
	partial class FrmControl
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.gb_Usuario = new System.Windows.Forms.GroupBox();
			this.btn_salir_C_U = new System.Windows.Forms.Button();
			this.gb_Registro_C_U = new System.Windows.Forms.GroupBox();
			this.btn_Salida_U = new System.Windows.Forms.Button();
			this.btn_Ingreso_U = new System.Windows.Forms.Button();
			this.btn_Cam_U = new System.Windows.Forms.Button();
			this.btn_Busrcar_R_U = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.txt_BuscarBein_C_U = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.txt_Documento_C_U = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btn_Filtar_C_U = new System.Windows.Forms.Button();
			this.DGVControl_U = new System.Windows.Forms.DataGridView();
			this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.T_Bien = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.F_registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.H_Ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.H_Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Observaacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txt_Documento_U = new System.Windows.Forms.TextBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.cb_Documento_U = new System.Windows.Forms.CheckBox();
			this.cb_FechaFiltrar_U = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lbl_horaSistem_U = new System.Windows.Forms.Label();
			this.lbl_hora = new System.Windows.Forms.Label();
			this.relog = new System.Windows.Forms.Timer(this.components);
			this.gb_Usuario.SuspendLayout();
			this.gb_Registro_C_U.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DGVControl_U)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// gb_Usuario
			// 
			this.gb_Usuario.Controls.Add(this.btn_salir_C_U);
			this.gb_Usuario.Controls.Add(this.gb_Registro_C_U);
			this.gb_Usuario.Controls.Add(this.btn_Filtar_C_U);
			this.gb_Usuario.Controls.Add(this.DGVControl_U);
			this.gb_Usuario.Controls.Add(this.txt_Documento_U);
			this.gb_Usuario.Controls.Add(this.dateTimePicker1);
			this.gb_Usuario.Controls.Add(this.cb_Documento_U);
			this.gb_Usuario.Controls.Add(this.cb_FechaFiltrar_U);
			this.gb_Usuario.Controls.Add(this.groupBox2);
			this.gb_Usuario.Location = new System.Drawing.Point(12, 12);
			this.gb_Usuario.Name = "gb_Usuario";
			this.gb_Usuario.Size = new System.Drawing.Size(776, 426);
			this.gb_Usuario.TabIndex = 4;
			this.gb_Usuario.TabStop = false;
			this.gb_Usuario.Text = "Usuario";
			// 
			// btn_salir_C_U
			// 
			this.btn_salir_C_U.Location = new System.Drawing.Point(689, 19);
			this.btn_salir_C_U.Name = "btn_salir_C_U";
			this.btn_salir_C_U.Size = new System.Drawing.Size(75, 23);
			this.btn_salir_C_U.TabIndex = 10;
			this.btn_salir_C_U.Text = "Salir";
			this.btn_salir_C_U.UseVisualStyleBackColor = true;
			this.btn_salir_C_U.Click += new System.EventHandler(this.btn_salir_C_U_Click);
			// 
			// gb_Registro_C_U
			// 
			this.gb_Registro_C_U.Controls.Add(this.btn_Salida_U);
			this.gb_Registro_C_U.Controls.Add(this.btn_Ingreso_U);
			this.gb_Registro_C_U.Controls.Add(this.btn_Cam_U);
			this.gb_Registro_C_U.Controls.Add(this.btn_Busrcar_R_U);
			this.gb_Registro_C_U.Controls.Add(this.textBox3);
			this.gb_Registro_C_U.Controls.Add(this.txt_BuscarBein_C_U);
			this.gb_Registro_C_U.Controls.Add(this.textBox1);
			this.gb_Registro_C_U.Controls.Add(this.txt_Documento_C_U);
			this.gb_Registro_C_U.Controls.Add(this.label5);
			this.gb_Registro_C_U.Controls.Add(this.label4);
			this.gb_Registro_C_U.Controls.Add(this.label3);
			this.gb_Registro_C_U.Controls.Add(this.label2);
			this.gb_Registro_C_U.Location = new System.Drawing.Point(20, 219);
			this.gb_Registro_C_U.Name = "gb_Registro_C_U";
			this.gb_Registro_C_U.Size = new System.Drawing.Size(744, 106);
			this.gb_Registro_C_U.TabIndex = 9;
			this.gb_Registro_C_U.TabStop = false;
			this.gb_Registro_C_U.Text = "Registro";
			// 
			// btn_Salida_U
			// 
			this.btn_Salida_U.Location = new System.Drawing.Point(671, 19);
			this.btn_Salida_U.Name = "btn_Salida_U";
			this.btn_Salida_U.Size = new System.Drawing.Size(67, 66);
			this.btn_Salida_U.TabIndex = 16;
			this.btn_Salida_U.Text = "Salida";
			this.btn_Salida_U.UseVisualStyleBackColor = true;
			// 
			// btn_Ingreso_U
			// 
			this.btn_Ingreso_U.Location = new System.Drawing.Point(588, 19);
			this.btn_Ingreso_U.Name = "btn_Ingreso_U";
			this.btn_Ingreso_U.Size = new System.Drawing.Size(69, 66);
			this.btn_Ingreso_U.TabIndex = 15;
			this.btn_Ingreso_U.Text = "Ingreso";
			this.btn_Ingreso_U.UseVisualStyleBackColor = true;
			// 
			// btn_Cam_U
			// 
			this.btn_Cam_U.Location = new System.Drawing.Point(479, 62);
			this.btn_Cam_U.Name = "btn_Cam_U";
			this.btn_Cam_U.Size = new System.Drawing.Size(75, 23);
			this.btn_Cam_U.TabIndex = 14;
			this.btn_Cam_U.Text = "Cam";
			this.btn_Cam_U.UseVisualStyleBackColor = true;
			// 
			// btn_Busrcar_R_U
			// 
			this.btn_Busrcar_R_U.Location = new System.Drawing.Point(479, 21);
			this.btn_Busrcar_R_U.Name = "btn_Busrcar_R_U";
			this.btn_Busrcar_R_U.Size = new System.Drawing.Size(75, 23);
			this.btn_Busrcar_R_U.TabIndex = 10;
			this.btn_Busrcar_R_U.Text = "Buscar";
			this.btn_Busrcar_R_U.UseVisualStyleBackColor = true;
			// 
			// textBox3
			// 
			this.textBox3.Enabled = false;
			this.textBox3.ForeColor = System.Drawing.Color.Silver;
			this.textBox3.Location = new System.Drawing.Point(324, 65);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(132, 20);
			this.textBox3.TabIndex = 13;
			this.textBox3.Text = "Tipo de bien";
			// 
			// txt_BuscarBein_C_U
			// 
			this.txt_BuscarBein_C_U.ForeColor = System.Drawing.Color.Silver;
			this.txt_BuscarBein_C_U.Location = new System.Drawing.Point(324, 23);
			this.txt_BuscarBein_C_U.Name = "txt_BuscarBein_C_U";
			this.txt_BuscarBein_C_U.Size = new System.Drawing.Size(132, 20);
			this.txt_BuscarBein_C_U.TabIndex = 12;
			this.txt_BuscarBein_C_U.Text = "ID Bien:";
			this.txt_BuscarBein_C_U.Enter += new System.EventHandler(this.txt_BuscarBein_C_U_Enter);
			this.txt_BuscarBein_C_U.Leave += new System.EventHandler(this.txt_BuscarBein_C_U_Leave);
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.ForeColor = System.Drawing.Color.Silver;
			this.textBox1.Location = new System.Drawing.Point(82, 69);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(132, 20);
			this.textBox1.TabIndex = 11;
			this.textBox1.Text = "Nombre";
			// 
			// txt_Documento_C_U
			// 
			this.txt_Documento_C_U.ForeColor = System.Drawing.Color.Silver;
			this.txt_Documento_C_U.Location = new System.Drawing.Point(82, 23);
			this.txt_Documento_C_U.Name = "txt_Documento_C_U";
			this.txt_Documento_C_U.Size = new System.Drawing.Size(132, 20);
			this.txt_Documento_C_U.TabIndex = 10;
			this.txt_Documento_C_U.Text = "Documento";
			this.txt_Documento_C_U.Enter += new System.EventHandler(this.txt_Documento_C_U_Enter);
			this.txt_Documento_C_U.Leave += new System.EventHandler(this.txt_Documento_C_U_Leave);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(267, 72);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(31, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "Bien:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(267, 26);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "ID Bein:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Nombre:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Documento:";
			// 
			// btn_Filtar_C_U
			// 
			this.btn_Filtar_C_U.Location = new System.Drawing.Point(401, 37);
			this.btn_Filtar_C_U.Name = "btn_Filtar_C_U";
			this.btn_Filtar_C_U.Size = new System.Drawing.Size(75, 23);
			this.btn_Filtar_C_U.TabIndex = 8;
			this.btn_Filtar_C_U.Text = "Filtrar";
			this.btn_Filtar_C_U.UseVisualStyleBackColor = true;
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
			this.DGVControl_U.Location = new System.Drawing.Point(19, 66);
			this.DGVControl_U.Name = "DGVControl_U";
			this.DGVControl_U.ReadOnly = true;
			this.DGVControl_U.Size = new System.Drawing.Size(745, 147);
			this.DGVControl_U.TabIndex = 7;
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
			// txt_Documento_U
			// 
			this.txt_Documento_U.ForeColor = System.Drawing.Color.Silver;
			this.txt_Documento_U.Location = new System.Drawing.Point(247, 37);
			this.txt_Documento_U.Name = "txt_Documento_U";
			this.txt_Documento_U.Size = new System.Drawing.Size(132, 20);
			this.txt_Documento_U.TabIndex = 6;
			this.txt_Documento_U.Text = "Documento";
			this.txt_Documento_U.Enter += new System.EventHandler(this.txt_Documento_U_Enter);
			this.txt_Documento_U.Leave += new System.EventHandler(this.txt_Documento_U_Leave);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(41, 37);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(112, 20);
			this.dateTimePicker1.TabIndex = 5;
			// 
			// cb_Documento_U
			// 
			this.cb_Documento_U.AutoSize = true;
			this.cb_Documento_U.Location = new System.Drawing.Point(225, 37);
			this.cb_Documento_U.Name = "cb_Documento_U";
			this.cb_Documento_U.Size = new System.Drawing.Size(15, 14);
			this.cb_Documento_U.TabIndex = 4;
			this.cb_Documento_U.UseVisualStyleBackColor = true;
			// 
			// cb_FechaFiltrar_U
			// 
			this.cb_FechaFiltrar_U.AutoSize = true;
			this.cb_FechaFiltrar_U.Location = new System.Drawing.Point(19, 37);
			this.cb_FechaFiltrar_U.Name = "cb_FechaFiltrar_U";
			this.cb_FechaFiltrar_U.Size = new System.Drawing.Size(15, 14);
			this.cb_FechaFiltrar_U.TabIndex = 3;
			this.cb_FechaFiltrar_U.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lbl_horaSistem_U);
			this.groupBox2.Controls.Add(this.lbl_hora);
			this.groupBox2.Location = new System.Drawing.Point(20, 331);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(744, 75);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			// 
			// lbl_horaSistem_U
			// 
			this.lbl_horaSistem_U.AutoSize = true;
			this.lbl_horaSistem_U.Font = new System.Drawing.Font("MS Reference Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_horaSistem_U.Location = new System.Drawing.Point(6, 16);
			this.lbl_horaSistem_U.Name = "lbl_horaSistem_U";
			this.lbl_horaSistem_U.Size = new System.Drawing.Size(329, 44);
			this.lbl_horaSistem_U.TabIndex = 0;
			this.lbl_horaSistem_U.Text = "Hora del sistema:";
			// 
			// lbl_hora
			// 
			this.lbl_hora.AutoSize = true;
			this.lbl_hora.Font = new System.Drawing.Font("DS-Digital", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_hora.ForeColor = System.Drawing.Color.DarkRed;
			this.lbl_hora.Location = new System.Drawing.Point(503, 16);
			this.lbl_hora.Name = "lbl_hora";
			this.lbl_hora.Size = new System.Drawing.Size(186, 47);
			this.lbl_hora.TabIndex = 1;
			this.lbl_hora.Text = "00:00:00";
			// 
			// relog
			// 
			this.relog.Enabled = true;
			this.relog.Interval = 1000;
			this.relog.Tick += new System.EventHandler(this.relog_Tick);
			// 
			// FrmControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.gb_Usuario);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "FrmControl";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Control Entrada y Salida";
			this.gb_Usuario.ResumeLayout(false);
			this.gb_Usuario.PerformLayout();
			this.gb_Registro_C_U.ResumeLayout(false);
			this.gb_Registro_C_U.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DGVControl_U)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gb_Usuario;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lbl_horaSistem_U;
		private System.Windows.Forms.Label lbl_hora;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.CheckBox cb_Documento_U;
		private System.Windows.Forms.CheckBox cb_FechaFiltrar_U;
		private System.Windows.Forms.TextBox txt_Documento_U;
		private System.Windows.Forms.Button btn_Filtar_C_U;
		private System.Windows.Forms.DataGridView DGVControl_U;
		private System.Windows.Forms.Timer relog;
		private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn T_Bien;
		private System.Windows.Forms.DataGridViewTextBoxColumn F_registro;
		private System.Windows.Forms.DataGridViewTextBoxColumn H_Ingreso;
		private System.Windows.Forms.DataGridViewTextBoxColumn H_Salida;
		private System.Windows.Forms.DataGridViewTextBoxColumn Observaacion;
		private System.Windows.Forms.GroupBox gb_Registro_C_U;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_Documento_C_U;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox txt_BuscarBein_C_U;
		private System.Windows.Forms.Button btn_Cam_U;
		private System.Windows.Forms.Button btn_Busrcar_R_U;
		private System.Windows.Forms.Button btn_Salida_U;
		private System.Windows.Forms.Button btn_Ingreso_U;
		private System.Windows.Forms.Button btn_salir_C_U;
	}
}