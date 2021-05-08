using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alu = new Alumno("Yamil", "Palmiero", 33782264, 427);

            Console.WriteLine(alu.MostrarAlumno());
            Console.WriteLine(alu.Estudiar());

            Console.ReadKey(true);
        }
    }
}
