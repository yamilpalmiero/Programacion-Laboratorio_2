using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;
        private IAcciones iAcciones;

        public Lapiz(int unidades)
        {
            iAcciones = this;
            iAcciones.UnidadesDeEscritura = unidades;
        }

        ConsoleColor IAcciones.Color
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        float IAcciones.UnidadesDeEscritura
        {
            get
            {
                return this.tamanioMina;
            }
            set
            {
                this.tamanioMina = value;
            }
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            iAcciones = this;

            if (this.tamanioMina >= 0.1f * texto.Length)
            {
                this.tamanioMina -= 0.1f * texto.Length;
            }

            return new EscrituraWrapper(texto, this.iAcciones.Color);
        }
        bool IAcciones.Recargar(int unidades)
        {
            iAcciones = this;
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            iAcciones = this;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Es un Lapiz");
            sb.AppendLine($"El color es: {this.iAcciones.Color}");
            sb.AppendLine($"El tamaño de mina es: {this.iAcciones.UnidadesDeEscritura}");

            return sb.ToString();
        }
    }
}
