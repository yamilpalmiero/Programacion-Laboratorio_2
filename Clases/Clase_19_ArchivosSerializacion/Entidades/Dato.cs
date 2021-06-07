using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Dato//La clase debe ser publica
    {
        //Los atributos deben ser publicos
        public string nombre;
        public int edad;

        //Debe tener un constructor por default
        public Dato()
        {

        }
        public Dato(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        //Los metodos NO SE SERIALIZAN
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Edad: {this.edad}");

            return sb.ToString();
        }
    }
}
