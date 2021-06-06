using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IMiInterface
    {
        int PropiedadLE { get; set; }
        int PropiedadL { get; }
        int PropiedadE { set; }


        void MetodoSinRetornoNiParametros();
        double MetodoConParametros(int uno, int dos);
    }
}
