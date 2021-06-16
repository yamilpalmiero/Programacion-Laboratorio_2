using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        #region Enumerado
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
        #endregion

        #region Atributos
        protected Franja franjaHoraria;
        #endregion

        #region Constructores
        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }
        public Provincial(Franja miFranja, Llamada llamada)
            : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {

        }
        #endregion

        #region Propiedades
        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        #endregion

        #region Metodos
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Costo: ${this.CostoLlamada.ToString()}");
            sb.AppendLine("Franja horaria: " + this.franjaHoraria.ToString());

            return sb.ToString();
        }
        private float CalcularCosto()
        {
            float costo = 0;

            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    costo = 0.99f;
                    break;
                case Franja.Franja_2:
                    costo = 1.25f;
                    break;
                default:
                    costo = 0.66f;
                    break;
            }

            return costo * this.duracion;
        }
        #endregion
    }
}
