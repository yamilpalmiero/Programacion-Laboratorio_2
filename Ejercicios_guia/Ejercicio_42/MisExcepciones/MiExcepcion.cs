using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisExcepciones
{
    public class MiExcepcion : Exception
    {
        public MiExcepcion(string mensaje, Exception inner)
            : base(mensaje, inner)
        {

        }

        public MiExcepcion(string mensaje)
            : base(mensaje)
        {

        }
    }
}
