using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_16";

            Alumno alumno1 = new Alumno("Yamil", "Palmiero", 100);
            Alumno alumno2 = new Alumno("Mariana", "Seib", 200);
            Alumno alumno3 = new Alumno("Maria", "Martu", 300);

            alumno1.Estudiar(2, 8);
            alumno2.Estudiar(6, 5);
            alumno3.Estudiar(9, 8);

            alumno1.CalcularFinal();
            alumno2.CalcularFinal();
            alumno3.CalcularFinal();

            Console.WriteLine(alumno1.Mostrar());
            Console.WriteLine(alumno2.Mostrar());
            Console.WriteLine(alumno3.Mostrar());

            Console.ReadKey();
        }
    }
}
