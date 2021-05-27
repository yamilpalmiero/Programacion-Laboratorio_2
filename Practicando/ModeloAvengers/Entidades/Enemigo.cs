using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Enemigo : Personaje
    {
        private string objetivo;
        public Enemigo(string nombre, List<EHabilidades> hab, string objetivo)
            : base(nombre, hab)
        {
            this.objetivo = objetivo;
        }

        protected override string Nombre
        {
            get
            {
                return $"Soy {this.nombre} y los voy a hacer puré.\n";
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"Equipamiento principal: {this.objetivo}");
            return sb.ToString();
        }
    }
}
