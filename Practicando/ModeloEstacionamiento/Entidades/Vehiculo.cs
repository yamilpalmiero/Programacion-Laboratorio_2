using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected DateTime ingreso;
        private string patente;

        public Vehiculo(string patente)
        {
            this.patente = patente;
            DateTime.Now.AddHours(-3);
        }

        public string Patente
        {
            get
            {
                return this.patente;
            }
            set
            {
                if (value.Length == 6)
                {
                    this.patente = value;
                }
            }
        }

        public abstract string ConsultarDatos();

        public override string ToString()
        {
            return String.Format("Patente: {0}", this.Patente);
        }

        public virtual string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Ingreso: {this.ingreso.Ticks}");
            sb.AppendLine(this.ToString());
            return sb.ToString();
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return v1.Patente == v2.Patente;
        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}
