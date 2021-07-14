using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        private string descripcion;
        private int stock;

        public Producto(string descripcion, int stock)
        {
            this.descripcion = descripcion;
            this.stock = stock;
        }

        public string Descripcion
        {
            get { return this.descripcion; }
        }
        public int Stock
        {
            get { return this.stock; }
        }
    }
}
