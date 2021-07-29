using System;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class Xml<T> : IArchivos<T>
    {
        public bool Guardar(string archivo, T datos)
        {
            bool retorno = false;

            if (datos == null)
            {
                throw new System.Exception("La fuente de datos no es valida.");
            }
            else
            {
                try
                {
                    using (XmlTextWriter escritor = new XmlTextWriter(archivo, Encoding.UTF8))
                    {
                        XmlSerializer serializador = new XmlSerializer(typeof(T));
                        serializador.Serialize(escritor, datos);
                        retorno = true;
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Error de serializacion: " + e.Message, e);
                }
            }

            return retorno;
        }




        public bool Leer(string archivo, out T datos)
        {
            bool retorno = false;
            XmlSerializer deserializador = new XmlSerializer(typeof(T));

            using (XmlTextReader lector = new XmlTextReader(archivo))
            {
                datos = (T)deserializador.Deserialize(lector);
                retorno = true;
            }

            return retorno;
        }
    }
}
