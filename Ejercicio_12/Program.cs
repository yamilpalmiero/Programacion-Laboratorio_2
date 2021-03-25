using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            char c, seguir;
            int numero, sumador = 0;

            do
            {
                Console.WriteLine("Ingrese numero: ");
                numero = int.Parse(Console.ReadLine());
                sumador += numero;
                Console.WriteLine("Continuar? S/N: ");
                c = char.Parse(Console.ReadLine());

                if (ValidarRespuesta.ValidarS_N(c))//Si la respuesta no es S o N devuelve false y no entra el if
                {
                    seguir = c;
                }

            } while (c != 'N');

            Console.WriteLine("La suma total es: {0}", sumador);
            Console.ReadKey();
        }
    }
}
