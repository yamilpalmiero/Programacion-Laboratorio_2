using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero=int.MaxValue, i=1, j, suma, contador=0;

            while(contador<4)
            {
                suma = 0;
                i++;//En la 4ta iteracion i=6

                for (j = 1; j <= i-1; j++)//Este bucle itera 5 veces (6-1)
                {
                    if (i % j == 0)//6%1=0 6%2=0 6%3=0
                    {
                        suma += j;//suma=1+2+3=6
                    }
                }
                if (suma == i)//6=6
                {
                    Console.WriteLine("{0}", i);//Imprimo 6 porque es perfecto
                    contador++;//Contador=1
                }
            }

            Console.ReadKey();
        }
    }
}
