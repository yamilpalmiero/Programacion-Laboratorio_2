using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    public class FacturaB : Factura
    {
        #region Atributos
        #endregion

        #region Constructor
        public FacturaB(string nombre, string cuit) : base(nombre, cuit)
        {

        }
        #endregion

        #region Propiedades
        #endregion

        #region Metodos
        public string RetornarDatosCliente()
        {
            return this.nombreCliente;
        }

        public override string RetornarNumeroDeCuit()
        {
            return base.RetornarNumeroDeCuit();//Llamar a la funcionalidad del base. Esto aparece por defecto
            //return this.cuitEmisor;
        }
        #endregion
    }
}
