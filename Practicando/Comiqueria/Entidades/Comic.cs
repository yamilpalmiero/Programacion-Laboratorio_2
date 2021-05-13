﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comic : Publicacion
    {
        private bool esColor;

        public Comic(string nombre, bool esColor, int stock, float valor) : base(nombre, stock, valor)
        {
            this.esColor = esColor;//this.EsColor?
        }

        protected override bool EsColor
        {
            get
            {
                return this.esColor;
            }
        }
    }
}
