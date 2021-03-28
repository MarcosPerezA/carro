using clase_7_poo_inicio.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace clase_7_poo_inicio
{
    public partial class Form1 : Form
    {
        ClsAutomovil carrito; //lo pongo aqui para que me permita usarlo en todas las clases
        private string ruta="";
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            //crear el carro
           carrito = new ClsAutomovil("Meches",150);
            carrito.color = "Negro";
            MessageBox.Show("tu carro color negro ha sido creado ");
            
        
            //string respuesta = carrito.EncenderMotor();
            //labeldatos.Text = "encendido";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (carrito.EstaEncendido())
            {
                labelVelocidad.Text = carrito.Acelerar();
            }
            else
            {
                MessageBox.Show($"lo lamento el carro{carrito.marca} esta apagado");
            }
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "C:/Users/W10/Downloads/aceleracion.wav";
            player.Play();

        }

        private void encender_Click(object sender, EventArgs e)//clase de encender
        {
            

            string respuesta = carrito.EncenderMotor();
            labeldatos.Text = respuesta;
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "C:/Users/W10/Downloads/encendido.wav";
            player.Play();

        }

        private void frenar_Click(object sender, EventArgs e)
        {
            
            if (carrito.EstaEncendido())
            {
                labelVelocidad.Text = carrito.Frenar();
            }else
            {
                
            }
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "C:/Users/W10/Downloads/freno.wav";
            player.Play();
        }

        private void labelVelocidad_Click(object sender, EventArgs e)
        {

        }

        private void apagar_Click(object sender, EventArgs e)
        {
            string apagar = carrito.ApagarMotor();
            apago.Text = carrito.ApagarMotor();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void ccarro_Click(object sender, EventArgs e)
        {

        }

        private void radio_Click(object sender, EventArgs e)
        {
            if (carrito.EstaEncendido())
            {
                MessageBox.Show("Listo, radio encendida");
            }
            else
            {
                   
            }
        }

        private void apradio_Click(object sender, EventArgs e)
        {
           
                axWindowsMediaPlayer1.Ctlcontrols.stop();
               
            
            
        }

        private void playlist_Click(object sender, EventArgs e)
        {
            if(carrito.EstaEncendido())
            {
                
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        ruta = openFileDialog1.FileName;
                        lblru.Text = ruta;
                    }
                
                else
                {
                    
                }
               
            }
        }
        private void rep_Click(object sender, EventArgs e)
        {
            if (carrito.elige())
            {
                axWindowsMediaPlayer1.URL = ruta;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else
            {

            }
        }

        private void pau_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }
    }
}
