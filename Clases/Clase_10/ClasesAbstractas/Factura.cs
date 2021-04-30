using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    public abstract class Factura
    {
        #region Atributos
        protected string nombreCliente;
        protected float precioFinal;
        protected int numeroDeFactura;
        protected string cuitEmisor;
        #endregion

        #region Constructores
        public Factura (string nombreCliente, string numeroCUIT)
        {
            this.nombreCliente = nombreCliente;
            this.cuitEmisor = numeroCUIT;
        }
        #endregion

        #region Propiedades
        public string NombreCliente
        {
            get
            {
                return this.nombreCliente;
            }
            set
            {
                this.nombreCliente = value;
            }
        }

        public float PrecioFinal
        {
            get
            {
                return this.precioFinal;
            }
            set
            {
                this.precioFinal = value;
            }
        }

        public abstract int NumeroDeFactura { get; set; }
        #endregion

        #region Metodos
        public string RetornarDatosCliente()
        {
            return this.nombreCliente;
        }

        public abstract string RetornarDatosCompletos();

        public virtual string RetornarNumeroDeCuit()
        {
            return this.cuitEmisor;
        }
        #endregion
    }
}
