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
        private int edad;



        public Persona()
        {

        }
        public Persona(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
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
        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }




        public override string ToString()
        {
            return $"\nDatos de la persona:\n{this.Nombre}\n{this.Apellido}\n{this.Edad} años";
        }
    }
}
