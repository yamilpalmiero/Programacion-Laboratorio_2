using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente
    {
        private string apellido;
        private string nombre;
        private int turno;


        public Paciente(int turno, string nombre, string apellido)
        {
            this.turno = turno;
            this.nombre = nombre;
            this.apellido = apellido;
        }


        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public int Turno
        {
            get { return this.turno; }
            set { this.turno = value; }
        }


        public override string ToString()
        {
            return $"{this.Apellido}, {this.Nombre}";
        }
    }
}
