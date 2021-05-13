using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor
    {
        private string nombre;
        private List<Publicacion> ventas;

        private Vendedor()
        {
            this.ventas = new List<Publicacion>();
        }
        public Vendedor(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static string InformeDeVentas(Vendedor v)
        {
            StringBuilder sb = new StringBuilder();
            float ganancia = 0;

            sb.AppendLine(v.nombre);
            sb.AppendLine("-----------------------------");
            foreach (Publicacion publicacion in v.ventas)
            {
                sb.AppendLine(publicacion.Informacion());
                sb.AppendLine("-----------------------------");
                ganancia += publicacion.Importe;
            }
            sb.AppendLine(String.Format("\n\nGanancia Total: ${0:0.00}", ganancia));

            return sb.ToString();
        }

        public static bool operator +(Vendedor v, Publicacion p)
        {
            if (p.HayStock)
            {
                v.ventas.Add(p);
                p.Stock--;
                return true;
            }
            return false;
        }
    }
}
