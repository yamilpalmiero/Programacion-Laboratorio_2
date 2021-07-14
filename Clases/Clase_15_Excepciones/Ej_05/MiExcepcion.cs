using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_05
{
    class MiExcepcion : Exception
    {
        public MiExcepcion()
            : base("Mensaje personalizado de MiExcepcion")
        {

        }
        public MiExcepcion(string mensaje)
            : base(mensaje)
        {

        }
        public MiExcepcion(string mensaje, Exception innerException)
            : base(mensaje, innerException)
        {

        }
        public MiExcepcion(string mensaje, Exception innerException, string origenError)
            : base(mensaje, innerException)
        {
            base.Source = origenError;
        }

        public override string ToString()
        {
            return $"Mensaje de error: {base.Message}\nOrigen: {base.Source}\n";
        }
    }
}
