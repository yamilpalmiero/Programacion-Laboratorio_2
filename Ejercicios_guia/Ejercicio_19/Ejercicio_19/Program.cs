using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador a = new Sumador(1);
            a.Sumar(2, 3);
            a.Sumar("Hola", "Mundo");

            Sumador b = new Sumador();
            b.Sumar(4, 5);
            b.Sumar("a", "b");

            int c = (int)a;

            bool d = a | b;
            b.Sumar(2, 3);
            bool e = a | b;
            long f = a + b;
            long g = f;

            Console.ReadKey(true);
        }
    }
}
