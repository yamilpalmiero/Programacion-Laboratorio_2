using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Factura, Recibo> c = new Contabilidad<Factura, Recibo>();

            c += new Recibo(2);
            c += new Factura(3);
            c += new Recibo();

            Console.ReadKey();
        }
    }
}
