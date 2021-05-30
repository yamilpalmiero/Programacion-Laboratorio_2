using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_03
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Escriba un numero:");
                int numero1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Escriba el segundo numero:");
                int numero2 = int.Parse(Console.ReadLine());

                int resultado = numero1 / numero2;

                Console.WriteLine($"El resultado es {resultado}");
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)//CATCH generico siempre se agrega al final
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
