using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private List<Alumno> alumnos;
        private short anio;
        private Divisiones division;
        private Profesor profesor;

        private Curso()
        {
            this.alumnos = new List<Alumno>();
        }
        public Curso(short anio, Divisiones division, Profesor profesor)
        {
            this.anio = anio;
            this.division = division;
            this.profesor = profesor;
        }

        public string AnioDivision
        {
            get
            {
                return $"{this.anio}°{this.division}";
            }
        }

        public static explicit operator string(Curso c)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Curso: {c.AnioDivision}");
            sb.AppendLine($"Profesor: {c.profesor}");
            sb.AppendLine($"Alumnos:");
            foreach (Alumno alumno in c.alumnos)
            {
                sb.AppendLine($"{alumno.ExponerDatos()}");
            }
            return sb.ToString();
        }
        public static bool operator ==(Curso c, Alumno a)
        {
            bool retorno = false;

            foreach (Alumno auxAlumno in c.alumnos)
            {
                if (auxAlumno.AnioDivision == a.AnioDivision)
                {
                    retorno = true;
                }
            }

            return retorno;
        }
        public static bool operator !=(Curso c, Alumno a)
        {
            return !(c == a);
        }
        public static Curso operator +(Curso c, Alumno a)
        {
            if (c == a)
            {
                c.alumnos.Add(a);
            }

            return c;
        }
    }
}
