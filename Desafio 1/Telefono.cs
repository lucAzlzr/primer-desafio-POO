using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    internal class Telefono
    {
        //Agregar Constructor que reciba Modelo y Marca.
        public Telefono(string modelo, string marca) 
        { 
            this.modelo = modelo;
            this.marca = marca;
        }

        //atributos
        private string modelo;
        private string marca;
        private string numeroTelefonico;
        private int codigoOperador;

        //propiedades
        public string Modelo
        {  
            get { return modelo; } 
        }
        public string Marca
        {
            get { return marca; }
        }
        public string NumeroTelefonico
        {
            get { return numeroTelefonico; }
            set { numeroTelefonico = value;}
        }
        public int CodigoOperador
        {
            get { return codigoOperador; }
            set
            {
                if (value > 0 && value <= 3)
                    codigoOperador = value;
                else
                    codigoOperador = 0;
            }
        }

        //Método llamar
        public string llamar()
        {
            return "Realizando llamada...";
        }
        public string llamar(string contacto)
        {
            return "Llamando a " + contacto;
        }
    
   
    }   

}
