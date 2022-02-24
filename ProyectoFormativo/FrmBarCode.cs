using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarcodeLib;
// .net espacios de nombres obligatorios
using System.Drawing.Printing;

namespace ProyectoFormativo
{

    public partial class FrmBarCode : Form
    {
        string data = "";
        string nomPropietario = "";
        Image barcodeImage;
        //private Font fuente = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Pixel);

        public FrmBarCode()
        {
            InitializeComponent();
        }

        private void FrmBarCode_Load(object sender, EventArgs e)
        {
            // Crea una instancia de la API
            Barcode barcodeAPI = new Barcode();

            // Definir la configuración básica de la imagen.
            int imageWidth = 290;
            int imageHeight = 90;
            Color foreColor = Color.Black;
            Color backColor = Color.Transparent;
            data = FrmControlAdmin.serialBien;
            nomPropietario = FrmControlAdmin.NomProietario;

            // Para mostrar la cadena alfanumerica del codigo
            //barcodeAPI.IncludeLabel = true;
            // Genera el código de barras con tu configuración (fonto transparente)
            Image barcodeImage1 = barcodeAPI.Encode(TYPE.CODE128, data, foreColor, backColor, imageWidth, imageHeight);
            // Genera imagen para imprimir (fondo blanco para no perder calidad en la impresion)
            barcodeImage = barcodeAPI.Encode(TYPE.CODE128, data, foreColor, Color.White, imageWidth, imageHeight);

            // Almacena la imagen en alguna ruta con el formato deseado
            //barcodeImage.Save(@"C:\Users\David\Desktop\code-" + data + ".png", ImageFormat.Png);
            pbx_codigo.Image = barcodeImage1;

            lblSerial.Visible = true;
            lblSerial.Text = "S/N: " + data;
            lbl_NomPropietario.Text = "Generado a nombre de " + nomPropietario;
        }

        //A continuacion se agregara el siguiente método
        public void Imprimir_Solicitud()
        {

            //Este método contiene dos componentes muy importantes los cuales son:

            //PrintDocument y printDialog estos métodos definen las propiedades de impresión

            //como son: numero de copias, numero de paginas y seleccionar tipo de impresora
            PrintDocument datos = new PrintDocument();
            datos.PrintPage += new PrintPageEventHandler(Datos_Codigo);
            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.Document = datos;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                datos.Print();
            }
        }

        //En esta función se define los datos a imprimir en este caso

        //los datos de nuestros clientes y la posición de los mismos en el documento
        private void Datos_Codigo(object obj, PrintPageEventArgs ev)
        {
            //float pos_x = 115;
            //float pos_y = 135;

            // Para centrar el texto al area de la imagen
            Graphics graphics = ev.Graphics;

            Font font10 = new Font("Courier New", 10);

            float leading = 110;
            float lineheight10 = font10.GetHeight() + leading;

            float startX = 0;
            float startY = leading;
            float Offset = 0;

            StringFormat formatLeft = new StringFormat(StringFormatFlags.NoClip);
            StringFormat formatCenter = new StringFormat(formatLeft);
            StringFormat formatRight = new StringFormat(formatLeft);

            formatCenter.Alignment = StringAlignment.Center;
            formatRight.Alignment = StringAlignment.Far;
            formatLeft.Alignment = StringAlignment.Near;

            SizeF layoutSize = new SizeF(310 - Offset * 2, lineheight10);
            RectangleF layout = new RectangleF(new PointF(startX, startY + Offset), layoutSize);

            //Offset = Offset + lineheight10;

            //Lo que vamos a imprimir
            //texto
            //ev.Graphics.DrawString(label1.Text, fuente, Brushes.Black, pos_x, pos_y, new StringFormat());
            ev.Graphics.DrawString(lblSerial.Text, font10, Brushes.Black, layout, formatCenter);
            //imagen
            ev.Graphics.DrawImageUnscaled(barcodeImage, 10, 10);
        }
        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            Imprimir_Solicitud();
        }


    }
}
