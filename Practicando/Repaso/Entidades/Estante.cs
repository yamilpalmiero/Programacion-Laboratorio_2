using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estante
    {
        #region Atributos
        private Producto[] productos;
        private int ubicacionEstante;
        #endregion

        #region Constructores
        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }
        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }
        #endregion

        #region Metodos
        public Producto[] GetProductos()
        {
            return this.productos;
        }
        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("Ubicacion estante: {0}", e.ubicacionEstante));
            sb.AppendLine("Productos del estante:");
            foreach (Producto auxProducto in e.productos)
            {
                sb.AppendLine(Producto.MostrarProducto(auxProducto));
            }

            return sb.ToString();
        }
        #endregion

        #region Sobrecarga de Operadores
        public static bool operator ==(Estante e, Producto p)
        {
            bool retorno = false;

            foreach (Producto auxProducto in e.productos)
            {
                if (auxProducto == p)
                {
                    retorno = true;
                }
            }

            return retorno;
        }
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }
        public static bool operator +(Estante e, Producto p)
        {
            int i = 0;

            if (e != p)//Por la sobrecarga de != esto significa que en ese estante no se encuentra ese producto
            {
                foreach (Producto producto in e.GetProductos())
                {
                    if (producto is null)//Osea que este espacio esta vacio
                    {
                        e.GetProductos()[i] = p;
                        return true;
                    }
                    i++;
                }
            }

            return false;
        }
        public static Estante operator -(Estante e, Producto p)
        {
            int i = 0;

            if (e == p)//Si el estante contiene al producto
            {
                foreach (Producto producto in e.GetProductos())
                {
                    if (producto == p)
                    {
                        e.GetProductos()[i] = null;
                        break;
                    }
                    i++;
                }
            }

            return e;

        }
        #endregion
    }
}
