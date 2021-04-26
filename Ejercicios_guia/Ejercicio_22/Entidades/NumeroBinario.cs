using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NumeroBinario
    {
        public string numero;

        private NumeroBinario(string num)
        {
            this.numero = num;
        }

        public static implicit operator NumeroBinario(string numeroBinario)//NumeroBinario obj = "1001";
        {
            return new NumeroBinario(numeroBinario);
        }

        public static explicit operator string(NumeroBinario numeroBinario)
        {
            return numeroBinario.numero;//string binario = (string)new NumeroBinario("1001");
        }

        public static string operator +(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return numeroBinario.numero + Conversor.DecimalBinario((int)numeroDecimal.numero);//string + string
        }

        public static string operator -(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            double resultado = double.Parse(numeroBinario.numero) - numeroDecimal.numero;//double - double
            return resultado.ToString();
        }

        public static bool operator ==(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return numeroBinario.numero == Conversor.DecimalBinario((int)numeroDecimal.numero);
        }

        public static bool operator !=(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return !(numeroBinario == numeroDecimal);
        }
    }
}
