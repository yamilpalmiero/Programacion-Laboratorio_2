using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private int espacioDisponible;
        private string nombre;
        private List<Vehiculo> vehiculos;

        private Estacionamiento()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        public Estacionamiento(string nombre, int espacioDisponible)
            : this()
        {
            this.nombre = nombre;
            this.espacioDisponible = espacioDisponible;
        }

        public static explicit operator string(Estacionamiento e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {e.nombre}\nEspacios disponibles: {e.espacioDisponible}");
            sb.AppendLine("Vehiculos: ");
            foreach (Vehiculo v in e.vehiculos)
            {
                sb.AppendLine(v.ConsultarDatos());
                sb.AppendLine("--------------------------------------");
            }
            return sb.ToString();
        }
        public static bool operator ==(Estacionamiento e, Vehiculo v)
        {
            bool retorno = false;

            if (e.vehiculos.Contains(v))
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Estacionamiento e, Vehiculo v)
        {
            return !(e == v);
        }
        public static Estacionamiento operator +(Estacionamiento e, Vehiculo v)
        {
            if (e != v && v.Patente != "" && e.espacioDisponible > e.vehiculos.Count)
            {
                e.vehiculos.Add(v);
            }
            return e;
        }
        public static string operator -(Estacionamiento e, Vehiculo v)
        {
            if (e == v)
            {
                e.vehiculos.Remove(v);
                return v.ImprimirTicket();
            }
            return "El vehiculo no es parte del estacionamiento";
        }
    }
}
