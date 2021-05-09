using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        #region Atributos
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;
        #endregion

        #region Constructores
        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa)
            : this()
        {
            this.razonSocial = nombreEmpresa;
        }
        #endregion

        #region Propiedades
        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }
        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }
        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }
        #endregion

        #region Metodos
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float totalLocal = 0;
            float totalProvincial = 0;

            foreach (Llamada llamada in this.listaDeLlamadas)
            {
                if (llamada is Local)
                {
                    totalLocal += ((Local)llamada).CostoLLamada;
                }
                if (llamada is Provincial)
                {
                    totalProvincial += ((Provincial)llamada).CostoLlamada;
                }
            }

            switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                    return totalLocal;
                case Llamada.TipoLlamada.Provincial:
                    return totalProvincial;
                case Llamada.TipoLlamada.Todas:
                    return totalLocal + totalProvincial;
                default:
                    return 0;
            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Empresa: {this.razonSocial}");
            sb.AppendLine($"Ganacia total: {this.CalcularGanancia(Llamada.TipoLlamada.Todas)}");
            sb.AppendLine($"Ganancia por llamados locales: {this.CalcularGanancia(Llamada.TipoLlamada.Local)}");
            sb.AppendLine($"Ganancia por llamados provinciales: {this.CalcularGanancia(Llamada.TipoLlamada.Provincial)}");
            sb.AppendLine($"Detalle de llamada:");
            foreach (Llamada llamada in Llamadas)
            {
                sb.AppendLine($"{llamada.Mostrar()}");
            }

            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }
        #endregion
    }
}
