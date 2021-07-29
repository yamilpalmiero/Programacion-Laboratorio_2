using System;
using System.Text;

namespace Entidades
{
    [Serializable]
    public class Paciente
    {
        private string nombre;
        private string apellido;
        private int turno;

        public Paciente()
        {

        }

        public Paciente(string nombre, string apellido, int turno)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.turno = turno;
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
