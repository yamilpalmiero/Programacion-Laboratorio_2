using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejericicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_11";

            int valor = 0;
            int min = int.MaxValue;
            int max = int.MinValue;
            int acumulador = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese numero entero entre -100 y 100:");
                valor = int.Parse(Console.ReadLine());

                while (!Validacion.Validar(valor, -100, 100))
                {
                    Console.WriteLine("Error, el numero debe ser entre -100 y 100. Reingrese:");
                    valor = int.Parse(Console.ReadLine());
                }

                if (valor > max)
                {
                    max = valor;
                }
                if (valor < min)
                {
                    min = valor;
                }

                acumulador += valor;
            }

            Console.WriteLine("El minimo es {0}", min);
            Console.WriteLine("El maximo es {0}", max);
            Console.WriteLine("El promedio es {0}", acumulador / 10);

            Console.ReadKey();
        }
    }
}
