using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiClaseException
{
    public class MiClaseException : Exception
    {
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public MiClaseException()
            : base("Mensaje por defecto")
        {

        }

        /// <summary>
        /// Constructor con mensaje de error personalizado
        /// </summary>
        /// <param name="mensaje">Mensaje de error personalizado</param>
        public MiClaseException(string mensaje)
            : base(mensaje)
        {

        }

        /// <summary>
        /// Constructor con mensaje de error personalizado y la inner Exception
        /// </summary>
        /// <param name="mensaje">Mensaje de error personalizado</param>
        /// <param name="innerException">Inner Exception</param>
        public MiClaseException(string mensaje, Exception innerException)
            : base(mensaje, innerException)
        {

        }
    }
}
