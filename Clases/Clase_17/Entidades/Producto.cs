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
        private double precio;
        private const float iva = 0.21f;

        public Producto(string descripcion, double precio)
        {
            this.descripcion = descripcion;
            this.precio = precio;
        }

        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
        }
        public double Precio
        {
            get
            {
                return this.precio;
            }
        }
    }
}
