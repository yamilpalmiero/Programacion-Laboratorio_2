using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Marvel
    {
        /// <summary>
        /// No podra tener clases heredadas
        /// </summary>
        private static List<Personaje> listaPersonajes;

        /// <summary>
        /// Constructor estatico que instancia la lista de personajes
        /// </summary>
        static Marvel()
        {
            Marvel.listaPersonajes = new List<Personaje>();
        }

        /// <summary>
        /// Propiedad que agrega un personaje en la lista, siempre que este no exista
        /// </summary>
        public static Personaje Personaje
        {
            set
            {
                if (listaPersonajes != value)
                {
                    listaPersonajes += value;
                }
            }
        }

        /// <summary>
        /// Metodo que muestra la informacion completa del personaje, ya sea Avenger o Enemigo
        /// </summary>
        /// <returns>Datos completos del personaje</returns>
        public static string MostrarInformacion()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Personaje p in listaPersonajes)
            {
                if (p is Avenger)
                {
                    sb.AppendLine("*****AVENGER*****");
                    sb.AppendLine(p.ToString());
                }
                else
                {
                    sb.AppendLine("*****ENEMIGO*****");
                    sb.AppendLine(p.ToString());
                }
            }
            return sb.ToString();
        }
    }
}
