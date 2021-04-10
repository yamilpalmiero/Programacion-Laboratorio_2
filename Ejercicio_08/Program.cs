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
            double sueldoBruto;
            double sueldoNeto;
            double descuentos;

            Console.WriteLine("Nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Antigüedad: ");
            antiguedad = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor por hora: ");
            valorHora = float.Parse(Console.ReadLine());
            Console.WriteLine("Horas trabajadas en el mes: ");
            horasMes = float.Parse(Console.ReadLine());

            sueldoBruto = (valorHora * horasMes + antiguedad * 150);
            sueldoNeto = sueldoBruto * 0.87;
            descuentos = sueldoBruto * 0.13;

            Console.WriteLine(nombre);
            Console.WriteLine(valorHora);
            Console.WriteLine(antiguedad);
            Console.WriteLine(horasMes);
            Console.WriteLine(sueldoBruto);
            Console.WriteLine(sueldoNeto);
            Console.WriteLine(descuentos);

            Console.ReadKey();
        }
    }
}
