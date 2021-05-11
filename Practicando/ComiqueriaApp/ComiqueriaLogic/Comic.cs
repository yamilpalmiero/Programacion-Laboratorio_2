﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comic : Producto
    {
        #region Enmumerado
        public enum TipoComic
        {
            Occidental,
            Oriental
        }
        #endregion

        #region Atributos
        private string autor;
        private TipoComic tipoComic;
        #endregion

        #region Constructor
        public Comic(string descripcion, int stock, double precio, string autor, TipoComic tipoComic)
            : base(descripcion, stock, precio)
        {
            this.autor = autor;
            this.tipoComic = tipoComic;
        }
        #endregion

        #region Polimorfismo ToString
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine(String.Format("Autor: {0}", this.autor));
            sb.AppendLine(String.Format("Tipo de Comic: {0}", this.tipoComic));

            return sb.ToString();
        }
        #endregion
    }
}
