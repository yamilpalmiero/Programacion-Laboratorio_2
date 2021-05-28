using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private int capacidadEstacionamiento;
        private static Estacionamiento estacionamiento;
        private List<Vehiculo> listadoVehiculos;
        private string nombre;

        private Estacionamiento(string nombre, int capacidad)
        {
            this.nombre = nombre;
            this.capacidadEstacionamiento = capacidad;
            this.listadoVehiculos = new List<Vehiculo>();
        }

        public List<Vehiculo> ListadoVehiculos
        {
            get
            {
                return this.listadoVehiculos;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string InformarSalida(Vehiculo vehiculo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.Nombre}\nDatos del vehiculo: {vehiculo.ToString()}\nHora de salida: {vehiculo.HoraEgreso}\nCargo: {vehiculo.CostoEstadia}");
            return sb.ToString();
        }

        public static Estacionamiento GetEstacionamiento(string nombre, int capacidad)
        {
            if (Estacionamiento.estacionamiento is null)
            {
                Estacionamiento.estacionamiento = new Estacionamiento(nombre, capacidad);
            }
            else
            {
                Estacionamiento.estacionamiento.capacidadEstacionamiento--;
            }
            return Estacionamiento.estacionamiento;
        }

        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            bool retorno = false;

            if (estacionamiento.ListadoVehiculos.Contains(vehiculo))
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return !(estacionamiento == vehiculo);
        }
        public static bool operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            bool retorno = false;
            if (estacionamiento != vehiculo && estacionamiento.capacidadEstacionamiento > estacionamiento.ListadoVehiculos.Count)
            {
                estacionamiento.ListadoVehiculos.Add(vehiculo);
                retorno = true;
            }
            return retorno;
        }
        public static bool operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            bool retorno = false;

            if (estacionamiento == vehiculo)
            {
                vehiculo.HoraEgreso = DateTime.Now;
                estacionamiento.ListadoVehiculos.Remove(vehiculo);
                retorno = true;
            }
            return retorno;
        }
    }
}
