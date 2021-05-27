using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Marvel
    {
        private static List<Personaje> listaPersonajes;

        static Marvel()
        {
            Marvel.listaPersonajes = new List<Personaje>();
        }

        public static Personaje Personaje
        {
            set
            {
                if (listaPersonajes != value)
                {
                    Marvel.listaPersonajes += value;
                }
            }
        }

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
