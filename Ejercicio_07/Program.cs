using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_07";

            DateTime fechaNac;
            DateTime fechaHoy = DateTime.Today;
            TimeSpan cantDias;

            Console.WriteLine("Fecha de nacimiento (dd/mm/aaaa): ");
            fechaNac = DateTime.Parse(Console.ReadLine());
            cantDias = DateTime.Today.Subtract(fechaNac);

            Console.WriteLine("Cantidad de dias vividos: " + cantDias.TotalDays);

            Console.ReadKey();
        }
    }
}
