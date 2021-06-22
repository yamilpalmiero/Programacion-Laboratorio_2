using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        public enum TipoCompetencia
        {
            F1,
            MotoCross
        }

        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;

        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo)
            : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
            this.tipo = tipo;
        }

        public short CantidadCompetidores
        {
            get
            {
                return this.cantidadCompetidores;
            }
            set
            {
                this.cantidadCompetidores = value;
            }
        }
        public short CantidadVueltas
        {
            get
            {
                return this.cantidadVueltas;
            }
            set
            {
                this.cantidadVueltas = value;
            }
        }
        public VehiculoDeCarrera this[int i]
        {
            get
            {
                if (i < competidores.Count)
                {
                    return competidores[i];
                }
                else
                {
                    return null; //new VehiculoDeCarrera(0, "");
                }
            }
        }
        public TipoCompetencia Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }
        public List<VehiculoDeCarrera> Competidores
        {
            get
            {
                return this.competidores;
            }
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Cantidad de competidores: {this.CantidadCompetidores.ToString()}");
            sb.AppendLine($"Cantidad de vueltas: {this.cantidadVueltas.ToString()}");

            return sb.ToString();
        }

        public static bool operator ==(Competencia c, VehiculoDeCarrera v)
        {
            bool retorno = false;

            if (v is AutoF1 && c.Tipo == TipoCompetencia.F1)
            {
                foreach (AutoF1 a in c.competidores)
                {
                    if (a == (AutoF1)v)
                    {
                        retorno = true;
                    }
                }
            }
            else if (v is MotoCross && c.Tipo == TipoCompetencia.MotoCross)
            {
                foreach (MotoCross m in c.competidores)
                {
                    if (m == (MotoCross)v)
                    {
                        retorno = true;
                    }
                }
            }

            return retorno;
        }
        public static bool operator !=(Competencia c, VehiculoDeCarrera v)
        {
            return !(c == v);
        }
        public static bool operator +(Competencia c, VehiculoDeCarrera v)
        {
            try
            {
                if (c == v || c.competidores.Count >= c.CantidadCompetidores ||
                (c.Tipo != TipoCompetencia.F1 && v is AutoF1) ||
                (c.Tipo != TipoCompetencia.MotoCross && v is MotoCross))
                    throw new CompetenciaNoDisponibleException("El vehículo no corresponde a la competencia",
                        typeof(Competencia).Name, " == ");
            }
            catch (CompetenciaNoDisponibleException e)
            {
                throw new CompetenciaNoDisponibleException("Competencia incorrecta", typeof(Competencia).Name, " + ", e);
            }
            c.competidores.Add(v);
            v.EnCompetencia = true;
            v.VueltasRestantes = c.cantidadVueltas;
            v.CantidadCombustible = (short)new Random().Next(15, 100);
            return true;
        }
        public static bool operator -(Competencia c, VehiculoDeCarrera v)
        {
            if (v is AutoF1 && c.Tipo == TipoCompetencia.F1)
            {
                foreach (AutoF1 a in c.competidores)
                {
                    if (a == (AutoF1)v)// esto pincha???
                    {
                        c.competidores.Remove(v);
                        return true;
                    }
                }
            }
            else if (v is MotoCross && c.Tipo == TipoCompetencia.MotoCross)
            {
                foreach (MotoCross m in c.competidores)
                {
                    if (m == (MotoCross)v)
                    {
                        c.competidores.Remove(v);
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
