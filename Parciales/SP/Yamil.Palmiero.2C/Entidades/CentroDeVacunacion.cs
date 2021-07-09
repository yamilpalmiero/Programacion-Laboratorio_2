using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CentroDeVacunacion
    {
        private List<Paciente> personas;


        public CentroDeVacunacion()
        {

        }
        public CentroDeVacunacion(List<Paciente> pacientes)
        {
            this.personas = pacientes;
        }


        public List<Paciente> Personas
        {
            get { return this.personas; }
        }
    }
}
