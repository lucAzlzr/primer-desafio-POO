using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    internal class Empresa
    {
        public Empresa(string nombre)
        {
            this.nombre = nombre;
        }

        private int atender;
        private string nombre;

        public int Atender
        {
            get { return atender; }
            set { atender = value; }
        }
        public string Nombre
        {
            get { return Nombre; }
        }
        
        public string saludar()
        {
            return "Hola buenas tardes, se comunica con el servicio técnico de " + nombre;
        }
    }
}
