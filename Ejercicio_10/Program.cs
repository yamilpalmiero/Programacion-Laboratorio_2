using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_10";

            int cantPisos, piso, espacios, asteriscos;

            Console.WriteLine("Cantidad de pisos de la piramide: ");
            cantPisos = Convert.ToInt32(Console.ReadLine());

            for (piso = 1; piso <= cantPisos; piso++)
            {
                for (espacios = 0; espacios < cantPisos - piso; espacios++)
                {
                    Console.Write(" ");
                }
                for (asteriscos = 0; asteriscos < (piso * 2) - 1; asteriscos++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
