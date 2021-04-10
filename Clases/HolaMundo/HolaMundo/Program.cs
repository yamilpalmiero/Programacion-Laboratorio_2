using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            string miTexto;

            Console.WriteLine("Ingrese un numero: ");

            miTexto = Console.ReadLine();//Console.ReadLine (o Read) devuelve la cadena de caracteres

            Console.WriteLine(miTexto);
            Console.WriteLine(miTexto + 5);

            //Parseo
            int numeroParseado = int.Parse(miTexto);
            Console.WriteLine(numeroParseado + 5);

            //Casteo Explicito
            int numeroParseadoCasteado = (int)float.Parse(miTexto);
            Console.WriteLine(numeroParseadoCasteado);
            int.TryParse(miTexto, out numeroParseadoCasteado);

            //Casteo Implicito
            double resultadoSuma = suma(numeroParseadoCasteado, 5);
            Console.WriteLine(resultadoSuma);


            Console.ReadLine();
        }

        private static double suma(double sumando, double sumando2)//Creacion del metodo suma
        {
            sumando = sumando + sumando2;
            return sumando;
        }
    }
}
