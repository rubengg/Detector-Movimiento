using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scan0_C_;

namespace Scan0_C_
{
    
   

    public partial class Form1 : Form
    {
        private Webcam objWebcam;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            iniciarCam();
            numericUpDown1.Value = 20;
            comboBox2.SelectedIndex = 2;
        }

        public void iniciarCam()
        {
            objWebcam = new Webcam(PictureBox1);
            objWebcam.inicializarWebCam_DetectarMovimiento();
            checkBox1.Checked = true; //Imagen original

        }
        public void reinciarCam()
        {
            objWebcam.stop();
            objWebcam = new Webcam(PictureBox1,Convert.ToInt16(numericUpDown1.Value),Convert.ToInt16(comboBox2.SelectedItem));
            objWebcam.inicializarWebCam_DetectarMovimiento();

        }


        private void Button1_Click(object sender, EventArgs e)
        {
            iniciarCam();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            objWebcam.stop();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            objWebcam.configuracion();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            objWebcam.configuracion2();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            objWebcam.resolucionImagen = Convert.ToInt16(comboBox2.SelectedItem);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            reinciarCam();

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            SubstraccionVideo.umbralRojo = Convert.ToByte(hScrollBarRojo.Value);
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            SubstraccionVideo.umbralVerde = Convert.ToByte(hScrollBarVerde.Value);
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            SubstraccionVideo.umbralAzul = Convert.ToByte(hScrollBarAzul.Value);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                SubstraccionVideo.imagenBN = false;
            }
            else
            {
                SubstraccionVideo.imagenBN = true;
            }
        }

        private void trackBarSensibility_Scroll(object sender, EventArgs e)
        {
            objWebcam.setSensibility( trackBarSensibility.Value );
            labelPorcent.Text = "% " + objWebcam.getSensibility()*10;
        }

        private void checkBoxNotification_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNotification.Checked) { checkBoxNotification.Text = "Desactivar notificacion por SMS"; groupBoxNotification.Visible = true; }
            else { objWebcam.notifyOff(); checkBoxNotification.Text = "Activar notificacion por SMS"; groupBoxNotification.Visible = false; }
        }

        private void buttonAplicar_Click(object sender, EventArgs e)
        {
            objWebcam.setPort( textBoxPort.Text );
            objWebcam.setPhone( textBoxPhone.Text );
            objWebcam.notifyOn();
            MessageBox.Show("Notificacion por SMS Activada");
        }   

    }
}
