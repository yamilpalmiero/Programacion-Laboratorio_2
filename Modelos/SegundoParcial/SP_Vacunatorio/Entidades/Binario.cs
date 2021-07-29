using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Entidades
{
    public class Binario<T> where T : class, new()
    {
        private string ruta;


        public void Guardar(T objeto)
        {
            try
            {
                using (Stream stream = new FileStream(this.ruta, FileMode.Create))//Puede ser FileMode.Append
                {
                    BinaryFormatter formatter = new BinaryFormatter();

                    formatter.Serialize(stream, objeto);
                }
            }
            catch(SerializationException e)
            {
                throw new SerializationException("No se pudo serializar." + e.Message, e);
            }
        }





        public T Leer()
        {
            using (Stream stream = new FileStream(this.ruta, FileMode.Open))//No lo queremos crear sino abrir
            {
                BinaryFormatter formatter = new BinaryFormatter();

                return (T)formatter.Deserialize(stream);
            }
        }
    }
}
