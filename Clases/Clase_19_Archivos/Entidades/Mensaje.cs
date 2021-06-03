using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mensaje
    {
        public string envia;
        public string recibe;
        public string mensaje;

        public Mensaje(string envia, string recibe, string mensaje)
        {
            this.envia = envia;
            this.recibe = recibe;
            this.mensaje = mensaje;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Emisor: {this.envia}\nReceptor: {this.recibe}\n\nMensaje:\n{this.mensaje}");
            return sb.ToString();
        }
    }
}
