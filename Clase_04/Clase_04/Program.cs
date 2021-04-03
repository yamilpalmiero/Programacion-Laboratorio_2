using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Sobrecargas";

            float resultado;
            resultado = Calculadora.Sumar(30, 20);
            Console.WriteLine("El resultado es: {0}", resultado);
            resultado = Calculadora.Sumar(30, 20, 10);
            Console.WriteLine("El resultado es: {0}", resultado);

            Persona persona1 = new Persona("Fernandez");
            Persona persona2 = new Persona("Maria", 35125411, "Perez");

            Console.WriteLine(Persona.MostrarCantidadPersonas());

            Console.ReadKey(true);
        }
    }
}
