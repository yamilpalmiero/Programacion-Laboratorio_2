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
            Console.Title = "Ejercicio_12";

            char seguir;
            int numero, sumador = 0;

            do
            {
                numero = pedirEnteroPositivo("\nIngrese numero:", "Error, reingrese:");
                sumador += numero;
                seguir = pedirChar("Seguir? S/N: ");

            } while (ValidarRespuesta.ValidarS_N(seguir));//Si ponen 's' o 'S' devuelve true y sigue pidiendo numeros

            Console.WriteLine("\nLa suma total es: {0}", sumador);

            Console.ReadKey();

            #region Metodos
            // PEDIR STRING
            char pedirChar(String mensaje)
            {
                Console.WriteLine(mensaje);
                return Console.ReadKey().KeyChar;
            }
            // PEDIR INT
            int pedirEnteroPositivo(String mensaje, String mensajeError)
            {
                int num;
                Console.WriteLine(mensaje);
                while (true)
                {
                    if (!int.TryParse(Console.ReadLine(), out num) || num <= 0)
                    {
                        Console.WriteLine(mensajeError);
                    }
                    else
                        return num;
                }
            }
            #endregion
        }
    }
}
