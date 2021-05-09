using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Abstraccion
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto(5, Velocidades.Alta, 4);
            Caballo caballo = new Caballo(1, Velocidades.Baja, "Pony", Colores.Pinto);
            Cohete cohete = new Cohete(3, Velocidades.Hiper, "Apolo", 8);

            auto.Avanzar();
            auto.Frenar();
            Console.WriteLine();

            caballo.Avanzar();
            caballo.Frenar();
            Console.WriteLine();

            cohete.Avanzar();
            cohete.Frenar();

            Console.ReadKey(true);
        }
    }
}
