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

            int desde = pedirPositivo("Ingrese el anio de inicio: ", "Error, reingrese.");
            int hasta = pedirPositivo("Hasta el año: ", "Error, reingrese.");

            Console.WriteLine("\nAños bisiestos: ");
            for (int i = desde; i <= hasta; i++)
            {
                if ((i % 4 == 0) && (i % 100 != 0 || i % 400 == 0))
                {
                    Console.WriteLine(i);
                }
            }

            #region Metodos
            int pedirPositivo(string mensaje, string mensajeError)
            {
                int numero;
                bool error;

                Console.WriteLine(mensaje);

                do
                {
                    if (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
                    {
                        Console.WriteLine(mensajeError);
                        error = true;
                    }
                    else
                        error = false;

                } while (error);

                return numero;
            }
            #endregion
            Console.ReadKey();
        }
    }
}
