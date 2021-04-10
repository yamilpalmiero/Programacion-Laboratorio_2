using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaConstructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Sobrecarga de Constructores";

            Cosa objeto1 = new Cosa();
            objeto1.Mostrar();

            Cosa objeto2 = new Cosa("Hola");
            objeto2.Mostrar();

            Cosa objeto3 = new Cosa(5, "Chau");
            objeto3.Mostrar();


            Console.ReadKey(true);
        }
    }
}
