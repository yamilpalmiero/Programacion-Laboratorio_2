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
            //SE CREAN TORNEOS
            Torneo<EquipoFutbol> tFutbol = new Torneo<EquipoFutbol>("Superliga");
            Torneo<EquipoBasquet> tBasquet = new Torneo<EquipoBasquet>("NBA");

            //SE CREAN EQUIPOS
            EquipoFutbol boca = new EquipoFutbol("Boca", new DateTime(1900, 1, 1));
            EquipoFutbol banfield = new EquipoFutbol("Banfield", new DateTime(1900, 7, 6));

            EquipoFutbol atlas = new EquipoFutbol("Atlas", new DateTime(1904, 2, 1));
            EquipoBasquet clippers = new EquipoBasquet("Clippers", new DateTime(1910, 1, 1));
            EquipoBasquet spurs = new EquipoBasquet("Spurs", new DateTime(1900, 8, 1));
            EquipoBasquet lakers = new EquipoBasquet("Lakers", new DateTime(1900, 9, 1));
            EquipoBasquet lakers2 = new EquipoBasquet("Lakers", new DateTime(1900, 9, 1));

            //SE METEN LOS EQUIPOS
            tFutbol += boca;
            tFutbol += banfield;
            tFutbol += atlas;
            tFutbol += boca;
            Console.WriteLine(tFutbol.Mostrar());

            tBasquet += clippers;
            tBasquet += clippers;
            tBasquet += lakers;
            tBasquet += lakers2;//No deberia agregarse por estar repetido
            tBasquet += spurs;
            Console.WriteLine(tBasquet.Mostrar());

            //PARTIDOS
            Console.WriteLine(tFutbol.JugarPartido);
            Console.WriteLine(tFutbol.JugarPartido);
            Console.WriteLine(tFutbol.JugarPartido);
            Console.WriteLine(tBasquet.JugarPartido);
            Console.WriteLine(tBasquet.JugarPartido);
            Console.WriteLine(tBasquet.JugarPartido);

            Console.ReadKey();
        }
    }
}
