using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        #region Atributos
        private double cantidad;
        private static double cotizRespectoDolar;
        #endregion

        #region Sobrecarga Constructores
        private Dolar()
        {
            Dolar.cotizRespectoDolar = 1;
        }
        public Dolar(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }
        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region Getters
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }
        #endregion

        #region Sobrecarga Exp Imp
        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.cantidad * Dolar.GetCotizacion());
        }
        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos(d.cantidad * Dolar.GetCotizacion() / Pesos.GetCotizacion());
        }
        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }
        #endregion

        #region Sobrecarga Operadores Comparacion
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return d1.cantidad == d2.cantidad;
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        public static bool operator ==(Dolar d, Pesos p)
        {
            return d.cantidad==p.GetCantidad();
        }
        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == p);
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            return d.cantidad == e.GetCantidad();
        }
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }
        #endregion

        #region Sobrecarga Operadores Aritmeticos
        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad + e.GetCantidad());
        }
        public static Dolar operator +(Dolar d, Pesos p)
        {
            return new Dolar(d.cantidad + p.GetCantidad());
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad - e.GetCantidad());
        }
        public static Dolar operator -(Dolar d, Pesos p)
        {
            return new Dolar(d.cantidad - p.GetCantidad());
        }
        #endregion
    }
}
