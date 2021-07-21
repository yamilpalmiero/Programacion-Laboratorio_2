using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Archivador
    {
        private string ruta;

        public Archivador(string ruta)
        {
            this.ruta = ruta;
        }

        public void Guardar(string texto)
        {
            StreamWriter escritor = null;

            try
            {
                escritor = new StreamWriter(this.ruta);

                escritor.WriteLine(texto);
            }
            finally
            {
                if (escritor != null)
                {
                    escritor.Close();
                }
            }
        }

        public string Leer()
        {
            using (StreamReader lector = new StreamReader(this.ruta))
            {
                return lector.ReadToEnd();
            }
        }
    }
}
