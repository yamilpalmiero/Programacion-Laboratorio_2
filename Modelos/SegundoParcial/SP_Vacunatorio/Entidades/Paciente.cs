using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente
    {
        private string nombre;
        private string apellido;
        private int turno;

        public Paciente(int turno, string nombre, string apellido)
        {
            this.turno = turno;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }
        public int Turno
        {
            get { return this.turno; }
            set { this.turno = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.Apellido}, {this.Nombre}");

            return sb.ToString();
        }
    }
}
