using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        #region Atributos
        private Guid codigo;
        private string descripcion;
        private double precio;
        private int stock;
        #endregion

        #region Constructores
        protected Producto(string descripcion, int stock, double precio)//Inicia el codigo con el metod estatico NewGuid de la clase Guid.
        {
            this.codigo = Guid.NewGuid();
            this.descripcion = descripcion;
            this.stock = stock;
            this.precio = precio;
        }
        #endregion

        #region Propiedades
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
        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                if (value >= 0)
                {
                    this.stock = value;
                }
            }
        }
        #endregion

        #region Sobrecargas
        public static explicit operator Guid(Producto p)
        {
            return p.codigo;
        }
        #endregion

        #region Polimorfismo ToString
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Descripcion: {0}\n", this.descripcion);
            sb.AppendLine($"Codigo: {this.codigo.ToString()}");
            sb.AppendLine(String.Format("Precio: ${0:0.00}", this.precio));
            sb.AppendLine($"Stock: {this.stock.ToString()} unidades");

            return sb.ToString();
        }
        #endregion
    }
}
