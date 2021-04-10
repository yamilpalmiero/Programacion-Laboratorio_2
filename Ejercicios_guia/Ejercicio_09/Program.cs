using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_09";

            int cantPisos, piso, asteriscos;

            Console.WriteLine("Cantidad de pisos de la piramide: ");
            cantPisos = Convert.ToInt32(Console.ReadLine());

            for (piso = 1; piso <= cantPisos; piso++)//Este for controla la cantidad de pisos que tiene la piramide (ingresado por usuario)
            {
                for (asteriscos = 0; asteriscos < (piso * 2) - 1; asteriscos++)//Este controla la cantidad de * que se imprimen por piso
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
