namespace ProyectoFormativo
{
    partial class FrmBarCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBarCode));
            this.lblSerial = new System.Windows.Forms.Label();
            this.pbx_codigo = new System.Windows.Forms.PictureBox();
            this.btn_Imprimir = new System.Windows.Forms.Button();
            this.lbl_NomPropietario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_codigo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSerial
            // 
            this.lblSerial.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerial.Location = new System.Drawing.Point(22, 135);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(290, 17);
            this.lblSerial.TabIndex = 2;
            this.lblSerial.Text = "label1";
            this.lblSerial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbx_codigo
            // 
            this.pbx_codigo.Location = new System.Drawing.Point(22, 41);
            this.pbx_codigo.Name = "pbx_codigo";
            this.pbx_codigo.Size = new System.Drawing.Size(290, 90);
            this.pbx_codigo.TabIndex = 1;
            this.pbx_codigo.TabStop = false;
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.Image = global::ProyectoFormativo.Properties.Resources.print;
            this.btn_Imprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Imprimir.Location = new System.Drawing.Point(134, 162);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Padding = new System.Windows.Forms.Padding(0, 4, 0, 3);
            this.btn_Imprimir.Size = new System.Drawing.Size(63, 55);
            this.btn_Imprimir.TabIndex = 0;
            this.btn_Imprimir.Text = "Imprimir";
            this.btn_Imprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Imprimir.UseVisualStyleBackColor = true;
            this.btn_Imprimir.Click += new System.EventHandler(this.btn_Imprimir_Click);
            // 
            // lbl_NomPropietario
            // 
            this.lbl_NomPropietario.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomPropietario.Location = new System.Drawing.Point(22, 15);
            this.lbl_NomPropietario.Name = "lbl_NomPropietario";
            this.lbl_NomPropietario.Size = new System.Drawing.Size(290, 17);
            this.lbl_NomPropietario.TabIndex = 3;
            this.lbl_NomPropietario.Text = "label1";
            this.lbl_NomPropietario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmBarCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 228);
            this.Controls.Add(this.lbl_NomPropietario);
            this.Controls.Add(this.lblSerial);
            this.Controls.Add(this.pbx_codigo);
            this.Controls.Add(this.btn_Imprimir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBarCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Codigo de Barras";
            this.Load += new System.EventHandler(this.FrmBarCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_codigo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Imprimir;
        private System.Windows.Forms.PictureBox pbx_codigo;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.Label lbl_NomPropietario;
    }
}