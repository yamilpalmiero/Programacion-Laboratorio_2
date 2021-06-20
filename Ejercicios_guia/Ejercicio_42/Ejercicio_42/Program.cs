using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MisExcepciones;
using Clases;

namespace Ejercicio_42
{
    class Program
    {
        static void Main(string[] args)
        {
            OtraClase otraClase;

            try
            {
                otraClase = new OtraClase();
                otraClase.MetodoDeInstancia();
            }
            catch (MiExcepcion e)
            {
                Console.WriteLine(e.Message);

                if (!(e.InnerException is null))
                {
                    Exception auxException = e.InnerException;

                    do
                    {
                        Console.WriteLine(auxException.Message);
                        auxException = auxException.InnerException;
                    } while (!(auxException is null));
                }
            }
            Console.ReadKey();
        }
    }
}
