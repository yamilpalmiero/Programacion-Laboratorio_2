using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Edificio : IMostrarDatos<T, U> //Implicita
    {
        public int Valor
        {
            get { return 0; }
        }

        public string FichaTecnica()
        {
            return "Ficha del edificio Implicita";
        }

        public void MetodoQueNoHaceNada()
        {

        }
    }
}
