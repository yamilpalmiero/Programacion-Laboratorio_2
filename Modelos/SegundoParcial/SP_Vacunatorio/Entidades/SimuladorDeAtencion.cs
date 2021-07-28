using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SimuladorDeAtencion<T>
    {
        public delegate void SimularVacunacion(object param);

        public event SimularVacunacion AvisoDeUso;
        public event SimularVacunacion FinDeUso;
    }
}
