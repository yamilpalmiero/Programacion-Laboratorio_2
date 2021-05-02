using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Mascota
    {
        private string especie;
        private string nombre;
        private DateTime fechaNacimiento;
        private Vacuna[] vacunas;

        public Mascota(string especie, string nombre, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.especie = especie;
            this.fechaNacimiento = fechaNacimiento;
        }

        public void AgregarVacuna(Vacuna vacuna)
        {
            if (this.vacunas is null)//Si el array de vacunas esta vacio, osea es la primer vacuna
            {
                this.vacunas = new Vacuna[1];//Creo el array de vacunas con una vacuna
            }
            else
            {
                int newSize = this.vacunas.Length + 1;
                Array.Resize(ref this.vacunas, newSize);//Redimensiona la capacidad del array
            }

            for (int i = 0; i < this.vacunas.Length; i++)//Recorro el array de vacunas
            {
                if (this.vacunas[i] is null)//Si encuentro un indice null, osea vacio...
                {
                    this.vacunas[i] = vacuna;//Guardo la vacuna en ese lugar
                    break;
                }
            }
        }

        public string MostrarDatos()
        {
            string retorno = $"\nNombre: {this.nombre}\nEspecie: {this.especie}\nFecha nacimiento: {this.fechaNacimiento.ToShortDateString()}\n";

            if (this.vacunas != null)
            {
                retorno += "Vacunas: \n";
                foreach (Vacuna vacuna in this.vacunas)
                {
                    if (vacuna != null)
                    {
                        retorno += vacuna.GetNombre();
                    }
                }
            }
            return retorno;
        }
    }
}
