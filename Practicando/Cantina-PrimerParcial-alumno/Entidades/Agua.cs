using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agua : Botella
    {
        #region Atributos
        private const int MEDIDA = 400;
        #endregion

        #region Constructor
        public Agua(int capacidadML, string marca, int contenidoML) : base(marca, capacidadML, contenidoML)
        {

        }
        #endregion

        #region Metodos
        protected override string GenerarInforme()
        {
            int descuento;
            return this.GenerarInforme();
        }
        public int ServirMedida(int medida)
        {

            if (medida <= this.contenidoML)
            {
                return medida;
            }
            base.contenidoML
            return this.contenidoML;
        }
        public override int ServirMedida()
        {
            return ServirMedida(MEDIDA);
        }
        #endregion
    }
}
