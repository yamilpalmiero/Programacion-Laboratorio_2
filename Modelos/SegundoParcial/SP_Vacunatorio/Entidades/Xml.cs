using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class Xml<T> : IArchivos<T>
    {
        public bool Guardar(string archivo, T datos)
        {
            bool retorno = false;
            XmlSerializer nuevoXml = new XmlSerializer(typeof(T));

            using (XmlTextWriter nuevoTW = new XmlTextWriter(archivo, Encoding.UTF8))
            {
                nuevoXml.Serialize(nuevoTW, datos);
                retorno = true;
            }

            return retorno;
        }




        public bool Leer(string archivo, out T datos)
        {
            bool retorno = false;
            XmlSerializer nuevoXml = new XmlSerializer(typeof(T));

            using (XmlTextReader nuevoTR = new XmlTextReader(archivo))
            {
                datos = (T)nuevoXml.Deserialize(nuevoTR);
                retorno = true;
            }

            return retorno;
        }
    }
}
