using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        private int legajo;
        private List<string> materias;

        public Alumno(string nombre, string apellido, long dni, int legajo) : base(nombre, apellido, dni)
        {
            this.legajo = legajo;
            this.materias = new List<string>();
        }

        public string Estudiar()
        {
            return "Estoy estudiando";
        }

        public string MostrarAlumno()
        {
            return string.Format(base.MostrarPersona() + "\nLegajo: {0}", this.legajo);
        }
    }
}
