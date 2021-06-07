using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejemplo_01
{
    class Program
    {
        static void Main(string[] args)
        {
            ///*
            #region Escritura de un archivo
            try
            {
                //ABRO UN ARCHIVO, SI NO EXISTE LO CREA
                StreamWriter sw = new StreamWriter("E:\\Facultad\\Programacion-Laboratorio_2\\Archivos\\Prueba.txt");
                //ESCRIBO
                sw.WriteLine("Hola Mundo!!!");
                //CIERRO EL ARCHIVO
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            #endregion

            #region Escritura con USING sin CLOSE()
            try
            {
                //BLOQUE USING ASEGURA QUE EL OBJETO INVOCARA AL METODO DISPOSE(), ENTONCES NO HACE FALTA USAR EL CLOSE()
                using (StreamWriter sw = new StreamWriter("E:\\Facultad\\Programacion-Laboratorio_2\\Archivos\\Prueba.txt"))
                {
                    //ESTE ARCHIVO YA EXISTIA, POR LO TANTO SE SOBREESCRIBIRA
                    sw.Write("Este es el ");
                    sw.WriteLine("encabezado para el archivo.");
                    sw.WriteLine("-----------------------------------------");

                    //TAMBIEN SE PUEDEN ESCRIBIR OBJETOS ARBITRARIOS
                    sw.Write("La fecha es: ");
                    sw.WriteLine(DateTime.Now);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            #endregion
            //*/

            #region Lectura de archivo
            try
            {
                using (StreamReader sr = new StreamReader(@"E:\Facultad\Programacion-Laboratorio_2\Archivos\Prueba.txt"))
                {//El '@' es para poder usar una sola \ en el path ya que ignora todos los caracteres de escape
                    string linea;

                    while ((linea = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(linea);
                    }

                    Console.ReadKey();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            #endregion
        }
    }
}
