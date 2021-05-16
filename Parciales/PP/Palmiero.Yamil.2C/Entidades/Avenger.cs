using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Avenger : Personaje
    {
        private EEquipamiento equipamiento;

        /// <summary>
        /// Constructor del Avenger con parametros nombre, habiliad y equipamiento
        /// </summary>
        /// <param name="nombre">Nombre</param>
        /// <param name="hab">Habilidad</param>
        /// <param name="equipo">Equipamiento</param>
        public Avenger(string nombre, List<EHabilidades> hab, EEquipamiento equipo) : base(nombre, hab)
        {
            this.equipamiento = equipo;
        }

        /// <summary>
        /// Propiedad de solo lectura que retorna el nombre del Avenger más un mensaje
        /// </summary>
        protected override string Nombre
        {
            get
            {
                return String.Format("Mi nombre es {0} y si no puedo proteger la tierra, la vengaré", this.nombre);
            }
        }

        /// <summary>
        /// Polimorfismo del metodo ToString() que devuelve todos los datos de ese Avenger
        /// </summary>
        /// <returns>Datos del Avenger</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine("Equipamiento principal: " + this.equipamiento.ToString());
            sb.AppendLine("");

            return sb.ToString();
        }
    }
}
