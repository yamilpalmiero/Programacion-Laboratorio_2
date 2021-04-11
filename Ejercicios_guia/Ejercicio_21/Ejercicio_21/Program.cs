using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnidadesTemperatura;

namespace Ejercicio_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_21";

            Fahrenheit f = new Fahrenheit(1);
            Kelvin k = new Kelvin(255.928);
            Celsius c = new Celsius(-17.2222);

            Console.WriteLine(((Fahrenheit)k).GetTemperatura());
            Console.WriteLine(((Fahrenheit)c).GetTemperatura());
            Console.WriteLine(((Celsius)f).GetTemperatura());
            Console.WriteLine(((Celsius)k).GetTemperatura());

            Kelvin resKelvin = k + f;
            Fahrenheit resFahrenheit = f + k;
            Celsius resCelsius = c + k;
            Console.WriteLine("Resultado Fahrenheit {0}", resFahrenheit.GetTemperatura());
            Console.WriteLine("Resultado Celsius {0}", resCelsius.GetTemperatura());
            Console.WriteLine("Resultado Kelvin {0}", resKelvin.GetTemperatura());

            Console.ReadKey();
        }
    }
}
