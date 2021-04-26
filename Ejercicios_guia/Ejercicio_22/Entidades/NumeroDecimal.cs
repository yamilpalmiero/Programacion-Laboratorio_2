using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NumeroDecimal
    {
        public double numero;

        private NumeroDecimal(double num)
        {
            this.numero = num;
        }

        public static implicit operator NumeroDecimal(double numero)//NumeroDecimal obj = 9;
        {
            return new NumeroDecimal(numero);
        }

        public static explicit operator double(NumeroDecimal numeroDecimal)//double decim = (double)new NumeroDecimal(9);
        {
            return numeroDecimal.numero;
        }

        public static double operator +(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return numeroDecimal.numero + (double)Conversor.BinarioDecimal(numeroBinario.numero);
        }

        public static double operator -(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return numeroDecimal.numero - (double)Conversor.BinarioDecimal(numeroBinario.numero);
        }

        public static bool operator ==(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return numeroDecimal.numero == (double)Conversor.BinarioDecimal(numeroBinario.numero);
        }

        public static bool operator !=(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return !(numeroDecimal == numeroBinario);
        }
    }
}
