using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public sealed class Venta
    {
        #region Atributos
        private DateTime fecha;
        private static int porcentajeIva;
        private double precioFinal;
        private Producto producto;
        #endregion

        #region Constructores
        static Venta()
        {
            Venta.porcentajeIva = 21;
        }
        internal Venta(Producto producto, int cantidad)
        {

        }
        #endregion

        #region Propiedades
        internal DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
        }
        #endregion

        #region Metodos
        public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
        {
            return ((Venta.porcentajeIva * precioUnidad) / 100 + precioUnidad) * cantidad;
        }
        private void Vender(int cantidad)
        {
            producto.Stock -= cantidad;
            this.fecha = DateTime.Now;
            this.precioFinal = Venta.CalcularPrecioFinal(producto.Precio, cantidad);
        }
        public string ObtenerDescripcionBreve()
        {
            return String.Format("{0} - {1} - ${2:0.00}", this.fecha, this.producto.Descripcion, this.precioFinal);
        }
        #endregion
    }
}
