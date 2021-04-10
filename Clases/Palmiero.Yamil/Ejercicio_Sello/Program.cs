using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Sello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_Sello";

            string cadena; //Para guardar lo que devuelve Imprimir

            Sello.mensaje = "Primer mensaje";
            cadena = Sello.Imprimir(); //Porque Imprimir devuelve una cadena
            Console.WriteLine("El mensaje es: {0}", cadena); //IMPRIMO PRIMER MENSAJE NORMAL

            Sello.Borrar();
            cadena = Sello.Imprimir();
            Console.WriteLine("El mensaje es: {0}", cadena); //BORRO PRIMER MENSAJE E IMPRIMO VACIO

            Sello.mensaje = "Segundo mensaje";
            Sello.color = ConsoleColor.Yellow;
            Sello.ImprimirColor(); //IMPRIMO SEGUNDO MENSAJE EN COLOR
            cadena = Sello.Imprimir();
            Console.WriteLine("El mensaje es: {0}", cadena); //IMPRIMO SEGUNDO MENSAJE EN GRIS (DEFAULT)

            Console.ReadKey(true);
        }
    }
}
