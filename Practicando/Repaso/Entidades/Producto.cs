using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
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

        #region Getters
        public string GetMarca()
        {
            return this.marca;
        }
        public float GetPrecio()
        {
            return this.precio;
        }
        #endregion

        #region Metodos
        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Marca: {0}\nCodigo: {1}\nPrecio: {2}", p.marca, p.codigoDeBarra, p.precio);

            return sb.ToString();
        }
        #endregion

        #region Sobrecarga Operadores
        public static explicit operator string(Producto p)//Funciona como el getter del codigo de barras
        {
            return p.codigoDeBarra;
        }
        public static bool operator ==(Producto p1, Producto p2)
        {
            bool retorno = false;

            if (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra)
                retorno = true;

            return retorno;
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
