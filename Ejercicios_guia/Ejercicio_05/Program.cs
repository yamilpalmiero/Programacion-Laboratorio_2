using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_05";

            double numeroIngresado, numeroActual = 1, contadorIzquierda, contadorDerecha, sumaIzquierda, sumaDerecha;

            Console.WriteLine("Ingrese un numero:");
            numeroIngresado = double.Parse(Console.ReadLine());

            while (numeroActual < numeroIngresado)//Se pide entre 1 y el numero que ingrese el usuario
            {
                numeroActual++;//Aumento de entrada porque el contador arranca en 1
                sumaIzquierda = 0;
                sumaDerecha = 0;
                
                for(contadorIzquierda=1; contadorIzquierda < numeroActual; contadorIzquierda++)//Calculo la suma para la izquierda del numero actual
                {
                    sumaIzquierda += contadorIzquierda;//Se van usmando los numeros desde 1 consecutivamente
                }
                for(contadorDerecha=numeroActual+1; contadorDerecha<=sumaIzquierda; contadorDerecha++)//Arranca a sumar a la derecha de la popsicion actual y hasta que iguale la suma del otro lado
                {
                    if ((sumaDerecha==sumaIzquierda)||(sumaDerecha>sumaIzquierda))//Aca es donde separo el centro numerico
                    {
                        break;
                    }
                    sumaDerecha += contadorDerecha;
                }

                Console.WriteLine("{0} es un centro numerico.", numeroActual);
            }

            Console.ReadKey();
        }
    }
}
