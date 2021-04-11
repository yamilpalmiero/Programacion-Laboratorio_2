using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Pesos
    {
        #region Atributos
        private double cantidad;
        private static double cotizRespectoDolar;
        #endregion

        #region Sobrecarga Constructores
        private Pesos()
        {
            Pesos.cotizRespectoDolar = 1 / 66;
        }
        public Pesos(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }
        public Pesos(double cantidad, double cotizacion) : this(cantidad)
        {
            Pesos.cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region Getters
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return Pesos.cotizRespectoDolar;
        }
        #endregion

        #region Sobrecarga Exp Imp
        public static explicit operator Dolar(Pesos p)
        {
            return new Dolar(p.cantidad * Pesos.GetCotizacion());
        }
        public static explicit operator Euro(Pesos p)
        {
            return new Euro(p.cantidad * Pesos.GetCotizacion() / Euro.GetCotizacion());
        }
        public static implicit operator Pesos(double d)
        {
            return new Pesos(d);
        }
        #endregion

        #region Sobrecarga Operadores Comparacion
        public static bool operator ==(Pesos p1, Pesos p2)
        {
            return p1.GetCantidad() == p2.GetCantidad();
        }
        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Pesos p, Euro e)
        {
            return p == e;
        }
        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == e);
        }

        public static bool operator ==(Pesos p, Dolar d)
        {
            return p == d;
        }
        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }
        #endregion

        #region Sobrecarga Operadores Aritmeticos
        public static Pesos operator +(Pesos p, Euro e)
        {
            return p + e;
        }
        public static Euro operator +(Pesos p, Dolar d)
        {
            return p + d;
        }

        public static Euro operator -(Pesos p, Euro e)
        {
            return p - e;
        }
        public static Euro operator -(Pesos p, Dolar d)
        {
            return p - d;
        }
        #endregion
    }
}
