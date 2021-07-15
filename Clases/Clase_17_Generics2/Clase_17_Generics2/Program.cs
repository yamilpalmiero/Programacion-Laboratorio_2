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
            Futbol futbol = new Futbol();
            Equipo<Futbol> equipoA = new Equipo<Futbol>(futbol);

            Basquet basquet = new Basquet();
            Equipo<Basquet> equipoB = new Equipo<Basquet>(basquet);

            Deporte.Metodo<Futbol, Basquet>(futbol, basquet);
        }
    }
}
