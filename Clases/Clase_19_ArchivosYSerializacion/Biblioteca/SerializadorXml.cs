using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Biblioteca
{
    public class SerializadorXml<T> where T : class, new()
    {
        private string ruta;

        public SerializadorXml(string ruta)
        {
            this.ruta = ruta;
        }



        public void Guardar(T objeto)
        {
            using (XmlTextWriter escritor = new XmlTextWriter(ruta, Encoding.UTF8))
            {
                XmlSerializer serializador = new XmlSerializer(typeof(T));

                serializador.Serialize(escritor, objeto);
            }
        }



        public T Leer()
        {
            using (XmlTextReader lector = new XmlTextReader(ruta))
            {
                XmlSerializer deserializador = new XmlSerializer(typeof(T));

                return (T)deserializador.Deserialize(lector);
            }
        }
    }
}
