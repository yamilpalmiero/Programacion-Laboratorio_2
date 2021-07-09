using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void FinalDelegate(string mensaje);
    public delegate void SimuladoDelegate<U>(U item);


    public class SimuladorDeAtencion<T>
    {
        public event SimuladoDelegate<T> AvisoDeUso;
        public event FinalDelegate FinDeUso;



        public void SimularVacunacion(object param)
        {
            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (!(param is null) && param.GetType() == typeof(T))
            {
                List<T> lista = (List<T>)param;
                foreach (T item in lista)
                {
                    if (!(this.AvisoDeUso is null))
                    {
                        this.AvisoDeUso.Invoke(item);
                        Thread.Sleep(1200);
                    }
                }
                FinDeUso("Tarea finalizada.");

                using (StreamWriter sw = new StreamWriter(escritorio + @"\Pacientes atendidos.txt"))
                {
                    foreach (T item in lista)
                    {
                        sw.WriteLine(item.ToString());
                    }
                }
            }
        }
    }
}
