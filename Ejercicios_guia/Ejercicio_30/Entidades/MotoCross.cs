using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short cilindrada;

        public MotoCross(short numero, string escuderia)
            : base(numero, escuderia)
        {

        }
        public MotoCross(short numero, string escuderia, short cilindrada)
            : this(numero, escuderia)
        {
            this.cilindrada = cilindrada;
        }

        public short Cilindrada
        {
            get
            {
                return this.cilindrada;
            }
            set
            {
                this.cilindrada = value;
            }
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarDatos());
            sb.AppendLine($"Cilindrada: {this.Cilindrada.ToString()}");

            return sb.ToString();
        }

        public static bool operator ==(MotoCross m1, MotoCross m2)
        {
            bool retorno = false;

            if ((VehiculoDeCarrera)m1 == (VehiculoDeCarrera)m2 && m1.Cilindrada == m2.Cilindrada)
            {
                retorno = true;
            }

            return retorno;
        }
        public static bool operator !=(MotoCross m1, MotoCross m2)
        {
            return !(m1 == m2);
        }
    }
}
