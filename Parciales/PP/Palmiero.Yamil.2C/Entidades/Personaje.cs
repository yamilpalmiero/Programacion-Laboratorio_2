using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Personaje
    {
        /// <summary>
        /// La clase Personaje no deberá permitir que se instancien elementos de este tipo
        /// </summary>
        public enum EHabilidades
        {
            Volar,
            SuperFuerza,
            Resistencia,
            Rayos,
            Energia,
            InteligenciaSuperior,
            Sigilo,
            Astucia
        }
        public enum EEquipamiento
        {
            Armadura,
            Escudo,
            Martillo,
            Arco,
            Transformacion,
            ArtesMarciales
        }

        private List<EHabilidades> listaHabilidades;
        protected string nombre;

        /// <summary>
        /// Constructor privado donde se instancia la lista de habilidades
        /// </summary>
        private Personaje()
        {
            this.listaHabilidades = new List<EHabilidades>();
        }
        /// <summary>
        /// Constructor del Personaje con parametros nombre y habilidad
        /// </summary>
        /// <param name="nombre">Nombre</param>
        /// <param name="habilidades">Habilidad</param>
        public Personaje(string nombre, List<EHabilidades> habilidades) : this()
        {
            this.nombre = nombre;
            this.listaHabilidades = habilidades;
        }

        /// <summary>
        /// Propiedad de solo lectura que muestra todas las habilidades del personaje
        /// </summary>
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

        /// <summary>
        /// Propiedad de solo lectura que devuelve el nombre del personaje
        /// </summary>
        protected virtual string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        /// <summary>
        /// Polimorfismo del metodo ToString() que devuelve todos los datos de ese personaje
        /// </summary>
        /// <returns></returns>
        public virtual string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(String.Format(this.Nombre));
            sb.AppendLine("");
            sb.Append(String.Format(this.ListaHabilidades));

            return sb.ToString();
        }

        /// <summary>
        /// Sobrecarga del operador == que compara nombre y tipo de objeto para ver si un personaje si esta en la lista
        /// </summary>
        /// <param name="listaPersonajes">Lista de los personajes</param>
        /// <param name="personaje">Personaje</param>
        /// <returns>True si el personaje esta en la lista. False si no esta</returns>
        public static bool operator ==(List<Personaje> listaPersonajes, Personaje personaje)
        {
            foreach (Personaje p in listaPersonajes)
            {
                if (personaje.Nombre.Equals(p.Nombre) &&
                    personaje.GetType() == p.GetType())
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Sobrecarga del operador != que compara nombre y tipo de objeto para ver si un personaje no esta en la lista
        /// </summary>
        /// <param name="listaPersonajes">Lista de personajes</param>
        /// <param name="personaje">Personaje</param>
        /// <returns>True si el personaje no esta en la lista. False si si esta</returns>
        public static bool operator !=(List<Personaje> listaPersonajes, Personaje personaje)
        {
            return !(listaPersonajes == personaje);
        }
        /// <summary>
        /// Sobrecarga del operador + para agregar, o no, un personaje a la lista
        /// </summary>
        /// <param name="listaPersonajes">Lista de personajes</param>
        /// <param name="personaje">Personaje a agregar</param>
        /// <returns>La lista de personajes actualizada</returns>
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
