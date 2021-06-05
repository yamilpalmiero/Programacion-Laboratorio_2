using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClaseRestrictivaG<T> where T : MiClase
    {
        public List<T> miLista;

        public ClaseRestrictivaG()
        {
            this.miLista = new List<T>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (T item in this.miLista)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
    }
}
