using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Producto
    {
        #region Atributos
        private string codigoDeBarra;
        private string marca;
        private float precio;
        #endregion

        #region Constructor
        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }
        #endregion

        #region Metodos
        public string GetMarca()
        {
            return this.marca;
        }
        public float GetPrecio()
        {
            return this.precio;
        }
        public static string MostrarProducto(Producto p)
        {
            return string.Format("Codigo de barras: {0}\nMarca: {1}\nPrecio: {2}", p.codigoDeBarra, p.marca, p.precio);
        }
        #endregion

        #region Sobrecarga de Operadores
        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }
        public static bool operator ==(Producto p1, Producto p2)
        {
            if (p1.codigoDeBarra == p2.codigoDeBarra && p1.marca == p2.marca)
                return true;
            return false;
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
        public static bool operator ==(Producto p, string marca)
        {
            return p.marca == marca;
        }
        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }
        #endregion
    }
}
