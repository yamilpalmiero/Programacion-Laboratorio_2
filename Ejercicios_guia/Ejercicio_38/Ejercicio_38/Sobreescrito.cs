using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_38
{
    public abstract class Sobreescrito
    {
        protected string miAtributo;

        public Sobreescrito()
        {
            this.miAtributo = "Probar abstractos";
        }

        public string MiPropiedad
        {
            get
            {
                return this.miAtributo;
            }
        }

        public abstract string MiMetodo();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Este es mi étodo ToString sobreescrito!");
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Sobreescrito;
        }

        public override int GetHashCode()
        {
            return 1142510187;
        }
    }
}
