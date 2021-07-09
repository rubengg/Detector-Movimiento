using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using WebCam_Capture;

namespace Scan0_C_
{
    class Webcam
    {
        private PictureBox picture;
        private WebCamCapture objWebcam;
        private SubstraccionVideo objSubstraccion;
        private Bitmap imagenAnterior;
        private Graphics gr;

        private int Sensebility;
        private int moves = 0;
        private bool notify = false;
        private String port;
        private String phone;

        public int resolucionImagen { get; set; }
        public int tiempoCaptura_Milisegundos{get;set;}

        public void setSensibility(int sens) {
            this.Sensebility = sens;
        }

        public int getSensibility()
        {
            return this.Sensebility;
        }

        public void notifyOn() { notify = true;  }
        public void notifyOff() { notify = false; }

        public bool getNotify() {
            return notify;
        }

        public void setPort(String port) { this.port = port; }
        public void setPhone(String phone) { this.phone = phone; }

        public Webcam(PictureBox picture, int tiempoCaptura_Milisegundos=30, int resolucionImagen=300)
        {
            //Inicializamos propiedades
            this.tiempoCaptura_Milisegundos = tiempoCaptura_Milisegundos;
            this.resolucionImagen = resolucionImagen;
            this.picture = picture;
            this.imagenAnterior = new Bitmap(picture.Image);

            //Inicializamos objetos
            objWebcam = new WebCamCapture();
            objSubstraccion = new SubstraccionVideo();
            gr = picture.CreateGraphics();
            this.objWebcam.TimeToCapture_milliseconds = this.tiempoCaptura_Milisegundos;
        }

        public void stop()
        {
            objWebcam.Stop();
        }
        public void configuracion()
        {
            objWebcam.Config();
        }
        public void configuracion2()
        {
            objWebcam.Config2();
        }
        public void inicializarWebCam_DetectarMovimiento()
        {
            //Iniciamos cam y gestionamos evento
            objWebcam.Start(0);
            objWebcam.ImageCaptured += webcam_CapturarMovimiento;
        }

        private void webcam_CapturarMovimiento(Object source, WebcamEventArgs e)
        {

            //Calculamos la diferencia de imágenes
            picture.Image = objSubstraccion.substraer(new Bitmap(e.WebCamImage, this.resolucionImagen, this.resolucionImagen),
                new Bitmap(this.imagenAnterior, this.resolucionImagen, this.resolucionImagen));
            //Almacenamos la imagen actual como imagen anterior
            this.imagenAnterior = new Bitmap(e.WebCamImage);

            if (SubstraccionVideo.minimoX != 1000 && SubstraccionVideo.minimoY != 1000 )
            {
                //this.dibujarRecuadro();
                moves++;
                if (moves > Sensebility )
                {
                    if (notify)
                     SMS(port, phone, "Se ha detectado movimiento " + DateTime.Now.ToString("F"));

                    this.dibujarRecuadro();
                    moves = 0;
                }
            }
            //Enviar notificacion
            //SMS();
        }

        private void SMS(String port, String phone, String msj)
        {
            GSM sm = new GSM( port );
            sm.Opens();
            sm.sendSms(phone, msj);
            sm.Closes();
        }

        private void dibujarRecuadro()
        {
            Pen lapiz = new Pen(Color.Red);
            Font fuente = new Font("Arial", 8);
            Brush brocha = Brushes.Red;
            string texto;

            picture.Refresh();

            //Calculamos coeficientes de reducción ancho/alto y calculamos el centro de la imagen
            float coefX = ((float)picture.Width) / resolucionImagen;
            float coefY = ((float)picture.Height) / resolucionImagen;
            PointF centro=new PointF(((coefX*SubstraccionVideo.totalPixX)/SubstraccionVideo.totalPixeles),
                ((coefY*SubstraccionVideo.totalPixY)/SubstraccionVideo.totalPixeles));

            //Delimitamos área de movimiento
            gr.DrawRectangle(lapiz, coefX * SubstraccionVideo.minimoX, coefY * SubstraccionVideo.minimoY, coefX * (SubstraccionVideo.maximoX - SubstraccionVideo.minimoX),
               coefY * (SubstraccionVideo.maximoY - SubstraccionVideo.minimoY));

            //Dibujamos cruz en el centro
            gr.DrawLine(lapiz, new PointF(centro.X - 4, centro.Y), new PointF(centro.X + 4, centro.Y));
            gr.DrawLine(lapiz, new PointF(centro.X, centro.Y - 4), new PointF(centro.X, centro.Y + 4));

            //Escribimos texto con coordenadas
            //if (SubstraccionVideo.minimoX != 1000 && SubstraccionVideo.minimoY != 1000)
            //{
                //SMS();
                texto = Convert.ToString(SubstraccionVideo.minimoX) + "," + Convert.ToString(SubstraccionVideo.minimoY);
                gr.DrawString(texto, fuente, brocha, new PointF((coefX * SubstraccionVideo.minimoX) - 15, (coefY * SubstraccionVideo.minimoY) - 15));

                texto = Convert.ToString(SubstraccionVideo.minimoX) + "," + Convert.ToString(SubstraccionVideo.maximoY);
                gr.DrawString(texto, fuente, brocha, new PointF((coefX * SubstraccionVideo.minimoX) - 15, (coefY * SubstraccionVideo.maximoY)));

                texto = Convert.ToString(SubstraccionVideo.maximoX) + "," + Convert.ToString(SubstraccionVideo.minimoY);
                gr.DrawString(texto, fuente, brocha, new PointF((coefX * SubstraccionVideo.maximoX) - 15, (coefY * SubstraccionVideo.minimoY) - 15));

                texto = Convert.ToString(SubstraccionVideo.maximoX) + "," + Convert.ToString(SubstraccionVideo.maximoY);
                gr.DrawString(texto, fuente, brocha, new PointF((coefX * SubstraccionVideo.maximoX) - 15, (coefY * SubstraccionVideo.maximoY)));
            //}
            
        }
    }
}
