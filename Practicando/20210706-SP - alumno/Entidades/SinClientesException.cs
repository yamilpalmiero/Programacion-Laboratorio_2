using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SinClientesException : Exception
    {
        public SinClientesException()
            : base("No hay clientes.")
        {

        }
        public SinClientesException(string mensaje)
            : this(mensaje, null)
        {

        }
        public SinClientesException(string mensaje, Exception inner)
            : base(mensaje, inner)
        {

        }
    }
}
