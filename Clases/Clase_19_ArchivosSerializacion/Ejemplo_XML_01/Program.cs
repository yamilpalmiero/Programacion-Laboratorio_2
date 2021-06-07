using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.Xml.Serialization;
using Entidades;

namespace Ejemplo_XML_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Dato objDato = new Dato("Yamil", 33);

            try
            {
                //********** SE TOMA LA FOTO **********
                //Creo un objeto que sabe como escribir en XML
                //Si el archivo no existe lo crea, si existe lo sobrescribe. Aca no hay Append
                using (XmlTextWriter escritorXml = new XmlTextWriter("Datos.xml", System.Text.Encoding.UTF8))
                {
                    //Creo un objeto que sabe como serializar
                    //Le tengo que indicar que tipo de objeto va a serializar
                    XmlSerializer serializadorXml = new XmlSerializer(typeof(Dato));

                    //Utilizo el metodo estatico Serialize
                    //Le paso el escritor de xml y el objeto a SERIALIZAR a XML
                    serializadorXml.Serialize(escritorXml, objDato);
                }

                //********** SE REVELA LA FOTO **********
                //Creo un objeto que sabe como leer de XML
                using (XmlTextReader lectorXml = new XmlTextReader("Datos.xml"))
                {
                    //Creo un objeto que sabe como DESERIALIZAR de XML
                    //Le tengo que indicar que tipo de objeto va a deserializar
                    XmlSerializer deserializadorXml = new XmlSerializer(typeof(Dato));

                    //Utilizo el metodo estatico Deserialize, pasandole el lector de xml
                    //Le tengo que castear el tipo de dato especifico porque el metodo devuelve un objeto
                    Dato aux = (Dato)deserializadorXml.Deserialize(lectorXml);

                    Console.WriteLine(aux.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
