using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Consola.Xml
{
    class Program_Xml
    {
        static void Main(string[] args)
        {
            try
            {
                List<Persona> personas1 = new List<Persona>();
                personas1.Add(new Persona("Yamil", "Palmiero", new DateTime(1988, 05, 01)));
                personas1.Add(new Persona("Mariana", "Seib", new DateTime(1990, 05, 03)));
                
                Serializer<List<Persona>> serializador = new Serializer<List<Persona>>();
                serializador.SerializarXml(personas1, "Cachis.xml");

                List<Persona> personas2 = new List<Persona>();
                personas2 = serializador.DeserializarXml("Cachis.xml");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio un error: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}
