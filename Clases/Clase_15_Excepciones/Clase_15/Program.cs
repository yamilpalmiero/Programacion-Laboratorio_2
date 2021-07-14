using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Escriba un numero: ");
                int num = int.Parse(Console.ReadLine());

                Console.WriteLine("Esto se ejecuta dentro del TRY si no hubo excepcion.");
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Esto se ejecuta luego del bloque T-C haya o no excepcion, siguiendo el flujo normal del programa.");
            Console.ReadKey();
        }
    }
}
