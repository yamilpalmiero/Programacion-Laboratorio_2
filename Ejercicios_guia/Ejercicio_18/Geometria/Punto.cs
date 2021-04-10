using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Punto
    {
        #region Atributos
        private int x;
        private int y;
        #endregion

        #region Metodos
        public int GetX()
        {
            return this.x;
        }
        public int GetY()
        {
            return this.y;
        }
        #endregion

        #region Constructor
        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        #endregion
    }
}
