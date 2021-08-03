using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AutoF1
    {
        private string escuderia;
        private int posicion;
        private int puntoPartida;
        private int velocidad;

        /// <summary>
        /// 
        /// </summary>
        public AutoF1()
        {
            this.posicion = 0;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="escuderia"></param>
        /// <param name="velocidad"></param>
        /// <param name="puntoPartida"></param>
        public AutoF1(string escuderia, int velocidad, int puntoPartida)
        {
            this.escuderia = escuderia;
            this.velocidad = velocidad;
            this.puntoPartida = puntoPartida;
        }



        /// <summary>
        /// 
        /// </summary>
        public string Escuderia
        {
            get { return this.escuderia; }
            set { this.escuderia = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Posicion
        {
            get { return this.posicion; }
            set { this.posicion = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int UbicacionEnPista
        {
            get { return this.puntoPartida; }
            set { this.puntoPartida = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Velocidad
        {
            get { return this.velocidad; }
            set { this.velocidad = value; }
        }



        /// <summary>
        /// 
        /// </summary>
        public void Acelerar()
        {
            this.UbicacionEnPista = this.UbicacionEnPista + this.Velocidad;//UbicacionEnPista += Velocidad;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Escuderia: {this.Escuderia} - Posicion: {this.Posicion}";
        }
    }
}
