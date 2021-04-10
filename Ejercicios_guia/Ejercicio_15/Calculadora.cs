using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    public class Calculadora
    {
        public static double Calcular(double num1, double num2, char operacion)
        {
            double resultado = 0;

            switch (operacion)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    if (Calculadora.Validar(num2))
                    {
                        resultado = num1 / num2;
                    }
                    break;
            }
            return resultado;
        }
        private static bool Validar(double numero)
        {
            if (numero == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
