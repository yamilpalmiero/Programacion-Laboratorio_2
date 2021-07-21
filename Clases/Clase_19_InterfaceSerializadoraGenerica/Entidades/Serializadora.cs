using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Serializadora
    {
        public static bool Guardar(List<Persona> persona)
        {
            bool retorno = false;
            Xml<List<Persona>> guardarPersona = new Xml<List<Persona>>();

            retorno = guardarPersona.Guardar(AppDomain.CurrentDomain.BaseDirectory + "\\Personas.xml", persona);

            return retorno;
        }



        public List<Persona> Leer()
        {
            bool retorno = false;
            Xml<List<Persona>> leerPersona = new Xml<List<Persona>>();

            retorno = leerPersona.Leer(AppDomain.CurrentDomain.BaseDirectory + "\\Personas.xml", out List<Persona> auxPersona);

            if (retorno)
                return auxPersona;
            else
                return new List<Persona>();
        }
    }
}
