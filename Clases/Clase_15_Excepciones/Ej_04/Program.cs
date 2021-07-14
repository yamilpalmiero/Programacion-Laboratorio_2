using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lanzamiento de las excepciones: THROW

            Console.WriteLine("Estoy en el Main y llamo a la funcion 1.");

            try
            {
                Program.Funcion1();
            }
            catch (Exception e)
            {
                Console.WriteLine("Estoy en el Main y la excepcion fue: ");
                Console.WriteLine(e.Message);
                throw e;
            }

            Console.ReadKey();
        }

        private static void Funcion1()
        {
            Console.WriteLine("Estoy en la funcion 1 y llamo a la 2");
            try
            {
                Program.Funcion2();
            }
            catch (Exception e)
            {
                Console.WriteLine("Estoy en el CATCH de la funcion 1.\nLanzo la Excepcion hacia el Main");

                throw e;
            }
        }
        private static void Funcion2()
        {
            Console.WriteLine("Estoy en la funcion 2 y llamo a la 3");
            try
            {
                Program.Funcion3();
            }
            catch (Exception e)
            {
                Console.WriteLine("Estoy en el CATCH de la funcion 2.\nLanzo la Excepcion hacia la funcion 1");

                throw e;
            }
        }
        private static void Funcion3()
        {
            Console.WriteLine("Estoy en la funcion 3 y llamo a la 4");
            try
            {
                Program.Funcion4();
            }
            catch (Exception e)
            {
                Console.WriteLine("Estoy en el CATCH de la funcion 3.\nLanzo la Excepcion hacia la funcion 2");

                throw e;
            }
        }
        private static void Funcion4()
        {
            Console.WriteLine("Estoy en la funcion 4 y llamo a la 5");
            try
            {
                Program.Funcion5();
            }
            catch (Exception e)
            {
                Console.WriteLine("Estoy en el CATCH de la funcion 4.\nLanzo la Excepcion hacia la funcion 3");

                throw e;
            }
        }
        private static void Funcion5()
        {
            Console.WriteLine("Estoy en la funcion 5 y pido el numero...");
            Console.WriteLine("Si genero la Excepcion el CLR busca un catch en esta misma funcion y si no lo encuentra llama a la anterior y asi sucesivamente.");
            Console.WriteLine("Escriba un numero:");
            try
            {
                int numero = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Estoy en el CATCH de la funcion 5.\nLanzo la Excepcion hacia la funcion 4");

                throw e;
            }
            Console.WriteLine("Numero OK.");
            Console.WriteLine("Presione una tecla para salir...");
        }
    }
}
