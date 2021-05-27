using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Personaje
    {
        private List<EHabilidades> listaHabilidades;
        protected string nombre;

        private Personaje()
        {
            this.listaHabilidades = new List<EHabilidades>();
        }
        public Personaje(string nombre, List<EHabilidades> habilidades)
            : this()
        {
            this.nombre = nombre;
            this.listaHabilidades = habilidades;
        }

        private string ListaHabilidades
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Habilidades:");
                foreach (EHabilidades habilidad in listaHabilidades)
                {
                    sb.AppendLine(habilidad.ToString());
                }
                return sb.ToString();
            }
        }
        protected virtual string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine(this.ListaHabilidades);
            return sb.ToString();
        }

        public static bool operator ==(List<Personaje> listaPersonajes, Personaje personaje)
        {
            bool retorno = false;

            foreach (Personaje p in listaPersonajes)
            {
                if (p.Nombre.Equals(personaje.Nombre) && p.GetType() == personaje.GetType())
                {
                    retorno = true;
                }
            }

            return retorno;
        }
        public static bool operator !=(List<Personaje> listaPersonajes, Personaje personaje)
        {
            return !(listaPersonajes == personaje);
        }
        public static List<Personaje> operator +(List<Personaje> listaPersonajes, Personaje personaje)
        {
            if (listaPersonajes != personaje)
            {
                listaPersonajes.Add(personaje);
            }

            return listaPersonajes;
        }
    }
}
