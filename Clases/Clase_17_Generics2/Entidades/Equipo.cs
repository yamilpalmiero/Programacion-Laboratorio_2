using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo<T> where T : Deporte
    {
        private T deporte;

        public Equipo(T deporte)
        {
            this.deporte = deporte;
        }

        public T Deporte
        {
            get { return this.deporte; }
            set { this.deporte = value; }
        }
    }
}
