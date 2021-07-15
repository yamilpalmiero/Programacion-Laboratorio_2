using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private string nombre;

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
    }
}
