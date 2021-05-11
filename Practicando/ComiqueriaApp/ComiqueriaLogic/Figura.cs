﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Figura : Producto
    {
        #region Atributos
        private double altura;
        #endregion

        #region Constructores
        public Figura(string descripcion, int stock, double precio, double altura)
            : base(descripcion, stock, precio)
        {
            this.altura = altura;
        }
        public Figura(int stock, double precio, double altura)
            : this(String.Format("Figura {0} cm", altura), stock, precio, altura)
        {

        }
        #endregion

        #region Polimorfismo ToString
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine(String.Format("Altura: {0}", this.altura));

            return sb.ToString();
        }
        #endregion
    }
}
