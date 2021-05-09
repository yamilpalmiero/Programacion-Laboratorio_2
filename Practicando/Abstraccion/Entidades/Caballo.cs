using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Caballo : Transporte
    {
        #region Atributos
        public string raza;
        public Colores color;
        #endregion

        #region Constructor
        public Caballo(byte cantidadPasajeros, Velocidades velocidad, string raza, Colores color) : base(cantidadPasajeros, velocidad)
        {
            this.raza = raza;
            this.color = color;
        }
        #endregion

        #region Metodos
        public override void Frenar()
        {
            Console.WriteLine("El caballo esta frenando...");
        }
        public override void Avanzar()
        {
            base.Avanzar();
            Console.WriteLine("... el Caballo.");
        }
        #endregion

        #region Polimorfismo ToString
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine("En la clase caballo...");
            sb.Append("Raza: ");
            sb.AppendLine(this.raza);
            sb.Append("Color: ");
            sb.AppendLine(this.color.ToString());

            return sb.ToString();
        }
        #endregion
    }
}
