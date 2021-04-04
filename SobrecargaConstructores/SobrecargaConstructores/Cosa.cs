using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaConstructores
{
    class Cosa
    {
        #region Atributos Estaticos
        private int entero;
        private string cadena;
        private DateTime fecha;
        #endregion

        #region Constructores de Instancia
        public Cosa()
        {
            this.entero = 0;
            this.cadena = "Hola Mundo";
            this.fecha = DateTime.Now;
        }

        public Cosa(string cad):this()//Se invoca al constructor que no recibe nada para que inicialice los otros dos datos
        {
            //this.entero = 0; Se repite en el por defecto
            this.cadena = cad;
            //this.fecha = DateTime.Now; Se repite en el por defecto
        }

        public Cosa(int numero, string cad):this(cad)
        {
            this.entero = numero;
            //this.cadena = cad;
            //this.fecha = DateTime.Now;
        }
        #endregion

        #region Metodos
        public void Mostrar()
        {
            Console.WriteLine("\nValor del entero: {0}\nString: {1}\nFecha: {2}\n", this.entero, this.cadena, this.fecha);
        }
        #endregion
    }
}
