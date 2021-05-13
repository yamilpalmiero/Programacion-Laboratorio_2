using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPProgramacion
{
    static class Program
    {
        static void Main(string[] args)
        {
            Mundo a = new Mundo();
            Mes valor = a.MiMes;//aca le pone enero
            string mesActual = a.MiMes.NombreMes;//aca lee el mes enero
            mesActual = "Junio";//aca se lo cambia a junio
            valor.NombreMes = "Febrero";//en el setter de Mes le pone Febrero
            Console.WriteLine(a.MiMes.NombreMes);//y Febrero es lo que termina imprimiendo
            Console.ReadKey();
        }
    }

    public class Mes
    {
        string nombreMes;
        public Mes(string nombreMes)
        {
            this.nombreMes = nombreMes;
        }
        public string NombreMes
        {
            get
            {
                return this.nombreMes;
            }
            set
            {
                this.nombreMes = value;
            }
        }
    }

    public class Mundo
    {
        Mes miMes;
        public Mundo()
        {
            miMes = new Mes("Enero");
        }
        public Mes MiMes
        {
            get
            {
                return miMes;
            }
        }
    }
}
