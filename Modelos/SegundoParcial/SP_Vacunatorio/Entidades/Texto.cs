using System;
using System.IO;

namespace Entidades
{
    public class Texto : IArchivos<string>
    {



        public bool Guardar(string archivo, string dato)
        {
            bool retorno = false;

            try
            {
                if (!String.IsNullOrEmpty(archivo) && !String.IsNullOrEmpty(dato))
                {
                    using (StreamWriter escritor = new StreamWriter(archivo, true))
                    {
                        escritor.WriteLine(dato);
                    }

                    retorno = true;
                }
                else
                {
                    using (StreamWriter escritor = new StreamWriter(archivo, false))
                    {
                        escritor.WriteLine(dato);
                    }

                    retorno = true;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar guardar el archivo de texto.", e);
            }

            return retorno;
        }






        public bool Leer(string archivo, out string dato)
        {
            try
            {
                dato = String.Empty;

                if (File.Exists(archivo))
                {
                    using (StreamReader lector = new StreamReader(archivo))
                    {
                        dato = lector.ReadToEnd();
                        return true;
                    }
                }
            }
            catch (ArchivosException e)
            {
                throw new ArchivosException("Ocurrio un error al intentar leer el archivo.");
            }
            catch (FileNotFoundException e)
            {
                throw new FileNotFoundException(e.Message);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return false;
        }
    }
}

