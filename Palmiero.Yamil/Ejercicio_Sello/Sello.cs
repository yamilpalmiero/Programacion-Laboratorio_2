using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Sello
{
    class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        public static string Imprimir()
        {
            return Sello.mensaje;
        }

        public static void Borrar()
        {
            Sello.mensaje = "";
        }

        public static void ImprimirColor()
        {
            string cad;

            cad = Sello.Imprimir();
            Console.ForegroundColor = Sello.color;
            Console.WriteLine("El mensaje es: {0}", Sello.mensaje);
            Sello.color = ConsoleColor.Gray;
            Console.ForegroundColor = Sello.color;
        }
    }
}
