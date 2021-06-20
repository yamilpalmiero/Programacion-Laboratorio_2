using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MisExcepciones;

namespace Clases
{
    public class MiClase
    {
        private float a;
        private float b;
        private char operador;

        public MiClase()
        {
            try
            {
                MiClase.Calcular();
            }
            catch (DivideByZeroException e)
            {
                throw new DivideByZeroException("Mensaje DivideByZero", e);
            }
        }
        public MiClase(float numero1, float numero2, char operador)
            : this()
        {
            this.a = numero1;
            this.b = numero2;
            this.operador = operador;

            try
            {
                MiClase nuevaClase = new MiClase();
            }
            catch (DivideByZeroException e)
            {
                throw new UnaExcepcion("Mensaje UnaExcepcion", e);
            }
        }

        private static float Calcular()
        {
            throw new DivideByZeroException();
        }
    }
}
