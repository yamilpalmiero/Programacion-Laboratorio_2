using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente
    {
        #region Atributos
        private string nombre;
        private string apellido;
        private Mascota[] mascotas;
        #endregion

        #region Constructores
        public Cliente()
        {

        }
        public Cliente(string nom, string ape)
        {
            this.nombre = nom;
            this.apellido = ape;
        }
        #endregion

        #region Getter y Setters
        /*public string MostrarDatos()
        {
            return this.nombre + " " + this.apellido;
        }*/
        #endregion

        public void AgregarMascota(Mascota mascota)
        {
            if (this.mascotas is null)//Si el array de vacunas esta vacio, osea es la primer vacuna
            {
                this.mascotas = new Mascota[1];//Creo el array de vacunas con una vacuna
            }
            else
            {
                int newSize = this.mascotas.Length + 1;
                Array.Resize(ref this.mascotas, newSize);//Redimensiona la capacidad del array
            }

            for (int i = 0; i < this.mascotas.Length; i++)//Recorro el array de vacunas
            {
                if (this.mascotas[i] is null)//Si encuentro un indice null, osea vacio...
                {
                    this.mascotas[i] = mascota;//Guardo la vacuna en ese lugar
                    break;
                }
            }
        }

        public string MostrarDatos()
        {
            string retorno = $"Nombre: {this.nombre}\nApellido: {this.apellido}\n";

            if (this.mascotas != null)
            {
                retorno += "Mascotas: \n";
                foreach (Mascota mascota in this.mascotas)
                {
                    if (mascota != null)
                    {
                        retorno += mascota.MostrarDatos();
                    }
                }
            }
            return retorno;
        }
    }
}
