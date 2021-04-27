using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Euro
    {
        #region Atributos
        private double cantidad;
        private static double cotizRespectoDolar;
        #endregion

        #region Sobrecarga Constructores
        private Euro()
        {
            Euro.cotizRespectoDolar = 1.08;
        }
        public Euro(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region Getters
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }
        #endregion

        #region Sobrecarga Exp Imp
        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad * Euro.GetCotizacion());
        }
        public static explicit operator Pesos(Euro e)
        {
            return new Pesos(e.cantidad * Euro.GetCotizacion() / Pesos.GetCotizacion());
        }
        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }
        #endregion

        #region Sobrecarga Operadores Comparacion
        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.GetCantidad() == e2.GetCantidad();
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        public static bool operator ==(Euro e, Pesos p)
        {
            return (Pesos)e == p;
        }
        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            return (Dolar)e == d;
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }
        #endregion

        #region Sobrecarga Operadores Aritmeticos
        public static Euro operator +(Euro e, Dolar d)
        {
            return e + d;
        }
        public static Euro operator +(Euro e, Pesos p)
        {
            return e + p;
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            return e - d;
        }
        public static Euro operator -(Euro e, Pesos p)
        {
            return e - p;
        }
        #endregion
    }
}
