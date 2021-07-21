using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Yamil", "Palmiero", 33);
            Persona persona2 = new Persona("Mariana", "Seib", 31);
            Persona persona3 = new Persona("Selene", "Palmiero", 30);
            List<Persona> personas = new List<Persona>();

            List<Persona> personasLeer = null;
            Serializadora serializadora = new Serializadora();


            personas.Add(persona1);
            personas.Add(persona2);
            personas.Add(persona3);



            //SERIALIZO
            if (Serializadora.Guardar(personas))
                Console.WriteLine("Archivo guardado correctamente.");
            else
                Console.WriteLine("No se pudo serializar.");


            //DESERIALIZO
            personasLeer = serializadora.Leer();
            foreach (Persona item in personasLeer)
            {
                Console.WriteLine(item.ToString());
            }


            Console.ReadKey();
        }
    }
}
