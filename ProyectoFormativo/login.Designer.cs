namespace ProyectoFormativo
{
	partial class login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.BtnIngresar = new System.Windows.Forms.Button();
			this.txtUsusario = new System.Windows.Forms.TextBox();
			this.txtContrasena = new System.Windows.Forms.TextBox();
			this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
			this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
			this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
			this.btnCerrar = new System.Windows.Forms.PictureBox();
			this.btnMinimizar = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(256, 367);
			this.panel1.TabIndex = 1;
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 56);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(225, 225);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Black;
			this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DimGray;
			this.label1.Location = new System.Drawing.Point(464, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 34);
			this.label1.TabIndex = 6;
			this.label1.Text = "Ingreso";
			// 
			// BtnIngresar
			// 
			this.BtnIngresar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.BtnIngresar.FlatAppearance.BorderSize = 0;
			this.BtnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
			this.BtnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnIngresar.Location = new System.Drawing.Point(316, 293);
			this.BtnIngresar.Name = "BtnIngresar";
			this.BtnIngresar.Size = new System.Drawing.Size(402, 40);
			this.BtnIngresar.TabIndex = 3;
			this.BtnIngresar.Text = "Ingresar";
			this.BtnIngresar.UseVisualStyleBackColor = false;
			this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
			// 
			// txtUsusario
			// 
			this.txtUsusario.BackColor = System.Drawing.SystemColors.MenuText;
			this.txtUsusario.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtUsusario.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsusario.ForeColor = System.Drawing.Color.DimGray;
			this.txtUsusario.Location = new System.Drawing.Point(319, 108);
			this.txtUsusario.Name = "txtUsusario";
			this.txtUsusario.Size = new System.Drawing.Size(404, 21);
			this.txtUsusario.TabIndex = 1;
			this.txtUsusario.Text = "Usuario";
			this.txtUsusario.Enter += new System.EventHandler(this.txtUsusario_Enter);
			this.txtUsusario.Leave += new System.EventHandler(this.txtUsusario_Leave);
			// 
			// txtContrasena
			// 
			this.txtContrasena.BackColor = System.Drawing.SystemColors.MenuText;
			this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtContrasena.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtContrasena.ForeColor = System.Drawing.Color.DimGray;
			this.txtContrasena.Location = new System.Drawing.Point(317, 224);
			this.txtContrasena.Name = "txtContrasena";
			this.txtContrasena.Size = new System.Drawing.Size(404, 21);
			this.txtContrasena.TabIndex = 2;
			this.txtContrasena.Text = "Contraseña";
			this.txtContrasena.TextChanged += new System.EventHandler(this.txtContrasena_TextChanged);
			this.txtContrasena.Enter += new System.EventHandler(this.txtContrasena_Enter);
			this.txtContrasena.Leave += new System.EventHandler(this.txtContrasena_Leave);
			// 
			// shapeContainer1
			// 
			this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
			this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
			this.shapeContainer1.Name = "shapeContainer1";
			this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
			this.shapeContainer1.Size = new System.Drawing.Size(814, 367);
			this.shapeContainer1.TabIndex = 10;
			this.shapeContainer1.TabStop = false;
			// 
			// lineShape2
			// 
			this.lineShape2.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
			this.lineShape2.Enabled = false;
			this.lineShape2.Name = "lineShape2";
			this.lineShape2.X1 = 315;
			this.lineShape2.X2 = 715;
			this.lineShape2.Y1 = 248;
			this.lineShape2.Y2 = 248;
			// 
			// lineShape1
			// 
			this.lineShape1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
			this.lineShape1.Enabled = false;
			this.lineShape1.Name = "lineShape1";
			this.lineShape1.X1 = 316;
			this.lineShape1.X2 = 720;
			this.lineShape1.Y1 = 132;
			this.lineShape1.Y2 = 132;
			// 
			// btnCerrar
			// 
			this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
			this.btnCerrar.Location = new System.Drawing.Point(782, 3);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(30, 32);
			this.btnCerrar.TabIndex = 11;
			this.btnCerrar.TabStop = false;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// btnMinimizar
			// 
			this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
			this.btnMinimizar.Location = new System.Drawing.Point(740, 0);
			this.btnMinimizar.Name = "btnMinimizar";
			this.btnMinimizar.Size = new System.Drawing.Size(36, 32);
			this.btnMinimizar.TabIndex = 12;
			this.btnMinimizar.TabStop = false;
			this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
			// 
			// login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlText;
			this.ClientSize = new System.Drawing.Size(814, 367);
			this.ControlBox = false;
			this.Controls.Add(this.btnMinimizar);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.txtContrasena);
			this.Controls.Add(this.txtUsusario);
			this.Controls.Add(this.BtnIngresar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.shapeContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "login";
			this.Opacity = 0.9D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "login";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.login_MouseDown);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button BtnIngresar;
		private System.Windows.Forms.TextBox txtUsusario;
		private System.Windows.Forms.TextBox txtContrasena;
		private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
		private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
		private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
		private System.Windows.Forms.PictureBox btnCerrar;
		private System.Windows.Forms.PictureBox btnMinimizar;
	}
}