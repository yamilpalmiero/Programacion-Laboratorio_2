namespace Entidades
{
    public class SimuladorDeAtencion<T>
    { 
        public event SimuladoDelegate<T> AvisoDeUso;
        public event FinalDelegate FinDeUso;

        public void SimularVacunacion(object param)
        {

        }
    }
}
