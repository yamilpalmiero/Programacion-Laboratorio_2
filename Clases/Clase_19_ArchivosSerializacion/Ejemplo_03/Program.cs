using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejemplo_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            try
            {
                using (StreamWriter sw = new StreamWriter(escritorio + @"\PruebaCopia.txt"))
                {
                    sw.WriteLine("Linea agregada al archivo...");
                }
                using (StreamReader sr = new StreamReader(escritorio + @"\PruebaCopia.txt"))
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
