using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private string nombre;
        private int numero;


        public Cliente()
        {

        }
        public Cliente(string nombre)
        {
            this.nombre = nombre;
        }


        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public int Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }
    }
}
