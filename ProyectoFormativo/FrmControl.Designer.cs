namespace ProyectoFormativo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmControlVigi));
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Feltar = new System.Windows.Forms.Button();
            this.cb_Fecha_R = new System.Windows.Forms.CheckBox();
            this.combox_pag = new System.Windows.Forms.ComboBox();
            this.DGVReportes = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_horaR = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_filtrarReporteDoc = new System.Windows.Forms.TextBox();
            this.cb_Documento_R = new System.Windows.Forms.CheckBox();
            this.dt_Fecha_R = new System.Windows.Forms.DateTimePicker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.relogR = new System.Windows.Forms.Timer(this.components);
            this.lbl_Nom_User = new System.Windows.Forms.Label();
            this.lbl_Rol = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gb_Registro_C_U.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVControl_U)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVReportes)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
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
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 371);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Control";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_salir_C_U
            // 
            this.btn_salir_C_U.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.btn_cancelar_C_U.Image = global::ProyectoFormativo.Properties.Resources.refresh;
            this.btn_cancelar_C_U.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cancelar_C_U.Location = new System.Drawing.Point(516, 41);
            this.btn_cancelar_C_U.Name = "btn_cancelar_C_U";
            this.btn_cancelar_C_U.Size = new System.Drawing.Size(24, 23);
            this.btn_cancelar_C_U.TabIndex = 17;
            this.btn_cancelar_C_U.UseVisualStyleBackColor = true;
            this.btn_cancelar_C_U.Click += new System.EventHandler(this.btn_cancelar_C_U_Click);
            // 
            // btn_Salida_U
            // 
            this.btn_Salida_U.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.btn_Ingreso_U.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.lbl_horaSistem_U.Size = new System.Drawing.Size(329, 44);
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
            this.Column1,
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
            this.ID.FillWeight = 75F;
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
            // Column1
            // 
            this.Column1.DataPropertyName = "Marca";
            this.Column1.HeaderText = "Marca";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
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
            this.tabPage2.Controls.Add(this.txt_Cantidad);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btn_Feltar);
            this.tabPage2.Controls.Add(this.cb_Fecha_R);
            this.tabPage2.Controls.Add(this.combox_pag);
            this.tabPage2.Controls.Add(this.DGVReportes);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txt_filtrarReporteDoc);
            this.tabPage2.Controls.Add(this.cb_Documento_R);
            this.tabPage2.Controls.Add(this.dt_Fecha_R);
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 371);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reportes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(698, 268);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(46, 20);
            this.txt_Cantidad.TabIndex = 14;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(666, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "De";
            // 
            // btn_Feltar
            // 
            this.btn_Feltar.Enabled = false;
            this.btn_Feltar.Location = new System.Drawing.Point(407, 13);
            this.btn_Feltar.Name = "btn_Feltar";
            this.btn_Feltar.Size = new System.Drawing.Size(75, 23);
            this.btn_Feltar.TabIndex = 8;
            this.btn_Feltar.Text = "Filtrar";
            this.btn_Feltar.UseVisualStyleBackColor = true;
            this.btn_Feltar.Click += new System.EventHandler(this.btn_Feltar_Click);
            // 
            // cb_Fecha_R
            // 
            this.cb_Fecha_R.AutoSize = true;
            this.cb_Fecha_R.Location = new System.Drawing.Point(25, 16);
            this.cb_Fecha_R.Name = "cb_Fecha_R";
            this.cb_Fecha_R.Size = new System.Drawing.Size(15, 14);
            this.cb_Fecha_R.TabIndex = 3;
            this.cb_Fecha_R.UseVisualStyleBackColor = true;
            this.cb_Fecha_R.CheckedChanged += new System.EventHandler(this.cb_Fecha_R_CheckedChanged);
            // 
            // combox_pag
            // 
            this.combox_pag.FormattingEnabled = true;
            this.combox_pag.Location = new System.Drawing.Point(609, 268);
            this.combox_pag.Name = "combox_pag";
            this.combox_pag.Size = new System.Drawing.Size(51, 21);
            this.combox_pag.TabIndex = 12;
            this.combox_pag.SelectionChangeCommitted += new System.EventHandler(this.combox_pag_SelectionChangeCommitted);
            this.combox_pag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combox_pag_KeyPress);
            // 
            // DGVReportes
            // 
            this.DGVReportes.AllowUserToAddRows = false;
            this.DGVReportes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.DGVReportes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVReportes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVReportes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
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
            this.Column9,
            this.dataGridViewTextBoxColumn3,
            this.Column8,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.DGVReportes.Cursor = System.Windows.Forms.Cursors.Default;
            this.DGVReportes.EnableHeadersVisualStyles = false;
            this.DGVReportes.Location = new System.Drawing.Point(25, 42);
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
            this.DGVReportes.Size = new System.Drawing.Size(720, 220);
            this.DGVReportes.TabIndex = 7;
            this.DGVReportes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGVReportes_CellFormatting);
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
            this.label9.Size = new System.Drawing.Size(329, 44);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(552, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Pagina";
            // 
            // txt_filtrarReporteDoc
            // 
            this.txt_filtrarReporteDoc.Enabled = false;
            this.txt_filtrarReporteDoc.ForeColor = System.Drawing.Color.Silver;
            this.txt_filtrarReporteDoc.Location = new System.Drawing.Point(253, 16);
            this.txt_filtrarReporteDoc.Name = "txt_filtrarReporteDoc";
            this.txt_filtrarReporteDoc.Size = new System.Drawing.Size(132, 20);
            this.txt_filtrarReporteDoc.TabIndex = 6;
            this.txt_filtrarReporteDoc.Text = "Documento";
            this.txt_filtrarReporteDoc.Enter += new System.EventHandler(this.txt_filtrarReporteDoc_Enter);
            this.txt_filtrarReporteDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_filtrarReporteDoc_KeyPress);
            this.txt_filtrarReporteDoc.Leave += new System.EventHandler(this.txt_filtrarReporteDoc_Leave);
            // 
            // cb_Documento_R
            // 
            this.cb_Documento_R.AutoSize = true;
            this.cb_Documento_R.Location = new System.Drawing.Point(231, 16);
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
            this.dt_Fecha_R.Location = new System.Drawing.Point(47, 16);
            this.dt_Fecha_R.Name = "dt_Fecha_R";
            this.dt_Fecha_R.Size = new System.Drawing.Size(112, 20);
            this.dt_Fecha_R.TabIndex = 5;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "time_management_tasks_to_do_list_planning_icon_188740.ico");
            this.imageList1.Images.SetKeyName(1, "estadistica-inferencial.png");
            this.imageList1.Images.SetKeyName(2, "cerrar.png");
            this.imageList1.Images.SetKeyName(3, "boton-eliminar2.png");
            // 
            // relogR
            // 
            this.relogR.Enabled = true;
            this.relogR.Tick += new System.EventHandler(this.relogR_Tick);
            // 
            // lbl_Nom_User
            // 
            this.lbl_Nom_User.AutoSize = true;
            this.lbl_Nom_User.Location = new System.Drawing.Point(19, 424);
            this.lbl_Nom_User.Name = "lbl_Nom_User";
            this.lbl_Nom_User.Size = new System.Drawing.Size(42, 13);
            this.lbl_Nom_User.TabIndex = 7;
            this.lbl_Nom_User.Text = "nombre";
            this.lbl_Nom_User.Visible = false;
            // 
            // lbl_Rol
            // 
            this.lbl_Rol.AutoSize = true;
            this.lbl_Rol.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rol.Location = new System.Drawing.Point(706, 11);
            this.lbl_Rol.Name = "lbl_Rol";
            this.lbl_Rol.Size = new System.Drawing.Size(31, 19);
            this.lbl_Rol.TabIndex = 2;
            this.lbl_Rol.Text = "Rol";
            this.lbl_Rol.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFormativo.Properties.Resources.user3;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(676, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_control";
            this.dataGridViewTextBoxColumn1.FillWeight = 70F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Visitante";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Documento";
            this.Column9.HeaderText = "Documento";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
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
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "hora_entrada";
            this.dataGridViewTextBoxColumn5.HeaderText = "Entrada";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "hora_salida";
            this.dataGridViewTextBoxColumn6.HeaderText = "Salida";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Nom_User";
            this.dataGridViewTextBoxColumn7.HeaderText = "Usuario";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // FrmControlVigi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Rol);
            this.Controls.Add(this.lbl_Nom_User);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Timer relog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Feltar;
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
        private System.Windows.Forms.Label lbl_Nom_User;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combox_pag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Rol;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoBien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}