using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor
    {
        private string nombre;
        private List<Producto> ventas;

        private Vendedor()
        {
            this.ventas = new List<Producto>();
        }
        public Vendedor(string nombre)
            : this()
        {
            this.nombre = nombre;
        }

        public List<Producto> Ventas
        {
            get { return this.ventas; }
        }
    }
}
