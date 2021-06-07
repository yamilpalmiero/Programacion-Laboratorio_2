using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Ejemplo_02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //SI NO EXISTE, LO COPIO
                if (!File.Exists(@"E:\Facultad\Programacion-Laboratorio_2\Archivos\PruebaCopia.txt"))
                {
                    File.Copy(@"E:\Facultad\Programacion-Laboratorio_2\Archivos\Prueba.txt", @"E:\Facultad\Programacion-Laboratorio_2\Archivos\PruebaCopia.txt");
                }
                else
                {
                    //SI EXISTE, LO BORRO
                    File.Delete(@"E:\Facultad\Programacion-Laboratorio_2\Archivos\PruebaCopia.txt");
                }

                using (StreamReader sr = new StreamReader(@"E:\Facultad\Programacion-Laboratorio_2\Archivos\PruebaCopia.txt"))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
