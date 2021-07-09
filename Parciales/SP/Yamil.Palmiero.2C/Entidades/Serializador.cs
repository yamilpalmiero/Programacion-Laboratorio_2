using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class Serializador<T> where T : class, new()
    {
        public static T LeerXml(string rutaArchivo)
        {
            T datos;
            XmlSerializer ser = null;
            XmlTextReader reader = null;

            try
            {
                ser = new XmlSerializer(typeof(T));
                reader = new XmlTextReader(rutaArchivo);
                datos = (T)ser.Deserialize(reader);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }

            return datos;
        }


        public static T LeerBinario(string ruta)
        {
            T datos;
            FileStream fs = null;
            BinaryFormatter ser = null;

            try
            {
                fs = new FileStream(ruta, FileMode.Open);
                ser = new BinaryFormatter();
                datos = (T)ser.Deserialize(fs);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }

            return datos;
        }
    }
}
