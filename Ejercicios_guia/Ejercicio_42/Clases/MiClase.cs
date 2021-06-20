using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            }
        }

        private static float Calcular()
        {
            throw new DivideByZeroException();
        }
    }
}
