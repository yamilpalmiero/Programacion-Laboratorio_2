using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Billetes;

namespace Ejercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolar dolar = new Dolar(100);
            Euro euro = new Euro(92.5925926);
            Pesos peso = new Pesos(6600);
            Dolar total = dolar + euro + peso;
            Console.WriteLine(total.GetCantidad());


            if ((Pesos)new Dolar(100) == new Pesos(6600))
                Console.WriteLine("Explicito Pesos = OK");
            else
                Console.WriteLine("Explicito Pesos = NO");

            if (new Dolar(100) == (Dolar)new Pesos(6600))
                Console.WriteLine("Explicito Dolar = OK");
            else
                Console.WriteLine("Explicito Dolar = NO");

            if ((Euro)new Dolar(108) == new Euro(100))
                Console.WriteLine("Explicito Euro = OK");
            else
                Console.WriteLine("Explicito Euro = NO");


            Console.ReadKey();
        }
    }
}
