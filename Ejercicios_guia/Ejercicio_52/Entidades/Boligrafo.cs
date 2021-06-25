using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public ConsoleColor Color
        {
            get
            {
                return this.colorTinta;
            }
            set
            {
                this.colorTinta = value;
            }
        }
        public float UnidadesDeEscritura
        {
            get
            {
                return this.tinta;
            }
            set
            {
                this.tinta = value;
            }
        }

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.tinta = unidades;
            this.colorTinta = color;
        }

        public EscrituraWrapper Escribir(string texto)
        {
            if (this.tinta >= 0.3f * texto.Length)
            {
                this.tinta -= 0.3f * texto.Length;
                return new EscrituraWrapper(texto, this.Color);
            }

            return null;
        }
        public bool Recargar(int unidades)
        {
            this.tinta += unidades;

            return true;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Es un Boligrafo");
            sb.AppendLine($"El color es: {this.Color}");
            sb.AppendLine($"El nivel de tinta es: {this.UnidadesDeEscritura}");

            return sb.ToString();
        }
    }
}
