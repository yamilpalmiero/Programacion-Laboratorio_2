using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro : IMostrarDatos //Explicita
    {
        int IMostrarDatos.Valor//Propiedad de la interfaz IMostrarDatos implementada de forma explicita
        {
            get { return 0; }
        }

        string IMostrarDatos.FichaTecnica()//Metodo de la interfaz IMostrarDatos implementada de forma explicita
        {
            return "Ficha del perro Explicita";
        }
    }
}
