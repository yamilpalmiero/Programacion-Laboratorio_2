using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_14";

            int opcion;
            double area = 0;
            double valorA;
            double valorB;

            Console.WriteLine("CALCULO DE AREA");
            Console.WriteLine("1- Calcular area de un cuadrado");
            Console.WriteLine("2- Calcular area de un triangulo");
            Console.WriteLine("3- Calcular area de un circulo");
            Console.WriteLine("Elija una opcion: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese el valor del lado: ");
                    valorA = int.Parse(Console.ReadLine());
                    area = CalculoDeArea.CalcularCuadrado(valorA);
                    break;
                case 2:
                    Console.WriteLine("Ingrese el valor de base: ");
                    valorA = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor de altura: ");
                    valorB = int.Parse(Console.ReadLine());
                    area = CalculoDeArea.CalcularTriangulo(valorA, valorB);
                    break;
                case 3:
                    Console.WriteLine("Ingrese el valor del radio: ");
                    valorA = int.Parse(Console.ReadLine());
                    area = CalculoDeArea.CalcularCirculo(valorA);
                    break;

            }

            Console.WriteLine("El area es : {0}", area);
            Console.ReadKey();
        }
    }
}
