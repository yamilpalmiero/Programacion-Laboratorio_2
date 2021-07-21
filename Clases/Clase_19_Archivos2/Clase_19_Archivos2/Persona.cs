using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;

        public Persona()
        {

        }

        public Persona(string nombre, string apellido, DateTime fecha)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fecha;
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
        public DateTime FechaNacimiento
        {
            get { return this.fechaNacimiento; }
            set { this.fechaNacimiento = value; }
        }

    }
}
