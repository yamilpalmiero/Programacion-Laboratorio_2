using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Consola.Txt
{
    class Program_Txt
    {
        static void Main(string[] args)
        {
            string texto = "Hola Mundo!";
            string nombreArchivo = "Clase_19_Archivos";
            string extension = "txt";
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            FileManager fileManager = new FileManager();

            fileManager.EscribirArchivoTexto(ruta, nombreArchivo, extension, texto, false);
            fileManager.EscribirArchivoTexto(ruta, nombreArchivo, extension, "Chau Mundo...", true);

            Console.WriteLine(fileManager.LeerArchivoTexto(ruta, nombreArchivo, extension));

            Console.ReadKey();
        }
    }
}
