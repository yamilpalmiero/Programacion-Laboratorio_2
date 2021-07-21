﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    [Serializable]//Esta etiqueta es para serializar a Binario
    public class Persona
    {
        private string nombre;
        private string apellido;



        public Persona()
        {

        }
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }




        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }



        public override string ToString()
        {
            return $"Se llama {this.Nombre} {this.Apellido}";
        }
    }
}
