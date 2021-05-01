using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado = 0;
            string[] nombres = new string[5];

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Title = "Mi Proyecto";

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write("{0} nombre: ", i + 1);
                nombres[i] = Console.ReadLine();
            }

            foreach (string auxNombre in nombres)
            {
                Console.WriteLine(auxNombre);
            }


            DateTime dt = DateTime.Now;

            resultado = suma(DateTime.Now.Minute, DateTime.Now.Second);

            Console.WriteLine("La suma de {0} minutos con {1} segundos es: {2}", dt.Minute, dt.Second, resultado);

            Console.ReadKey(true);

        }

        static int suma(int numero1, int numero2)
        {
            if (numero1 > 25 || numero2 > 25)
            {
                return numero1 + numero2;
            }
            else
            {
                return 0;
            }
        }
    }
}
