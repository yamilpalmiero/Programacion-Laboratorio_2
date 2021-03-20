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
            
            for(int i=0; i < 5; i++)
            {
                Console.Write("i° numero:");
                numero = int.Parse(Console.Read());

            }
        }
    }
}
