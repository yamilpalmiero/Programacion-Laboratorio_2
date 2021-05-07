using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza : Botella
    {
        #region Atributos
        private const int MEDIDA = 330;
        private Tipo tipo;
        #endregion

        #region Constructores
        public Cerveza(int capacidadML, string marca, int contenidoML) :base(marca, capacidadML, contenidoML)
        {
            this.tipo = tipo;
        }
        public Cerveza(int capacidadML, string marca, Tipo tipo, int contenido)
        #endregion
    }
}
