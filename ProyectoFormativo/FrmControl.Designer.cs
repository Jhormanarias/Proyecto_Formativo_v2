﻿namespace ProyectoFormativo
{
	partial class FrmControlVigi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.relog = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_salir_C_U = new System.Windows.Forms.Button();
            this.gb_Registro_C_U = new System.Windows.Forms.GroupBox();
            this.btn_cancelar_C_U = new System.Windows.Forms.Button();
            this.btn_Salida_U = new System.Windows.Forms.Button();
            this.btn_Ingreso_U = new System.Windows.Forms.Button();
            this.btn_Cam_U = new System.Windows.Forms.Button();
            this.btn_Busrcar_R_U = new System.Windows.Forms.Button();
            this.txt_BuscarBien_C_U = new System.Windows.Forms.TextBox();
            this.txt_nombre_R_U = new System.Windows.Forms.TextBox();
            this.txt_Documento_C_U = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_horaSistem_U = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.DGVControl_U = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoBien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.cb_Fecha_R = new System.Windows.Forms.CheckBox();
            this.DGVReportes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_horaR = new System.Windows.Forms.Label();
            this.txt_filtrarReporteDoc = new System.Windows.Forms.TextBox();
            this.cb_Documento_R = new System.Windows.Forms.CheckBox();
            this.dt_Fecha_R = new System.Windows.Forms.DateTimePicker();
            this.relogR = new System.Windows.Forms.Timer(this.components);
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_Nom_User = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gb_Registro_C_U.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVControl_U)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVReportes)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // relog
            // 
            this.relog.Enabled = true;
            this.relog.Interval = 1000;
            this.relog.Tick += new System.EventHandler(this.relog_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 402);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_salir_C_U);
            this.tabPage1.Controls.Add(this.gb_Registro_C_U);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.DGVControl_U);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 376);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Control";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_salir_C_U
            // 
            this.btn_salir_C_U.Location = new System.Drawing.Point(670, 13);
            this.btn_salir_C_U.Name = "btn_salir_C_U";
            this.btn_salir_C_U.Size = new System.Drawing.Size(75, 23);
            this.btn_salir_C_U.TabIndex = 10;
            this.btn_salir_C_U.Text = "Salir";
            this.btn_salir_C_U.UseVisualStyleBackColor = true;
            this.btn_salir_C_U.Click += new System.EventHandler(this.btn_salir_C_U_Click);
            // 
            // gb_Registro_C_U
            // 
            this.gb_Registro_C_U.Controls.Add(this.btn_cancelar_C_U);
            this.gb_Registro_C_U.Controls.Add(this.btn_Salida_U);
            this.gb_Registro_C_U.Controls.Add(this.btn_Ingreso_U);
            this.gb_Registro_C_U.Controls.Add(this.btn_Cam_U);
            this.gb_Registro_C_U.Controls.Add(this.btn_Busrcar_R_U);
            this.gb_Registro_C_U.Controls.Add(this.txt_BuscarBien_C_U);
            this.gb_Registro_C_U.Controls.Add(this.txt_nombre_R_U);
            this.gb_Registro_C_U.Controls.Add(this.txt_Documento_C_U);
            this.gb_Registro_C_U.Controls.Add(this.label4);
            this.gb_Registro_C_U.Controls.Add(this.label3);
            this.gb_Registro_C_U.Controls.Add(this.label2);
            this.gb_Registro_C_U.Location = new System.Drawing.Point(25, 174);
            this.gb_Registro_C_U.Name = "gb_Registro_C_U";
            this.gb_Registro_C_U.Size = new System.Drawing.Size(720, 106);
            this.gb_Registro_C_U.TabIndex = 9;
            this.gb_Registro_C_U.TabStop = false;
            this.gb_Registro_C_U.Text = "Registro";
            // 
            // btn_cancelar_C_U
            // 
            this.btn_cancelar_C_U.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar_C_U.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_cancelar_C_U.Location = new System.Drawing.Point(516, 41);
            this.btn_cancelar_C_U.Name = "btn_cancelar_C_U";
            this.btn_cancelar_C_U.Size = new System.Drawing.Size(24, 23);
            this.btn_cancelar_C_U.TabIndex = 17;
            this.btn_cancelar_C_U.Text = "X";
            this.btn_cancelar_C_U.UseVisualStyleBackColor = true;
            this.btn_cancelar_C_U.Click += new System.EventHandler(this.btn_cancelar_C_U_Click);
            // 
            // btn_Salida_U
            // 
            this.btn_Salida_U.Enabled = false;
            this.btn_Salida_U.Location = new System.Drawing.Point(645, 23);
            this.btn_Salida_U.Name = "btn_Salida_U";
            this.btn_Salida_U.Size = new System.Drawing.Size(67, 66);
            this.btn_Salida_U.TabIndex = 16;
            this.btn_Salida_U.Text = "Salida";
            this.btn_Salida_U.UseVisualStyleBackColor = false;
            this.btn_Salida_U.Click += new System.EventHandler(this.btn_Salida_U_Click);
            // 
            // btn_Ingreso_U
            // 
            this.btn_Ingreso_U.Enabled = false;
            this.btn_Ingreso_U.Location = new System.Drawing.Point(562, 23);
            this.btn_Ingreso_U.Name = "btn_Ingreso_U";
            this.btn_Ingreso_U.Size = new System.Drawing.Size(69, 66);
            this.btn_Ingreso_U.TabIndex = 15;
            this.btn_Ingreso_U.Text = "Ingreso";
            this.btn_Ingreso_U.UseVisualStyleBackColor = false;
            this.btn_Ingreso_U.Click += new System.EventHandler(this.btn_Ingreso_U_Click);
            // 
            // btn_Cam_U
            // 
            this.btn_Cam_U.Location = new System.Drawing.Point(435, 61);
            this.btn_Cam_U.Name = "btn_Cam_U";
            this.btn_Cam_U.Size = new System.Drawing.Size(75, 23);
            this.btn_Cam_U.TabIndex = 14;
            this.btn_Cam_U.Text = "Cam";
            this.btn_Cam_U.UseVisualStyleBackColor = true;
            // 
            // btn_Busrcar_R_U
            // 
            this.btn_Busrcar_R_U.Location = new System.Drawing.Point(435, 23);
            this.btn_Busrcar_R_U.Name = "btn_Busrcar_R_U";
            this.btn_Busrcar_R_U.Size = new System.Drawing.Size(75, 23);
            this.btn_Busrcar_R_U.TabIndex = 10;
            this.btn_Busrcar_R_U.Text = "Buscar";
            this.btn_Busrcar_R_U.UseVisualStyleBackColor = true;
            this.btn_Busrcar_R_U.Click += new System.EventHandler(this.btn_Busrcar_R_U_Click);
            // 
            // txt_BuscarBien_C_U
            // 
            this.txt_BuscarBien_C_U.ForeColor = System.Drawing.Color.Black;
            this.txt_BuscarBien_C_U.Location = new System.Drawing.Point(291, 23);
            this.txt_BuscarBien_C_U.Name = "txt_BuscarBien_C_U";
            this.txt_BuscarBien_C_U.Size = new System.Drawing.Size(132, 20);
            this.txt_BuscarBien_C_U.TabIndex = 12;
            this.txt_BuscarBien_C_U.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_BuscarBien_C_U_KeyPress);
            // 
            // txt_nombre_R_U
            // 
            this.txt_nombre_R_U.Enabled = false;
            this.txt_nombre_R_U.ForeColor = System.Drawing.Color.Silver;
            this.txt_nombre_R_U.Location = new System.Drawing.Point(82, 69);
            this.txt_nombre_R_U.Name = "txt_nombre_R_U";
            this.txt_nombre_R_U.Size = new System.Drawing.Size(132, 20);
            this.txt_nombre_R_U.TabIndex = 11;
            // 
            // txt_Documento_C_U
            // 
            this.txt_Documento_C_U.ForeColor = System.Drawing.Color.Black;
            this.txt_Documento_C_U.Location = new System.Drawing.Point(82, 23);
            this.txt_Documento_C_U.Name = "txt_Documento_C_U";
            this.txt_Documento_C_U.Size = new System.Drawing.Size(132, 20);
            this.txt_Documento_C_U.TabIndex = 10;
            this.txt_Documento_C_U.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Documento_C_U_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Serial Bein:";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_horaSistem_U);
            this.groupBox2.Controls.Add(this.lbl_hora);
            this.groupBox2.Location = new System.Drawing.Point(24, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(721, 75);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
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
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_hora.Location = new System.Drawing.Point(491, 20);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(198, 42);
            this.lbl_hora.TabIndex = 1;
            this.lbl_hora.Text = "00:00:00 --";
            // 
            // DGVControl_U
            // 
            this.DGVControl_U.AllowUserToAddRows = false;
            this.DGVControl_U.AllowUserToDeleteRows = false;
            this.DGVControl_U.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVControl_U.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGVControl_U.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVControl_U.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVControl_U.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVControl_U.ColumnHeadersHeight = 25;
            this.DGVControl_U.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVControl_U.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Apellido,
            this.TipoBien,
            this.Serial,
            this.Color});
            this.DGVControl_U.EnableHeadersVisualStyles = false;
            this.DGVControl_U.Location = new System.Drawing.Point(24, 42);
            this.DGVControl_U.Name = "DGVControl_U";
            this.DGVControl_U.ReadOnly = true;
            this.DGVControl_U.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVControl_U.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVControl_U.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVControl_U.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVControl_U.Size = new System.Drawing.Size(721, 124);
            this.DGVControl_U.TabIndex = 7;
            this.DGVControl_U.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVControl_U_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_bien";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // TipoBien
            // 
            this.TipoBien.DataPropertyName = "Tipobien";
            this.TipoBien.HeaderText = "Tipo de Bien";
            this.TipoBien.Name = "TipoBien";
            this.TipoBien.ReadOnly = true;
            // 
            // Serial
            // 
            this.Serial.DataPropertyName = "Serial";
            this.Serial.HeaderText = "Serial";
            this.Serial.Name = "Serial";
            this.Serial.ReadOnly = true;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.cb_Fecha_R);
            this.tabPage2.Controls.Add(this.DGVReportes);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.txt_filtrarReporteDoc);
            this.tabPage2.Controls.Add(this.cb_Documento_R);
            this.tabPage2.Controls.Add(this.dt_Fecha_R);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 376);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reportes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(670, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(407, 36);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "Filtrar";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // cb_Fecha_R
            // 
            this.cb_Fecha_R.AutoSize = true;
            this.cb_Fecha_R.Location = new System.Drawing.Point(25, 36);
            this.cb_Fecha_R.Name = "cb_Fecha_R";
            this.cb_Fecha_R.Size = new System.Drawing.Size(15, 14);
            this.cb_Fecha_R.TabIndex = 3;
            this.cb_Fecha_R.UseVisualStyleBackColor = true;
            this.cb_Fecha_R.CheckedChanged += new System.EventHandler(this.cb_Fecha_R_CheckedChanged);
            // 
            // DGVReportes
            // 
            this.DGVReportes.AllowUserToAddRows = false;
            this.DGVReportes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.DGVReportes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVReportes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVReportes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVReportes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVReportes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVReportes.ColumnHeadersHeight = 25;
            this.DGVReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVReportes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column8,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.DGVReportes.Cursor = System.Windows.Forms.Cursors.Default;
            this.DGVReportes.EnableHeadersVisualStyles = false;
            this.DGVReportes.Location = new System.Drawing.Point(25, 65);
            this.DGVReportes.Name = "DGVReportes";
            this.DGVReportes.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVReportes.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVReportes.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DGVReportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVReportes.Size = new System.Drawing.Size(720, 218);
            this.DGVReportes.TabIndex = 7;
            this.DGVReportes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGVReportes_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_control";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "N. Visitante";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Tipobien";
            this.dataGridViewTextBoxColumn3.HeaderText = "Bien";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Serial";
            this.Column8.HeaderText = "Serial";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fecha_registro";
            this.dataGridViewTextBoxColumn4.HeaderText = "F. Registro";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "hora_entrada";
            this.dataGridViewTextBoxColumn5.HeaderText = "H. Ingreso";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "hora_salida";
            this.dataGridViewTextBoxColumn6.HeaderText = "H. Salida";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Nom_User";
            this.dataGridViewTextBoxColumn7.HeaderText = "N. Usuario";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.lbl_horaR);
            this.groupBox4.Location = new System.Drawing.Point(25, 289);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(720, 75);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(330, 44);
            this.label9.TabIndex = 0;
            this.label9.Text = "Hora del sistema:";
            // 
            // lbl_horaR
            // 
            this.lbl_horaR.AutoSize = true;
            this.lbl_horaR.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_horaR.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_horaR.Location = new System.Drawing.Point(490, 20);
            this.lbl_horaR.Name = "lbl_horaR";
            this.lbl_horaR.Size = new System.Drawing.Size(198, 42);
            this.lbl_horaR.TabIndex = 1;
            this.lbl_horaR.Text = "00:00:00 --";
            // 
            // txt_filtrarReporteDoc
            // 
            this.txt_filtrarReporteDoc.Enabled = false;
            this.txt_filtrarReporteDoc.ForeColor = System.Drawing.Color.Silver;
            this.txt_filtrarReporteDoc.Location = new System.Drawing.Point(253, 36);
            this.txt_filtrarReporteDoc.Name = "txt_filtrarReporteDoc";
            this.txt_filtrarReporteDoc.Size = new System.Drawing.Size(132, 20);
            this.txt_filtrarReporteDoc.TabIndex = 6;
            this.txt_filtrarReporteDoc.Text = "Documento";
            this.txt_filtrarReporteDoc.Enter += new System.EventHandler(this.txt_filtrarReporteDoc_Enter);
            this.txt_filtrarReporteDoc.Leave += new System.EventHandler(this.txt_filtrarReporteDoc_Leave);
            // 
            // cb_Documento_R
            // 
            this.cb_Documento_R.AutoSize = true;
            this.cb_Documento_R.Location = new System.Drawing.Point(231, 36);
            this.cb_Documento_R.Name = "cb_Documento_R";
            this.cb_Documento_R.Size = new System.Drawing.Size(15, 14);
            this.cb_Documento_R.TabIndex = 4;
            this.cb_Documento_R.UseVisualStyleBackColor = true;
            this.cb_Documento_R.CheckedChanged += new System.EventHandler(this.cb_Documento_R_CheckedChanged);
            // 
            // dt_Fecha_R
            // 
            this.dt_Fecha_R.Enabled = false;
            this.dt_Fecha_R.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Fecha_R.Location = new System.Drawing.Point(47, 36);
            this.dt_Fecha_R.Name = "dt_Fecha_R";
            this.dt_Fecha_R.Size = new System.Drawing.Size(112, 20);
            this.dt_Fecha_R.TabIndex = 5;
            // 
            // relogR
            // 
            this.relogR.Enabled = true;
            this.relogR.Tick += new System.EventHandler(this.relogR_Tick);
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Usuario.Location = new System.Drawing.Point(17, 425);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(54, 13);
            this.lbl_Usuario.TabIndex = 6;
            this.lbl_Usuario.Text = "Usuario:";
            // 
            // lbl_Nom_User
            // 
            this.lbl_Nom_User.AutoSize = true;
            this.lbl_Nom_User.Location = new System.Drawing.Point(78, 425);
            this.lbl_Nom_User.Name = "lbl_Nom_User";
            this.lbl_Nom_User.Size = new System.Drawing.Size(42, 13);
            this.lbl_Nom_User.TabIndex = 7;
            this.lbl_Nom_User.Text = "nombre";
            this.lbl_Nom_User.Visible = false;
            // 
            // FrmControlVigi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_Nom_User);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmControlVigi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Entrada y Salida";
            this.Activated += new System.EventHandler(this.FrmControlVigi_Activated);
            this.Load += new System.EventHandler(this.FrmControlVigi_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gb_Registro_C_U.ResumeLayout(false);
            this.gb_Registro_C_U.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVControl_U)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVReportes)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Timer relog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView DGVReportes;
        private System.Windows.Forms.TextBox txt_filtrarReporteDoc;
        private System.Windows.Forms.DateTimePicker dt_Fecha_R;
        private System.Windows.Forms.CheckBox cb_Documento_R;
        private System.Windows.Forms.CheckBox cb_Fecha_R;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_horaR;
        private System.Windows.Forms.Button btn_salir_C_U;
        private System.Windows.Forms.GroupBox gb_Registro_C_U;
        private System.Windows.Forms.Button btn_Salida_U;
        private System.Windows.Forms.Button btn_Ingreso_U;
        private System.Windows.Forms.Button btn_Cam_U;
        private System.Windows.Forms.Button btn_Busrcar_R_U;
        private System.Windows.Forms.TextBox txt_BuscarBien_C_U;
        private System.Windows.Forms.TextBox txt_Documento_C_U;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGVControl_U;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_horaSistem_U;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Button btn_cancelar_C_U;
        private System.Windows.Forms.TextBox txt_nombre_R_U;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer relogR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoBien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label lbl_Nom_User;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}