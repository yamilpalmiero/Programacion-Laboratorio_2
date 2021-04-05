using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class Boligrafo
    {
        #region Atributos
        public static short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;
        #endregion

        #region Contructores
        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }
        #endregion

        #region Metodos
        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }
        private void SetTinta(short tinta)
        {

            if (tinta > 0)
            {
                this.tinta += tinta;
                while (this.tinta > cantidadTintaMaxima)
                {
                    Console.WriteLine("Error, el nivel de tinta no puede pasar de 100");
                }
            }
            else
            {
                this.tinta -= tinta;
                while (this.tinta < 0)
                {
                    Console.WriteLine("Error, el nivel de tinta no puede bajar de 0");
                }
            }

        }
        public void Recargar()
        {
            this.tinta = cantidadTintaMaxima;
        }
        #endregion
    }
}
