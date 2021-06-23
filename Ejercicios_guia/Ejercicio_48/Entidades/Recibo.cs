﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Recibo : Documento
    {
        public Recibo(int numero)
            : base(numero)
        {

        }
        public Recibo()
            : this(0)
        {

        }
    }
}
