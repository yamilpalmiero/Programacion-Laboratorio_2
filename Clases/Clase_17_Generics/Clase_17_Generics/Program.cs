using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Clase_17_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //STRING
            MensajeG<string> tipoTexto = new MensajeG<string>();
            tipoTexto.MiAtributo = "Hola";//Cuando no se sabe se inicializa en default

            Console.WriteLine(tipoTexto.MiAtributo);
            Console.WriteLine(tipoTexto.ToString() + "\n");




            //MICLASE
            MensajeG<MiClase> tipoMiClase = new MensajeG<MiClase>();
            tipoMiClase.MiAtributo = new MiClase();

            Console.WriteLine(tipoMiClase.MiAtributo);
            Console.WriteLine(tipoMiClase.ToString() + "\n");




            //STRING - INT
            MensajeroG<string, int> tipoTextoEntero = new MensajeroG<string, int>();
            tipoTextoEntero.miAtributo1 = "Cadena";
            tipoTextoEntero.miAtributo2 = 5;

            Console.WriteLine(tipoTextoEntero.ToString());
            Console.WriteLine(tipoTextoEntero.miAtributo1);
            Console.WriteLine(tipoTextoEntero.miAtributo2.ToString() + "\n");




            //RESTRICTIVA
            ClaseRestrictivaG<MiClase> restrictiva = new ClaseRestrictivaG<MiClase>();
            restrictiva.miLista.Add(new MiClase());

            Console.WriteLine(restrictiva.ToString());




            Console.ReadKey();
        }
    }
}