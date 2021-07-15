using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Entidades
{
    public class Deporte
    {
        public static bool Metodo<T, U>(T algo, U otroAlgo)
            where T : Deporte, new()
            where U : new()
        {
            bool retorno = false;

            if (algo is string && otroAlgo is Futbol)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
