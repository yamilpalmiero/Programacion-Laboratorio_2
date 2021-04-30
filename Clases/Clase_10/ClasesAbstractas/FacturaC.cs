using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    public class FacturaC : Factura
    {
        #region Atributos
        #endregion

        #region Constructor
        public FacturaC(string nombre, string cuit) : base(nombre, cuit)
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
            return "FacturaC-CUIT:" + this.RetornarNumeroDeCuit();
        }
        #endregion
    }
}
