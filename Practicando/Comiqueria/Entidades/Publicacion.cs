using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Publicacion
    {
        protected float importe;
        protected string nombre;
        protected int stock;

        public Publicacion(string nombre)
        {
            this.nombre = nombre;
        }
        public Publicacion(string nombre, int stock) : this(nombre)
        {
            this.stock = stock;
        }
        public Publicacion(string nombre, int stock, float importe) : this(nombre, stock)
        {
            this.importe = importe;
        }

        protected abstract bool EsColor { get; }

        public virtual bool HayStock
        {
            get
            {
                if (this.importe > 0 && this.stock > 0)//this.Importe? this.Stock?
                {
                    return true;
                }
                return false;
            }
        }

        public float Importe
        {
            get
            {
                return this.importe;
            }
        }

        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                if (value > 0)
                {
                    this.stock = value;
                }
            }
        }

        public string Informacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(String.Format("Nombre: {0}\n", this.nombre));
            sb.AppendLine(String.Format("Stock: {0}", this.stock));
            sb.AppendFormat("Color: {0}\n", this.EsColor);
            sb.AppendLine(String.Format("Valor: ${0:0.00}", this.importe));

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.nombre;
        }
    }
}
