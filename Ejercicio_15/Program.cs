using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_15";

            int num1;
            int num2;
            char operacion;

            Console.WriteLine("Primer numero: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Operacion (+, -, *, /): ");
            operacion = char.Parse(Console.ReadLine());

            Console.WriteLine("Segundo numero: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("El resultado es: {0}", Calculadora.Calcular(num1, num2, operacion));

            Console.ReadKey();
        }
    }
}
