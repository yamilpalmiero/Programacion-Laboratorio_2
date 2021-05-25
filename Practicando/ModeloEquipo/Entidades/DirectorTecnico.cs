using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private int aniosExperiencia;

        public DirectorTecnico(string nombre, string apellido, int edad, int dni, int aniosExperiencia)
            : base(nombre, apellido, edad, dni)
        {
            this.aniosExperiencia = aniosExperiencia;
        }

        public int AniosExperiencia
        {
            get
            {
                return this.aniosExperiencia;
            }
            set
            {
                this.aniosExperiencia = value;
            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.Append($"Años de experiencia: {this.AniosExperiencia}");
            return sb.ToString();
        }

        public override bool ValidarAptitud()
        {
            bool retorno = false;

            if (this.Edad < 65 && this.AniosExperiencia >= 2)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
