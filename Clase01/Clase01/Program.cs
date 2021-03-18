using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase01_ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            string textoIngresado, textoIngresado2;
            int contadorA = 0;

            Console.WriteLine("Ingrese un texto: ");
            textoIngresado = Console.ReadLine();

            foreach(char letra in textoIngresado)
            {
                if(letra == 'a')
                {
                    contadorA++;
                }
            }

            Console.WriteLine("La cantidad de letras a es: {0}", contadorA);
            Console.WriteLine();


            //Resuelto creando un metodo
            Console.WriteLine("Ingrese otro texto: ");
            textoIngresado2 = Console.ReadLine();
            contadorA = contadorLetras(textoIngresado2, 'a');
            Console.WriteLine("La cantidad de letras a es: {0}", contadorA);


            Console.ReadKey();
        }

        private static int contadorLetras (string texto, char letra)
        {
            int contador = 0;

            for(int i=0; i<texto.Length; i++)
            {
                if (texto[i].Equals(letra))
                {
                    contador++;
                }
            }

            return contador;
        }
    }
}
