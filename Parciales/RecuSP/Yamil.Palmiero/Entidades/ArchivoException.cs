﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ArchivoException : Exception
    {
        public ArchivoException()
        {

        }
        public ArchivoException(string mensaje)
            : base(mensaje)
        {

        }
        public ArchivoException(string mensaje, Exception inner)
            : base(mensaje, inner)
        {

        }
    }
}
