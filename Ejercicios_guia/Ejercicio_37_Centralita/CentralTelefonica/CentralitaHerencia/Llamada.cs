﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {
        #region Atributos
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        #endregion

        #region Enumerado
        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }
        #endregion

        #region Constructor
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        #endregion

        #region Propiedades
        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }
        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }
        #endregion

        #region Metodos
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat($"Duracion: {this.duracion.ToString()}\nDestino: {this.nroDestino}\nOrigen: {this.nroOrigen}");

            return sb.ToString();
        }
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1.duracion > llamada2.duracion)
            {
                return 1;
            }
            else if (llamada1.duracion < llamada2.duracion)
            {
                return -1;
            }

            return 0;
        }
        #endregion
    }
}
