using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Conversor
    {
        public static string DecimalBinario(int numero)
        {
            if (numero > 0 && numero < 256)
            {
                string resultado = "";

                do
                {
                    resultado = (numero % 2) + resultado;
                    numero = numero / 2;
                } while (numero > 0);

                return resultado;
            }
            else
                return "Valor inválido";
        }

        public static int BinarioDecimal(string binario)
        {
            int resultado;

            if (Conversor.EsBinario(binario))
            {
                char[] arrayBinario = binario.ToCharArray();
                Array.Reverse(arrayBinario);
                double numero = 0;

                for (int i = 0; i < arrayBinario.Length; i++)
                {
                    if (arrayBinario[i] == '1')
                    {
                        if (i == 0)
                        {
                            numero += 1;
                        }
                        else
                        {
                            numero += Math.Pow(2, i);
                        }
                    }
                }
                resultado = (int)numero;
            }
            else
            {
                resultado = 0;
            }

            return resultado;
        }

        private static bool EsBinario(string binario)
        {
            bool esBinario = true;

            foreach (char i in binario)
            {
                if (i != '0' && i != '1')
                {
                    esBinario = false;
                }
            }
            return esBinario;
        }
    }
}
