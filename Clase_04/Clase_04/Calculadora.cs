using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_04
{
    public class Calculadora
    {
        public float numero1;
        public float numero2;
        public float numero3;
      
        public static float Sumar(float numero1, float numero2)
        {
            return numero1 + numero2;
        }

        public static float Sumar(float numero1, float numero2, float numero3)
        {
            //return numero1 + numero2 + numero3;
            return numero3 + Calculadora.Sumar(1, 2);
        }

        public static float Sumar(int numero1, float numero2, float numero3)
        {
            return numero1 + numero2 + numero3;
        }
    }
}
