using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_06";

            int anioInicio, anioFin;

            Console.WriteLine("Ingrese anio de inicio:");
            anioInicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese anio de finalizacion:");
            anioFin = int.Parse(Console.ReadLine());

            for(int i=anioInicio; i<=anioFin; i++)
            {
                if (i % 4 == 0 && i < 100)
                {
                    Console.WriteLine("{0} es bisiesto.", i);
                }
                if(i % 4 == 0 && i >= 100)
                {
                    if(i % 100 == 0 && !(i % 400 == 0))
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("{0} es bisiesto.", i);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
