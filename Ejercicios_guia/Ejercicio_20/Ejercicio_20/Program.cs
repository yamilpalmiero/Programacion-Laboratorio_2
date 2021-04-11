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
            Euro euro = new Euro(100);
            Pesos peso = new Pesos(660);
            Dolar total = dolar + euro + peso;
            Console.WriteLine(total.cantidad);

            if (total.GetCantidad() > 99 && total.GetCantidad() < 101)
            {
                Console.WriteLine(total.GetCantidad());
                Console.WriteLine("OK");
            }
            else
                Console.WriteLine("NO");

            if ((Pesos)new Dolar(100) == new Pesos(660))
                Console.WriteLine("OK");
            else
                Console.WriteLine("NO");

            Console.ReadKey();
        }
    }
}
