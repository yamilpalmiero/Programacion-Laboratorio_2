using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Biblioteca;

namespace Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Cliente cli = new Cliente("Yamil", "Palmiero");
            Console.WriteLine("Con CONSTRUCTOR:");
            Console.WriteLine(cli.GetNombreCompleto());*/

            /*cli.SetNombre("Mariana");
            cli.SetApellido("Seib");
            Console.WriteLine("\nCon SETTERS:");
            Console.WriteLine(cli.GetNombreCompleto());*/

            //--------------------------------------------------------------
            Cliente cliente = new Cliente("Yamil", "Palmiero");
            Mascota perro = new Mascota("Perro", "Papu", new DateTime(2015, 08, 16));
            Vacuna vacunaRabia = new Vacuna("Rabia");
            perro.AgregarVacuna(vacunaRabia);
            Mascota gato = new Mascota("Gato", "Pipi", new DateTime(2010, 05, 10));
            cliente.AgregarMascota(perro);
            cliente.AgregarMascota(gato);
            Console.WriteLine(cliente.MostrarDatos());

            Console.ReadKey(true);
        }
    }
}
