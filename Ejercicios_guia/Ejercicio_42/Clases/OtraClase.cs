using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MisExcepciones;

namespace Clases
{
    public class OtraClase
    {
        private int a;

        public void MetodoDeInstancia()
        {
            try
            {
                MiClase otraClase = new MiClase(1, 2, '*');
            }
            catch (UnaExcepcion e)
            {
                throw new MiExcepcion("Mensaje MiExcepcion", e);
            }
        }
    }
}
