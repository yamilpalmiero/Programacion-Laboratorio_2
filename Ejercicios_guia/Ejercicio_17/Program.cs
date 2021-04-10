using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_17";

            Boligrafo azul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo rojo = new Boligrafo(50, ConsoleColor.Red);
            string dibujo;

            rojo.Pintar(49, out dibujo);
            rojo.Pintar(10, out dibujo);

            Console.ForegroundColor = rojo.GetColor();
            Console.WriteLine(dibujo);

            rojo.Recargar();
            rojo.Pintar(10, out dibujo);

            Console.WriteLine(dibujo);

            Console.ReadKey();
        }
    }
}
