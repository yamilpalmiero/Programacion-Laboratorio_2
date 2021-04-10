using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Alumno
    {
        byte nota1;
        byte nota2;
        float notaFinal;
        string apellido;
        int legajo;
        string nombre;

        public Alumno(string nom, string ape, int leg)
        {
            this.nombre = nom;
            this.apellido = ape;
            this.legajo = leg;
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public void CalcularFinal()
        {
            Random notaRandom = new Random();

            if (this.nota1 >= 4 && this.nota2 >= 4)
            {
                this.notaFinal = notaRandom.Next(6, 10);
            }
            else
            {
                this.notaFinal = -1;
            }
        }

        public string Mostrar()
        {
            if (this.notaFinal == -1)
            {
                return "Nombre: " + this.nombre + "\nApellido: " + this.apellido + "\nLegajo: " + this.legajo + "\nNota 1: " + this.nota1 + "\nNota 2: " + this.nota2 + "\nNota final: Alumno desaprobado\n\n";
            }
            else
            {
                return "Nombre: " + this.nombre + "\nApellido: " + this.apellido + "\nLegajo: " + this.legajo + "\nNota 1: " + this.nota1 + "\nNota 2: " + this.nota2 + "\nNota final: " + notaFinal + "\n\n";
            }
        }

    }
}
