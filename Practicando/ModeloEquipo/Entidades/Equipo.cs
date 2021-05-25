using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }
        public Equipo(string nombre)
            : this()
        {
            this.nombre = nombre;
        }

        public DirectorTecnico DirectorTecnico
        {
            set
            {
                if (value.ValidarAptitud())
                {
                    this.directorTecnico = value;
                }
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public static bool ValidarEquipo(Equipo e)
        {
            bool retorno = false;

            short cantidadDefensores = 0;
            short cantidadCentrales = 0;
            short cantidadDelanteros = 0;
            short cantidadArqueros = 0;

            if (e.directorTecnico != null)
            {
                foreach (Jugador j in e.jugadores)
                {
                    switch (j.Posicion)
                    {
                        case Posicion.Arquero:
                            cantidadArqueros++;
                            break;
                        case Posicion.Defensor:
                            cantidadDefensores++;
                            break;
                        case Posicion.Central:
                            cantidadCentrales++;
                            break;
                        case Posicion.Delantero:
                            cantidadDelanteros++;
                            break;
                    }
                }

                if (e.jugadores.Count == cantidadMaximaJugadores)
                {
                    if (cantidadArqueros == 1 && cantidadCentrales > 0 && cantidadDefensores > 0 && cantidadDelanteros > 0)
                    {
                        retorno = true;
                    }
                }
            }

            return retorno;
        }

        public static explicit operator string(Equipo e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {e.Nombre}");
            sb.AppendLine($"Jugadores:");
            foreach (Jugador j in e.jugadores)
            {
                sb.AppendLine(j.Mostrar());
            }

            if (e.directorTecnico is null)
            {
                sb.AppendLine($"DT: Sin DT asignado");
            }
            else
            {
                sb.AppendLine($"DT: {e.directorTecnico.Mostrar()}");
            }

            return sb.ToString();
        }
        public static bool operator ==(Equipo e, Jugador j)
        {
            bool retorno = false;

            if (e.jugadores.Contains(j))
            {
                retorno = true;
            }
            /*
             * foreach (Jugador item in e.jugadores)
            {
                if ((item != j))
                {
                    retorno = false;
                }
                else
                {
                    retorno = true;
                }
            }
            */
            return retorno;
        }
        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }
        public static Equipo operator +(Equipo e, Jugador j)
        {
            if (e != j && e.jugadores.Count < Equipo.cantidadMaximaJugadores && j.ValidarAptitud())
            {
                e.jugadores.Add(j);
            }

            return e;
        }
    }
}
