using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Enemigo : Personaje
    {
        private string objetivo;

        /// <summary>
        /// Constructor de Enemigo con parametros nombre, habilidad y objetivo
        /// </summary>
        /// <param name="nombre">Nombre</param>
        /// <param name="hab">Habilidad</param>
        /// <param name="objetivo">Objetivo</param>
        public Enemigo(string nombre, List<EHabilidades> hab, string objetivo) : base(nombre, hab)
        {
            this.objetivo = objetivo;
        }

        /// <summary>
        /// Propiedad de solo lectura que retorna el nombre del Enemigo más un mensaje
        /// </summary>
        protected override string Nombre
        {
            get
            {
                return $"Soy {this.nombre} y los voy a ahcer puré";
            }
        }

        /// <summary>
        /// Polimorfismo del metodo ToString() que devuelve todos los datos de ese Enemigo
        /// </summary>
        /// <returns>Datos del Enemigo</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine(this.objetivo);
            sb.AppendLine("");

            return sb.ToString();
        }
    }
}
