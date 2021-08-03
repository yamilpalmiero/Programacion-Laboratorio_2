using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class GestorDeArchivos : IGuardar<Carrera>, IGuardar<AutoF1>
    {
        private string archivo;

        /// <summary>
        /// Constructor de Gestor de Archivos que recibe un string
        /// </summary>
        /// <param name="ruta">String</param>
        public GestorDeArchivos(string ruta)
        {
            this.archivo = ruta;
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        void IGuardar<AutoF1>.Guardar(AutoF1 item)//EXPLICITA no lleva modificador de visibilidad. Almacena la llegada de los vehiculos a la meta
        {
            try
            {
                using (StreamWriter escritor = new StreamWriter(archivo, true))
                {
                    escritor.WriteLine(item.ToString());
                }
            }
            catch (Exception)
            {
                throw new Exception("No se pudo guardar el archivo.");
            }
        }


        /// <summary>
        /// Serializa la lista de vehiculos de la carrera
        /// </summary>
        /// <returns>Carrera</returns>
        public Carrera LeerXML()
        {
            if (!archivo.Contains(".xml"))//Si no se puede leer el xml
            {
                throw new ArchivoException();//Lanzo la excepcion
            }

            try
            {
                Carrera carrera = new Carrera();

                if (!Directory.Exists(archivo))//Si no existe el archivo
                {
                    Directory.CreateDirectory(archivo);//Lo creo
                }

                using (XmlTextReader lector = new XmlTextReader(archivo))//Creo el lector de XML
                {
                    XmlSerializer deserializador = new XmlSerializer(typeof(Carrera));//Creo el deserializador
                    carrera = (Carrera)deserializador.Deserialize(lector);//Guardo los datos con casting
                    return carrera;//los devuelvo
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo leer el archivo.", ex);
            }
        }

        /// <summary>
        /// Metodo que guarda la lista de vehiculos en un archivo de texto
        /// </summary>
        /// <param name="carrera">Archivo a guardar</param>
        public void Guardar(Carrera carrera)//IMPLICITA serializa a XML
        {
            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter(archivo, Encoding.UTF8))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(Carrera));
                    serializador.Serialize(escritor, carrera);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar guardar el archivo.", e);
            }
        }
    }
}
