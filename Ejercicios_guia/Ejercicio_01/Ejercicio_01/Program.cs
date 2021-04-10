using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int min = int.MaxValue;
            int max = int.MinValue;
            int acumulador = 0;

            Console.WriteLine("Ingrese cinco numeros:");
            
            for(int i=1; i <= 5; i++)
            {
                Console.Write("{0}° numero:",i);
                numero = int.Parse(Console.ReadLine());

                if (numero < min)
                {
                    min = numero;
                }
                if (numero > max)
                {
                    max = numero;
                }

                acumulador += numero;
            }

            Console.WriteLine("El maximo es: {0}", max);
            Console.WriteLine("El minimo es: {0}", min);
            Console.WriteLine("El promedio es: {0}", acumulador/5);

            Console.ReadKey();
        }
    }
}
