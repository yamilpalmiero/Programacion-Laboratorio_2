using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Ingresar un numero positivo:");
            numero = int.Parse(Console.ReadLine());

            while (numero < 0)
            {
                Console.WriteLine("Error, reingrese:");
                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("El cuadrado es: {0} y el cubo es {1}", Math.Pow(numero, 2), Math.Pow(numero, 3));

            Console.ReadKey();
        }
    }
}
