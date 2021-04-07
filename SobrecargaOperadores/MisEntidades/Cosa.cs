using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisEntidades
{
    public class Cosa
    {
        #region Atributos
        private string cadena;
        private int entero;
        private DateTime fecha;
        #endregion

        #region Sobrecarga de Operadores
        public static bool operator ==(Cosa c1, OtraCosa oc)//Sobrecarga del operador de comparacion ==
        {
            if (c1.entero == oc.entero && c1.cadena == oc.cadena)//Son de diferente tipo pero solo estamos comparando sus atributos
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Cosa c1, OtraCosa oc)//Sobrecarga obligada del opuesto (solo los de comparacion)
        {
            //if (c1.entero != oc.entero || c1.cadena != oc.cadena)
            //{
            //    return true;
            //}
            //return false;
            //if (c1 == oc)
            //{
            //    return false;
            //}
            //return true;
            return !(c1 == oc);//Esto aplica a todos los operadores de comparacion
        }

        public static bool operator ==(Cosa c1, Cosa c2)//2da sobrecarga
        {
            if (c1.entero == c2.entero)//Comparacion de los atributos enteros de los objetos
                return true;

            return false;
        }
        public static bool operator !=(Cosa c1, Cosa c2)
        {
            return !(c1 == c2);
        }

        public static bool operator ==(Cosa c1, int n)//3ra sobrecarga
        {
            return c1.entero == n;//Comparacion del atributo entero con un numero entero
        }
        public static bool operator !=(Cosa c1, int n)
        {
            return !(c1 == n);
        }

        public static bool operator ==(int n, Cosa c1)//4ta sobrecarga
        {
            return c1.entero == n;//Igual que la tercera pero al reves
        }
        public static bool operator !=(int n, Cosa c1)
        {
            return !(c1 == n);
        }

        public static Cosa operator +(Cosa c1, Cosa c2)//Sobrecarga del operador +
        {
            int resultado = c1.entero + c2.entero;

            Cosa cresultado = new Cosa();
            cresultado.entero = resultado;

            return cresultado;
        }
        #endregion
    }
}
