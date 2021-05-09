using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Transporte
    {
        #region Atributos
        protected byte cantidadPasajeros;
        protected Velocidades velocidadMaxima;
        #endregion

        #region Constructor
        public Transporte(byte pasajeros, Velocidades velocidadMaxima)
        {
            this.cantidadPasajeros = pasajeros;
            this.velocidadMaxima = velocidadMaxima;
        }
        #endregion

        #region Metodos
        public virtual void Avanzar()
        {
            Console.Write("Esta avamnzando:");
        }
        public abstract void Frenar();
        #endregion

        #region Polimorfismo ToString
        public override string ToString()
        {
            System.Text.StringBuilder sb = new StringBuilder();

            sb.AppendLine("En la clase Transporte...");
            sb.Append("Cantidad de pasajeros: ");
            sb.AppendLine(this.cantidadPasajeros.ToString());
            sb.Append("Velocidad maxima: ");
            sb.AppendLine(((int)this.velocidadMaxima).ToString());

            return sb.ToString();
        }
        #endregion
    }
}
