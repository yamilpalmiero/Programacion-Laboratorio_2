using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        private float altura;
        private float peso;
        private Posicion posicion;

        public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura, Posicion posicion)
            : base(nombre, apellido, edad, dni)
        {
            this.peso = peso;
            this.altura = altura;
            this.posicion = posicion;
        }

        public float Altura
        {
            get
            {
                return this.altura;
            }
        }
        public float Peso
        {
            get
            {
                return this.peso;
            }
        }
        public Posicion Posicion
        {
            get
            {
                return this.posicion;
            }
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.Append($"Peso: {this.Peso}\nAltura: {this.Altura}\nPosicion: {this.Posicion}");
            return sb.ToString();
        }

        public bool ValidarEstadoFisico()
        {
            bool retorno = false;
            float IMC = (float)this.Peso / (this.Altura * this.Altura);

            if (IMC >= 18.5 && IMC <= 25)
            {
                retorno = true;
            }

            return retorno;
        }

        public override bool ValidarAptitud()
        {
            bool retorno = false;

            if (this.ValidarEstadoFisico())
            {
                if (this.Edad <= 40)
                {
                    retorno = true;
                }
            }

            return retorno;
        }
    }
}
