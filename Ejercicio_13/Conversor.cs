using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    public class Conversor
    {
        public static string DecimalBinario(double numero)
        {
            return Convert.ToString(Convert.ToByte(numero), 2);
        }
        public static int BinarioDecimal(string numero)
        {
            return (int)Convert.ToInt64(numero, 2);
        }
    }
}
