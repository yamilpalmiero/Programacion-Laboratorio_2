using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MiClase : IMiInterface
    {
        public string atributo;

        public MiClase(string atributo)
        {
            this.atributo = atributo;
        }

        public override string ToString()
        {
            return this.atributo;
        }

        #region Implementacion de todos los miembros de la Interface
        public int PropiedadLE
        {
            get { return this.atributo.Length; }
            set { this.atributo = value.ToString(); }
        }
        public int PropiedadL
        {
            get
            {
                return 66;
            }
        }
        public int PropiedadE
        {
            set
            {
                this.atributo = value.ToString();
            }
        }

        public double MetodoConParametros(int num1, int num2)
        {
            return num1 + num2;
        }
        public void MetodoSinRetornoNiParametros()
        {
            Console.WriteLine("Metodo de Interface");
        }
        #endregion
    }
}
