using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validadora
    {
        public static Producto InicializarProducto(Producto p)
        {
            return p = new Producto();
        }
        public static Cliente InicializarCliente(Cliente c)
        {
            return c = new Cliente();
        }
    }
}
