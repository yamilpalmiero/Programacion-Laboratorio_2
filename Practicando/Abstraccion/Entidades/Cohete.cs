using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cohete : Transporte
    {
        #region Atributos
        public string modelo;
        public int cantidadVentanas;
        #endregion

        #region Constructor
        public Cohete(byte cantidadPasajeros, Velocidades velocidad, string modelo, int ventanas) : base(cantidadPasajeros, velocidad)
        {
            this.modelo = modelo;
            this.cantidadVentanas = ventanas;
        }
        #endregion

        #region Metodos
        public override void Frenar()
        {
            Console.WriteLine("El Cohete esta frenando...");
        }
        public override void Avanzar()
        {
            base.Avanzar();
            Console.WriteLine("... el Cohete.");
        }
        #endregion

        #region Plomorfismo ToString
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine("En la clase Cohete...");
            sb.Append("Modelo: ");
            sb.AppendLine(this.modelo);
            sb.Append("Cantidad de ventanas: ");
            sb.AppendLine(this.cantidadVentanas.ToString());

            return sb.ToString();
        }
        #endregion
    }
}

