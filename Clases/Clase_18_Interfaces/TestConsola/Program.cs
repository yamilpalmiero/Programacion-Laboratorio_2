using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace TestConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            MiClase obj = new MiClase("Valor string");

            obj.PropiedadE = 98;
            Console.WriteLine(obj.PropiedadL);
            Console.WriteLine(obj.PropiedadLE);

            Console.ReadKey();
        }
    }
}
