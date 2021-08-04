using System;

namespace Entidades
{
    public class BomberoOcupadoException : Exception
    {
        public BomberoOcupadoException()
        {

        }
        public BomberoOcupadoException(string mensaje)
            : base(mensaje)
        {

        }
        public BomberoOcupadoException(string mensaje, Exception inner)
            : base(mensaje, inner)
        {

        }
    }
}
