using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        public enum ETipo
        {
            Ciclomotor,
            Scooter,
            Sport
        }

        private ETipo tipo;
        private static double valorHora;

        static Moto()
        {
            Moto.valorHora = 100;
        }
        public Moto(string patente, DateTime horaIngreso, ETipo tipo)
            : base(patente, horaIngreso)
        {
            this.tipo = tipo;
        }

        public override double CostoEstadia
        {
            get
            {
                return this.CargoDeEstacionamiento();
            }
        }
        public override string Descripcion
        {
            get
            {
                return this.tipo.ToString();
            }
        }
        public static double ValorHora
        {
            set
            {
                if (value > 0)
                {
                    Moto.valorHora = value;
                }
            }
        }

        protected override double CargoDeEstacionamiento()
        {
            return Moto.valorHora * (this.HoraEgreso.Ticks - this.HoraIngreso.Ticks);
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("*****MOTO*****");
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine(this.ToString());
            return sb.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Tipo: {this.tipo.ToString()}\nValor por hora: ${Moto.valorHora}\nHora salida: {this.HoraEgreso}\nTotal: ${this.CostoEstadia}");
            return sb.ToString();
        }
    }
}
