using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int [5];
            int max = 0;
            int min = 0;
            int suma = 0;
            int flag = 0;


            for(int i=0; i<5; i++)
            {
                Console.WriteLine("Ingrese numero:");
                numeros[i] = int.Parse(Console.ReadLine());
                if (flag == 0)
                {
                    min = numeros[i];
                    max = numeros[i];
                    flag = 1;
                }
                else
                {
                    if (numeros[i] <= min)
                    {
                        min = numeros[i];
                    }
                    if (numeros[i] >= max)
                    {
                        max = numeros[i];
                    }
                }
                suma += numeros[i];
            }

            Console.WriteLine("El valor maximo es {0}, el minimo es {1} y el promedio {2:#,###.00}", max, min, (float)suma / 5);

            Console.ReadKey();
        }
    }
}
