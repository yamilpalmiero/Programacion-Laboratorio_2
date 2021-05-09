using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto : Transporte
    {
        #region Atributos
        public int cantidadRuedas;//Este no forma parte de la clase base porque no todos los transportes tienen ruedas (por ejemplo el caballo)
        #endregion

        #region Constructor
        public Auto(byte pasajeros, Velocidades velocidad, int cantidadRuedas) : base(pasajeros, velocidad)
        {
            this.cantidadRuedas = cantidadRuedas;
        }
        #endregion

        #region Metodos
        public override void Frenar()//Sobreescritura del metodo frenar
        {
            Console.WriteLine("El auto esta frenando...");
        }
        public override void Avanzar()//Este como es virtual podria no implementarse
        {
            base.Avanzar();//Uso la implementacion de la clase base y le agrego...
            Console.WriteLine("El Auto.");
        }
        #endregion

        #region Plimorfismo ToString
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());

            sb.AppendLine("En la clase Auto...");
            sb.Append("Cantidad de ruedas: ");
            sb.AppendLine(this.cantidadRuedas.ToString());

            return sb.ToString();
        }
        #endregion
    }
}
