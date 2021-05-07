using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Botella
    {
        #region Atributos
        protected int capacidadML;
        protected int contenidoML;
        protected string marca;
        #endregion

        #region Constructor
        protected Botella(string marca, int capacidadML, int contenidoML)
        {
            this.marca = marca;
            this.contenidoML = contenidoML;
            if (capacidadML < contenidoML)
            {
                this.contenidoML = capacidadML;
            }
            else
            {
                this.capacidadML = capacidadML;
            }
        }
        #endregion

        #region Propiedades
        public int CapacidadLitros
        {
            get
            {
                return capacidadML / 1000;//Divido por mil porque la unidad que retorna es Litros
            }
        }
        public int Contenido
        {
            get
            {
                return this.contenidoML / 1000;
            }
            set
            {
                this.contenidoML = value;
            }
        }
        public float PorcentajeContenido
        {
            get
            {
                return (this.contenidoML * 100) / this.capacidadML;
            }
        }
        #endregion

        #region Metodos
        protected virtual string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat($"Capacidad: {this.capacidadML}");
            sb.AppendFormat($"Contenido: {this.contenidoML}");
            sb.AppendFormat($"Marca: {this.marca}");

            return sb.ToString();
        }
        public abstract int ServirMedida();
        public override string ToString()
        {
            return this.GenerarInforme();
        }
        #endregion

        #region Enumerado
        public enum Tipo
        {
            Vidrio,
            Plastico
        }
        #endregion
    }
}
