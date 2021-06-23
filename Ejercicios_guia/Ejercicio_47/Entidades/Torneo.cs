using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Torneo<T> where T : Equipo
    {
        private List<T> equipos;
        private string nombre;

        Random random = new Random();

        private Torneo()
        {
            this.equipos = new List<T>();
        }
        public Torneo(string nombre)
            : this()
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            bool retorno = false;

            foreach (T item in torneo.equipos)
            {
                if (item == equipo)
                {
                    retorno = true;
                }
            }

            return retorno;
        }
        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }
        public static Torneo<T> operator +(Torneo<T> torneo, T equipo)
        {
            if (torneo != equipo)
                torneo.equipos.Add(equipo);

            return torneo;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Torneo: {this.nombre}");
            sb.AppendLine("Participantes:");
            foreach (T item in this.equipos)
            {
                sb.AppendLine(item.Ficha());
            }

            return sb.ToString();
        }

        private string CalcularPartido(T e1, T e2)
        {
            int scoreE1 = random.Next(0, 5);
            int scoreE2 = random.Next(0, 5);

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{e1.Nombre} ({scoreE1}) - ({scoreE2}) {e2.Nombre}");

            return sb.ToString();
        }

        public string JugarPartido
        {
            get
            {
                int index1 = random.Next(0, this.equipos.Count - 1);
                int index2 = random.Next(0, this.equipos.Count - 1);

                StringBuilder sb = new StringBuilder();

                sb.AppendLine(CalcularPartido(this.equipos[index1], this.equipos[index2]));

                return sb.ToString();
            }
        }
    }
}
