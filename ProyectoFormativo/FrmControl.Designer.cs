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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_horaR = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.relogR = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gb_Registro_C_U.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVControl_U)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(775, 414);
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
            this.tabPage1.Size = new System.Drawing.Size(767, 388);
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
            this.gb_Registro_C_U.Location = new System.Drawing.Point(25, 195);
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
            this.btn_Salida_U.UseVisualStyleBackColor = true;
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
            this.btn_Ingreso_U.UseVisualStyleBackColor = true;
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
            this.groupBox2.Location = new System.Drawing.Point(24, 310);
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
            this.lbl_hora.Location = new System.Drawing.Point(499, 16);
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
            this.DGVControl_U.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVControl_U.Location = new System.Drawing.Point(24, 42);
            this.DGVControl_U.Name = "DGVControl_U";
            this.DGVControl_U.ReadOnly = true;
            this.DGVControl_U.Size = new System.Drawing.Size(721, 147);
            this.DGVControl_U.TabIndex = 7;
            this.DGVControl_U.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVControl_U_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.checkBox2);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.dateTimePicker2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 388);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reportes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(667, 18);
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
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(25, 36);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView1.Location = new System.Drawing.Point(25, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(717, 239);
            this.dataGridView1.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "T. Bien";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "F. Registro";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "H. Ingreso";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "H. Salida";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Observacion";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.lbl_horaR);
            this.groupBox4.Location = new System.Drawing.Point(25, 310);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(717, 75);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 16);
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
            this.lbl_horaR.Location = new System.Drawing.Point(497, 17);
            this.lbl_horaR.Name = "lbl_horaR";
            this.lbl_horaR.Size = new System.Drawing.Size(198, 42);
            this.lbl_horaR.TabIndex = 1;
            this.lbl_horaR.Text = "00:00:00 --";
            // 
            // textBox5
            // 
            this.textBox5.ForeColor = System.Drawing.Color.Silver;
            this.textBox5.Location = new System.Drawing.Point(253, 36);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(132, 20);
            this.textBox5.TabIndex = 6;
            this.textBox5.Text = "Documento";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(231, 36);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(47, 36);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(112, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // relogR
            // 
            this.relogR.Enabled = true;
            this.relogR.Tick += new System.EventHandler(this.relogR_Tick);
            // 
            // FrmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Entrada y Salida";
            this.Activated += new System.EventHandler(this.FrmControl_Activated);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gb_Registro_C_U.ResumeLayout(false);
            this.gb_Registro_C_U.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVControl_U)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Timer relog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
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
    }
}