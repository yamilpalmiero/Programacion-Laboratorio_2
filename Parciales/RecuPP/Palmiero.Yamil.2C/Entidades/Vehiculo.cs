using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        public enum EVehiculos
        {
            Automovil,
            Moto
        }

        private DateTime horaEgreso;
        private DateTime horaIngreso;
        private string patente;

        public Vehiculo(string patente, DateTime horaIngreso)
        {
            this.patente = this.Patente;
            this.horaIngreso = horaIngreso;
        }

        public abstract double CostoEstadia { get; }

        public abstract string Descripcion { get; }

        public DateTime HoraEgreso
        {
            get
            {
                return this.horaEgreso;
            }
            set
            {
                if (value >= this.HoraIngreso)
                {
                    this.horaEgreso = value;
                }
            }
        }
        public DateTime HoraIngreso
        {
            get
            {
                return this.horaIngreso;
            }
        }
        public string Patente
        {
            get
            {
                return this.patente;
            }
            set
            {
                if (ValidarPatente(value))
                {
                    this.patente = value;
                }
            }
        }

        protected virtual double CargoDeEstacionamiento()
        {
            return this.HoraEgreso.Ticks - this.HoraIngreso.Ticks;
        }

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Patente: {this.Patente}\nHora ingreso: {this.HoraIngreso}");
            return sb.ToString();
        }

        private bool ValidarPatente(string patente)
        {
            bool retorno = false;

            if (patente.Length == 6 || patente.Length == 7)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
