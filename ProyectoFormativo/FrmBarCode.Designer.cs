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
            this.btn_Imprimir = new System.Windows.Forms.Button();
            this.lblSerial = new System.Windows.Forms.Label();
            this.pbx_codigo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_codigo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.Location = new System.Drawing.Point(132, 193);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(75, 23);
            this.btn_Imprimir.TabIndex = 0;
            this.btn_Imprimir.Text = "Imprimir";
            this.btn_Imprimir.UseVisualStyleBackColor = true;
            this.btn_Imprimir.Click += new System.EventHandler(this.btn_Imprimir_Click);
            // 
            // lblSerial
            // 
            this.lblSerial.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerial.Location = new System.Drawing.Point(22, 130);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(290, 17);
            this.lblSerial.TabIndex = 2;
            this.lblSerial.Text = "label1";
            this.lblSerial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbx_codigo
            // 
            this.pbx_codigo.Location = new System.Drawing.Point(22, 31);
            this.pbx_codigo.Name = "pbx_codigo";
            this.pbx_codigo.Size = new System.Drawing.Size(290, 90);
            this.pbx_codigo.TabIndex = 1;
            this.pbx_codigo.TabStop = false;
            // 
            // FrmBarCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 228);
            this.Controls.Add(this.lblSerial);
            this.Controls.Add(this.pbx_codigo);
            this.Controls.Add(this.btn_Imprimir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBarCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBarCode";
            this.Load += new System.EventHandler(this.FrmBarCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_codigo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Imprimir;
        private System.Windows.Forms.PictureBox pbx_codigo;
        private System.Windows.Forms.Label lblSerial;
    }
}