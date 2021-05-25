using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        private short anio;
        private Divisiones division;

        public Alumno(string nombre, string apellido, string documento, short anio, Divisiones division)
            : base(nombre, apellido, documento)
        {
            this.anio = anio;
            this.division = division;
        }

        public string AnioDivision
        {
            get
            {
                return $"{this.anio}°{this.division}";
            }
        }

        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ExponerDatos());
            sb.Append($"Curso: {this.AnioDivision}");
            return sb.ToString();
        }

        protected override bool ValidarDocumentacion(string doc)
        {
            bool retorno = false;

            if (doc.Length == 9 && doc[2] == '-' && doc[7] == '-')//Formato valido XX-XXXX-X
            {
                foreach (char c in doc)
                {
                    if (!char.IsDigit(c))//Si los digitos no son numeros
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
