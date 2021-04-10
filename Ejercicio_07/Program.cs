using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_07";

            int anio = pedirEnteroPositivo("Año de nacimiento: ", "Error, reingrese: ");
            int mes = pedirEnteroEnRango(1, 12, "Mes: ", "Error, debe ser del 1 al 12: ");
            int dia = pedirDia(mes);

            int cantDias = ((TimeSpan)(DateTime.Now - new DateTime(anio, mes, dia))).Days;

            if (cantDias > 0)
                Console.WriteLine("Pasaron {0} dias desde el nacimiento.", cantDias);
            else
                Console.WriteLine("Todavia no nacio.");

            Console.ReadKey(true);

            #region Metodos
            int pedirEnteroPositivo(string mensaje, string mensajeError)
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

            int pedirEnteroEnRango(int desde, int hasta, string mensaje, string mensajeError)
            {
                int numero;
                bool error;

                Console.WriteLine(mensaje);

                do
                {
                    if (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0 || numero < desde || numero > hasta)
                    {
                        Console.WriteLine(mensajeError);
                        error = true;
                    }
                    else
                        error = false;
                } while (error);

                return numero;
            }

            int pedirDia(int m)
            {
                int[] mesesDeTreinta = { 4, 6, 9, 11 };
                int diasEnElMes;

                if (mes == 2)
                    diasEnElMes = 28;
                else if (mesesDeTreinta.Contains(m))
                    diasEnElMes = 30;
                else
                    diasEnElMes = 31;

                return pedirEnteroEnRango(1, diasEnElMes, "Dia de nacimiento: ", "Error, reingrese: ");
            }
            #endregion

            Console.ReadKey();
        }
    }
}
