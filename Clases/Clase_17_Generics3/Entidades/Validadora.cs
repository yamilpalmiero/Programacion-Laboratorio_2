using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validadora
    {
        public static Producto InicializarProducto(Producto producto)
        {
            return producto ?? new Producto();//Si no es nulo retorno producto, si es null hago el new
        }

        public static Cliente InicializarCliente(Cliente cliente)
        {
            return cliente is null ? new Cliente() : cliente;
            /*if(cliente is null)
             * new Cliente();
             * else
             * cliente;*/
        }

        public static bool ValidarCliente(Cliente cliente)
        {
            return !String.IsNullOrWhiteSpace(cliente.Nombre);
        }

        public static T InicializarElemento<T>(T valor) where T : new()
        {
            if (valor == null)
                return new T();
            else
                return valor;
        }

        public static bool ValidarProducto(Producto producto)
        {
            return !String.IsNullOrWhiteSpace(producto.Nombre);
        }
    }
}
