using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Avenger : Personaje
    {
        private EEquipamiento equipamiento;

        public Avenger(string nombre, List<EHabilidades> hab, EEquipamiento equipo)
            : base(nombre, hab)
        {
            this.equipamiento = equipo;
        }

        protected override string Nombre
        {
            get
            {
                return $"Mi nombre es {this.nombre} y si no puedo proteger la Tierra, la vengaré.\n";
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"Equipamiento principal: {this.equipamiento}");
            return sb.ToString();
        }
    }
}
