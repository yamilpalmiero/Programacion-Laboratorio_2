using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_08";

            string nombre;
            int antiguedad;
            float valorHora;
            float horasMes;
            char seguir;

            do
            {
                Console.Write("Nombre: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Antiüedad: ");
                antiguedad = int.Parse(Console.ReadLine());
                Console.WriteLine("Valor por hora: ");
                valorHora = float.Parse(Console.ReadLine());
                Console.WriteLine("Horas trabajadas en el mes: ");
                horasMes = float.Parse(Console.ReadLine());

            } while (seguir == 's' || seguir == 'S');
        }
    }
}
