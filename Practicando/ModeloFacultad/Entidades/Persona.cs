using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private string documento;
        private string nombre;

        public Persona(string nombre, string apellido, string documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.documento = documento;
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }
        public string Documento
        {
            get
            {
                return this.documento;
            }
            set
            {
                this.documento = value;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public virtual string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Nombre completo: {Nombre} {Apellido}\nDNI: {Documento}");
            return sb.ToString();
        }

        protected abstract bool ValidarDocumentacion(string doc);
    }
}
