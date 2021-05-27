using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PickUp : Vehiculo
    {
        private string modelo;
        private static int valorHora;

        static PickUp()
        {
            PickUp.valorHora = 70;
        }
        public PickUp(string patente, string modelo)
            : base(patente)
        {
            this.modelo = modelo;
        }
        public PickUp(string patente, string modelo, int valorHora)
            : this(patente, modelo)
        {
            PickUp.valorHora = valorHora;
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.Append($"Modelo: {this.modelo}\nValor por hora: ${PickUp.valorHora}");
            return sb.ToString();
        }

        public override string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.ConsultarDatos());
            sb.AppendLine($"Costo estadía: ${valorHora * (DateTime.Now.Hour - base.ingreso.Hour)}");
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is PickUp;
        }
    }
}
