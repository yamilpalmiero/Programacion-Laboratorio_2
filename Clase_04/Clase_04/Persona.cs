using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_04
{
    class Persona
    {
        #region Atributos

        public string apellido;
        public string nombre;
        public int dni;
        private static int cantPersonas;

        #endregion

        #region Constructores
        static Persona()
        {
            Persona.cantPersonas = 66;
        }
        public Persona()
        {
            this.apellido = "Sin apellido";
            this.nombre = "Sin nombre";
            this.dni = -1;
            Persona.cantPersonas += 1;
        }

        public Persona(string apellido): this()
        {
            this.apellido = apellido;
        }

        public Persona(string apellido, int dni): this(apellido)
        {
            this.dni = dni;
        }

        public Persona(string apellido, int dni, string nombre): this(apellido, dni)
        {
            this.nombre = nombre;
        }
        #endregion

        public static int MostrarCantidadPersonas()
        {
            return Persona.cantPersonas;
        }
    }
}
