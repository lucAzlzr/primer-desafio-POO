using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono t1 = new Telefono("Pocket", "Samsung");
            Empresa e1 = new Empresa("Telecentro");
            Console.WriteLine("Ingrese número telefónico: ");
            t1.NumeroTelefonico = Console.ReadLine();
            Console.WriteLine("Ingrese código de operador: ");
            t1.CodigoOperador = int.Parse(Console.ReadLine());

            Console.WriteLine("El celular ingresado es un " + t1.Marca + t1.Modelo + " Y su número es: " + t1.NumeroTelefonico + " Con código de operador : " + t1.CodigoOperador);
            Console.WriteLine(t1.llamar("Telecentro"));
            Console.WriteLine("Llamada entrante de cliente, ¿desea atender?, pulse 1 para atender y 0 para rechazar");
            e1.Atender = int.Parse(Console.ReadLine());

            if (e1.Atender != 0) 
                Console.WriteLine(e1.saludar());

            
            Console.ReadKey();
        }
    }
}
