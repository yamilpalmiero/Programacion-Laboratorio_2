using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisEntidades
{
    public class OtraCosa
    {
        #region Atributos
        public static string algo;
        public int entero;
        public string cadena;
        #endregion

        #region Constructores
        public OtraCosa(int entero)
        {
            this.entero = entero;
        }
        #endregion

        #region Sobrecargas
        public static implicit operator OtraCosa(int n)//Sobrecarga de casteo implicito simulada
        {
            return new OtraCosa(n);
        }

        public static explicit operator OtraCosa(string cad)//Sobrecarga de casteo implicito simulada
        {
            OtraCosa a = new OtraCosa(1);
            a.cadena = cad;
            return a;
        }

        public static implicit operator string(OtraCosa oc)//Sobrecarga de casteo implicito simulada
        {
            return oc.cadena + "-" + oc.entero;
        }

        public static OtraCosa operator ++(OtraCosa oc)
        {
            oc.entero++;
            return oc;
        }
        #endregion
    }
}
