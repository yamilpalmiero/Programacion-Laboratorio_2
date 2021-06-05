using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MensajeroG<T, U>
    {
        public T miAtributo1;
        public U miAtributo2;
        private Dictionary<T, U> miDiccionario;

        public MensajeroG()
        {
            this.miAtributo1 = default;
            this.miAtributo2 = default(U);
            this.miDiccionario = new Dictionary<T, U>();
        }

        public override string ToString()
        {
            return this.miAtributo1.ToString() + " - " + this.miAtributo2.ToString() + " - " + this.miDiccionario.Count.ToString();
        }
    }
}
