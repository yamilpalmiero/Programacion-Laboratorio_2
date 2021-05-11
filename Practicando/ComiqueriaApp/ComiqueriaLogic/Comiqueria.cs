using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        #region Atributos
        private List<Producto> productos;
        private List<Venta> ventas;
        #endregion

        #region Constructor
        public Comiqueria()
        {
            this.productos = new List<Producto>();
            this.ventas = new List<Venta>();
        }
        #endregion

        #region Indexador
        public Producto this[Guid codigo]
        {
            get
            {
                foreach (Producto producto in this.productos)
                {
                    if ((Guid)producto == codigo)
                    {
                        return producto;
                    }
                }

                return null;
            }
        }
        #endregion

        #region Metodos
        public void Vender(Producto producto, int cantidad)
        {
            this.ventas.Add(new Venta(producto, cantidad));
        }
        public void Vender(Producto producto)
        {
            this.Vender(producto, 1);
        }
        public string ListarVentas()
        {
            List<Venta> ventasOrdenadas = this.ventas.OrderByDescending(x => x.Fecha).ToList();

            StringBuilder sb = new StringBuilder();
            foreach (Venta venta in ventasOrdenadas)
            {
                sb.AppendLine(venta.ObtenerDescripcionBreve());
            }

            return sb.ToString();
        }
        public Dictionary<Guid, string> ListarProductos()
        {
            Dictionary<Guid, string> respuesta = new Dictionary<Guid, string>();

            foreach (Producto producto in this.productos)
            {
                respuesta.Add((Guid)producto, producto.Descripcion);
            }

            return respuesta;
        }
        #endregion

        #region Sobrecargas
        public static bool operator ==(Comiqueria comiqueria, Producto producto)
        {
            foreach (Producto p in comiqueria.productos)
            {
                if (p.Descripcion == producto.Descripcion)
                {
                    return true;
                }
            }

            return false;
        }
        public static bool operator !=(Comiqueria comiqueria, Producto producto)
        {
            return !(comiqueria == producto);
        }
        public static Comiqueria operator +(Comiqueria comiqueria, Producto producto)
        {
            if (comiqueria != producto)
            {
                comiqueria.productos.Add(producto);
            }

            return comiqueria;
        }
        #endregion
    }
}
