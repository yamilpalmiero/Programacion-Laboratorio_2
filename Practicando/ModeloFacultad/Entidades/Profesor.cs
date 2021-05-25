using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        private DateTime fechaIngreso;

        public Profesor(string nombre, string apellido, string documento)
            : base(nombre, apellido, documento)
        {

        }
        public Profesor(string nombre, string apellido, string documento, DateTime fechaIngreso)
            : this(nombre, apellido, documento)
        {
            this.fechaIngreso = fechaIngreso;
        }

        public int Antiguedad
        {
            get
            {
                return DateTime.Now.Subtract(fechaIngreso).Days;
            }
        }

        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ExponerDatos());
            sb.Append($"Antigüedad: {Antiguedad.ToString()}");
            return sb.ToString();
        }

        protected override bool ValidarDocumentacion(string doc)
        {
            bool retorno = false;

            if (doc.Length == 9)
            {
                foreach (char c in doc)
                {
                    if (!(char.IsDigit(c)))
                    {
                        return retorno;
                    }
                }
                retorno = true;
            }

            return retorno;
        }
    }
}
