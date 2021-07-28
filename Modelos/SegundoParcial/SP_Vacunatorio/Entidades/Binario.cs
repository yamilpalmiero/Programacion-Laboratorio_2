using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Binario<T> where T : class, new()
    {
        private string ruta;

        public Binario(string ruta)
        {
            this.ruta = ruta;
        }




        public void Guardar(T objeto)
        {
            using (Stream stream = new FileStream(this.ruta, FileMode.Create))//Puede ser FileMode.Append
            {
                BinaryFormatter formatter = new BinaryFormatter();

                formatter.Serialize(stream, objeto);
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
