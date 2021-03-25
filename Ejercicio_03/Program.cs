using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Ingrese un numero:");
            numero = int.Parse(Console.ReadLine());

            for(int i=1; i<=numero; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("{0}", i);
                }
            }

            Console.ReadKey();
        }
    }
}
