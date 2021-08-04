using System;

namespace Entidades
{
    public class Salidas
    {
        private DateTime fechaFin;
        private DateTime fechaInicio;

        public Salidas()
        {
            this.fechaInicio = DateTime.Now;
        }




        public DateTime FechaFin
        {
            get { return this.fechaFin; }
            set { this.fechaFin = value; }
        }
        public DateTime FechaInicio
        {
            get { return this.fechaInicio; }
            set { this.fechaInicio = value; }
        }
        public int TiempoTotal
        {
            get { return this.FechaInicio.DiferenciaEnMinutos(this.FechaFin); }
        }





        public void FinalizarSalida()
        {
            this.fechaFin = DateTime.Now;
        }
    }
}
