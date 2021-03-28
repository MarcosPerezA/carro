using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_7_poo_inicio.clases
{
    class ClsAutomovil
    {

        public string marca { get; }//quitamos el st para que no se pueda cambiar la marca
        public string apagar { get; }
        public int vel_max { get; } //si pongo private en vez de public no lo puede acceder el usuario
        private int velocidadActual { get; set; } //si pongo private no lo puede acceder el usuario
        public string color { get; set; }
        private bool encendido = false;
        private bool radio = true;
        private bool elegir=true;
        private int vel_min = 0;
          
        public string Acelerar()
        {
            if (velocidadActual < vel_max)
            {
                velocidadActual = velocidadActual + 10;
                return $"vas a {velocidadActual} km por hora";
            }
            else
            {
                return " has llegado a la velocidad maxima ";
            }
        }
        public bool EstaEncendido()
        {
            return encendido;
        }
        public bool radioencendida()
        {
            return radio;
        }
        public bool elige()
        {
            return elegir;
        }
        public ClsAutomovil(string marcaCarro, int velocidadMx)//creando clase constructor para agregar valores al carro que el usuario no pueda modificar porque esta en pivate
        {
            this.marca = marcaCarro;
            this.vel_max = velocidadMx;
        }

        public ClsAutomovil()
        {
        }

        public string EncenderMotor()
        {
            if (encendido)
            {
                return "el carro ya esta encendido ";
            }
            else
            {
               encendido = true;
                velocidadActual = 0;
                return "Listo!! carro encendido";
            }
            
        }
        public string Frenar()
        {
            
            if (velocidadActual>vel_min)
            {
                velocidadActual = velocidadActual - 10;
                return $"vas a {velocidadActual} km por hora";
            } else
            {
                return " Tienes que acelerar de nuevo ";
            }

          
            
        }

        
        public string ApagarMotor()
        {

            if (velocidadActual > 0)
            {
                return "NO APAGUE EL CARRO MIENTRAS ESTA EN MOVIMIENTO PUEDE CAUSAR UN ACCIDENTE";
            }
            else
            {
                return "ha apagado el carro";
            }
           
        }
    }
}
