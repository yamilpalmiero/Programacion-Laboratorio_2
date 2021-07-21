using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class FileManager
    {
        public void EscribirArchivoTexto(string ruta, string nombre, string extension, string texto, bool append)
        {
            StreamWriter escritor = null;

            try
            {
                string rutaCompleta = ruta + "\\" + nombre + extension;
                escritor = new StreamWriter(rutaCompleta, append);
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



        public string LeerArchivoTexto(string ruta, string nombre, string extension)
        {
            StreamReader lector = null;

            try
            {
                string rutaCompleta = ruta + "\\" + nombre + extension;
                lector = new StreamReader(rutaCompleta);
                return lector.ReadToEnd();
            }
            finally
            {
                if (lector != null)
                {
                    lector.Close();
                }
            }
        }
    }
}
