using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creacion de nuestras propias Excepciones y lanzamiento con throw

            try
            {
                try
                {
                    Console.WriteLine("1- Excepcion propia.");
                    Console.WriteLine("2- Excepcion propia, desde un catch.");
                    Console.WriteLine("3- Excepcion propia, manteniendo la excepcion original.");
                    Console.WriteLine("4- Excepcion propia, desde una funcion manteniendo la excepcion original");
                    Console.WriteLine();

                    int opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            throw new MiExcepcion("Lanzo una excepcion propia!!");
                            break;
                        case 2:
                            Console.WriteLine("Ingrese un numero:");
                            int numero1 = int.Parse(Console.ReadLine());
                            break;
                        case 3:
                            Console.WriteLine("Ingrese un numero distinto de cero:");
                            int numero2 = int.Parse(Console.ReadLine());
                            Console.WriteLine(1 / numero2);
                            break;
                        case 4:
                            Program.Funcion();
                            break;
                    }
                }
                catch (MiExcepcion ex)
                {
                    Console.Write(ex.ToString());
                    Console.ReadKey();
                }
                catch (FormatException e)
                {
                    throw new MiExcepcion("Cuidado! Solo se permite el ingreso de numeros enteros.");
                }
                catch (DivideByZeroException e)
                {
                    throw new MiExcepcion("Cuidado! No se puede dividir por cero.");
                }
            }
            catch (Exception e)//La excepcion general esta en el Main
            {
                Console.WriteLine(e.ToString());

                if (e.InnerException != null)
                {
                    Console.WriteLine($"Excepcion Original : {e.InnerException.Message}");
                }

                Console.ReadKey();
            }
        }

        //FUNCION
        private static void Funcion()
        {
            try
            {
                object o = null;
                o.ToString();
            }
            catch (Exception e)
            {
                throw new MiExcepcion("Dentro de la funcion...", e, "Program.Funcion");
            }
        }
    }
}
