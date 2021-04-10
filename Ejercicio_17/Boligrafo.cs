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
        public const short cantidadTintaMaxima = 100;
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
            if (this.tinta + tinta <= 0)
                this.tinta = 0;
            else if (this.tinta + tinta >= cantidadTintaMaxima)
                this.tinta = cantidadTintaMaxima;
            else
                this.tinta += tinta;
        }
        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }
        public bool Pintar(short gasto, out string dibujo)
        {
            dibujo = "";
            int gastoRealizado = gasto < tinta ? gasto : tinta;

            SetTinta((short)-gastoRealizado);

            for (int i = 0; i < gastoRealizado; i++)
            {
                dibujo += "*";
            }

            return gasto <= tinta ? true : false;
        }
        #endregion
    }
}
