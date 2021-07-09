using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic.Comun
{
    public static class MiExtension
    {
        public static string FormatearPrecio(this double numero)
        {
            string aux = String.Format("${0:0.00}", numero);

            return aux;
        }
    }
}
