using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Entidades
{
    public class Serializer<T> where T : new()
    {
        //XML
        public void SerializarXml(T objeto, string rutaCompleta)
        {
            XmlTextWriter escritor = null;
            XmlSerializer serializador = null;

            try
            {
                escritor = new XmlTextWriter(rutaCompleta, Encoding.UTF8);

                serializador = new XmlSerializer(typeof(T));
                serializador.Serialize(escritor, objeto);
            }
            finally
            {
                if (escritor != null)
                {
                    escritor.Close();
                }
            }
        }

        public T DeserializarXml(string rutaCompleta)
        {
            using (XmlTextReader lector = new XmlTextReader(rutaCompleta))
            {
                XmlSerializer serializador = new XmlSerializer(typeof(T));
                return (T)serializador.Deserialize(lector);
            }
        }



        //BINARIO
        public void SerializarBin(T objeto, string rutaCompleta)
        {
            XmlTextWriter escritor = null;
            XmlSerializer serializador = null;

            try
            {
                escritor = new XmlTextWriter(rutaCompleta, Encoding.UTF8);

                serializador = new XmlSerializer(typeof(T));
                serializador.Serialize(escritor, objeto);
            }
            finally
            {
                if (escritor != null)
                {
                    escritor.Close();
                }
            }
        }

        public T DeserializarBin(string rutaCompleta)
        {
            using (XmlTextReader lector = new XmlTextReader(rutaCompleta))
            {
                XmlSerializer serializador = new XmlSerializer(typeof(T));
                return (T)serializador.Deserialize(lector);
            }
        }
    }
}
