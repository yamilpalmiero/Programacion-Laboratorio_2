using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estoy en el Main y llamo a la Funcion 1");

            try
            {
                Program.Funcion1();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Message);
                Console.WriteLine("Presione una tecla para salir...");
                Console.ReadKey();
            }
        }
        private static void Funcion1()
        {
            Console.WriteLine("Estoy en la funcion 1 y llamo a la 2");
            Program.Funcion2();
        }
        private static void Funcion2()
        {
            Console.WriteLine("Estoy en la funcion 2 y llamo a la 3");
            Program.Funcion3();
        }
        private static void Funcion3()
        {
            Console.WriteLine("Estoy en la funcion 3 y llamo a la 4");
            Program.Funcion4();
        }
        private static void Funcion4()
        {
            Console.WriteLine("Estoy en la funcion 4 y llamo a la 5");
            Program.Funcion5();
        }
        private static void Funcion5()
        {
            Console.WriteLine("Estoy en la funcion 5 y pido el numero...");
            Console.WriteLine("Si genero la Excepcion el CLR busca un catch en esta misma funcion y si no lo encuentra llama a la anterior y asi sucesivamente.");
            Console.WriteLine("Escriba un numero:");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero OK.");
            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
