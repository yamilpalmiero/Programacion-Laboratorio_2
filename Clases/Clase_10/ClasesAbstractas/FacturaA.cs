using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    public class FacturaA : Factura
    {
        #region Atributos
        protected float importeSinIVA;
        #endregion

        #region Constructor
        public FacturaA(string nombre, string cuit):base(nombre, cuit)
        {

        }
        #endregion

        #region Propiedades
        public float ImporteSinIVA
        {
            get
            {
                return this.importeSinIVA;
            }
            set
            {
                this.importeSinIVA = value;
            }
        }

        public override int NumeroDeFactura
        {
            get
            {
                return base.numeroDeFactura;
            }
            set
            {

            }
        }
        #endregion

        #region Metodos
        public string RetornarDatosCliente()
        {
            return this.nombreCliente;
        }

        public override string RetornarDatosCompletos()
        {
            throw new NotImplementedException();
        }

        public override string RetornarNumeroDeCuit()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Numero de CUIT: {0}", base.RetornarNumeroDeCuit());
            return sb.ToString();
        }
        #endregion
    }
}
